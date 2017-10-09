using ASPEx_2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECommerce.Tables.Content;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ASPEx_2.Models
{
	public class YasaCategoryModel
	{
		#region Members

		private int						id				= Constants.DEFAULT_VALUE_INT;
		private string					name			= String.Empty;
		private string					description		= String.Empty;
		private string					fileName		= String.Empty;
		private Category				entity			= null;

		#endregion

		#region Properties

		[Key]
		public int ID
		{
			get { return this.id; }
		}

		[Required]
		[Display(Name = "Name")]
		[StringLength(30)]
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		[Required]
		[Display(Name = "Description")]
		[DataType(DataType.MultilineText)]
		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}


		[Required]
		[Display(Name = "Image Name")]
		[DataType(DataType.Upload)]
		public string Image
		{
			get { return this.fileName; }
			set { this.fileName = value; }
		}

		#endregion

		#region Constructors

		public YasaCategoryModel()
		{

		}

		private YasaCategoryModel(Category entity)
		{
			this.id				= entity.ID;
			this.name			= entity.Name;
			this.description	= entity.Description;
			this.fileName		= entity.ImageName;
			this.entity			= entity;

		}

		#endregion

		#region Execute Create

		public static YasaCategoryModel ExecuteCreate(int? id)
		{
			YasaCategoryModel				result				= null;

			if(id.HasValue)
			{
				Category					entity				= Category.ExecuteCreate(id.Value);

				if(entity != null)
				{
					result										= new YasaCategoryModel(entity);
				}
			}
			else
			{
				result											= new YasaCategoryModel();
			}

			return result;
		}

		#endregion

		#region List 

		public static List<YasaCategoryModel> List()
		{
			List<YasaCategoryModel>					result				= new List<YasaCategoryModel>();
			List<Category>							list				= Category.List();

			foreach (Category item in list)
			{
				result.Add(new YasaCategoryModel(item));
			}

			return result;
		}

		#endregion

		#region Methods

		#region Validate
		
		public bool Validate(ModelStateDictionary state)
		{
			bool			result					= true;

			if(String.IsNullOrEmpty(this.fileName))
			{
				result								&= false;
				state.AddModelError("Filename", "Please upload an image");
			}

			return  true;
		}

		#endregion

		#region Sync

		public void Sync(YasaCategoryModel model)
		{
			this.name				= model.Name;
			this.description		= model.Description;
		}

		#endregion

		#region Save

		public void Save()
		{

		}

		#endregion 


		#endregion



	}
}