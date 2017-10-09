using ECommerce.Tables.Active.HR;
using ASPEx_2.Helpers;

namespace ASPEx_2.Models
{
    public class UserModel
    {
        #region Properties
        private string Name { get; set; }
        private string ShippingAddress { get; set; }
        private string ContactNumber { get; set; }
        private string Email { get; set; }
        #endregion

        #region Class members
        public static      int         ID      = 0;
        #endregion

        #region Class constructor
        public UserModel()
        {
            Account         account     = Account.ExecuteCreate(ID);

            this.Name                   = SessionSingleton.Current.CurrentUserSession.FirstName;
            this.ShippingAddress        = SessionSingleton.Current.CurrentUserSession.ShippingAddress;
            this.ContactNumber          = SessionSingleton.Current.CurrentUserSession.ContactNo;
            this.Email                  = SessionSingleton.Current.CurrentUserSession.Email;
        }
        #endregion

        #region Getters
        public string GetName()
        {
            return this.Name;
        }

        public string GetShippingAddress()
        {
            return this.ShippingAddress;
        }

        public string GetContactNumber()
        {
            return this.ContactNumber;
        }

        public string GetEmail()
        {
            return this.Email;
        }
        #endregion
    }
}