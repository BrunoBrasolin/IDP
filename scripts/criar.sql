CREATE DATABASE [idp];

USE [idp];
GO

CREATE TABLE [dbo].[usuarios](
	[usua_id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[usua_login] [varchar](255) NOT NULL,
	[usua_senha] [varchar](255) NOT NULL
);

CREATE TABLE [dbo].[sistemas](
	[stms_id] [int] PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[stms_sistema] [varchar](255) NOT NULL,
	[stms_url] [varchar](255) NOT NULL
);

CREATE TABLE [dbo].[acessos](
	[acso_id] [int] PRIMARY KEY IDENTITY (1,1) NOT NULL,
	[stms_id] [int] FOREIGN KEY REFERENCES sistemas(stms_id) NOT NULL,
	[usua_id] [int] FOREIGN KEY REFERENCES usuarios(usua_id) NOT NULL,
);