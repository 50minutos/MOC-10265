
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2013 15:02:56
-- Generated from EDMX file: C:\Users\Admin\Desktop\MOC-10265\10265-02\003-DllEdmxModelFirst\AdventureWorks.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AdventureWorks];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoas'
CREATE TABLE [dbo].[Pessoas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Telefones'
CREATE TABLE [dbo].[Telefones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [PessoaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pessoas'
ALTER TABLE [dbo].[Pessoas]
ADD CONSTRAINT [PK_Pessoas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Telefones'
ALTER TABLE [dbo].[Telefones]
ADD CONSTRAINT [PK_Telefones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PessoaId] in table 'Telefones'
ALTER TABLE [dbo].[Telefones]
ADD CONSTRAINT [FK_PessoaTelefone]
    FOREIGN KEY ([PessoaId])
    REFERENCES [dbo].[Pessoas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaTelefone'
CREATE INDEX [IX_FK_PessoaTelefone]
ON [dbo].[Telefones]
    ([PessoaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------