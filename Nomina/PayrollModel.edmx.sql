
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2015 08:11:34
-- Generated from EDMX file: C:\Users\R. Jimenez\documents\visual studio 2015\Projects\UNAPEC\Nomina\PayrollModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [payroll-unapec];
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

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cedula] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Salary] float  NOT NULL,
    [PayrollId] nvarchar(max)  NOT NULL,
    [Department_Id] int  NOT NULL,
    [DepartmentEmployee_Employee_Id] int  NOT NULL,
    [Position_Id] int  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RiskLevel] nvarchar(max)  NOT NULL,
    [MinSalary] float  NOT NULL,
    [MaxSalary] float  NOT NULL
);
GO

-- Creating table 'IncomeTypes'
CREATE TABLE [dbo].[IncomeTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SalaryDependent] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [TransactionIncomeType_IncomeType_Id] int  NOT NULL
);
GO

-- Creating table 'DeductionTypes'
CREATE TABLE [dbo].[DeductionTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SalaryDependent] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [TransactionDeductionType_DeductionType_Id] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Amount] float  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'IncomeTypes'
ALTER TABLE [dbo].[IncomeTypes]
ADD CONSTRAINT [PK_IncomeTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeductionTypes'
ALTER TABLE [dbo].[DeductionTypes]
ADD CONSTRAINT [PK_DeductionTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Department_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeeDepartment]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeDepartment'
CREATE INDEX [IX_FK_EmployeeDepartment]
ON [dbo].[Employees]
    ([Department_Id]);
GO

-- Creating foreign key on [DepartmentEmployee_Employee_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_DepartmentEmployee]
    FOREIGN KEY ([DepartmentEmployee_Employee_Id])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentEmployee'
CREATE INDEX [IX_FK_DepartmentEmployee]
ON [dbo].[Employees]
    ([DepartmentEmployee_Employee_Id]);
GO

-- Creating foreign key on [Position_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeePosition]
    FOREIGN KEY ([Position_Id])
    REFERENCES [dbo].[Positions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeePosition'
CREATE INDEX [IX_FK_EmployeePosition]
ON [dbo].[Employees]
    ([Position_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionEmployee'
CREATE INDEX [IX_FK_TransactionEmployee]
ON [dbo].[Transactions]
    ([Employee_Id]);
GO

-- Creating foreign key on [TransactionIncomeType_IncomeType_Id] in table 'IncomeTypes'
ALTER TABLE [dbo].[IncomeTypes]
ADD CONSTRAINT [FK_TransactionIncomeType]
    FOREIGN KEY ([TransactionIncomeType_IncomeType_Id])
    REFERENCES [dbo].[Transactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionIncomeType'
CREATE INDEX [IX_FK_TransactionIncomeType]
ON [dbo].[IncomeTypes]
    ([TransactionIncomeType_IncomeType_Id]);
GO

-- Creating foreign key on [TransactionDeductionType_DeductionType_Id] in table 'DeductionTypes'
ALTER TABLE [dbo].[DeductionTypes]
ADD CONSTRAINT [FK_TransactionDeductionType]
    FOREIGN KEY ([TransactionDeductionType_DeductionType_Id])
    REFERENCES [dbo].[Transactions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionDeductionType'
CREATE INDEX [IX_FK_TransactionDeductionType]
ON [dbo].[DeductionTypes]
    ([TransactionDeductionType_DeductionType_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------