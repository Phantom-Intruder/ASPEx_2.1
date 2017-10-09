using System;
using System.Data;
using System.Data.SqlClient;

namespace ECommerce.SQL.Utility.System
{
	/// <summary>
	/// Provides access to the database to obtain various configuration settings stored in the Config table.
	/// </summary>
	public class Config
	{
		#region Constants

		protected const string      STORED_PROCEDURE_CONFIG_GET         = "ConfigGetByName";
		protected const string      STORED_PROCEDURE_CONFIG_SET         = "ConfigSetByName";

		#endregion

		#region Methods

		/// <summary>
		/// Obtains a value from the table Config given a name
		/// </summary>
		/// <param name="Name">The name of the item in the table</param>
		/// <returns>null or a DataTable</returns>
		public static DataTable ConfigGetByName(string name)
		{
			SqlParameter            param               = new SqlParameter("@name", SqlDbType.NVarChar, 255);

			param.Value                                 = name;

			return SqlData.getSelectDataTable(SqlData.MASTER, STORED_PROCEDURE_CONFIG_GET, param);
		}

		/// <summary>
		/// Obtains a value from the table Config given a name
		/// </summary>
		/// <param name="Name">The name of the item in the table</param>
		/// <returns>null or a DataTable</returns>
		public static DataTable ConfigSetByName(string name, string value)
		{
			SqlParameter[]          param               =   {   new SqlParameter("@name", SqlDbType.NVarChar, 255),
																new SqlParameter("@value",SqlDbType.NVarChar, 255)
															};

			param[0].Value                              = name;
			param[1].Value                              = value;

			return SqlData.getSelectDataTable(SqlData.MASTER, STORED_PROCEDURE_CONFIG_SET, param);
		}

		#endregion
	}
}
