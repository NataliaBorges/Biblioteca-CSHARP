USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 17/08/2021 19:45:17 ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = OFF
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Emprestimo]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emprestimo](
	[ID_emprestimo] [int] IDENTITY(1,1) NOT NULL,
	[ID_funcionario] [int] NULL,
	[ID_leitor] [int] NULL,
	[Data_emprestimo] [date] NOT NULL,
	[Data_devolucao] [date] NOT NULL,
	[Obs_emprestimo] [varchar](200) NOT NULL,
 CONSTRAINT [PK__Empresti__F6844D720BC50A1B] PRIMARY KEY CLUSTERED 
(
	[ID_emprestimo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[ID_fornecedor] [int] IDENTITY(1,1) NOT NULL,
	[Nome_fornecedor] [varchar](30) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Telefone] [varchar](11) NOT NULL,
	[CNPJ] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Forneced__08215804EAED2608] PRIMARY KEY CLUSTERED 
(
	[ID_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[ID_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [varchar](20) NOT NULL,
	[Data_Nascimento] [date] NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Nome_funcionario] [varchar](100) NOT NULL,
	[Endereco] [varchar](255) NOT NULL,
	[Email] [varchar](255) NULL,
	[Senha] [varchar](255) NULL,
 CONSTRAINT [PK__Funciona__AB248D9B796979CB] PRIMARY KEY CLUSTERED 
(
	[ID_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_emprestimo]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_emprestimo](
	[ID_EM] [int] IDENTITY(1,1) NOT NULL,
	[ID_livro] [int] NULL,
	[ID_emprestimo] [int] NULL,
 CONSTRAINT [PK__Item_emp__8B62DF4997583059] PRIMARY KEY CLUSTERED 
(
	[ID_EM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_reserva]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_reserva](
	[ID_RE] [int] IDENTITY(1,1) NOT NULL,
	[ID_livro] [int] NULL,
	[ID_reserva] [int] NULL,
	[Obs_item] [varchar](200) NULL,
 CONSTRAINT [PK__Item_res__8B6381F10EC9099E] PRIMARY KEY CLUSTERED 
(
	[ID_RE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leitor]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leitor](
	[ID_leitor] [int] IDENTITY(1,1) NOT NULL,
	[Nome_Leitor] [varchar](30) NOT NULL,
	[Data_Nascimento] [date] NOT NULL,
	[Telefone] [varchar](11) NOT NULL,
	[CPF] [varchar](20) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Leitor__928A0536A3257B19] PRIMARY KEY CLUSTERED 
(
	[ID_leitor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livro]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro](
	[ID_livro] [int] IDENTITY(1,1) NOT NULL,
	[ID_fornecedor] [int] NULL,
	[Nome_Livro] [varchar](30) NOT NULL,
	[Autor_Livro] [varchar](30) NOT NULL,
	[Edicao] [varchar](10) NOT NULL,
	[Ano_publicacao] [varchar](4) NOT NULL,
	[Data_aquisicao] [date] NOT NULL,
 CONSTRAINT [PK__Livro__726BCFAE16CDC95C] PRIMARY KEY CLUSTERED 
(
	[ID_livro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 17/08/2021 19:45:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[ID_reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_funcionario] [int] NULL,
	[ID_leitor] [int] NULL,
	[Data_reserva] [date] NOT NULL,
	[Obs_reserva] [varchar](200) NULL,
 CONSTRAINT [PK__Reserva__CD692CB0F99D4738] PRIMARY KEY CLUSTERED 
(
	[ID_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD  CONSTRAINT [FK__Emprestim__ID_fu__3F466844] FOREIGN KEY([ID_funcionario])
REFERENCES [dbo].[Funcionario] ([ID_funcionario])
GO
ALTER TABLE [dbo].[Emprestimo] CHECK CONSTRAINT [FK__Emprestim__ID_fu__3F466844]
GO
ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD  CONSTRAINT [FK__Emprestim__ID_le__403A8C7D] FOREIGN KEY([ID_leitor])
REFERENCES [dbo].[Leitor] ([ID_leitor])
GO
ALTER TABLE [dbo].[Emprestimo] CHECK CONSTRAINT [FK__Emprestim__ID_le__403A8C7D]
GO
ALTER TABLE [dbo].[Item_emprestimo]  WITH CHECK ADD  CONSTRAINT [FK__Item_empr__ID_em__440B1D61] FOREIGN KEY([ID_emprestimo])
REFERENCES [dbo].[Emprestimo] ([ID_emprestimo])
GO
ALTER TABLE [dbo].[Item_emprestimo] CHECK CONSTRAINT [FK__Item_empr__ID_em__440B1D61]
GO
ALTER TABLE [dbo].[Item_emprestimo]  WITH CHECK ADD  CONSTRAINT [FK__Item_empr__ID_li__4316F928] FOREIGN KEY([ID_livro])
REFERENCES [dbo].[Livro] ([ID_livro])
GO
ALTER TABLE [dbo].[Item_emprestimo] CHECK CONSTRAINT [FK__Item_empr__ID_li__4316F928]
GO
ALTER TABLE [dbo].[Item_reserva]  WITH CHECK ADD  CONSTRAINT [FK__Item_rese__ID_li__4AB81AF0] FOREIGN KEY([ID_livro])
REFERENCES [dbo].[Livro] ([ID_livro])
GO
ALTER TABLE [dbo].[Item_reserva] CHECK CONSTRAINT [FK__Item_rese__ID_li__4AB81AF0]
GO
ALTER TABLE [dbo].[Item_reserva]  WITH CHECK ADD  CONSTRAINT [FK__Item_rese__ID_re__4BAC3F29] FOREIGN KEY([ID_reserva])
REFERENCES [dbo].[Reserva] ([ID_reserva])
GO
ALTER TABLE [dbo].[Item_reserva] CHECK CONSTRAINT [FK__Item_rese__ID_re__4BAC3F29]
GO
ALTER TABLE [dbo].[Livro]  WITH CHECK ADD  CONSTRAINT [FK__Livro__ID_fornec__3A81B327] FOREIGN KEY([ID_fornecedor])
REFERENCES [dbo].[Fornecedor] ([ID_fornecedor])
GO
ALTER TABLE [dbo].[Livro] CHECK CONSTRAINT [FK__Livro__ID_fornec__3A81B327]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK__Reserva__ID_func__46E78A0C] FOREIGN KEY([ID_funcionario])
REFERENCES [dbo].[Funcionario] ([ID_funcionario])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK__Reserva__ID_func__46E78A0C]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK__Reserva__ID_leit__47DBAE45] FOREIGN KEY([ID_leitor])
REFERENCES [dbo].[Leitor] ([ID_leitor])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK__Reserva__ID_leit__47DBAE45]
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
