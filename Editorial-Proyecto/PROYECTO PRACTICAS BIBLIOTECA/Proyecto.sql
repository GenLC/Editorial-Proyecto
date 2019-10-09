USE [BD_Libreria_Practicas]
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[ArticulosGeneros]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[ArticulosFormatos]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[ArticulosEstados]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[Articulos]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[Editoriales]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/03/2019 17:00:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreFantasia] [varchar](100) NULL,
	[Estado] [varchar](100) NULL,
	[Mail] [varchar](100) NULL,
	[Movil] [int] NULL,
	[IdVendedor] [int] NULL,
	[RazonSocial] [varchar](100) NULL,
	[Domicilio] [varchar](100) NULL,
	[NroCuit] [int] NULL,
	[Telefono] [int] NULL,
	[PorcentajeDescuento] [varchar](100) NULL,
	[DNI] [int] NULL,
	[FechaNacimiento] [date] NULL,
	[CantidadPrestamos] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransaccionesDetalles]    Script Date: 10/03/2019 17:00:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransaccionesDetalles](
	[IdTransaccionDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdTransaccion] [int] NULL,
	[Cantidad] [int] NULL,
	[IdArticulo] [int] NULL,
	[Precio] [money] NULL,
	[Total] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 10/03/2019 17:00:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transacciones](
	[IdTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NULL,
	[IdCliente] [int] NULL,
	[Fecha] [date] NULL,
	[Importe] [money] NULL,
	[Comprobante] [int] NULL,
	[Total] [int] NULL,
	[TransaccionTipo] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transaccion]    Script Date: 10/03/2019 17:00:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transaccion](
	[IdTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[IdArticulo] [int] NULL,
	[IdCliente] [int] NULL,
	[ImporteTotal] [money] NULL,
	[Comprobante] [varchar](50) NULL,
	[TransaccionTipo] [varchar](50) NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 10/03/2019 17:00:47 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarProveedores]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarEditorial]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarAutor]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarArtGenero]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarArtFormato]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Modificar]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarProveedores]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarGrillaoAutores]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaoAutores]
as
select IdAutor,upper(Nombre),upper(Nacionalidad) as 'Nacionalidad'
from dbo.Autores
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaEditorial]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaEditorial]
as
select IdEditorial,UPPER( NombreEditorial)
from Editoriales
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaArtGenero]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaArtGenero]
as
select IdArticuloCaracteristica,Genero,NombreTipoArticulo
from ArticulosGeneros
GO
/****** Object:  StoredProcedure [dbo].[CargarGrillaArtFormato]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CargarGrillaArtFormato]
as
select IdArticuloFormato,upper(NombreTipoArticulo)
from ArticulosFormatos
GO
/****** Object:  StoredProcedure [dbo].[CargarGrilla]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CargarGrilla]
as
select IdArticuloCaracteristica, UPPER(Genero), UPPER(NombreTipoArticulo)
from ArticulosGeneros
GO
/****** Object:  StoredProcedure [dbo].[CargarEditorial]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarArtGenero]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarArtFormato]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Cargar]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarTodosPorveedores]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarTodosPorveedores]
as
select IdProveedores, UPPER( NombreCompañia),UPPER (NombreFantasia),UPPER (NombreContacto),NroCuit,NroContacto
from Proveedores
GO
/****** Object:  StoredProcedure [dbo].[BuscarporIDGenero]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarPorIdClientes]    Script Date: 10/03/2019 17:00:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BuscarPorIdClientes]
@IdCliente  int
as
select IdCliente,NombreFantasia,Mail,RazonSocial,NroCuit,Domicilio,CantidadPrestamos
from dbo.Clientes
where IdCliente=@IdCliente
GO
/****** Object:  StoredProcedure [dbo].[BuscarPorIdAutor]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarporID]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarIDProveedor]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarID]    Script Date: 10/03/2019 17:00:46 ******/
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
/****** Object:  StoredProcedure [dbo].[AgregarAutor]    Script Date: 10/03/2019 17:00:46 ******/
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
