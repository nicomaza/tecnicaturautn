create database recetas_db
go
use recetas_db

go

create table TipoReceta
(
id_tipoReceta int identity(1,1) not null,
tipoReceta varchar(100),
CONSTRAINT PK_TIPORECETA Primary key (id_tipoReceta)
)
go

create table Chef
(
 id_chef int Identity(1,1) not null,
 nombre varchar(100),
 constraint pk_chef primary key (id_chef)
)

go


create table Recetas
(
	[id_receta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[id_chef] int Not null,
	[id_tipo_receta] [int] NOT NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY (id_receta),
 CONSTRAINT FK_chef foreign Key (id_chef)
 REFERENCES Chef (id_chef),
 CONSTRAINT FK_TIPORECETA Foreign key (id_tipo_receta)
 References TipoReceta (id_tipoReceta)
)


CREATE TABLE [Ingredientes]
(
	[id_ingrediente] [int] NOT NULL,
	[n_ingrediente] [varchar](50) NOT NULL,
	unidad_medida varchar(50) not null,
	CONSTRAINT [PK_Ingredientes] PRIMARY KEY (id_ingrediente) 
 )



 CREATE TABLE [dbo].[Detalles_Receta](
	detalle_nro int not null,
	[id_receta] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[cantidad] [numeric](5, 2) NOT NULL,
 CONSTRAINT [PK_Detalles_Receta] PRIMARY KEY (id_receta,detalle_nro),
 CONSTRAINT [FK_Recetas] FOREIGN KEY (id_receta)
 REFERENCES Recetas (id_receta),
 CONSTRAINT FK_Ingredientes FOREIGN KEY (id_ingrediente)
 REFERENCES Ingredientes (id_ingrediente)
 )

 go

 INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (1, N'Pollo', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (2, N'Zanahoria', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (3, N'Sal', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (4, N'Aceite', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (5, N'Carne', N'gramos')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (6, N'Azucar', N'cm3')
INSERT [dbo].[Ingredientes] ([id_ingrediente], [n_ingrediente], [unidad_medida]) VALUES (7, N'Comino', N'gramos')

go

insert into Chef values ('Nico Maza')
insert into Chef values ('Juan the lovie')
insert into Chef values ('Meli Ravue')
insert into Chef values ('Roberto Lopez')
insert into Chef values ('Juan Cruz')

go

insert into TipoReceta Values ('Carnes')
insert into TipoReceta Values ('Vegetales')
insert into TipoReceta Values ('Postres')

go
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLES] 
	@detalle_nro int,
	@id_receta int,
	@id_ingrediente int, 
	@cantidad int
AS
BEGIN
	INSERT INTO DETALLES_RECETA(detalle_nro,id_receta,id_ingrediente,cantidad)
    VALUES (@detalle_nro,@id_receta, @id_ingrediente, @cantidad)
END

GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_RECETA] 
	@id_tipo_receta int,
	@nombre varchar(50),
	@id_cheff int
AS
BEGIN
	INSERT INTO Recetas (nombre, id_chef , id_tipo_receta)
    VALUES (@nombre, @id_cheff, @id_tipo_receta );

END


GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_INGREDIENTES]
AS
BEGIN
	
	SELECT * from Ingredientes ORDER BY 2;
END

go

CREATE PROCEDURE SP_CONSULTARCHEF
AS
BEGIN 
		SELECT * FROM Chef Order by 2;
end

go

Create PROCEDURE SP_CONSULTAR_RECETA
AS
BEGIN 
		SELECT * FROM TipoReceta;
end

go

CREATE PROCEDURE SP_PROXIMARECETA
@next int OUTPUT
AS
BEGIN 
	SET @next = (SELECT MAX(id_receta)+1 FROM Recetas)
END


