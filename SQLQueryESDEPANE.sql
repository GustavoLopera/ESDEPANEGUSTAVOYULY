USE [master]
GO
/****** Object:  Database [RequisitosPaciente]    Script Date: 09/04/2022 2:03:43 ******/
CREATE DATABASE [RequisitosPaciente]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RequisitosPaciente', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RequisitosPaciente.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RequisitosPaciente_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RequisitosPaciente_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RequisitosPaciente] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RequisitosPaciente].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RequisitosPaciente] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET ARITHABORT OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RequisitosPaciente] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RequisitosPaciente] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RequisitosPaciente] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RequisitosPaciente] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RequisitosPaciente] SET  MULTI_USER 
GO
ALTER DATABASE [RequisitosPaciente] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RequisitosPaciente] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RequisitosPaciente] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RequisitosPaciente] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RequisitosPaciente] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RequisitosPaciente] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RequisitosPaciente] SET QUERY_STORE = OFF
GO
USE [RequisitosPaciente]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[IdCiudad] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[IdCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosCivil]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosCivil](
	[IdEstadoCivil] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EstadosCivil] PRIMARY KEY CLUSTERED 
(
	[IdEstadoCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluaciones]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluaciones](
	[IdPaciente] [bigint] NOT NULL,
	[IdPreguntasRespuestas] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelesEscolaridad]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelesEscolaridad](
	[IdEscolaridad] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NivelesEscolaridad] PRIMARY KEY CLUSTERED 
(
	[IdEscolaridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ocupaciones]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocupaciones](
	[IdOcupacion] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ocupaciones] PRIMARY KEY CLUSTERED 
(
	[IdOcupacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[IdPaciente] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](50) NOT NULL,
	[IdTipoDocumento] [smallint] NOT NULL,
	[NumeroDocumento] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[IdSexo] [smallint] NOT NULL,
	[IdEstadoCivil] [smallint] NOT NULL,
	[IdOcupacion] [smallint] NOT NULL,
	[IdEscolaridad] [smallint] NOT NULL,
	[IdEPS] [smallint] NOT NULL,
	[IdRegimen] [smallint] NOT NULL,
	[DireccionResidencial] [nvarchar](50) NOT NULL,
	[IdCiudad] [smallint] NOT NULL,
	[CelularContacto] [nchar](10) NOT NULL,
	[TelefonoEmergencia] [nchar](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[IdPregunta] [nchar](10) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED 
(
	[IdPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntasRespuestas]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntasRespuestas](
	[IdPreguntasRespuesta] [smallint] IDENTITY(1,1) NOT NULL,
	[IdPregunta] [nchar](10) NOT NULL,
	[IdRespuesta] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PreguntasRespuestas] PRIMARY KEY CLUSTERED 
(
	[IdPreguntasRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[IdRespuesta] [nchar](10) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[PuntajeEscala] [smallint] NOT NULL,
 CONSTRAINT [PK_Respuestas] PRIMARY KEY CLUSTERED 
(
	[IdRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexos]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexos](
	[IdSexo] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sexos] PRIMARY KEY CLUSTERED 
(
	[IdSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDocumento](
	[IdTipoDocumento] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposEPS]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposEPS](
	[IdEPS] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposEPS] PRIMARY KEY CLUSTERED 
(
	[IdEPS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposRegimen]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposRegimen](
	[IdRegimen] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposRegimen] PRIMARY KEY CLUSTERED 
(
	[IdRegimen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (1, N'Bogotá')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (2, N'Medellín')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (3, N'Cali')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (4, N'Barranquilla')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (5, N'Cartagena de Indias')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (6, N'Soacha')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (7, N'Cúcuta')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (8, N'Soledad')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (9, N'Bucaramanga')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (10, N'Bello')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (11, N'Villavicencio')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (12, N'Ibagué')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (13, N'Santa Marta')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (14, N'Valledupar')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (15, N'Manizales')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (16, N'Pereira')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (17, N'Montería')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (18, N'Nieva')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (19, N'Pasto')
GO
INSERT [dbo].[Ciudades] ([IdCiudad], [Nombre]) VALUES (20, N'Armenia')
GO
INSERT [dbo].[EstadosCivil] ([IdEstadoCivil], [Nombre]) VALUES (1, N'Soltero/a')
GO
INSERT [dbo].[EstadosCivil] ([IdEstadoCivil], [Nombre]) VALUES (2, N'Unión Libre')
GO
INSERT [dbo].[EstadosCivil] ([IdEstadoCivil], [Nombre]) VALUES (3, N'Casado/a')
GO
INSERT [dbo].[EstadosCivil] ([IdEstadoCivil], [Nombre]) VALUES (4, N'Divorciado/a')
GO
INSERT [dbo].[EstadosCivil] ([IdEstadoCivil], [Nombre]) VALUES (5, N'Viudo/a')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (1, N'Preescolar')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (2, N'Básica Primaria')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (3, N'Básica Secundaria')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (4, N'Educación Media')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (5, N'Educación Superior')
GO
INSERT [dbo].[NivelesEscolaridad] ([IdEscolaridad], [Nombre]) VALUES (6, N'Ninguna')
GO
INSERT [dbo].[Ocupaciones] ([IdOcupacion], [Nombre]) VALUES (1, N'Empleado/a')
GO
INSERT [dbo].[Ocupaciones] ([IdOcupacion], [Nombre]) VALUES (2, N'Desempleado/a')
GO
INSERT [dbo].[Ocupaciones] ([IdOcupacion], [Nombre]) VALUES (3, N'Estudiante')
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (1, N'juan', 1, N'3282324234', CAST(N'1998-05-23T00:00:00.0000000' AS DateTime2), 1, 2, 3, 2, 3, 1, N'Montañez', 4, N'1234567856', N'1234567866', N'tavo@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (2, N'juan', 1, N'3282324234', CAST(N'1998-05-23T00:00:00.0000000' AS DateTime2), 1, 2, 3, 2, 3, 1, N'Montañez', 4, N'1234567856', N'1234567866', N'tavo@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (3, N'JUAN', 1, N'1234567891', CAST(N'1998-01-12T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, 1, N'Montañez', 1, N'1234567891', N'1234567891', N'GUSTAVO@GAMIL')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (4, N'JUAN', 1, N'1234567891', CAST(N'1998-01-12T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, 1, N'Montañez', 1, N'1234567891', N'1234567891', N'GUSTAVO@GAMIL')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (5, N'juan', 3, N'1223455555', CAST(N'2022-04-07T00:00:00.0000000' AS DateTime2), 2, 1, 3, 2, 17, 2, N'montañez', 5, N'2687268726', N'2889027892', N'juan@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (6, N'wuihwiuw', 4, N'2792872982', CAST(N'2022-04-07T00:00:00.0000000' AS DateTime2), 2, 2, 2, 3, 17, 2, N'montañez', 3, N'2798279827', N'2900292   ', N'juan@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (7, N'hsgsgus', 3, N'7298729827', CAST(N'2022-04-07T00:00:00.0000000' AS DateTime2), 2, 2, 3, 3, 17, 3, N'montañez', 4, N'7298279287', N'8209820982', N'juan@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (8, N'Gustavo Adolfo Lopera Gallego', 2, N'1035921673', CAST(N'1998-11-03T00:00:00.0000000' AS DateTime2), 2, 1, 3, 4, 5, 1, N'Calle 65#87-35', 2, N'3126204737', N'3126204737', N'gustavoa.lopera@udea.edu.co')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (9, N'Gustavo', 2, N'309383093', CAST(N'2022-03-02T00:00:00.0000000' AS DateTime2), 2, 1, 3, 3, 19, 2, N'lejoe', 3, N'9380398039', N'9809280282', N'sjjwnww')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (10, N'udhiudhd', 1, N'3333333333', CAST(N'2022-04-08T00:00:00.0000000' AS DateTime2), 2, 2, 1, 3, 20, 2, N'hwhhuwhwhwiw', 5, N'2780297272', N'7298279827', N'wuwugwwgwhw')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (11, N'djdjd', 3, N'444444444', CAST(N'2022-04-08T00:00:00.0000000' AS DateTime2), 2, 2, 2, 2, 18, 2, N'jdfnkfjnkfjnfkjf', 4, N'8409804980', N'4904940494', N'flkfmkfmfklmf')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (12, N'Yuly Mosquera', 2, N'1067482067', CAST(N'1999-06-24T00:00:00.0000000' AS DateTime2), 1, 1, 3, 4, 15, 2, N'calle 65 #56-84', 2, N'3125784877', N'3245678910', N'yuly.m@gmail.com')
GO
INSERT [dbo].[Pacientes] ([IdPaciente], [NombreCompleto], [IdTipoDocumento], [NumeroDocumento], [FechaNacimiento], [IdSexo], [IdEstadoCivil], [IdOcupacion], [IdEscolaridad], [IdEPS], [IdRegimen], [DireccionResidencial], [IdCiudad], [CelularContacto], [TelefonoEmergencia], [Email]) VALUES (13, N'yu', 2, N'8768769869', CAST(N'2022-03-01T00:00:00.0000000' AS DateTime2), 1, 2, 2, 1, 17, 3, N'gjhgjh', 4, N'8767868999', N'675596979 ', N'hvjhhjkn')
GO
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P1        ', N'Me ha costado mucho descargar la tensión')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P10       ', N'He sentido que no había nada que me ilusionara')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P11       ', N'Me he sentido inquieto')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P12       ', N'Se me hizo difícil relajarme')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P13       ', N'Me sentí triste y deprimido')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P14       ', N'No toleré nada que no me permitiera continuar con lo que estaba haciendo')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P15       ', N'Sentí que estaba al punto de pánico')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P16       ', N'No me pude entusiasmar por nada')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P17       ', N'Sentí que valía muy poco como persona')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P18       ', N'He tendido a sentirme enfadado con facilidad')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P19       ', N'Sentí los latidos de mi corazón a pesar de no haber hecho ningún esfuerzo físico')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P2        ', N'Me di cuenta que tenía la boca seca')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P20       ', N'Tuve miedo sin razón')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P21       ', N'Sentí que la vida no tenía ningún sentido')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P3        ', N'No podía sentir ningún sentimiento positivo')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P4        ', N'Se me hizo difícil respirar')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P5        ', N'Se me hizo difícil tomar la iniciativa para hacer cosas')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P6        ', N'Reaccioné exageradamente en ciertas situaciones')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P7        ', N'Sentí que mis manos temblaban')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P8        ', N'He sentido que estaba gastando una gran cantidad de energía')
GO
INSERT [dbo].[Preguntas] ([IdPregunta], [Nombre]) VALUES (N'P9        ', N'Estaba preocupado por situaciones en las cuales podía tener pánico o en las que podríahacer el ridículo')
GO
INSERT [dbo].[Respuestas] ([IdRespuesta], [Nombre], [PuntajeEscala]) VALUES (N'R1        ', N'No me ha ocurrido', 0)
GO
INSERT [dbo].[Respuestas] ([IdRespuesta], [Nombre], [PuntajeEscala]) VALUES (N'R2        ', N'Me ha ocurrido un poco, o durante parte del tiempo', 1)
GO
INSERT [dbo].[Respuestas] ([IdRespuesta], [Nombre], [PuntajeEscala]) VALUES (N'R3        ', N'Me ha ocurridobastante, o durante una buena parte del tiempo', 2)
GO
INSERT [dbo].[Respuestas] ([IdRespuesta], [Nombre], [PuntajeEscala]) VALUES (N'R4        ', N'Me ha ocurrido mucho, o la mayor parte del tiempo', 3)
GO
INSERT [dbo].[Sexos] ([IdSexo], [Nombre]) VALUES (1, N'Femenino')
GO
INSERT [dbo].[Sexos] ([IdSexo], [Nombre]) VALUES (2, N'Masculino')
GO
INSERT [dbo].[Sexos] ([IdSexo], [Nombre]) VALUES (3, N'No binario')
GO
INSERT [dbo].[TiposDocumento] ([IdTipoDocumento], [Nombre]) VALUES (1, N'Tarjeta de Identidad')
GO
INSERT [dbo].[TiposDocumento] ([IdTipoDocumento], [Nombre]) VALUES (2, N'Cédula de Ciudadanía')
GO
INSERT [dbo].[TiposDocumento] ([IdTipoDocumento], [Nombre]) VALUES (3, N'Registro civil')
GO
INSERT [dbo].[TiposDocumento] ([IdTipoDocumento], [Nombre]) VALUES (4, N'Pasaporte')
GO
INSERT [dbo].[TiposDocumento] ([IdTipoDocumento], [Nombre]) VALUES (5, N'Cédula de extranjería')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (1, N'Cruz Blanca EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (2, N'Salud vida EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (3, N'EPS SURA')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (4, N'Asmet Salud EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (5, N'Aliansalud')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (6, N'Coosalud')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (7, N'MUTUAL SER')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (8, N'Servicio Occidental de Salud (SOS)')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (9, N'Cafam')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (10, N'Emssanar')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (11, N'Capital Salud')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (12, N'Comfandi')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (13, N'Medimás EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (14, N'Colsubsidio')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (15, N'EPS Sanitas')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (16, N'Compensar')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (17, N'Coomeva EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (18, N'Salud total')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (19, N'Nueva EPS')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (20, N'Famisanar')
GO
INSERT [dbo].[TiposEPS] ([IdEPS], [Nombre]) VALUES (21, N'Otra')
GO
INSERT [dbo].[TiposRegimen] ([IdRegimen], [Nombre]) VALUES (1, N'Subsidiado')
GO
INSERT [dbo].[TiposRegimen] ([IdRegimen], [Nombre]) VALUES (2, N'Contributivo')
GO
INSERT [dbo].[TiposRegimen] ([IdRegimen], [Nombre]) VALUES (3, N'Especial')
GO
/****** Object:  Index [IX_Pacientes_NumeroDocumento]    Script Date: 09/04/2022 2:03:43 ******/
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [IX_Pacientes_NumeroDocumento] UNIQUE NONCLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF_Pacientes_Celular_1]  DEFAULT ('0000000000') FOR [CelularContacto]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_Pacientes] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_Pacientes]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_PreguntasRespuestas] FOREIGN KEY([IdPreguntasRespuestas])
REFERENCES [dbo].[PreguntasRespuestas] ([IdPreguntasRespuesta])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_PreguntasRespuestas]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Ciudades] FOREIGN KEY([IdCiudad])
REFERENCES [dbo].[Ciudades] ([IdCiudad])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Ciudades]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_EstadosCivil] FOREIGN KEY([IdEstadoCivil])
REFERENCES [dbo].[EstadosCivil] ([IdEstadoCivil])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_EstadosCivil]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_NivelesEscolaridad] FOREIGN KEY([IdEscolaridad])
REFERENCES [dbo].[NivelesEscolaridad] ([IdEscolaridad])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_NivelesEscolaridad]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Ocupaciones] FOREIGN KEY([IdOcupacion])
REFERENCES [dbo].[Ocupaciones] ([IdOcupacion])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Ocupaciones]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Sexos1] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexos] ([IdSexo])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Sexos1]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TiposDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TiposDocumento] ([IdTipoDocumento])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TiposDocumento]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TiposEPS] FOREIGN KEY([IdEPS])
REFERENCES [dbo].[TiposEPS] ([IdEPS])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TiposEPS]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TiposRegimen1] FOREIGN KEY([IdRegimen])
REFERENCES [dbo].[TiposRegimen] ([IdRegimen])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TiposRegimen1]
GO
ALTER TABLE [dbo].[PreguntasRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasRespuestas_Preguntas] FOREIGN KEY([IdPregunta])
REFERENCES [dbo].[Preguntas] ([IdPregunta])
GO
ALTER TABLE [dbo].[PreguntasRespuestas] CHECK CONSTRAINT [FK_PreguntasRespuestas_Preguntas]
GO
ALTER TABLE [dbo].[PreguntasRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasRespuestas_Respuestas] FOREIGN KEY([IdRespuesta])
REFERENCES [dbo].[Respuestas] ([IdRespuesta])
GO
ALTER TABLE [dbo].[PreguntasRespuestas] CHECK CONSTRAINT [FK_PreguntasRespuestas_Respuestas]
GO
/****** Object:  StoredProcedure [dbo].[IngresarPaciente]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		YulyAndGustavo
-- Create date: 7-04-2022
-- Description:	Permite ingresar un paciente
-- =============================================
CREATE PROCEDURE [dbo].[IngresarPaciente](
	-- Add the parameters for the stored procedure here
	        @NombreCompleto nvarchar(50)
           ,@IdTipoDocumento smallint
           ,@NumeroDocumento nvarchar(50)
           ,@FechaNacimiento datetime2(7)
           ,@IdSexo smallint
           ,@IdEstadoCivil smallint
           ,@IdOcupacion smallint
           ,@IdEscolaridad smallint
           ,@IdEPS smallint
           ,@IdRegimen smallint
           ,@DireccionResidencial nvarchar(50)
           ,@IdCiudad smallint
           ,@CelularContacto nchar(10)
           ,@TelefonoEmergencia nchar(10)
           ,@Email nvarchar(50))
AS
BEGIN
	INSERT INTO [dbo].[Pacientes]
           ([NombreCompleto]
           ,[IdTipoDocumento]
           ,[NumeroDocumento]
           ,[FechaNacimiento]
           ,[IdSexo]
           ,[IdEstadoCivil]
           ,[IdOcupacion]
           ,[IdEscolaridad]
           ,[IdEPS]
           ,[IdRegimen]
           ,[DireccionResidencial]
           ,[IdCiudad]
           ,[CelularContacto]
           ,[TelefonoEmergencia]
           ,[Email])
     VALUES
           (@NombreCompleto 
           ,@IdTipoDocumento
           ,@NumeroDocumento
           ,@FechaNacimiento
           ,@IdSexo
           ,@IdEstadoCivil
           ,@IdOcupacion
           ,@IdEscolaridad
           ,@IdEPS
           ,@IdRegimen
           ,@DireccionResidencial
           ,@IdCiudad
           ,@CelularContacto
           ,@TelefonoEmergencia
           ,@Email)
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPaciente]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		YulyAndGustavo
-- Create date: 7/04/2022
-- Description:	Permite obtener un paciente
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerPaciente]
   @IdPaciente bigint  
AS
BEGIN
SELECT [IdPaciente]
      ,[NombreCompleto]
      ,pa.[IdTipoDocumento]
	  ,td.Nombre TipoDocumento
      ,[NumeroDocumento]
      ,[FechaNacimiento]
      ,se.[IdSexo]
	  ,se.Nombre Sexo
      ,ec.[IdEstadoCivil]
	  ,ec.Nombre EstadoCivil
      ,oc.[IdOcupacion]
	  ,oc.Nombre Ocupacion
      ,ne.[IdEscolaridad]
	  ,ne.Nombre Escolaridad
      ,te.[IdEPS]
	  ,te.Nombre EPS
      ,tr.[IdRegimen]
	  ,tr.Nombre Regimen
      ,[DireccionResidencial]
      ,ci.[IdCiudad]
	  ,ci.Nombre Ciudad
      ,[CelularContacto]
      ,[TelefonoEmergencia]
      ,[Email]
  FROM [dbo].[Pacientes] pa
  INNER JOIN TiposDocumento td on td.IdTipoDocumento = pa.IdTipoDocumento 
  INNER JOIN Sexos se on se.IdSexo = pa.IdSexo
  INNER JOIN EstadosCivil ec on ec.IdEstadoCivil = pa.IdEstadoCivil
  INNER JOIN Ocupaciones oc on oc.IdOcupacion = pa.IdOcupacion 
  INNER JOIN NivelesEscolaridad ne on ne.IdEscolaridad = pa.IdEscolaridad
  INNER JOIN TiposEPS te on te.IdEPS = pa.IdEPS 
  INNER JOIN TiposRegimen tr on tr.IdRegimen = pa.IdRegimen
  INNER JOIN Ciudades ci on ci.IdCiudad = pa.IdCiudad
    WHERE IdPaciente=@IdPaciente
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPacientes]    Script Date: 09/04/2022 2:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		YulyAndGustavo
-- Create date: 7/04/2022
-- Description:	Permite obtener los pacientes
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerPacientes]
    @NumeroDocumento nvarchar (50) = null
   ,@NombreCompleto nvarchar (max) = null
AS
BEGIN
SELECT [IdPaciente]
      ,[NombreCompleto]
      ,pa.[IdTipoDocumento]
	  ,td.Nombre TipoDocumento
      ,[NumeroDocumento]
      ,[FechaNacimiento]
      ,se.[IdSexo]
	  ,se.Nombre Sexo
      ,ec.[IdEstadoCivil]
	  ,ec.Nombre EstadoCivil
      ,oc.[IdOcupacion]
	  ,oc.Nombre Ocupacion
      ,ne.[IdEscolaridad]
	  ,ne.Nombre Escolaridad
      ,te.[IdEPS]
	  ,te.Nombre EPS
      ,tr.[IdRegimen]
	  ,tr.Nombre Regimen
      ,[DireccionResidencial]
      ,ci.[IdCiudad]
	  ,ci.Nombre Ciudad
      ,[CelularContacto]
      ,[TelefonoEmergencia]
      ,[Email]
  FROM [dbo].[Pacientes] pa
  INNER JOIN TiposDocumento td on td.IdTipoDocumento = pa.IdTipoDocumento 
  INNER JOIN Sexos se on se.IdSexo = pa.IdSexo
  INNER JOIN EstadosCivil ec on ec.IdEstadoCivil = pa.IdEstadoCivil
  INNER JOIN Ocupaciones oc on oc.IdOcupacion = pa.IdOcupacion 
  INNER JOIN NivelesEscolaridad ne on ne.IdEscolaridad = pa.IdEscolaridad
  INNER JOIN TiposEPS te on te.IdEPS = pa.IdEPS 
  INNER JOIN TiposRegimen tr on tr.IdRegimen = pa.IdRegimen
  INNER JOIN Ciudades ci on ci.IdCiudad = pa.IdCiudad
    WHERE (NumeroDocumento = @NumeroDocumento  or @NumeroDocumento is null) or
	      (NombreCompleto like '%' + @NombreCompleto + '%' or @NombreCompleto is null)
END
GO
USE [master]
GO
ALTER DATABASE [RequisitosPaciente] SET  READ_WRITE 
GO
