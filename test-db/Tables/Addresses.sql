CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PersonId] INT NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Addresses_ToPeople] FOREIGN KEY ([PersonId]) REFERENCES [People]([PeopleId])
)
