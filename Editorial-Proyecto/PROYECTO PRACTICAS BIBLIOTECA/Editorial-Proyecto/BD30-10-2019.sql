USE [BD_Libreria_Practicas]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Libros](
	[IdLibro] [int] IDENTITY(1,1) NOT NULL,
	[NombreLibro] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Precio] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturaVentaDetalles]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVentaDetalles](
	[IdVentaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdFacturaVenta] [int] NULL,
	[IdLibro] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [money] NULL,
	[Total] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasVentas]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturasVentas](
	[IdFacturaVenta] [int] IDENTITY(1,1) NOT NULL,
	[Letra] [varchar](50) NULL,
	[PuntoVenta] [int] NULL,
	[Nro] [int] NOT NULL,
	[IdCliente] [int] NULL,
	[Total] [money] NULL,
	[Fecha] [date] NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Editoriales](
	[NombreEditorial] [varchar](100) NULL,
	[IdEditorial] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreFantasia] [varchar](100) NULL,
	[Estado] [bit] NULL,
	[Mail] [varchar](100) NULL,
	[Movil] [int] NULL,
	[DNI] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autores](
	[Nombre] [varchar](100) NULL,
	[Nacionalidad] [varchar](100) NULL,
	[IdAutor] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArticulosGeneros]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArticulosGeneros](
	[IdArticuloCaracteristica] [int] IDENTITY(1,1) NOT NULL,
	[Genero] [varchar](100) NULL,
	[NombreTipoArticulo] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArticulosFormatos]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArticulosFormatos](
	[NombreTipoArticulo] [varchar](100) NULL,
	[IdArticuloFormato] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArticulosEstados]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArticulosEstados](
	[IdArticuloEstado] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NULL,
	[EstadoTipo] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articulos](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NULL,
	[IdCliente] [int] NULL,
	[IdEditorial] [int] NULL,
	[IdAlquiler] [int] NULL,
	[IdVenta] [int] NULL,
	[IdAutor] [int] NULL,
	[IdArticuloCaracteristica] [int] NULL,
	[Titulo] [varchar](100) NULL,
	[ISBN] [varchar](100) NULL,
	[CantidadTotal] [int] NULL,
	[Estado] [varchar](100) NULL,
	[Descripcion] [varchar](100) NULL,
	[FechaPublicacion] [date] NULL,
	[Edicion] [varchar](100) NULL,
	[Tapa] [varchar](100) NULL,
	[CantPag] [varchar](100) NULL,
	[Precio] [money] NULL,
	[TamañoDelArchivo] [varchar](100) NULL,
	[FechaDePublicacion] [varchar](100) NULL,
	[Idioma] [varchar](100) NULL,
	[Audible] [varchar](100) NULL,
	[Comentarios] [varchar](1000) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alquileres]    Script Date: 10/30/2019 19:56:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[IdAlquiler] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdLibro] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CargarDetalleVenta]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CargarDetalleVenta]
@IdCliente as int,
@IdLibro as int,
@IdVenta as int,
@PrecioLibro as money
as
insert into DetallesVenta
(IdCliente,IdLibro,IdVenta,PrecioLibro)
values
(@IdCliente,
@IdLibro,
@IdVenta,
@PrecioLibro)
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedores] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompañia] [varchar](100) NULL,
	[NombreFantasia] [varchar](100) NULL,
	[NombreContacto] [varchar](100) NULL,
	[NroCuit] [varchar](50) NULL,
	[NroContacto] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[ModificarProveedores]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarProveedores]
@IdProveedores int,
@NombreCompañia varchar(100),
@NombreFantasia varchar(100),
@NombreContacto varchar(100),
@NroCuit varchar(50),
@NroContacto varchar(50)
as
update Proveedores
set NombreCompañia=@NombreCompañia,NombreFantasia=@NombreFantasia,NombreContacto=@NombreContacto,NroCuit=@NroCuit,NroContacto=@NroContacto
where IdProveedores=@IdProveedores
GO
/****** Object:  StoredProcedure [dbo].[ModificarEditorial]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarEditorial]
@idEditorial int,
@NombreEditorial varchar(100)
as
update Editoriales
set NombreEditorial=@NombreEditorial
where IdEditorial=@idEditorial
GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarCliente]
@IdCliente as int,
@Nombre as varchar(50),
@DNI as int,
@TelMovil as varchar(50),
@Mail as varchar(50),
@EstadoCliente as bit
as
update Clientes
set 
NombreFantasia=@Nombre,
Estado=@EstadoCliente,
Mail=@Mail,
Movil=@TelMovil,
DNI=@DNI
where 
IdCliente=@IdCliente
GO
/****** Object:  StoredProcedure [dbo].[ModificarAutor]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarAutor]
@Nombre  varchar (50),
@Nacionalidad  varchar(50),
@IdAutor as int
as
update dbo.Autores
set Nombre=@Nombre,
	Nacionalidad=@Nacionalidad
where IdAutor=@IdAutor
GO
/****** Object:  StoredProcedure [dbo].[ModificarArtGenero]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarArtGenero]
@IdArticuloCaracteristica int,
@Genero varchar(100),
@NombreTipoArticulo varchar(100)
as
update ArticulosGeneros
set Genero=@Genero, NombreTipoArticulo=@NombreTipoArticulo
where IdArticuloCaracteristica=@IdArticuloCaracteristica
GO
/****** Object:  StoredProcedure [dbo].[ModificarArtFormato]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ModificarArtFormato]
@IdArticuloFormato int,
@NombreTipoArticulo varchar(100)
as
update ArticulosFormatos
set NombreTipoArticulo=@NombreTipoArticulo
where IdArticuloFormato=@IdArticuloFormato
GO
/****** Object:  StoredProcedure [dbo].[Modificar]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Modificar]
@idArticuloCaracteristica int,
@Genero varchar(100),
@NombreTipoArticulo varchar(100)
as
update ArticulosGeneros
set Genero = @Genero, NombreTipoArticulo=@NombreTipoArticulo
where IdArticuloCaracteristica = @idArticuloCaracteristica
GO
/****** Object:  StoredProcedure [dbo].[CargarArtGenero]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarArtGenero]
@Genero varchar(100),
@NomreTipoArticulo varchar(100)
as
insert into ArticulosGeneros(Genero,NombreTipoArticulo)
values (@Genero, @NomreTipoArticulo)
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[CargarArtFormato]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarArtFormato]
@NombreTipoArticulo varchar(100)
as
insert into ArticulosFormatos
values(@NombreTipoArticulo)
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[Cargar]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Cargar]
@Genero varchar(100),
@NombreTipoArticulo varchar(100)
as
insert into ArticulosGeneros
values(@Genero,@NombreTipoArticulo)
GO
/****** Object:  StoredProcedure [dbo].[BuscarTodosPorveedores]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarTodosPorveedores]
as
select IdProveedores, UPPER( NombreCompañia),UPPER (NombreFantasia),UPPER (NombreContacto),NroCuit,NroContacto
from Proveedores
GO
/****** Object:  StoredProcedure [dbo].[BuscarTodosClientes]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarTodosClientes]
as
select  IdCliente,UPPER(NombreFantasia),UPPER(Mail),UPPER(RazonSocial),	UPPER(Domicilio),CantidadPrestamos,Estado
from Clientes
GO
/****** Object:  StoredProcedure [dbo].[BuscarporIDGenero]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarporIDGenero]
@IdArticuloCaracteristica int
as
select IdArticuloCaracteristica,Genero,NombreTipoArticulo
from ArticulosGeneros
where IdArticuloCaracteristica=@IdArticuloCaracteristica
GO
/****** Object:  StoredProcedure [dbo].[BuscarPorIdClientes]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarPorIdClientes]
@IdCliente  int
as
select IdCliente,NombreFantasia,Mail,RazonSocial,NroCuit,Domicilio,CantidadPrestamos,Estado
from dbo.Clientes
where IdCliente=@IdCliente
GO
/****** Object:  StoredProcedure [dbo].[BuscarPorIdAutor]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarPorIdAutor]
@IdAutor  int
as
select IdAutor,Nombre,Nacionalidad
from Autores
where IdAutor=@IdAutor
GO
/****** Object:  StoredProcedure [dbo].[BuscarporID]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarporID]
@idEditorial int
as
select IdEditorial,NombreEditorial
from Editoriales
where IdEditorial=@idEditorial
GO
/****** Object:  StoredProcedure [dbo].[BuscarIDProveedor]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarIDProveedor]
@IdProveedores int
as
select IdProveedores,NombreCompañia,NombreFantasia,NombreContacto,NroCuit,NroContacto
from Proveedores
where IdProveedores=@IdProveedores
GO
/****** Object:  StoredProcedure [dbo].[BuscarID]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarID]
@IdArticuloFormato int
as
select IdArticuloFormato,NombreTipoArticulo
from ArticulosFormatos
where IdArticuloFormato=@IdArticuloFormato
GO
/****** Object:  StoredProcedure [dbo].[BuscarCliente]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarCliente]
@IdCliente as int
as
select * from Clientes
where IdCliente= @IdCliente
GO
/****** Object:  StoredProcedure [dbo].[BuscadorLibro]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscadorLibro] 
 @Nombre varchar(50)
 as
 select * 
 from Libros
 where NombreLibro like '%' + @Nombre+'%'
 order by NombreLibro
GO
/****** Object:  StoredProcedure [dbo].[BuscadorCliente]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscadorCliente]

@Nombre  varchar(50)
as
select *
 from clientes
 where NombreFantasia like '%' +@Nombre+'%'
order by NombreFantasia
GO
/****** Object:  StoredProcedure [dbo].[AgregarCliente]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarCliente]
@Nombre as varchar(50),
@DNI as int,
@TelMovil as varchar(50),
@Mail as varchar(50),
@EstadoCliente as bit
as
insert into Clientes
(NombreFantasia,
Estado,
Mail,
Movil,
DNI)
values
(@Nombre,
@EstadoCliente,
@Mail,
@TelMovil,
@DNI)
GO
/****** Object:  StoredProcedure [dbo].[AgregarAutor]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarAutor]
@Nombre varchar(50),
@Nacionalidad  varchar(50)
as
insert into dbo.Autores(Nombre,Nacionalidad)
values (@Nombre,@Nacionalidad)
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[CargarProveedores]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarProveedores]
@NombreCompañia varchar(100),
@NombreFantasia varchar(100),
@NombreContacto varchar(100),
@NroCuit varchar(50),
@NroContacto varchar(50)
as
insert into Proveedores
values(@NombreCompañia,@NombreFantasia,@NombreContacto,@NroCuit,@NroContacto)
select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaoAutores]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaoAutores]
as
select IdAutor,upper(Nombre),upper(Nacionalidad) as 'Nacionalidad'
from dbo.Autores
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaLibros]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaLibros]
as
select NombreLibro,Precio,IdLibro from Libros
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaEditorial]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaEditorial]
as
select IdEditorial,UPPER( NombreEditorial)
from Editoriales
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaClientes]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaClientes]
as
select IdCliente,NombreFantasia,Mail,Movil,DNI from Clientes
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaArtGenero]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaArtGenero]
as
select IdArticuloCaracteristica,Genero,NombreTipoArticulo
from ArticulosGeneros
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaArtFormato]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaArtFormato]
as
select IdArticuloFormato,upper(NombreTipoArticulo)
from ArticulosFormatos
GO
/****** Object:  StoredProcedure [dbo].[CargarGrilla]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CargarGrilla]
as
select IdArticuloCaracteristica, UPPER(Genero), UPPER(NombreTipoArticulo)
from ArticulosGeneros
GO
/****** Object:  StoredProcedure [dbo].[CargarFacturaVentaDetalle]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarFacturaVentaDetalle]
  @IdFactura as int, @IdLibro as int , @Cantidad as int , @PrecioUnitario as money, @Total as money
  as
  insert into dbo.FacturaVentaDetalles
  values (
  @IdFactura,@IdLibro,@Cantidad,@PrecioUnitario,@Total
  )
GO
/****** Object:  StoredProcedure [dbo].[CargarFacturaVenta]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[CargarFacturaVenta]
   @Letra as varchar, 
   @PuntoVenta as int,
    @Nro as int,
     @IdCliente as int,
     @Total as money, 
     @Fecha as date, 
     @Estado as bit
  as 
  insert into dbo.FacturasVentas
  values 
  (@Letra,@PuntoVenta,@Nro,@IdCliente,@Total,@Fecha,@Estado)
  select @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[CargarEditorial]    Script Date: 10/30/2019 19:56:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarEditorial]
@NombreEditorial varchar(100)
as
insert into Editoriales
values(@NombreEditorial)
select @@IDENTITY
GO
