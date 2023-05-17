CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NOT NULL, 
    [pass] NVARCHAR(50) NOT NULL, 
    [mail] NVARCHAR(50) NOT NULL, 
    [gender] NCHAR(10) NOT NULL, 
    [genre1] NCHAR(10) NULL, 
    [genre2] NCHAR(10) NULL, 
    [genre3] NCHAR(10) NULL, 
    [genre4] NCHAR(10) NULL, 
    [genre5] NCHAR(10) NULL, 
    [genre6] NCHAR(10) NULL, 
    [birthday] NVARCHAR(50) NOT NULL
)
