SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE [master];
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'School')
	DROP DATABASE OnlineShop;
GO

-- Create the School database.
CREATE DATABASE OnlineShop;
GO

-- Specify a simple recovery model 
-- to keep the log growth to a minimum.
ALTER DATABASE OnlineShop 
	SET RECOVERY SIMPLE;
GO

USE OnlineShop;
GO

-- Create the User table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[User]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[Firstname] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Street] [nvarchar](255) NOT NULL,
	[Hno] [nvarchar](255) NOT NULL,
	[Zip] [int] NOT NULL,
	[City] [nvarchar](255) NOT NULL,
	[Birthdate] [datetime] NULL,
	[Phone] [datetime] NULL,
	[eMail] [datetime] NOT NULL,
	[roleID] [int] NOT NULL,
	[dateCreated] [datetime] NOT NULL
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the Role table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Role]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[RightID] [int] NOT NULL,
	[dateCreated] [datetime] NOT NULL
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the Right table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[Right]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Right](
	[RightID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[dateCreated] [datetime] NOT NULL
 CONSTRAINT [PK_Right] PRIMARY KEY CLUSTERED 
(
	[RightID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the BeanBagType table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[BeanBagType]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BeanBagType](
	[BeanBagTypeID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[dateCreated] [datetime] NOT NULL
 CONSTRAINT [PK_BeanBagType] PRIMARY KEY CLUSTERED 
(
	[BeanBagTypeID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- Create the BeanBag table.
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[dbo].[BeanBag]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BeanBag](
	[BeanBagID] [int] NOT NULL,
	[BeanBagTypeID] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Prize] [int] NOT NULL,
	[dateCreated] [datetime] NOT NULL
 CONSTRAINT [PK_BeanBag] PRIMARY KEY CLUSTERED 
(
	[BeanBagID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO