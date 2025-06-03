/*Listar articulos */

Select 
A.Id,
A.Codigo,
A.Nombre,
A.Descripcion,
M.Id As IdMarca,
M.Descripcion AS Marca,
C.Id AS IdCategoria,
C.Descripcion AS Categoria,
A.ImagenUrl,
A.Precio
From Articulos A
Inner Join Categorias C On C.Id = A.IdCategoria
Inner Join Marcas M On M.Id = A.IdMarca

/*Listar marcas*/

Select
Id,
Descripcion
From Marcas