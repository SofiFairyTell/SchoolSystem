CREATE TABLE [dbo].[Составление_расписания] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Класс]          NCHAR (10)    NOT NULL,
    [День_недели]    NVARCHAR (20) NOT NULL,
    [Время_урока]    NCHAR (20)    NOT NULL,
    [Предмет]        NCHAR (30)    NOT NULL,
    [ФИО_учителя]    NCHAR (30)    NOT NULL,
    [Номер_кабинета] NCHAR (3)     NOT NULL, 
    CONSTRAINT [FK_Составление_расписания_Предмет] FOREIGN KEY ([Предмет]) REFERENCES [dbo].[Предмет], 
    CONSTRAINT [PK_Составление_расписания] PRIMARY KEY ([Id]));

