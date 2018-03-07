CREATE TABLE [dbo].Account
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NCHAR(15) NULL, 
    [email] NCHAR(40) NULL, 
    [password] NCHAR(20) NULL, 
    [address] NCHAR(50) NULL, 
    [phone] INT NULL
)
