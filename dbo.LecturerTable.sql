CREATE TABLE [dbo].[LecturerTable] (
    [empID]      VARCHAR (50) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [faculty]    VARCHAR (50) NULL,
    [department] VARCHAR (50) NULL,
    [center]     VARCHAR (50) NULL,
    [building]   VARCHAR (50) NULL,
    [level]      INT          NULL,
    PRIMARY KEY CLUSTERED ([empID] ASC)
);

