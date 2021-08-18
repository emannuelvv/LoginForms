CREATE TABLE [dbo].[TBLogin] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [nome]  VARCHAR (50) NOT NULL,
    [senha] VARCHAR (50) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
    );

