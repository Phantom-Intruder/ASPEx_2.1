using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ECommerce.Tables.Utility.Extension
{
	public static class EnumExtensions
	{
		/// <summary>
		/// Get the description string from the enum if it exists
		/// </summary>
		/// <param name="enumVal"></param>
		/// <returns></returns>
		public static string ToDescriptionString(this Enum enumVal)
		{
			string result = "";
			DescriptionAttribute[] attributes = enumVal.GetType().GetField(enumVal.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

			if (attributes != null && attributes.Length > 0)
			{
				result = attributes[0].Description;
			}
			else
			{
				result = enumVal.ToString();
			}

			return result;
		}

	}
}
