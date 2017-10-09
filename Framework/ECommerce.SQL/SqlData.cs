using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ECommerce.SQL
{
	/// <summary>
	/// Provides reusable database functionality to derived classes.
	/// </summary>
	public class SqlData
	{
		#region Constants
		/// <summary>
		/// Definition of the connection string
		/// </summary>
		public		const		string		MASTER					= "ConnectionString";
		protected	const		int			CONNECTION_TIMEOUT		= 180;
		#endregion

		#region Public Data Access Methods
		/// <summary>
		/// Returns a data table
		/// </summary>
		/// <param name="connectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="storedProcedureName">The name of the stored procedure to execute.</param>
		/// <param name="storedProcedureParameter">A parameter to pass to the stored procedure.</param>
		/// <returns>A data table</returns>
		public static DataTable getSelectDataTable(string connectionStringKeyword, string storedProcedureName, SqlParameter storedProcedureParameter)
		{
			DataTable result = new DataTable();

			SqlDataAdapter da = getSelectDataAdapter(connectionStringKeyword, storedProcedureName, storedProcedureParameter);

			da.Fill(result);

			return result;
		}

		/// <summary>
		/// Returns a data table
		/// </summary>
		/// <param name="ConnectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="StoredProcedureName">The name of the stored procedure to execute.</param>
		/// <param name="StoredProcedureParameter">An array of parameters to pass to the stored procedure.</param>
		/// <returns>A data table</returns>
		public static DataTable getSelectDataTable(string connectionStringKeyword, string storedProcedureName, SqlParameter[] storedProcedureParameter)
		{
			DataTable result = new DataTable();

			SqlDataAdapter da = getSelectDataAdapter(connectionStringKeyword, storedProcedureName, storedProcedureParameter);

			da.Fill(result);

			return result;
		}

		/// <summary>
		/// Returns a data table
		/// </summary>
		/// <param name="connectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="storedProcedureName">The name of the stored procedure to execute.</param>
		/// <returns>A data table</returns>
		public static DataTable getSelectDataTable(string connectionStringKeyword, string storedProcedureName)
		{
			DataTable result = new DataTable();

			SqlDataAdapter da = getSelectDataAdapter(connectionStringKeyword, storedProcedureName);

			da.Fill(result);

			return result;
		}

		/// <summary>
		/// Returns a dataset from executing the stored procedure
		/// </summary>
		/// <param name="connectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="storedProcedureName">The name of the stored procedure to execute.</param>
		/// <param name="StoredProcedureParameter">A parameter to pass to the stored procedure.</param>
		/// <returns>A dataset</returns>
		public static DataSet getSelectDataSet(string connectionStringKeyword, string storedProcedureName, SqlParameter[] storedProcedureParameter)
		{
			DataSet				result				= new DataSet();

			SqlDataAdapter		da					= getSelectDataAdapter(connectionStringKeyword, storedProcedureName, storedProcedureParameter);
			da.MissingSchemaAction					= MissingSchemaAction.AddWithKey;
			
			da.Fill(result);

			return result;
		}

		/// <summary>
		/// Returns a dataset from executing the stored procedure
		/// </summary>
		/// <param name="connectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="storedProcedureName">The name of the stored procedure to execute.</param>
		/// <returns>A dataset</returns>
		public static DataSet getSelectDataSet(string connectionStringKeyword, string storedProcedureName)
		{
			DataSet				result	= new DataSet();

			SqlDataAdapter		da		= getSelectDataAdapter(connectionStringKeyword, storedProcedureName);
			
			da.Fill(result);

			return result;
		}
		#endregion

		#region Internal Methods
		/// <summary>
		/// Returns a SQL server data adapter, ready to use.
		/// </summary>
		/// <param name="ConnectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="StoredProcedureName">The name of the stored procedure to execute.</param>
		/// <param name="StoredProcedureParameters">An array of parameters to pass to the stored procedure.</param>
		protected static SqlDataAdapter getSelectDataAdapter(string connectionStringKeyword, string storedProcedureName, params SqlParameter[] storedProcedureParameters)
		{
			string connectionString = GetConnectionString(connectionStringKeyword);

			SqlConnection _connection					= new SqlConnection(connectionString);
			SqlDataAdapter _adapter						= new SqlDataAdapter(storedProcedureName, _connection);
			
			_adapter.SelectCommand.CommandTimeout		= CONNECTION_TIMEOUT;
			_adapter.SelectCommand.CommandType			= CommandType.StoredProcedure;

			for (int i = 0; i < storedProcedureParameters.Length; i++)
			{
				_adapter.SelectCommand.Parameters.Add(storedProcedureParameters[i]);
			}

			return _adapter;
		}

		/// <summary>
		/// Returns a scalar value
		/// </summary>
		/// <param name="ConnectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="StoredProcedureName">The name of the stored procedure to execute.</param>
		/// <returns></returns>
		public static object getSelectScalar(string ConnectionStringKeyword, string StoredProcedureName )
		{
			return getSelectScalar( ConnectionStringKeyword, StoredProcedureName, new SqlParameter[0] );
		}

		/// <summary>
		/// Returns a scalar value
		/// </summary>
		/// <param name="ConnectionStringKeyword">The configuration keyword to obtain the connection string.</param>
		/// <param name="StoredProcedureName">The name of the stored procedure to execute.</param>
		/// <param name="StoredProcedureParameters">An array of parameters to pass to the stored procedure.</param>
		/// <returns></returns>
		public static object getSelectScalar(string ConnectionStringKeyword, string StoredProcedureName, SqlParameter[] StoredProcedureParameters)
		{
			SqlConnection		_connection	= new SqlConnection(
													   ConfigurationManager.ConnectionStrings[ConnectionStringKeyword].ConnectionString
													);

			SqlCommand			command		= new SqlCommand( StoredProcedureName, _connection );
			command.CommandTimeout			= CONNECTION_TIMEOUT;
			for (int i=0;i<StoredProcedureParameters.Length;i++)
			{
				command.Parameters.Add(StoredProcedureParameters[i]);
			}

			return command.ExecuteScalar();
		}

		/// <summary>
		/// Gets the connection string from the Config file
		/// </summary>
		/// <param name="configName">The Config name</param>
		/// <returns>The connection string</returns>
		protected static string GetConnectionString(string configName)
		{
			string			result				= "";

			if ((ConfigurationManager.ConnectionStrings[configName] != null) &&
					(!String.IsNullOrEmpty(ConfigurationManager.ConnectionStrings[configName].ConnectionString)))
			{
                result							= ConfigurationManager.ConnectionStrings[configName].ConnectionString;
            }
			else
			{
                //throw new System.ArgumentException("Connection string with the key '" + configName + "' could not be found.");
                result                          = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=ECommerceSite; Integrated Security=True";
            }

			return result;
		}
		#endregion
	}
}
