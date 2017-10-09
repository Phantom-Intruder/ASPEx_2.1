using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using ECommerce.Tables.Utility.System;

namespace ECommerce.Tables.Utility.Messaging
{
	/// <summary>
	/// Email base class for the framework.
	/// </summary>
	public abstract class Email : Volume.Toolkit.Email
	{
		#region Members

		private string applicationURL = "";
		private string applicationName = "";

		#endregion

		#region Abstract Methods

		protected abstract string GetSubjectTitle();    // Gets the subject of the email

		#endregion

		#region Virtual Methods

		/// <summary>
		/// Gets the forecolour to use in emails (highlighted text).
		/// </summary>
		/// <returns>The string "#000000"</returns>
		protected virtual string GetForeColour()
		{
			return "#000000";
		}

		#endregion

		#region Email Settings

		/// <summary>
		/// Gets the prefix length for files that used to ensure unique file names for attachments
		/// </summary>
		/// <returns>The prefix length for attachment files</returns>
		protected override int GetFileUniquePrefixLength()
		{
			return 5;
		}

		/// <summary>
		/// Gets the SMTP server to use
		/// </summary>
		/// <returns>The SMTP server</returns>
		protected override string GetSMTPSever()
		{
			return Config.SmtpServer;
		}

		/// <summary>
		/// Gets the development email addresses to use if in development mode
		/// </summary>
		/// <returns>The development email addresses</returns>
		protected override string GetDevTo()
		{
			return Config.EmailDevelopment;
		}

		/// <summary>
		/// Gets the list of email addresses that will be blind carbon copied into the email
		/// </summary>
		/// <returns>A list of email addresses to blind carbon copy</returns>
		protected override string GetBCC()
		{
			return Config.EmailBcc;
		}

		/// <summary>
		/// Get the "from" email address
		/// </summary>
		/// <returns>A string of "from" email</returns>
		protected override string GetFrom()
		{
			return Config.EmailFrom;
		}

		/// <summary>
		/// Determines if the application is in development mode.
		/// In order to know who to send the email too
		/// </summary>
		/// <returns>True if the application is in development mode; otherwise false</returns>
		protected override bool IsDevelopmentMode()
		{
			return Config.DevelopmentMode;
		}

		#endregion

		#region Base Content of Emails

		/// <summary>
		/// Gets the full subject to use 
		/// </summary>
		/// <returns>The full subject to use on the email</returns>
		protected override string GetSubject()
		{
			return this.ApplicationName + " : " + this.GetSubjectTitle();
		}

		/// <summary>
		/// Gets the warning message to place at the top of the email after the header.
		/// </summary>
		/// <returns>A warning message</returns>
		protected override string GetWarning()
		{
			string result = "";

			result = "This is an automatically generated email from " + this.ApplicationName + ". <strong>Please do not reply to this message.</strong>";

			return result;
		}

		#endregion

		#region Formatting Content Methods

		/// <summary>
		/// Adds the content as an HTML paragraph
		/// </summary>
		/// <param name="content">The content to add to the paragraph</param>
		/// <returns>An HTML string that represents a paragraph of the content</returns>
		protected string AddParagraph(string content)
		{
			string result = content;

			result = "<p>" + content + "</p>";

			return result;
		}

		/// <summary>
		/// Starts an HTML paragraph
		/// </summary>
		/// <returns>An HTML string that starts a paragraph</returns>
		protected string StartParagraph()
		{
			return "<p>";
		}

		/// <summary>
		/// Ends an HTML paragraph
		/// </summary>
		/// <returns>An HTML string that ends a paragraph</returns>
		protected string EndParagraph()
		{
			return "</p>";
		}

		/// <summary>
		/// Creates a sentance as an HTML string.
		/// </summary>
		/// <param name="content">The content of the sentance</param>
		/// <returns>A sentance as an HTML string</returns>
		protected string CreateSentance(string content)
		{
			return content + "<br />";
		}

		/// <summary>
		/// Highlights the content as an HTML string
		/// </summary>
		/// <param name="content">The content to highlight</param>
		/// <returns>The content passed highlighted</returns>
		protected string CreateHighlightedText(string content)
		{
			return "<strong style=\"color:" + this.GetForeColour() + "\">" + content + "</strong>";
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the application URL
		/// </summary>
		protected string ApplicationURL
		{
			get
			{
				if (String.IsNullOrEmpty(this.applicationURL))
				{
					this.applicationURL = Config.ApplicationUrl;
				}

				return this.applicationURL;
			}
		}

		/// <summary>
		/// Gets the application name
		/// </summary>
		protected string ApplicationName
		{
			get
			{
				if (String.IsNullOrEmpty(this.applicationName))
				{
					this.applicationName = Config.ApplicationName;
				}

				return this.applicationName;
			}
		}

		#endregion
	}
}
