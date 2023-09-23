use TestDb;

CREATE TABLE [dbo].[movietbl](
	[ID][int] NOT NULL,
	[Title]nvarchar(25) NOT NULL,
	[Language]nvarchar(25) NOT NULL,
	[Hero]nvarchar(25) NOT NULL,
	[Director]nvarchar(25) NOT NULL,
	[MusicDirector]nvarchar(25) NOT NULL,
	[ReleaseDate][date] NOT NULL,
	[Cost][decimal](18, 0) NOT NULL,
	[Collection][decimal](18, 0) NOT NULL,
	[Review][int] NOT NULL,
	CONSTRAINT [PK_movietbl] PRIMARY KEY CLUSTERED ( [ID]ASC)
);
