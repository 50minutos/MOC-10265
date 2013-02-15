
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2013 15:49:46
-- Generated from EDMX file: C:\Users\Admin\Desktop\MOC-10265\10265-02\005-CustomizarEdmx\Model10265.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE AdventureWorks;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Perecivel_inherits_Produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos_Perecivel] DROP CONSTRAINT [FK_Perecivel_inherits_Produto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO
IF OBJECT_ID(N'[dbo].[Produtos_Perecivel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos_Perecivel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Produtos_Perecivel'
CREATE TABLE [dbo].[Produtos_Perecivel] (
    [Vencimento] datetime  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos_Perecivel'
ALTER TABLE [dbo].[Produtos_Perecivel]
ADD CONSTRAINT [PK_Produtos_Perecivel]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'Produtos_Perecivel'
ALTER TABLE [dbo].[Produtos_Perecivel]
ADD CONSTRAINT [FK_Perecivel_inherits_Produto]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------