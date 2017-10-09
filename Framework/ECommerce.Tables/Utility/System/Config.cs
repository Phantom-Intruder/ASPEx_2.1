using System;
using System.Collections.Specialized;
using System.Web.Configuration;
using Volume.Toolkit.Paths;
using System.Data;

using Volume.Logger;

namespace ECommerce.Tables.Utility.System
{
	/// <summary>
	/// Provides configuration options set in either a config file or database.
	/// </summary>
	public class Config
	{

		#region Key Constants

		// Email addresses
		private const string            KEY_EMAIL_ADMIN                         = "EmailAdministrator";
		private const string            KEY_EMAIL_BCC                           = "EmailBcc";
		private const string            KEY_EMAIL_DEVELOPMENT                   = "EmailDevelopment";
		private const string            KEY_EMAIL_FROM                          = "EmailFrom";
		private const string            KEY_EMAIL_NOTIFICATIONS                 = "EmailNotifications";

		// Master account
		private const string            KEY_MASTER_ACCOUNT                      = "MasterAccount";

		// Email server
		private const string            KEY_SMTP_SERVER                         = "SmtpServer";

		// Storage
		private const string            KEY_STORAGE_PATH_URL                    = "StorageURL";
		private const string            KEY_STORAGE_PATH						= "StoragePath";


		// Script/CSS combining
		private const string            KEY_CSS_COMBINING_ENABLED               = "CssCombiningEnabled";
		private const string            KEY_SCRIPT_COMBINING_ENABLED            = "ScriptCombiningEnabled";

		// General settings
		private const string            KEY_DEVELOPMENT_MODE                    = "DevelopmentMode";
		private const string            KEY_APPLICATION_NAME                    = "ApplicationName";
		private const string            KEY_APPLICATION_URL                     = "ApplicationUrl";
		private const string            KEY_START_STOP_EMAILS_ENABLED           = "StartStopEmailsEnabled";

		// Web farm Thread settings 
		private const string            KEY_THREAD_ACTIVE_NODE_ID               = "ThreadActiveNodeID";
		private const string            KEY_THREAD_NODE_POLLING_INTERVAL        = "ThreadNodePollIntervalMinutes";

		// Translations 
		private const string            KEY_TRANSLATION_ENABLED                 = "TranslationEnabled";
		private const string            KEY_DEFAULT_CULTURE                     = "DefaultCulture";

		// Google Analytics
		private const string            KEY_PROFILE_CODE                        = "ProfileCode";
		private const string            KEY_PROFILE_DOMAIN                      = "ProfileDomain";

		// Maintenance message
		private const string            KEY_MAINTENANCE_DELIVERY_DATE           = "MaintenanceDeliveryDate";
		private const string            KEY_MAINTENANCE_MESSAGE_SHOW_DURATION   = "MaintenanceMsgShowDurationHours";
		private const string            KEY_MAINTENANCE_MESSAGE_HIDE_AFTER      = "MaintenanceMsgHideAfterMins";
		private const string            KEY_APP_LAUNCH_DATE                     = "ApplicationLaunchDate";

		#endregion

		#region Folder Constants

		// Folders
		public  const string            FOLDER_PRODUCT                          = "Product";
		public  const string            FOLDER_TEMP                             = "Temp";
		public  const string            FOLDER_CATEGORY                         = "Category"; 
		#endregion

		#region Properties
		public static string StoragePathTemp
		{
			get { return PathUtility.CombinePaths(StoragePath, FOLDER_TEMP); }
		}

		public static string StoragePathCateogry
		{
			get { return PathUtility.CombinePaths(StoragePath, FOLDER_CATEGORY); }
		} 

		public static string StorageUrlTemp
		{
			get { return PathUtility.CombineUrls(StorageUrl, FOLDER_TEMP); }
		}

		public static string StorageUrlCateogry
		{
			get { return PathUtility.CombineUrls(StorageUrl, FOLDER_CATEGORY); }
		}
		 
		/// <summary>
		/// Gets the SMTP server.
		/// </summary>
		public static string SmtpServer
		{
			get { return GetConfigString(KEY_SMTP_SERVER); }
		}

		/// <summary>
		/// Gets the email address for the system administrator.
		/// </summary>
		public static string EmailAdministrator
		{
			get { return GetConfigString(KEY_EMAIL_ADMIN); }
		}

		/// <summary>
		/// Gets the email addresses where blind carbon copies should be sent to.
		/// </summary>
		public static string EmailBcc
		{
			get { return GetConfigString(KEY_EMAIL_BCC); }
		}

		/// <summary>
		/// Gets the email addresses where emails are sent to when development mode is enabled.
		/// </summary>
		public static string EmailDevelopment
		{
			get { return GetConfigString(KEY_EMAIL_DEVELOPMENT); }
		}

		/// <summary>
		/// Gets the email address where emails will appear from.
		/// </summary>
		public static string EmailFrom
		{
			get { return GetConfigString(KEY_EMAIL_FROM); }
		}

		/// <summary>
		/// Gets the email addresses where notification emails should be sent to.
		/// </summary>
		public static string EmailNotifications
		{
			get { return GetConfigString(KEY_EMAIL_NOTIFICATIONS); }
		}

		/// <summary>
		/// Gets the master account email address.
		/// </summary>
		public static string MasterAccount
		{
			get { return GetConfigString(KEY_MASTER_ACCOUNT); }
		}

		/// <summary>
		/// Gets whether the application is in development mode or not.
		/// </summary>
		public static bool DevelopmentMode
		{
			get { return GetAppSettingBoolean(KEY_DEVELOPMENT_MODE); }
		}

		/// <summary>
		/// Gets whether the application start/stop emails are enabled.
		/// </summary>
		public static bool StartStopEmailsEnabled
		{
			get { return GetAppSettingBoolean(KEY_START_STOP_EMAILS_ENABLED); }
		}

		/// <summary>
		/// Gets the application name.
		/// </summary>
		public static string ApplicationName
		{
			get { return GetAppSettingString(KEY_APPLICATION_NAME); }
		}

		/// <summary>
		/// Gets the application URL.
		/// </summary>
		public static string ApplicationUrl
		{
			get { return GetAppSettingString(KEY_APPLICATION_URL); }
		}

		/// <summary>
		/// Gets whether CSS combining is enabled or not.
		/// </summary>
		public static bool CssCombiningEnabled
		{
			get { return GetAppSettingBoolean(KEY_CSS_COMBINING_ENABLED); }
		}

		/// <summary>
		/// Gets whether script combining is enabled or not.
		/// </summary>
		public static bool ScriptCombiningEnabled
		{
			get { return GetAppSettingBoolean(KEY_SCRIPT_COMBINING_ENABLED); }
		}

		/// <summary>
		/// Gets whether translations are enabled or not.
		/// </summary>
		public static bool TranslationEnabled
		{
			get { return GetAppSettingBoolean(KEY_TRANSLATION_ENABLED); }
		}

		/// <summary>
		/// Gets the default culture
		/// </summary>
		public static string DefaultCulture
		{
			get { return GetConfigString(KEY_DEFAULT_CULTURE); }
		}

		/// <summary>
		/// Gets the URL to the storage location.
		/// </summary>
		public static string StorageUrl
		{
			get { return GetConfigString(KEY_STORAGE_PATH_URL); }
		}

		public static string StoragePath
		{
			get { return GetConfigString(KEY_STORAGE_PATH); }
		}

		/// <summary>
		/// Get the Date the application has been released
		/// </summary>
		public static string ApplicationLaunchDate
		{
			get { return GetAppSettingString(KEY_APP_LAUNCH_DATE); }
		}

		/// <summary>
		/// Gets the Google analytics Profile code
		/// </summary>
		public static string ProfileCode
		{
			get { return GetAppSettingString(KEY_PROFILE_CODE); }
		}

		/// <summary>
		/// Gets the Google Analytics Profile ID
		/// </summary>
		public static string ProfileDomain
		{
			get { return GetAppSettingString(KEY_PROFILE_DOMAIN); }
		}

		/// <summary>
		/// Gets delivery date
		/// </summary>
		public static DateTime MaintenanceDeliveryDate
		{
			get
			{
				return Config.GetConfigDateTime(KEY_MAINTENANCE_DELIVERY_DATE);
			}
		}

		/// <summary>
		/// Maintenance Msg Show Duration
		/// </summary>
		public static int MaintenanceMsgShowDurationHours
		{
			get
			{
				int value                                       = Int32.Parse(Config.GetConfigString(KEY_MAINTENANCE_MESSAGE_SHOW_DURATION));

				return value;
			}
		}

		/// <summary>
		/// Maintenance Msg Hide After
		/// </summary>
		public static int MaintenanceMsgHideAfterMins
		{
			get
			{
				int value                                       = Int32.Parse(Config.GetConfigString(KEY_MAINTENANCE_MESSAGE_HIDE_AFTER));

				return value;
			}
		}

		#region Webfarm Thread Settings Accessors
		/// <summary>
		/// Gets the ThreadActiveNodeID value
		/// </summary>
		public static string ThreadActiveNodeID
		{
			get { return GetConfigString(KEY_THREAD_ACTIVE_NODE_ID); }
		}

		/// <summary>
		/// Gets the ThreadActiveNodeID key name
		/// </summary>
		public static string ThreadActiveNodeIDKeyName
		{
			get { return KEY_THREAD_ACTIVE_NODE_ID; }
		}

		/// <summary>
		/// Polling Interval
		/// </summary>
		public static double ThreadNodePollIntervalMinutes
		{
			get { return GetConfigDouble(KEY_THREAD_NODE_POLLING_INTERVAL); }
		}

		#endregion

		#endregion

		#region Config Methods

		/// <summary>
		/// Gets a string config setting.
		/// </summary>
		/// <param name="Key">The key for the config setting.</param>
		/// <returns>The string setting.</returns>
		protected static string GetConfigString(string Key)
		{
			string                          result          = null;

			DataTable                       dt              = SQL.Utility.System.Config.ConfigGetByName(Key);

			if (dt != null)
			{
				if (dt.Rows.Count >= 1)
				{
					result                                  = (string)dt.Rows[0]["Value"];
				}
			}

			if (result == null)
			{
				Log.Warning(string.Format("Config table key '{0}' could not be found", Key));
			}

			return result;
		}

		/// <summary>
		/// Sets a string config setting.
		/// </summary>
		/// <param name="key">The key for the config setting.</param>
		/// <param name="value">The value for the config setting.</param>
		public static void SetConfigString(string key, string value)
		{
			SQL.Utility.System.Config.ConfigSetByName(key, value);
		}

		/// <summary>
		/// Gets a boolean config setting.
		/// </summary>
		/// <param name="Key">The key for the application setting.</param>
		/// <returns>The boolean setting.</returns>
		protected static bool GetConfigBoolean(string key)
		{
			string                          text                    = GetConfigString(key);

			// Parse and let .NET handle and throw an exception if not a valid Boolean string.
			bool                            setting                 = Boolean.Parse(text);

			return setting;
		}

		/// <summary>
		/// Gets an Double configuration setting.
		/// </summary>
		/// <param name="key">The key for the configuration setting.</param>
		/// <returns>The Double setting.</returns>
		static double GetConfigDouble(string key)
		{
			string                          text                    = GetConfigString(key);

			// Parse and let .NET handle and throw an exception if not a valid Double string.
			double                          setting                 = Double.Parse(text);

			return setting;
		}

		/// <summary>
		/// Gets an DateTime configuration setting.
		/// </summary>
		/// <param name="key">The key for the configuration setting.</param>
		/// <returns>The DateTime setting.</returns>
		static DateTime GetConfigDateTime(string key)
		{
			string                      text                        = GetConfigString(key);

			// Parse and let .NET handle and throw an exception if not a valid DateTime string.
			DateTime                    setting                     = DateTime.Parse(text);

			return setting;
		}

		#endregion

		#region App Setting Methods

		/// <summary>
		/// Gets a string application setting.
		/// </summary>
		/// <param name="Key">The key for the application setting.</param>
		/// <returns>The string setting.</returns>
		protected static string GetAppSettingString(string Key)
		{
			// Get the application settings
			NameValueCollection             appSettings             = WebConfigurationManager.AppSettings;

			// Get the setting with the key
			string                          setting                 = appSettings[Key];

			// Check if null
			if (setting == null)
			{
				Log.Warning(string.Format("App setting key '{0}' could not be found", Key));
			}

			return setting;
		}

		/// <summary>
		/// Gets a boolean application setting.
		/// </summary>
		/// <param name="Key">The key for the application setting.</param>
		/// <returns>The boolean setting.</returns>
		protected static bool GetAppSettingBoolean(string key)
		{
			string                          text                    = GetAppSettingString(key);

			// Parse and let .NET handle and throw an exception if not a valid Boolean string.
			bool                            setting                 = Boolean.Parse(text);

			return setting;
		}

		/// <summary>
		/// Gets an Integer configuration setting.
		/// </summary>
		/// <param name="key">The key for the configuration setting.</param>
		/// <returns>The Integer setting.</returns>
		static int GetIntegerSetting(string key)
		{
			string                      text                        = GetAppSettingString(key);

			// Let .NET handle and throw an exception if not a valid Boolean string.
			int                         setting                     = Int32.Parse(text);

			return setting;
		}

		#endregion




























	}
}
