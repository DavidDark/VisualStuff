CREATE PROCEDURE dbo.SocConsulta
	@Id varchar(5)
AS
	begin	
		select *
		from dbo.Socio
		where Id=@Id
	RETURN
	end
