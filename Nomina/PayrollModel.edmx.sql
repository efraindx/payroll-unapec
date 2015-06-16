
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2015 15:09:17
-- Generated from EDMX file: C:\Users\R. Jimenez\documents\visual studio 2015\Projects\UNAPEC\Nomina\PayrollModel.edmx
-- --------------------------------------------------
CREATE DATABASE [payroll-unapec]

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2015 18:50:15
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

IF OBJECT_ID(N'[dbo].[FK_DepartmentEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_DepartmentEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeeDepartment];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeePayroll]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeePayroll];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeePosition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeePosition];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionTransactionType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionTransactionType];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Payrolls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payrolls];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[TransactionTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionTypes];
GO

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
    [Payroll_Id] int  NOT NULL,
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

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Amount] float  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [TransactionType_Id] int  NOT NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- Creating table 'TransactionTypes'
CREATE TABLE [dbo].[TransactionTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SalaryDependent] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [isIncome] bit  NOT NULL
);
GO

-- Creating table 'Payrolls'
CREATE TABLE [dbo].[Payrolls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Periocity] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TransactionTypes'
ALTER TABLE [dbo].[TransactionTypes]
ADD CONSTRAINT [PK_TransactionTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payrolls'
ALTER TABLE [dbo].[Payrolls]
ADD CONSTRAINT [PK_Payrolls]
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

-- Creating foreign key on [TransactionType_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionTransactionType]
    FOREIGN KEY ([TransactionType_Id])
    REFERENCES [dbo].[TransactionTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionTransactionType'
CREATE INDEX [IX_FK_TransactionTransactionType]
ON [dbo].[Transactions]
    ([TransactionType_Id]);
GO

-- Creating foreign key on [Payroll_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeePayroll]
    FOREIGN KEY ([Payroll_Id])
    REFERENCES [dbo].[Payrolls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeePayroll'
CREATE INDEX [IX_FK_EmployeePayroll]
ON [dbo].[Employees]
    ([Payroll_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------