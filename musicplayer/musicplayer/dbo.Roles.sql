CREATE TABLE [dbo].[Roles] (
    [Id]  INT           NOT NULL,
    [Drama]    NVARCHAR (50) NULL,
    [Director] NVARCHAR (50) NULL,
    [Actor]    NVARCHAR (50) NULL,
    [Actress]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

