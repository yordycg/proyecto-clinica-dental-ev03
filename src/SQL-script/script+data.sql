USE [master]
GO
/****** Object:  Database [clinicaDentalDB]    Script Date: 6/17/2025 3:33:14 PM ******/
CREATE DATABASE [clinicaDentalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'clinicaDentalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\clinicaDentalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'clinicaDentalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\clinicaDentalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [clinicaDentalDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [clinicaDentalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [clinicaDentalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [clinicaDentalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [clinicaDentalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [clinicaDentalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [clinicaDentalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [clinicaDentalDB] SET  MULTI_USER 
GO
ALTER DATABASE [clinicaDentalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [clinicaDentalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [clinicaDentalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [clinicaDentalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [clinicaDentalDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [clinicaDentalDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'clinicaDentalDB', N'ON'
GO
ALTER DATABASE [clinicaDentalDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [clinicaDentalDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [clinicaDentalDB]
GO
/****** Object:  Table [dbo].[citas]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citas](
	[cita_id] [int] IDENTITY(1,1) NOT NULL,
	[run_paciente] [varchar](15) NOT NULL,
	[dentista_id] [varchar](15) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[creado_por] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cita_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_cita]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_cita](
	[detalle_cita_id] [int] IDENTITY(1,1) NOT NULL,
	[cita_id] [int] NOT NULL,
	[servicio_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[detalle_cita_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[run] [varchar](15) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[tipo_empleado_id] [int] NOT NULL,
	[sexo] [varchar](50) NOT NULL,
	[telefono] [varchar](15) NULL,
	[correo] [varchar](100) NULL,
	[fecha_registro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pacientes]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacientes](
	[run] [varchar](15) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[sexo] [varchar](50) NOT NULL,
	[telefono] [varchar](15) NULL,
	[correo] [varchar](100) NULL,
	[fecha_registro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagos]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagos](
	[pago_id] [int] IDENTITY(1,1) NOT NULL,
	[cita_id] [int] NOT NULL,
	[monto] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[metodo_pago] [varchar](50) NOT NULL,
	[estado_pago] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pago_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicios]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicios](
	[servicio_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[costo] [int] NOT NULL,
	[duracion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[servicio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos_empleados]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos_empleados](
	[tipo_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 6/17/2025 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[empleado_run] [varchar](15) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fecha_registro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[citas] ON 

INSERT [dbo].[citas] ([cita_id], [run_paciente], [dentista_id], [estado], [fecha], [hora], [creado_por]) VALUES (1, N'18.651.798-9', N'21.088.108-5', N'Programada', CAST(N'2025-06-20' AS Date), CAST(N'15:30:00' AS Time), N'18.855.085-1')
INSERT [dbo].[citas] ([cita_id], [run_paciente], [dentista_id], [estado], [fecha], [hora], [creado_por]) VALUES (2, N'18.651.798-9', N'21.088.108-5', N'Completada', CAST(N'2025-06-10' AS Date), CAST(N'18:30:00.5900000' AS Time), N'18.855.085-1')
INSERT [dbo].[citas] ([cita_id], [run_paciente], [dentista_id], [estado], [fecha], [hora], [creado_por]) VALUES (3, N'21.173.952-5', N'21.088.108-5', N'Completada', CAST(N'2025-06-03' AS Date), CAST(N'15:00:00' AS Time), N'18.855.085-1')
SET IDENTITY_INSERT [dbo].[citas] OFF
GO
INSERT [dbo].[empleados] ([run], [nombre], [apellido], [tipo_empleado_id], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'18.855.085-1', N'Yordy', N'Carmona', 4, N'M', N'912341234', N'yordy@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[empleados] ([run], [nombre], [apellido], [tipo_empleado_id], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'19.355.975-1', N'Lucia', N'Fernandez', 3, N'F', N'912348765', N'lucy@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[empleados] ([run], [nombre], [apellido], [tipo_empleado_id], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'21.088.108-5', N'Sebastian', N'Leon', 1, N'M', N'912345678', N'seba@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[empleados] ([run], [nombre], [apellido], [tipo_empleado_id], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'22.542.226-5', N'Lucas', N'Jara', 2, N'M', N'987654321', N'lucas@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[empleados] ([run], [nombre], [apellido], [tipo_empleado_id], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'26.685.571-0', N'Nicolas', N'Segura', 3, N'M', N'987658765', N'nico@gmail.com', CAST(N'2025-06-16' AS Date))
GO
INSERT [dbo].[pacientes] ([run], [nombre], [apellido], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'18.651.798-9', N'Franco', N'Larenas', N'Masculino', N'012345678', N'franco@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[pacientes] ([run], [nombre], [apellido], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'20.002.610-1', N'Carla', N'Pizarro', N'Femenino', N'987654321', N'carla@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[pacientes] ([run], [nombre], [apellido], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'21.173.952-5', N'Felipe', N'Gutierrez', N'No Responde', N'912341234', N'felipe@gmail.com', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[pacientes] ([run], [nombre], [apellido], [sexo], [telefono], [correo], [fecha_registro]) VALUES (N'38.099.292-2', N'ELIMINAR', N'AHORA', N'Masculino', N'123412340', N'eliminar@ahora.com', CAST(N'2025-06-16' AS Date))
GO
SET IDENTITY_INSERT [dbo].[pagos] ON 

INSERT [dbo].[pagos] ([pago_id], [cita_id], [monto], [fecha], [metodo_pago], [estado_pago]) VALUES (1, 3, 100000, CAST(N'2025-06-17T22:46:17.000' AS DateTime), N'Efectivo', N'Pendiente')
INSERT [dbo].[pagos] ([pago_id], [cita_id], [monto], [fecha], [metodo_pago], [estado_pago]) VALUES (2, 3, 200000, CAST(N'2025-06-11T22:57:07.960' AS DateTime), N'Tarjeta de Credito', N'Pagado')
SET IDENTITY_INSERT [dbo].[pagos] OFF
GO
SET IDENTITY_INSERT [dbo].[servicios] ON 

INSERT [dbo].[servicios] ([servicio_id], [nombre], [costo], [duracion]) VALUES (1, N'Limpieza Dental', 35000, 45)
INSERT [dbo].[servicios] ([servicio_id], [nombre], [costo], [duracion]) VALUES (2, N'Extraccion Simple', 60000, 60)
INSERT [dbo].[servicios] ([servicio_id], [nombre], [costo], [duracion]) VALUES (3, N'Extraccion Compleja', 110000, 90)
INSERT [dbo].[servicios] ([servicio_id], [nombre], [costo], [duracion]) VALUES (4, N'Blanqueamiento Dental', 150000, 90)
INSERT [dbo].[servicios] ([servicio_id], [nombre], [costo], [duracion]) VALUES (7, N'Eliminar', 2, 1)
SET IDENTITY_INSERT [dbo].[servicios] OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_empleados] ON 

INSERT [dbo].[tipos_empleados] ([tipo_id], [nombre]) VALUES (4, N'Admin')
INSERT [dbo].[tipos_empleados] ([tipo_id], [nombre]) VALUES (2, N'Auxiliar')
INSERT [dbo].[tipos_empleados] ([tipo_id], [nombre]) VALUES (1, N'Dentista')
INSERT [dbo].[tipos_empleados] ([tipo_id], [nombre]) VALUES (3, N'Secretari@')
SET IDENTITY_INSERT [dbo].[tipos_empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([usuario_id], [empleado_run], [nombre], [password], [fecha_registro]) VALUES (1, N'18.855.085-1', N'yordycg', N'123', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[usuarios] ([usuario_id], [empleado_run], [nombre], [password], [fecha_registro]) VALUES (2, N'19.355.975-1', N'lucy', N'123', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[usuarios] ([usuario_id], [empleado_run], [nombre], [password], [fecha_registro]) VALUES (3, N'21.088.108-5', N'seba', N'123', CAST(N'2025-06-16' AS Date))
INSERT [dbo].[usuarios] ([usuario_id], [empleado_run], [nombre], [password], [fecha_registro]) VALUES (4, N'22.542.226-5', N'lucas', N'123', CAST(N'2025-06-16' AS Date))
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__servicio__72AFBCC6C19F65F6]    Script Date: 6/17/2025 3:33:14 PM ******/
ALTER TABLE [dbo].[servicios] ADD UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tipos_em__72AFBCC6A2702B48]    Script Date: 6/17/2025 3:33:14 PM ******/
ALTER TABLE [dbo].[tipos_empleados] ADD UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__usuarios__72AFBCC61AB96F5E]    Script Date: 6/17/2025 3:33:14 PM ******/
ALTER TABLE [dbo].[usuarios] ADD UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[empleados] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[pacientes] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[servicios] ADD  DEFAULT ((0)) FOR [costo]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD FOREIGN KEY([creado_por])
REFERENCES [dbo].[empleados] ([run])
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD FOREIGN KEY([dentista_id])
REFERENCES [dbo].[empleados] ([run])
GO
ALTER TABLE [dbo].[citas]  WITH CHECK ADD FOREIGN KEY([run_paciente])
REFERENCES [dbo].[pacientes] ([run])
GO
ALTER TABLE [dbo].[detalle_cita]  WITH CHECK ADD FOREIGN KEY([cita_id])
REFERENCES [dbo].[citas] ([cita_id])
GO
ALTER TABLE [dbo].[detalle_cita]  WITH CHECK ADD FOREIGN KEY([servicio_id])
REFERENCES [dbo].[servicios] ([servicio_id])
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([tipo_empleado_id])
REFERENCES [dbo].[tipos_empleados] ([tipo_id])
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD FOREIGN KEY([cita_id])
REFERENCES [dbo].[citas] ([cita_id])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([empleado_run])
REFERENCES [dbo].[empleados] ([run])
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD CHECK  (([estado_pago]='Reembolso' OR [estado_pago]='Pendiente' OR [estado_pago]='Pagado'))
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD CHECK  (([metodo_pago]='Transferencia' OR [metodo_pago]='Tarjeta de Credito' OR [metodo_pago]='Efectivo'))
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD CHECK  (([monto]>(0)))
GO
ALTER TABLE [dbo].[servicios]  WITH CHECK ADD CHECK  (([costo]>(0)))
GO
USE [master]
GO
ALTER DATABASE [clinicaDentalDB] SET  READ_WRITE 
GO
