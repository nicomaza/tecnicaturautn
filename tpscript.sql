USE [FACTURACIONTP]
GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[ID_ARTICULO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[PRECIO_UNITARIO] [money] NULL,
 CONSTRAINT [PK_ID_ARTICULO] PRIMARY KEY CLUSTERED 
(
	[ID_ARTICULO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA](
	[ID_DETALLE] [int] IDENTITY(1,1) NOT NULL,
	[ID_ARTICULO] [int] NULL,
	[CANTIDAD] [int] NULL,
	[NRO_FACTURA] [int] NULL,
 CONSTRAINT [PK_ID_DETALLE] PRIMARY KEY CLUSTERED 
(
	[ID_DETALLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[NRO_FACTURA] [int] IDENTITY(1,1) NOT NULL,
	[FECHA] [datetime] NULL,
	[ID_FORMAPAGO] [int] NULL,
	[CLIENTE] [varchar](100) NULL,
	[estado] [char](1) NULL,
 CONSTRAINT [PK_NRO_FACTURA] PRIMARY KEY CLUSTERED 
(
	[NRO_FACTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FORMA_PAGO]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORMA_PAGO](
	[ID_FORMAPAGO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
 CONSTRAINT [PK_ID_FORMAPAGO] PRIMARY KEY CLUSTERED 
(
	[ID_FORMAPAGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_ID_ARTICULO] FOREIGN KEY([ID_ARTICULO])
REFERENCES [dbo].[ARTICULOS] ([ID_ARTICULO])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_ID_ARTICULO]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_NRO_FACTURA] FOREIGN KEY([NRO_FACTURA])
REFERENCES [dbo].[FACTURA] ([NRO_FACTURA])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_NRO_FACTURA]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_ID_FORMAPAGO] FOREIGN KEY([ID_FORMAPAGO])
REFERENCES [dbo].[FORMA_PAGO] ([ID_FORMAPAGO])
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_ID_FORMAPAGO]
GO
/****** Object:  StoredProcedure [dbo].[consulta_articulos]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[consulta_articulos]
as
select * from ARTICULOS
GO
/****** Object:  StoredProcedure [dbo].[consulta_factivas]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consulta_factivas]
as
select NRO_FACTURA,FECHA,ID_FORMAPAGO,CLIENTE
from FACTURA 
where estado = 0
GO
/****** Object:  StoredProcedure [dbo].[consulta_facturas]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consulta_facturas]
as
select nro_factura 'nro factura', fecha 'fecha',
cliente 'cliente', estado 'estado'
from factura  
GO
/****** Object:  StoredProcedure [dbo].[consulta_fanuladas]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consulta_fanuladas]
as
select NRO_FACTURA,FECHA,ID_FORMAPAGO,CLIENTE
from FACTURA 
where estado = 1
GO
/****** Object:  StoredProcedure [dbo].[consulta_form]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consulta_form]
as
SELECT  DF.NRO_FACTURA ,FECHA,FP.ID_FORMAPAGO 'COD_FORMA',FP.NOMBRE 'FORMA PAGO',CLIENTE, AR.ID_ARTICULO 'IDARTICULO', AR.NOMBRE'ARTICULO', CANTIDAD, PRECIO_UNITARIO
FROM FORMA_PAGO FP JOIN FACTURA FA ON FP.ID_FORMAPAGO = FA.ID_FORMAPAGO 
JOIN DETALLE_FACTURA DF ON DF.NRO_FACTURA = FA.NRO_FACTURA
JOIN ARTICULOS AR ON AR.ID_ARTICULO = DF.ID_ARTICULO
GO
/****** Object:  StoredProcedure [dbo].[consulta_ultimo]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[consulta_ultimo]
as
begin
select max(NRO_FACTURA)
from FACTURA
end
GO
/****** Object:  StoredProcedure [dbo].[formas_pago]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[formas_pago]
as
begin
select * from FORMA_PAGO
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_articulo]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_articulo]
@nombre varchar(100),
@preciounitario money,
@idarticulo int output
as
begin
INSERT INTO ARTICULOS values (@nombre,@preciounitario)
set @idarticulo = SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_detalle]
@idarticulo int,
@cantidad int,
@nrofactura int,
@iddetalle int output
as
begin
INSERT INTO DETALLE_FACTURA values (@idarticulo,@cantidad,@nrofactura)
set @iddetalle = SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[insertar_factura]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_factura]
@fecha date,
@idformapago int,
@cliente varchar(100),
@estado char(1),
@nrofactura int output
as
begin
INSERT INTO FACTURA VALUES (@fecha,@idformapago,@cliente,@estado)
set @nrofactura = SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_estadofac]    Script Date: 9/6/2022 6:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_estadofac]
@nro_factura int
as
update FACTURA
set estado = 1
where NRO_FACTURA = @nro_factura
GO
