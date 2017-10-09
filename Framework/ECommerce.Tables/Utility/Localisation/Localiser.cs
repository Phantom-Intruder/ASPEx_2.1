using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Web;
using Volume.Toolkit.Paths;
using ECommerce.Tables.Utility.System;
using ECommerce.Tables.Utility.System.Loggers;

using Volume.Logger;

namespace ECommerce.Tables.Utility.Localisation
{
	/// <summary>
	/// Provides common localisation functionality. 
	/// </summary>
	public abstract class Localiser
	{
		#region Localised Files

		/// <summary>
		/// Gets the localised version of a URL
		/// </summary>
		/// <param name="url">URL</param>
		/// <returns>Localised version</returns>
		public static string GetLocalisedUrl(string url)
		{
			// Get the two-digit culture code
			string          code                    = CurrentUICulture.Name;

			// Join them together
			string          result                  = PathUtility.CombineUrls(new string[2] { url, code });

			return result;
		}

		#endregion

		#region Global Resources

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="className">Class name to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <param name="args">Arguments to format within the text.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		public static string GetGlobalTextResource(Type type, string key, params string[] args)
		{
			// Get the resource text
			string              resourceText                = GetGlobalTextResource(type, key);

			// Format the text
			string              result                      = string.Format(resourceText, (object[])args);

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="type">Type to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		public static string GetGlobalTextResource(Type type, string key)
		{
			string              result                      = GetGlobalTextResource(type.Name, key);

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="type">Type to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetGlobalTextResource(Type type, string key, CultureInfo cultureInfo)
		{
			string              result                      = GetGlobalTextResource(type.Name, key, cultureInfo);

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="className">Class name to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <param name="args">Arguments to format within the text.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetGlobalTextResource(Type type, string key, CultureInfo cultureInfo, params string[] args)
		{
			// Get the resource text
			string              resourceText                = GetGlobalTextResource(type.Name, key, cultureInfo);

			// Format the text
			string              result                      = string.Format(resourceText, (object[])args);

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="className">Class name to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetGlobalTextResource(string className, string key, CultureInfo cultureInfo)
		{
			return GetGlobalTextResource(className, key, cultureInfo, true);
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="className">Class name to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetGlobalTextResource(string className, string key, CultureInfo cultureInfo, bool logIfNotFound)
		{
			// Get the fallback text to show in the event the resource cannot be found.
			string                      result              = GetDefaultText();

			// Wrap in try/catch, so we can handle if the resource file is not found for
			// the specified object
			try
			{
				// Try getting the resource value. 
				object                  value               = null;

				// If we have a culture, use it (but only if translations have been enabled in the UI)
				if (cultureInfo != null && Config.TranslationEnabled)
				{
					value                                   = HttpContext.GetGlobalResourceObject(className, key, cultureInfo);
				}
				// Otherwise use current
				else
				{
					value                                   = HttpContext.GetGlobalResourceObject(className, key);
				}

				// Check if null
				if (value != null)
				{
					// Is there, so set to result
					result                                  = value.ToString();
				}
				else
				{
					// Log only if flag set
					if (logIfNotFound)
					{
						// Not found in resource file. Log it first.
						if (cultureInfo != null)
						{
							Log.Info(string.Format("Resource with key '{0}' was not found for class '{1}' and culture '{2}', or the default culture.", key, className, cultureInfo.TwoLetterISOLanguageName));
						}
						else
						{
							Log.Info(string.Format("Resource with key '{0}' was not found for class '{1}' and culture '{2}', or the default culture.", key, className, Localiser.CurrentUICulture.TwoLetterISOLanguageName));
						}
					}
				}
			}
			catch (MissingManifestResourceException)
			{
				// We couldn't find the resource file. Just log, and the default text will
				// be returned
				Log.Error(string.Format("Resource file was not found for the class '{0}'. The resource '{1}' could not be retrieved.", className, key));
			}

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="type">Type to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		public static string GetGlobalTextResource(Type type, string key, string arg)
		{
			// Get the resource text
			string              result                      = GetGlobalTextResource(type, key, new string[1] { arg });

			return result;
		}

		/// <summary>
		/// Gets a global text resource.
		/// </summary>
		/// <param name="className">Class name to retrieve it for.</param>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetGlobalTextResource(string className, string key)
		{
			// Get the fallback text to show in the event the resource cannot be found.
			string                      result              = GetDefaultText();

			// Wrap in try/catch, so we can handle if the resource file is not found for
			// the specified object
			try
			{
				// Try getting the resource value. It will fall back to the default if not found.
				object                  value               = HttpContext.GetGlobalResourceObject(className, key);

				// Check if null
				if (value != null)
				{
					// Is there, so set to result
					result                                  = value.ToString();
				}
				else
				{
					// Not found in resource file. Log it first.
					Log.Info(string.Format("Resource with key '{0}' was not found for class '{1}' and culture '{2}', or the default culture.", key, className, Localiser.CurrentUICulture.TwoLetterISOLanguageName));
				}
			}
			catch (MissingManifestResourceException)
			{
				// We couldn't find the resource file. Just log, and the default text will
				// be returned
				Log.Error(string.Format("Resource file was not found for the class '{0}'. The resource '{1}' could not be retrieved.", className, key));
			}

			return result;
		}

		#endregion

		#region Fallback

		/// <summary>
		/// Gets the default text in the event a localised resource cannot be found.
		/// </summary>
		/// <param name="key">The key of the resource to retrieve.</param>
		/// <param name="stackFrame">Stack frame called from.</param>
		/// <returns>Localised text resource. If not found, it will fallback to the default culture.</returns>
		protected static string GetDefaultText()
		{
			// Create empty text to show in the event the resource cannot be found.
			string                      result              = "[NO DEFAULT TEXT]";

			// Wrap in try/catch, so we can handle if the resource file is not found for
			// the specified object
			try
			{
				// Try getting the resource value
				object                  value               = HttpContext.GetGlobalResourceObject(typeof(Localiser).Name, "DefaultText");

				// Check if null
				if (value != null)
				{
					// Is there, so set to result
					result                                  = "[" + value.ToString() + "]";
				}
			}
			catch (MissingManifestResourceException)
			{
				// We couldn't find the resource file. Just return default text 
			}

			return result;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the currently executing thread's UI culture.
		/// </summary>
		public static CultureInfo CurrentUICulture
		{
			get
			{
				// Return currently executing thread's UI culture
				return Thread.CurrentThread.CurrentUICulture;
			}
			set
			{
				Thread.CurrentThread.CurrentCulture = value;
				Thread.CurrentThread.CurrentUICulture = value;
			}
		}

		#endregion
	}
}
