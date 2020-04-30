CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [รหัสนักศึกษา] NCHAR(100) NULL, 
    [ชื่อ-นามสกุล] NCHAR(100) NULL, 
    [สาขา] NCHAR(100) NULL, 
    [อาการ] NCHAR(200) NULL, 
    [ยาที่รับ] NCHAR(100) NULL
)
