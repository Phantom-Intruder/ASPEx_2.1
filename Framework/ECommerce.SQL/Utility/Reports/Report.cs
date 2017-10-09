using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace ECommerce.SQL.Utility.Reports
{
	/// <summary>
	/// This is the class to provide the methods to generate the result of the report
	/// </summary>
	public static class Report
	{
		/// <summary>
		/// Get a datatable for the SP
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="listParam"></param>
		/// <returns></returns>
		public static DataTable spIntelReportResult(string SP, int[] listParam)
		{
			DataTable result = null;

			if (listParam != null && listParam.Length > 0)
			{
				SqlParameter[] param = new SqlParameter[listParam.Length];

				for (int i = 0; i < listParam.Length; i++)
				{
					param[i] = new SqlParameter("@param" + i.ToString(), SqlDbType.Int);
					param[i].Value = listParam[i];
				}

				result = SqlData.getSelectDataTable(SqlData.MASTER, SP, param);
			}
			else
			{
				result = SqlData.getSelectDataTable(SqlData.MASTER, SP);
			}

			return result;
		}

		/// <summary>
		/// Get a datatable for the SP
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="listParam"></param>
		/// <returns></returns>
		public static DataTable spIntelReportResult(string SP, string[] listParam)
		{
			DataTable result = null;

			if (listParam != null && listParam.Length > 0)
			{
				SqlParameter[] param = new SqlParameter[listParam.Length];

				for (int i = 0; i < listParam.Length; i++)
				{
					param[i] = new SqlParameter("@param" + i.ToString(), SqlDbType.NVarChar, 4000);
					param[i].Value = listParam[i];
				}

				result = SqlData.getSelectDataTable(SqlData.MASTER, SP, param);
			}
			else
			{
				result = SqlData.getSelectDataTable(SqlData.MASTER, SP);
			}

			return result;
		}

		/// <summary>
		/// Get a datatable for the SP
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="listParam"></param>
		/// <returns></returns>
		public static DataTable spIntelReportResult(string SP, object[] listParam)
		{
			DataTable result = null;

			if (listParam != null && listParam.Length > 0)
			{
				SqlParameter[] param = new SqlParameter[listParam.Length];

				for (int i = 0; i < listParam.Length; i++)
				{
					param[i] = new SqlParameter("@param" + i.ToString(), GetSQLDBType(listParam[i]), 4000);
					param[i].Value = listParam[i];
				}

				result = SqlData.getSelectDataTable(SqlData.MASTER, SP, param);
			}
			else
			{
				result = SqlData.getSelectDataTable(SqlData.MASTER, SP);
			}

			return result;
		}

		private static SqlDbType GetSQLDBType(object para)
		{
			SqlDbType SQLtype = SqlDbType.NVarChar;
			Type type = para.GetType();

			switch (type.ToString().ToLower())
			{
				case "system.string":
					{
						SQLtype = SqlDbType.NVarChar;
					}
					break;
				case "system.int32":
					{
						SQLtype = SqlDbType.Int;
					}
					break;
				case "system.boolean":
					{
						SQLtype = SqlDbType.Bit;
					}
					break;
				case "system.datetime":
					{
						SQLtype = SqlDbType.SmallDateTime;
					}
					break;
			}

			return SQLtype;
		}

		public static DataTable spIntelReportResult(string SP, string XMLargs)
		{
			DataTable result = null;

			if (XMLargs != null && XMLargs != "")
			{
				SqlParameter[] param = new SqlParameter[1];

				param[0] = new SqlParameter("@XMLargs", SqlDbType.VarChar, 4000);
				param[0].Value = XMLargs;

				result = SqlData.getSelectDataTable(SqlData.MASTER, SP, param);
			}
			else
			{
				result = SqlData.getSelectDataTable(SqlData.MASTER, SP);
			}

			return result;
		}

		/// <summary>
		/// Gets the result as a datatable from the passed stored procedure.
		/// </summary>
		/// <param name="SP">The stored procedure to call</param>
		/// <param name="XMLargs">The XML args</param>
		/// <param name="listParam">An array of additional params</param>
		/// <example>
		///		@XMLargs	VARCHAR(8000) = null,
		///		@param0 int,
		///		@param1 int,
		///		@param2 int,
		///		@param3 int,
		///		@param4 int,
		///		@param5 int
		///		
		///		AS
		///		
		///		Your stored procedure here...
		/// </example>
		/// <returns>Datatable</returns>
		public static DataTable spIntelReportResult(string SP, string XMLargs, int[] listParam)
		{
			DataTable result = null;

			bool xml = false;
			bool args = false;

			SqlParameter[] param = null;

			if (XMLargs != null && XMLargs != "")
			{
				xml = true;
			}

			if (listParam != null && listParam.Length > 0)
			{
				args = true;
			}

			if (xml && args)
			{
				param = new SqlParameter[1 + listParam.Length];

				param[0] = new SqlParameter("@XMLargs", SqlDbType.VarChar, 4000);
				param[0].Value = XMLargs;

				//build up the custom params
				for (int i = 0; i < listParam.Length; i++)
				{
					param[i + 1] = new SqlParameter("@param" + i.ToString(), SqlDbType.Int);
					param[i + 1].Value = listParam[i];
				}
			}
			else if (xml && !args)
			{
				param = new SqlParameter[1];

				param[0] = new SqlParameter("@XMLargs", SqlDbType.VarChar, 4000);
				param[0].Value = XMLargs;
			}
			else if (!xml && args)
			{
				param = new SqlParameter[listParam.Length];

				//build up the custom params
				for (int i = 0; i < listParam.Length; i++)
				{
					param[i] = new SqlParameter("@param" + i.ToString(), SqlDbType.Int);
					param[i].Value = listParam[i];
				}
			}

			if (param != null)
			{
				if (xml || args)
				{
					result = SqlData.getSelectDataTable(SqlData.MASTER, SP, param);
				}
				else
				{
					result = SqlData.getSelectDataTable(SqlData.MASTER, SP);
				}
			}

			return result;
		}
	}
}
