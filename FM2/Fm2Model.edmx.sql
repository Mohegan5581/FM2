
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/27/2016 17:21:43
-- Generated from EDMX file: C:\Users\jvanderbilt\Source\Repos\FM2\FM2\Fm2Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [fm_eval];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Players]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Players];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlayerName] nvarchar(max)  NOT NULL,
    [Aggression] smallint  NOT NULL,
    [WorkRate] smallint  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlayerId] int  NOT NULL,
    [PositionLookupId] int  NOT NULL
);
GO

-- Creating table 'Weights'
CREATE TABLE [dbo].[Weights] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Attribute] nvarchar(max)  NOT NULL,
    [Weight] decimal(18,0)  NOT NULL,
    [TacticId] int  NOT NULL
);
GO

-- Creating table 'Contracts'
CREATE TABLE [dbo].[Contracts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlayerId] int  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [PerWeek] int  NOT NULL,
    [PerWeekWithBonus] int  NOT NULL
);
GO

-- Creating table 'PositionLookups'
CREATE TABLE [dbo].[PositionLookups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PositionAbbr] nvarchar(max)  NOT NULL,
    [PositionName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tactics'
CREATE TABLE [dbo].[Tactics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TacticName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Weights'
ALTER TABLE [dbo].[Weights]
ADD CONSTRAINT [PK_Weights]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [PK_Contracts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PositionLookups'
ALTER TABLE [dbo].[PositionLookups]
ADD CONSTRAINT [PK_PositionLookups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tactics'
ALTER TABLE [dbo].[Tactics]
ADD CONSTRAINT [PK_Tactics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PlayerId] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [FK_PlayerPositions]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerPositions'
CREATE INDEX [IX_FK_PlayerPositions]
ON [dbo].[Positions]
    ([PlayerId]);
GO

-- Creating foreign key on [PositionLookupId] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [FK_PositionLookupPositions]
    FOREIGN KEY ([PositionLookupId])
    REFERENCES [dbo].[PositionLookups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PositionLookupPositions'
CREATE INDEX [IX_FK_PositionLookupPositions]
ON [dbo].[Positions]
    ([PositionLookupId]);
GO

-- Creating foreign key on [PlayerId] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_PlayerContract]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerContract'
CREATE INDEX [IX_FK_PlayerContract]
ON [dbo].[Contracts]
    ([PlayerId]);
GO

-- Creating foreign key on [TacticId] in table 'Weights'
ALTER TABLE [dbo].[Weights]
ADD CONSTRAINT [FK_TacticWeights]
    FOREIGN KEY ([TacticId])
    REFERENCES [dbo].[Tactics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TacticWeights'
CREATE INDEX [IX_FK_TacticWeights]
ON [dbo].[Weights]
    ([TacticId]);
GO

-- Create some default values
INSERT INTO Tactics VALUES ('Default')
GO

INSERT INTO Weights VALUES ('Aggression', 1.0,1)
INSERT INTO Weights VALUES ('Work Rate', 1.0,1)

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------