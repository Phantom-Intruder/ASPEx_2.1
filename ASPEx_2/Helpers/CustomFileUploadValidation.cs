using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPEx_2.Helpers
{
	public class CustomFileUploadValidation : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			//Get a list of all properties that are marked with [UniqueAnswersOnly]
			var props = validationContext.ObjectInstance.GetType().GetProperties().Where(
				prop => Attribute.IsDefined(prop, typeof(CustomFileUploadValidation)));

			var values = new HashSet<string>();

			//Read the values of all other properties
			foreach (var prop in props)
			{
				var pValue = (string)prop.GetValue(validationContext.ObjectInstance);
				if (prop.Name != validationContext.MemberName && !values.Contains(pValue))
				{
					values.Add(pValue);
				}
			}

			if (!SessionSingleton.Current.IsEdit)
			{
				return new ValidationResult("Field is required", new[] { validationContext.MemberName });
			}
			return null;
		}
	}
}