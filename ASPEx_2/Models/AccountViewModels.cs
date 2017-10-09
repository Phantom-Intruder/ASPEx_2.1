using ASPEx_2.Helpers;
using ECommerce.Tables.Active.HR;
using ECommerce.Tables.Content;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPEx_2.Models
{
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

	public class LoginViewModel
    {
		#region Class members
		private ShoppingCartModels		cart				= ShoppingCartModels.GetInstanceOfObject();
		private List<Order>				orderList			= new List<Order>();
		private List<OrderItem>			orderItemList		= new List<OrderItem>();
		#endregion

		#region Login model
		[Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
		#endregion

		#region Model methods

		/// <summary>
		/// Set user defaults and any saved data about the shopping cart
		/// </summary>
		/// <param name="record"></param>
		public void InitialiseUserAndReadyCart(Account record){
			SessionSingleton.Current.CurrentUserSession			= record;
			orderList											= Order.ListByAccountID(record.ID);
			UserModel.ID										= record.ID;


			if (record.Role == 1)
			{
				SessionSingleton.Current.CurrentUserRole		= record.Role;
			}


			foreach (Order o in orderList)
			{
				orderItemList									= OrderItem.ListByOrderID(o.ID);
				foreach (OrderItem item in orderItemList)
				{
					cart.AddProductToCart(item.ProductID);
				}
			}
		}
		#endregion
    }

    public class RegisterViewModel
    {
		#region Register model
		[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName{ get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; }

        [Required]
        [Display(Name = "Role")]
        public int Role { get; set; }

        [Required]
        [Display(Name = "Created Account ID")]
        public int CreatedAccountID { get; set; }

        [Required]
        [Display(Name = "Modified Account ID")]
        public int ModifiedAccountID { get; set; }
		#endregion

		#region Model methods

		/// <summary>
		/// If data is valid, create an account and insert it into the database
		/// </summary>
		public void CreateAndInsertAccount()
		{
			string		salt								= GetHashCode().ToString();
			string		encodingPasswordString				= Helper.EncodePassword(this.Password, salt);
			Account		record								= Account.ExecuteCreate(this.FirstName,
																					this.LastName,
																					this.Email,
																					encodingPasswordString,
																					salt,
																					this.ContactNumber,
																					this.ShippingAddress,
																					this.Country,
																					1,
																					this.Role,
																					this.CreatedAccountID,
																					this.ModifiedAccountID);
			record.Insert();
			SessionSingleton.Current.CurrentUserSession			= record;
		}
		#endregion
	}

}
