USE [master]
GO
/****** Object:  Database [segurosabc]    Script Date: 13 mar. 2018 19:21:52 ******/
CREATE DATABASE [segurosabc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'segurosabc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\segurosabc.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'segurosabc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\segurosabc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [segurosabc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [segurosabc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [segurosabc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [segurosabc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [segurosabc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [segurosabc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [segurosabc] SET ARITHABORT OFF 
GO
ALTER DATABASE [segurosabc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [segurosabc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [segurosabc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [segurosabc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [segurosabc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [segurosabc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [segurosabc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [segurosabc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [segurosabc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [segurosabc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [segurosabc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [segurosabc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [segurosabc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [segurosabc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [segurosabc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [segurosabc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [segurosabc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [segurosabc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [segurosabc] SET  MULTI_USER 
GO
ALTER DATABASE [segurosabc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [segurosabc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [segurosabc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [segurosabc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [segurosabc] SET DELAYED_DURABILITY = DISABLED 
GO
USE [segurosabc]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 13 mar. 2018 19:21:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[nombre] [varchar](50) NULL,
	[cedula] [varchar](50) NOT NULL,
	[pin] [varchar](50) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pagos]    Script Date: 13 mar. 2018 19:21:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pagos](
	[cedula] [varchar](50) NULL,
	[fecha] [date] NULL,
	[monto] [numeric](18, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_clientes] FOREIGN KEY([cedula])
REFERENCES [dbo].[clientes] ([cedula])
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_clientes]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarPagosClientes]    Script Date: 13 mar. 2018 19:21:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ConsultarPagosClientes]
	-- Add the parameters for the stored procedure here
	@cedula varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		c.nombre,
		c.cedula,
		p.fecha,
		p.monto
	FROM
		clientes c
	INNER JOIN
		pagos p
	ON
		c.cedula = p.cedula
	WHERE
		c.cedula = @cedula;

	set nocount off

END

GO
USE [master]
GO
ALTER DATABASE [segurosabc] SET  READ_WRITE 
GO
