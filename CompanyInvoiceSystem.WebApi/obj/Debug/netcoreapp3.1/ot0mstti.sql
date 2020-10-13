IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Customers] (
    [CustomerId] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [EIN] int NULL,
    [IsDomestic] bit NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
);

GO

CREATE UNIQUE INDEX [INDEX_CUSTOMERS__CUSTOMER_NAME] ON [Customers] ([Name]);

GO

CREATE PROCEDURE GetCustomers
                               AS
                               SELECT * FROM Customers

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201009034205_InitialMigration', N'3.1.8');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] ON;
INSERT INTO [Customers] ([CustomerId], [EIN], [Name])
VALUES ('3574ce85-dedb-4bd8-93b5-080963ef2019', 123456789, N'AZ Tech');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] ON;
INSERT INTO [Customers] ([CustomerId], [EIN], [Name])
VALUES ('a775f9ca-b24e-4273-ac40-bb46e1a7d37a', 100000001, N'Brooklyn Trucks');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201009040111_InitialDataSeed', N'3.1.8');

GO

DELETE FROM [Customers]
WHERE [CustomerId] = '3574ce85-dedb-4bd8-93b5-080963ef2019';
SELECT @@ROWCOUNT;


GO

DELETE FROM [Customers]
WHERE [CustomerId] = 'a775f9ca-b24e-4273-ac40-bb46e1a7d37a';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] ON;
INSERT INTO [Customers] ([CustomerId], [EIN], [Name])
VALUES ('ae860ae3-9120-4b12-9cc1-a6e1396814ef', 123456789, N'AZ Tech');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] ON;
INSERT INTO [Customers] ([CustomerId], [EIN], [Name])
VALUES ('2ea2b7af-6fbc-4f56-a275-c124b7acf7c9', 100000001, N'Brooklyn Trucks Inc.');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] ON;
INSERT INTO [Customers] ([CustomerId], [EIN], [Name])
VALUES ('d99f9213-ddb9-4ea2-bcc6-3e411a78d9bd', 100000331, N'Alt Solutions');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CustomerId', N'EIN', N'Name') AND [object_id] = OBJECT_ID(N'[Customers]'))
    SET IDENTITY_INSERT [Customers] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201009042232_UseMigrationConfig', N'3.1.8');

GO

