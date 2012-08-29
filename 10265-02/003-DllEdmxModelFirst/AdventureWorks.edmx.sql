
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/31/2012 13:44:08
-- Generated from EDMX file: c:\users\usuario\documents\visual studio 2010\Projects\10265-02\003-DllEdmxModelFirst\AdventureWorks.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [10265];
GO
IF SCHEMA_ID(N'Financeiro') IS NULL EXECUTE(N'CREATE SCHEMA [Financeiro]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[Financeiro].[FK_PessoaTelefone]', 'F') IS NOT NULL
    ALTER TABLE [Financeiro].[TELEFONE] DROP CONSTRAINT [FK_PessoaTelefone];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[Financeiro].[PESSOA]', 'U') IS NOT NULL
    DROP TABLE [Financeiro].[PESSOA];
GO
IF OBJECT_ID(N'[Financeiro].[TELEFONE]', 'U') IS NOT NULL
    DROP TABLE [Financeiro].[TELEFONE];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PESSOA'
CREATE TABLE [Financeiro].[PESSOA] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TELEFONE'
CREATE TABLE [Financeiro].[TELEFONE] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PESSOA'
ALTER TABLE [Financeiro].[PESSOA]
ADD CONSTRAINT [PK_PESSOA]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TELEFONE'
ALTER TABLE [Financeiro].[TELEFONE]
ADD CONSTRAINT [PK_TELEFONE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdPessoa] in table 'TELEFONE'
ALTER TABLE [Financeiro].[TELEFONE]
ADD CONSTRAINT [FK_PessoaTelefone]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [Financeiro].[PESSOA]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaTelefone'
CREATE INDEX [IX_FK_PessoaTelefone]
ON [Financeiro].[TELEFONE]
    ([IdPessoa]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------