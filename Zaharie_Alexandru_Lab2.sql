-- 1. Creăm tabelul Author
CREATE TABLE [dbo].[Author] (
    [ID] INT IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED ([ID] ASC)
);

GO
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND name = 'AuthorID')
BEGIN
    ALTER TABLE [dbo].[Book] ADD [AuthorID] INT NULL;
END