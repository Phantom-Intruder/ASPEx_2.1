/*

	This script inserts the standard config keys we use in majority of our applications.
	
*/

/****** Object:  Table [dbo].[Config]    Script Date: 07/08/2008 17:11:02 ******/


CREATE TABLE [dbo].[Config](
	[name] [nvarchar](255) NOT NULL,
	[value] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Config] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO 

DECLARE		@SMTPServer							NVARCHAR(255);
DECLARE		@EmailAdministrator					NVARCHAR(255);
DECLARE		@EmailBcc							NVARCHAR(255);
DECLARE		@EmailDevelopment					NVARCHAR(255);
DECLARE		@EmailFrom							NVARCHAR(255);
DECLARE		@EmailNotifications					NVARCHAR(255);

DECLARE		@FolderTemp							NVARCHAR(255);
DECLARE		@StoragePath						NVARCHAR(255);
DECLARE		@StorageURL							NVARCHAR(255);
DECLARE		@MasterAccount						NVARCHAR(255);

DECLARE		@MaintenanceDeliveryDate			NVARCHAR(255);
DECLARE		@MaintenanceMsgShowDurationHours	NVARCHAR(255);
DECLARE		@MaintenanceMsgHideAfterMins		NVARCHAR(255);

DECLARE		@EnableStartStopEmail				NVARCHAR(255);

DECLARE		@ThreadActiveNodeID					NVARCHAR(255);
DECLARE		@ThreadNodePollIntervalMinutes		NVARCHAR(255);


/* Email Related */
SET			@SMTPServer							= 'mail.volume.co.uk';
SET			@EmailAdministrator					= 'developers@volumeglobal.com';
SET			@EmailBcc							= 'developers@volumeglobal.com';
SET			@EmailDevelopment					= 'developers@volumeglobal.com';
SET			@EmailFrom							= 'developers@volumeglobal.com';
SET			@EmailNotifications					= 'developers@volumeglobal.com';

SET			@MasterAccount						= 'developers@volumeglobal.com';

/* Folder Related */
SET			@FolderTemp							= 'Temp/';
SET			@StorageURL							= 'http://localhost/[WEBPROJECT]/filestore/';

/* Maintenance Messages */
SET			@MaintenanceDeliveryDate			= '2020-06-06 10:00:00'
SET			@MaintenanceMsgShowDurationHours	= '24'
SET			@MaintenanceMsgHideAfterMins		= '60'

SET			@EnableStartStopEmail				= 'true'

/* Webfarm thread related */
SET			@ThreadActiveNodeID					= ''
SET			@ThreadNodePollIntervalMinutes		= ''


/*******************************************************************************/

/* Start Insert*/
INSERT INTO Config
	([name], [value])
VALUES
	('SmtpServer', @SMTPServer);

INSERT INTO Config
	([name], [value])
VALUES
	('EmailAdministrator', @EmailAdministrator);

INSERT INTO Config
	([name], [value])
VALUES
	('EmailBcc', @EmailBcc);

INSERT INTO Config
	([name], [value])
VALUES
	('EmailDevelopment', @EmailDevelopment);

INSERT INTO Config
	([name], [value])
VALUES
	('EmailFrom', @EmailFrom);

INSERT INTO Config
	([name], [value])
VALUES
	('EmailNotifications', @EmailNotifications);

INSERT INTO Config
	([name], [value])
VALUES
	('FolderTemp', @FolderTemp);

INSERT INTO Config
	([name], [value])
VALUES
	('StorageURL', @StorageURL);

INSERT INTO Config
	([name], [value])
VALUES
	('MasterAccount', @MasterAccount);
	
INSERT INTO Config
	([name], [value])
VALUES
	('MaintenanceDeliveryDate', @MaintenanceDeliveryDate);

INSERT INTO Config
	([name], [value])
VALUES
	('MaintenanceMsgShowDurationHours', @MaintenanceMsgShowDurationHours);

INSERT INTO Config
	([name], [value])
VALUES
	('MaintenanceMsgHideAfterMins', @MaintenanceMsgHideAfterMins);
	
INSERT INTO Config
	([name], [value])
VALUES
	('EnableStartStopEmail', @EnableStartStopEmail);

INSERT INTO Config
	([name], [value])
VALUES
	('ThreadActiveNodeID', @ThreadActiveNodeID);
	
INSERT INTO Config
	([name], [value])
VALUES
	('ThreadNodePollIntervalMinutes', @ThreadNodePollIntervalMinutes);
	
	
	/***************** Config Get/Set Procedures *******************/
	
	/****** Object:  StoredProcedure [dbo].[ConfigGetByName]    Script Date: 01/23/2008 11:39:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConfigGetByName] 

@name		nVarChar(255)

AS

SELECT value FROM Config
WHERE [name] = @name

/****** Object:  StoredProcedure [dbo].[ConfigSetByName]    Script Date: 01/23/2008 11:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConfigSetByName] 

@name		nVarChar(255),
@value		nVarChar(255)

AS

UPDATE Config set [value] = @value 
WHERE [name] = @name

GO

/****** Object:  Table [dbo].[SystemLogged]    Script Date: 08/04/2008 16:47:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemLogged](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[date_logged] [datetime] NOT NULL,
	[url] [nvarchar](500) COLLATE Latin1_General_CI_AS NOT NULL,
	[account_id] [int] NOT NULL,
	[class_name] [nvarchar](300) COLLATE Latin1_General_CI_AS NOT NULL,
	[method_name] [nvarchar](300) COLLATE Latin1_General_CI_AS NOT NULL,
	[description] [nvarchar](max) COLLATE Latin1_General_CI_AS NOT NULL,
	[severity] [int] NOT NULL,
	[remote_address] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[exceptiontype] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[user_agent] [nvarchar](200) COLLATE Latin1_General_CI_AS NULL,
	[server_name] [nvarchar](50) COLLATE Latin1_General_CI_AS NULL,
	[developer_msg] [nvarchar](500) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_SystemLogged] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


/**************** Stored Procedures ***********************/

/* DROP THE EXISTING PROCEDURE SystemLoggedList */
if exists (select* from dbo.sysobjects where id = object_id(N'[dbo].[SystemLoggedList]')and OBJECTPROPERTY(id,N'IsProcedure')=1)
drop procedure [dbo].[SystemLoggedList]
Go
/* DROP THE EXISTING PROCEDURE SystemLoggedInsert */
if exists (select* from dbo.sysobjects where id = object_id(N'[dbo].[SystemLoggedInsert]')and OBJECTPROPERTY(id,N'IsProcedure')=1)
drop procedure [dbo].[SystemLoggedInsert]
Go
/* DROP THE EXISTING PROCEDURE SystemLoggedGetByID */
if exists (select* from dbo.sysobjects where id = object_id(N'[dbo].[SystemLoggedGetByID]')and OBJECTPROPERTY(id,N'IsProcedure')=1)
drop procedure [dbo].[SystemLoggedGetByID]
Go
/* DROP THE EXISTING PROCEDURE SystemLoggedDelete */
if exists (select* from dbo.sysobjects where id = object_id(N'[dbo].[SystemLoggedDelete]')and OBJECTPROPERTY(id,N'IsProcedure')=1)
drop procedure [dbo].[SystemLoggedDelete]
Go
/* DROP THE EXISTING PROCEDURE SystemLoggedUpdate */
if exists (select* from dbo.sysobjects where id = object_id(N'[dbo].[SystemLoggedUpdate]')and OBJECTPROPERTY(id,N'IsProcedure')=1)
drop procedure [dbo].[SystemLoggedUpdate]
Go

CREATE PROCEDURE [dbo].[SystemLoggedInsert]
@date_logged 		 datetime,
@url 				 NVarChar (500) ,
@account_id  		 Int,
@class_name  		 NVarChar (300) ,
@method_name 		 NVarChar (300) ,
@description 		 NVarchar(MAX),
@severity			 Int,
@remote_address		 NVarChar(50),
@exceptiontype		 NVarchar(200),
@user_agent			 NVarchar(200),
@server_name		 NVarchar(50),
@developer_msg		 NVarchar(500)

AS

INSERT INTO SystemLogged
(
	[date_logged],
	[url],
	[account_id],
	[class_name],
	[method_name],
	[description],
	[severity],
	[remote_address],
	[exceptiontype],
	[user_agent],
	[server_name],
	[developer_msg]
)
VALUES
(
	@date_logged,
	@url,
	@account_id,
	@class_name,
	@method_name,
	@description,
	@severity,
	@remote_address,
	@exceptiontype,
	@user_agent,
	@server_name,
	@developer_msg
)
SELECT SCOPE_IDENTITY()

GO


CREATE TRIGGER [SystemLoggedErrorAlert]
ON [SystemLogged]
AFTER INSERT
AS
	DECLARE @class_name 		NVARCHAR(300),
			@method_name 		NVARCHAR(300),
			@description 		NVARCHAR(max),
			@Recipients			NVARCHAR(255),
			@record_count 		INT,
			@id					INT,
			@url				NVARCHAR(500),
			@severity			Int,
			@remote_address		NVarChar(50),
			@exceptiontype		NVarchar(200),
			@user_agent			NVarchar(200),
			@server_name		NVarchar(50)
							
	SELECT 	@id = ID, @class_name = class_name, @method_name = method_name, @url = url, @description = [description], 
			@severity = [severity],	@remote_address = [remote_address],	@exceptiontype = [exceptiontype], @user_agent =	[user_agent], @server_name = [server_name] FROM INSERTED
	
	SELECT @record_count = COUNT([ID])
					FROM SystemLogged 
					WHERE class_name = @class_name 
						AND method_name = @method_name 
						AND url = @url
						AND ID < @id
						AND date_logged > DATEADD(MINUTE, -10, GETDATE())
	IF (@record_count = 0)				
	BEGIN
				
		------ If we send emails every time this triggeres, then email server will fail. Send email every one hour.
		
		DECLARE @from_add			VARCHAR(200),
				@last_send_date		DATETIME,
				@servername		VARCHAR(100)
				
		IF (@@SERVERNAME = 'BSQ-SQLLIVE2008\LIVE2008')
			SET @servername = 'LIVE DB(WEB FARM)'
		ELSE IF (@@SERVERNAME = 'BSQ-WEB\LIVE2008')
			SET @servername = 'LIVE DB(STAND ALONE)'
		ELSE
			SET @servername = @@SERVERNAME
		-- Construct from address as comming from source
		SET @from_add = 'error@volume.co.uk' 		
			
		DECLARE @subject VARCHAR(200)
		DECLARE @CLASSIFICATION VARCHAR(100) 
		SET @CLASSIFICATION = CASE @severity WHEN 0 THEN 'Error' WHEN 1 THEN 'Warning' WHEN 2 THEN 'Notification' ELSE '' END
		SET @subject = @CLASSIFICATION + ' Log Alert from SERVER:' + @servername + ' - DB:' + (SELECT name FROM sys.databases WHERE database_id = DB_ID())
	
		DECLARE @body VARCHAR(MAX)
		
		
		-- Construct body
		SET @body = '<H3>Error Log Alert (Every Minute)</H3>' + 
					'<p>(This email will be triggered once in a minute only)</p>' +
					'<p>Please don''t reply to this email address</p>' +
					'<ul>' +
						'<li><b>Server</b> :- ' + @servername + '</li>' + 
						'<li><b>Database</b> :- ' + (SELECT name FROM sys.databases WHERE database_id = DB_ID()) + '</li>' +
						'<li><b>Time</b> :- ' + CONVERT(VARCHAR(50), GETDATE(), 109) + '</li>' + 
						'<li><b>Class</b> :- ' + @class_name + '</li>' + 
						'<li><b>Method</b> :- ' + @method_name + '</li>' +
						'<li><b>IP Address</b> :- ' + @remote_address + '</li>' +
						'<li><b>Exception Type</b> :- ' + @exceptiontype + '</li>' +
						'<li><b>User Agent</b> :- ' + @user_agent + '</li>' +
						'<li><b>Machine Name</b> :- ' + @server_name + '</li>' +
						'<li><b>Description</b></li>' + 
					'</ul><br />' +
					'<div>' + @description + '</div>'					
		
		--IF LEN(@Recipients) < 0
		--BEGIN
			SET @Recipients = 'error@volume.co.uk'
		--END
		-- Send email
		EXEC msdb.dbo.sp_send_dbmail
			@profile_name = 'Default Mail Profile',
			@from_address = @from_add,
			@recipients = @Recipients,
			@body = @body,
			@subject = @subject,
			@body_format = 'HTML';		
		
	END	
GO