CREATE TABLE [dbo].[SubjectTable] (
    [code]          VARCHAR (50) NOT NULL,
    [name]          VARCHAR (50) NOT NULL,
    [year]          INT          NULL,
    [semester]      INT          NULL,
    [lechrs]        INT          NULL,
    [tutehrs]       INT          NULL,
    [labhrs]        INT          NULL,
    [evaluationhrs] INT          NULL,
    PRIMARY KEY CLUSTERED ([code] ASC)
);

