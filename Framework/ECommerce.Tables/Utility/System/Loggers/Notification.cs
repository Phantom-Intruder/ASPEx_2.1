using System;
using System.Collections.Generic;
using System.Text;

using ECommerce.Tables.Utility.Messaging;

namespace ECommerce.Tables.Utility.System.Loggers
{
	internal class Notification : Email
	{
		#region Members

		protected string subject = "Notification";
		protected string className = null;
		protected string methodName = null;
		protected string description = null;
		protected string url = null;
		protected int accountID = -1;

		#endregion

		#region Constructor

		/// <summary>
		/// Creates a Notification object with the passed parameters
		/// </summary>
		/// <param name="subject">The subject of the notification</param>
		/// <param name="className">The class source that caused the notification</param>
		/// <param name="methodName">The method source that caused the notification</param>
		/// <param name="description">A description of the notification with any additional information</param>
		protected Notification(string subject,
								string className,
								string methodName,
								string description,
								string url,
								int accountID)
		{
			if (!String.IsNullOrEmpty(subject))
			{
				this.subject = subject;
			}

			this.className = className;
			this.description = description;
			this.methodName = methodName;
			this.url = url;
			this.accountID = accountID;
		}

		#endregion

		#region Execute Create

		/// <summary>
		/// Creates a notification object
		/// </summary>
		/// <param name="subject">The subject of the notification</param>
		/// <param name="className">The class source that caused the notification</param>
		/// <param name="methodName">The method source that caused the notification</param>
		/// <param name="description">A description of the notification with any additional information</param>
		/// <param name="url">The URL related to the notification</param>
		/// <param name="accountID">The account ID that caused the notification</param>
		/// <returns>A Notification object or null</returns>
		internal static Notification ExecuteCreate(string subject,
													string className,
													string methodName,
													string description,
													string url,
													int accountID)
		{
			Notification result = null;

			if (subject == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: subject cannot be null");
			}

			if (className == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: className cannot be null");
			}

			if (methodName == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: methodName cannot be null");
			}

			if (description == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: description cannot be null");
			}

			if (url == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: url cannot be null");
			}

			result = new Notification(subject,
															className,
															methodName,
															description,
															url,
															accountID);

			return result;
		}

		/// <summary>
		/// Creates a notification object
		/// </summary>
		/// <param name="className">The class source that caused the notification</param>
		/// <param name="methodName">The method source that caused the notification</param>
		/// <param name="description">A description of the notification with any additional information</param>
		/// <param name="url">The URL related to the notification</param>
		/// <param name="accountID">The account ID that caused the notification</param>
		/// <returns>A Notification object or null</returns>
		internal static Notification ExecuteCreate(string className,
													string methodName,
													string description,
													string url,
													int accountID)
		{
			Notification result = null;

			if (className == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: className cannot be null");
			}

			if (methodName == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: methodName cannot be null");
			}

			if (description == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: description cannot be null");
			}

			if (url == null)
			{
				throw new ArgumentNullException("Notification ExecuteCreate :: url cannot be null");
			}

			result = new Notification("",
															className,
															methodName,
															description,
															url,
															accountID);

			return result;
		}
		#endregion

		#region Methods

		/// <summary>
		/// Gets the HTML for displaying a name and its content value
		/// </summary>
		/// <param name="name">The name (key)</param>
		/// <param name="content">The content (value)</param>
		/// <returns>HTML markup to display the name and content</returns>
		protected string GetTextDetail(string name, string content)
		{
			string result = "";

			result += "<p>";
			result += "<strong>" + name + ":</strong> ";
			result += content;
			result += "</p>";

			return result;
		}

		/// <summary>
		/// Gets the HTML for displaying a name and its content value as a date
		/// </summary>
		/// <param name="name">The name (key)</param>
		/// <param name="content">The content (value) as a date</param>
		/// <returns>HTML markup to display the name and content</returns>
		protected string GetDateDetail(string name, DateTime content)
		{
			string formattedContent = "(none)";

			// If minvalue, it obviously hasn't been assigned a value. So don't return the actual value.
			if (content != DateTime.MinValue)
			{
				formattedContent = content.ToString("dd/MM/yyyy HH:mm:ss");
			}

			return this.GetTextDetail(name, formattedContent);
		}

		#endregion

		#region Overridden Methods

		/// <summary>
		/// Gets the subject title
		/// </summary>
		/// <returns>The subject title</returns>
		protected override string GetSubjectTitle()
		{
			return this.subject;
		}

		/// <summary>
		/// Gets the body of the notification
		/// </summary>
		/// <returns>The body of the notification</returns>
		protected override string GetBody()
		{
			string result = "";

			StringBuilder sb = new StringBuilder();

			string loggedInAccount = "(none)";
			string loggedURL = "(none)";

			sb.Append("<p>Logging Notification For ");
			sb.Append(Config.ApplicationName);
			sb.Append("</p>");
			sb.Append(this.GetTextDetail("Source Class", this.className));
			sb.Append(this.GetTextDetail("Source Method", this.methodName));

			if (!String.IsNullOrEmpty(this.url))
			{
				loggedURL = this.url;
			}

			sb.Append(this.GetTextDetail("URL", loggedURL));

			if (this.accountID > 0)
			{
				loggedInAccount = this.accountID.ToString();
			}

			sb.Append(this.GetTextDetail("Logged In Account ID", loggedInAccount));
			sb.Append(this.GetDateDetail("Date Logged", DateTime.Now));
			sb.Append(this.GetTextDetail("Logged Content", "<br/><br/>" + this.description));

			result = sb.ToString();

			return result;
		}

		/// <summary>
		/// Gets the from address of the notification
		/// </summary>
		/// <returns>The from email address</returns>
		protected override string GetFrom()
		{
			return Config.EmailFrom;
		}

		/// <summary>
		/// Gets the to address of the notification
		/// </summary>
		/// <returns></returns>
		protected override string GetTo()
		{
			return Config.EmailNotifications;
		}

		protected override bool SendViaAmazon()
		{
			return false;
		}

		#endregion
	}
}