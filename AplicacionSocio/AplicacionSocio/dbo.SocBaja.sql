CREATE PROCEDURE dbo.SocBaja
	@Id varchar(5)
AS
	begin
		delete from dbo.Socio
		where Id=@Id
	RETURN
	end