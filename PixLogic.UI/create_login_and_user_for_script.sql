if not exists(select * from sys.sql_logins where name = N'SelectOnly')
begin
	create login SelectOnly 
		with password = 'a'
end
go

use [PixLogic.DAL.DataContext]

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'SelectOnlyUser')
begin
	create user SelectOnlyUser 
		for login SelectOnly
end
go

grant select to SelectOnlyUser
go