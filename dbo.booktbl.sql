CREATE TABLE [dbo].[booktbl] (
    [bid]      INT           IDENTITY (1, 1) NOT NULL,
    [title]    NVARCHAR (50) NOT NULL,
    [author]   NVARCHAR (50) NOT NULL,
    [category] NVARCHAR (50) NOT NULL,
    [quantity] INT           NOT NULL,
    [B_price]    REAL          NOT NULL,
    [S_price] REAL NULL, 
    PRIMARY KEY CLUSTERED ([bid] ASC)
);

