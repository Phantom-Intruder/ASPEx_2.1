using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ECommerce.Tables.Utility.Reports
{
	public class Report
	{
		/// <summary>
		/// GetResultReport
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static DataTable GetResultReport(string SP)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, "");

			return result;
		}

		/// <summary>
		/// GetResultReport
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static DataTable GetResultReport(string SP, int[] arg)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, arg);

			return result;
		}

		/// <summary>
		/// GetResultReport
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static DataTable GetResultReport(string SP, string[] arg)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, arg);

			return result;
		}

		/// <summary>
		/// GetResultReport
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="arg"></param>
		/// <returns></returns>
		public static DataTable GetResultReport(string SP, object[] arg)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, arg);

			return result;
		}

		/// <summary>
		/// GetResultReportXMLArgs
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="XMLargs"></param>
		/// <returns></returns>
		public static DataTable GetResultReportXMLArgs(string SP, string XMLargs)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, XMLargs);

			return result;
		}

		/// <summary>
		/// GetResultReportXMLArgs
		/// </summary>
		/// <param name="SP"></param>
		/// <param name="XMLargs"></param>
		/// <param name="paramList"></param>
		/// <returns></returns>
		public static DataTable GetResultReportXMLArgs(string SP, string XMLargs, int[] paramList)
		{
			DataTable   result  = null;

			result              = SQL.Utility.Reports.Report.spIntelReportResult(SP, XMLargs, paramList);

			return result;
		}
	}
}
