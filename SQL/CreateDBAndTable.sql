USE [FormstackDB]
GO

CREATE TABLE [dbo].[Forms](
    FormId int NOT NULL,
    Name varchar(20) DEFAULT '',
    Description varchar(100) DEFAULT '',
    Date Date NOT NULL
    )
GO