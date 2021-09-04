declare @repId int;
declare @email nvarchar(50);

set @repId = 1;
set @email = 'apolo@apolo.com';

select 
	* 
from 
	dbo.Clientes 
where 
	RepresentanteId = @repId AND Email = @email;

-- usando filtro direto no banco

select 
	* 
from 
	dbo.Clientes 
where 
	(@repId = 0 OR RepresentanteId = @repId)
	AND
	(@email = '' OR Email = @email);
