CREATE TABLE [dbo].[Songs] (
    [Id] INT           NOT NULL,
    [Drama]   NVARCHAR (50) NULL,
    [Opening] NVARCHAR (50) NULL,
    [Ending]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_Songs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

