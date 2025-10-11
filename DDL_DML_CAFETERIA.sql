CREATE DATABASE LabCafeteria;
GO
USE [master]
GO
CREATE LOGIN [usrcafeteria] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabCafeteria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabCafeteria]
GO
CREATE USER [usrcafeteria] FOR LOGIN [usrcafeteria]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrcafeteria]
GO



