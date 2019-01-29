
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/22/2018 19:15:35
-- Generated from EDMX file: C:\Users\mshaf\The-Tech-Academy-Basic-C-Sharp-Projects\NewsletterAppMVC\NewsletterAppMVC\Newsletter.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Newsletter];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SignUps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SignUps];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SignUps'
CREATE TABLE [dbo].[SignUps] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(50)  NULL,
    [LastName] varchar(50)  NULL,
    [EmailAddress] varchar(100)  NULL,
    [SocialSecurityNumber] varchar(15)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SignUps'
ALTER TABLE [dbo].[SignUps]
ADD CONSTRAINT [PK_SignUps]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------