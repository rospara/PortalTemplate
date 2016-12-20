CREATE TABLE [dbo].[User] (
    [Id] INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (50) NULL,
    [Surename] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([Id] ASC)
);

