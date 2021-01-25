CREATE DATABASE [ChainOfStores]

USE [ChainOfStores]

CREATE TABLE [Account]
(
	[ID]					INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[Login]					NVARCHAR(30)				   NOT NULL,
	[Password]			    NVARCHAR(30)				   NOT NULL
)
GO

CREATE TABLE [Owner]
(
	[ID]					INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[Name]					NVARCHAR(30)			       NOT NULL,
	[Phone]					NVARCHAR(30)				   NOT NULL
)
GO

CREATE TABLE [Provider]
(
	[ID]					INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[Name]					NVARCHAR(30)				   NOT NULL,
	[Address]				NVARCHAR(30)				   NOT NULL,
	[Phone]					NVARCHAR(30)			       NOT NULL
)	
GO

CREATE TABLE [STORE]
(
	[ID]				   INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[NAME]		           NVARCHAR(30)			          NOT NULL,
	[Profile]			   NVARCHAR(30)					  NOT NULL,
	[Phone]				   NVARCHAR(30)				      NOT NULL,
	[Capital]			   INT							  NOT NULL,
	[NumberOfRegistration] INT							  NOT NULL,
	[DateOfRegistration]   DATE							  NOT NULL,
	[Contribution]         INT							  NOT NULL,
	[OwnerID]              INT CONSTRAINT FK_STORE_OwnerID_Owner_ID FOREIGN KEY REFERENCES [Owner] ([ID])
)
GO

CREATE TABLE [Consignment]
(
	[ID]				   INT PRIMARY KEY IDENTITY	      NOT NULL,
	[ProviderID]		   INT CONSTRAINT FK_Consignment_ProviderID_Provider_ID FOREIGN KEY REFERENCES [Provider] ([ID]),
	[StoreID]			   INT CONSTRAINT FK_Consignment_StoreID_Store_ID FOREIGN KEY REFERENCES [Store] ([ID]),
	[Volume]               INT							  NOT NULL
)
GO