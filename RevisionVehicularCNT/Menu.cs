using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionVehicularCNT
{
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            basededatos.leerconexion();
            MenuUss men = new MenuUss();
            men.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String StExBD;
            basededatos.leerconexion();
            StExBD = basededatos.ConsultarBD("CNTRevision");
            if (StExBD.Equals("0"))
            {
                string cadenainicio = "CREATE DATABASE [CNTRevision] ON  PRIMARY  ( NAME = N'CNTRevision', FILENAME = N'C:\\cnt\\CNTRevision.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )  LOG ON  ( NAME = N'CNTRevision_log', FILENAME = N'C:\\cnt\\CNTRevision_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB ) IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled')) begin EXEC [CNTRevision].[dbo].[sp_fulltext_database] @action = 'enable' end ALTER DATABASE [CNTRevision] SET ANSI_NULL_DEFAULT OFF  ALTER DATABASE [CNTRevision] SET ANSI_NULLS OFF  ALTER DATABASE [CNTRevision] SET ANSI_PADDING OFF  ALTER DATABASE [CNTRevision] SET ANSI_WARNINGS OFF  ALTER DATABASE [CNTRevision] SET ARITHABORT OFF  ALTER DATABASE [CNTRevision] SET AUTO_CLOSE OFF  ALTER DATABASE [CNTRevision] SET AUTO_SHRINK OFF  ALTER DATABASE [CNTRevision] SET AUTO_UPDATE_STATISTICS ON  ALTER DATABASE [CNTRevision] SET CURSOR_CLOSE_ON_COMMIT OFF  ALTER DATABASE [CNTRevision] SET CURSOR_DEFAULT  GLOBAL  ALTER DATABASE [CNTRevision] SET CONCAT_NULL_YIELDS_NULL OFF  ALTER DATABASE [CNTRevision] SET NUMERIC_ROUNDABORT OFF  ALTER DATABASE [CNTRevision] SET QUOTED_IDENTIFIER OFF  ALTER DATABASE [CNTRevision] SET RECURSIVE_TRIGGERS OFF  ALTER DATABASE [CNTRevision] SET  DISABLE_BROKER  ALTER DATABASE [CNTRevision] SET AUTO_UPDATE_STATISTICS_ASYNC OFF  ALTER DATABASE [CNTRevision] SET DATE_CORRELATION_OPTIMIZATION OFF  ALTER DATABASE [CNTRevision] SET TRUSTWORTHY OFF  ALTER DATABASE [CNTRevision] SET ALLOW_SNAPSHOT_ISOLATION OFF  ALTER DATABASE [CNTRevision] SET PARAMETERIZATION SIMPLE  ALTER DATABASE [CNTRevision] SET READ_COMMITTED_SNAPSHOT OFF  ALTER DATABASE [CNTRevision] SET HONOR_BROKER_PRIORITY OFF  ALTER DATABASE [CNTRevision] SET RECOVERY FULL  ALTER DATABASE [CNTRevision] SET  MULTI_USER  ALTER DATABASE [CNTRevision] SET PAGE_VERIFY CHECKSUM   ALTER DATABASE [CNTRevision] SET DB_CHAINING OFF  EXEC sys.sp_db_vardecimal_storage_format N'CNTRevision', N'ON'";
                String creartablas = "USE [CNTRevision] SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Inspeccion]( 	[Id] [int] IDENTITY(1,1) NOT NULL, 	[RevisionId] [int] NULL, 	[TipoInspeccion] [nvarchar](30) NULL, 	[Observaciones] [nvarchar](1000) NULL, 	[Estado] [int] NULL, 	[PersonaId] [int] NULL,  CONSTRAINT [PK_Inspeccion] PRIMARY KEY CLUSTERED  ( 	[Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Persona]( 	[Id] [int] IDENTITY(1,1) NOT NULL, 	[Identifacion] [nvarchar](16) NULL, 	[Nombre] [nvarchar](50) NULL, 	[Apellido] [nvarchar](50) NULL,  CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED  ( 	[Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Revision]( 	[Id] [int] IDENTITY(1,1) NOT NULL, 	[VehiculoId] [int] NULL, 	[Aprobado] [int] NULL, 	[Observaciones] [nvarchar](1000) NULL, 	[PersonaId] [int] NULL, 	[Fecha_revision] [datetime] NULL,  CONSTRAINT [PK_Revision] PRIMARY KEY CLUSTERED  ( 	[Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Tipo_Revision]( 	[Id] [int] IDENTITY(1,1) NOT NULL, 	[Nombre_tipo] [nvarchar](50) NULL,  CONSTRAINT [PK_Tipo_Revision] PRIMARY KEY CLUSTERED  ( 	[Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET ANSI_NULLS ON SET QUOTED_IDENTIFIER ON CREATE TABLE [dbo].[Vehiculo]( 	[Id] [int] IDENTITY(1,1) NOT NULL, 	[Marca] [nvarchar](50) NULL, 	[Modelo] [nvarchar](50) NULL, 	[Patente] [nvarchar](50) NULL, 	[Año] [int] NULL, 	[PersonaId] [int] NULL,  CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED  ( 	[Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] SET IDENTITY_INSERT [dbo].[Tipo_Revision] ON  INSERT [dbo].[Tipo_Revision] ([Id], [Nombre_tipo]) VALUES (1, N'Inspección frenos') INSERT [dbo].[Tipo_Revision] ([Id], [Nombre_tipo]) VALUES (2, N'Inspección gases') INSERT [dbo].[Tipo_Revision] ([Id], [Nombre_tipo]) VALUES (3, N'Inspeccion luces') SET IDENTITY_INSERT [dbo].[Tipo_Revision] OFF USE [master] ALTER DATABASE [CNTRevision] SET  READ_WRITE ";
                using (var connection = new SqlConnection(basededatos.ConexionSQLMaster))
                {
                    connection.Open();
                    SqlCommand comando = new SqlCommand(String.Format(cadenainicio), connection);
                    comando.ExecuteNonQuery();
                    SqlCommand comando2 = new SqlCommand(String.Format(creartablas), connection);
                    comando2.ExecuteNonQuery();
                }
                try
                {
                    Process Pross = new Process();

                    Pross.StartInfo.FileName = "sqlcmd";
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "persona1.txt";
                    Pross.Start();
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "persona2.txt";
                    Pross.Start();
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "revision1.txt";
                    Pross.Start();
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "revision2.txt";
                    Pross.Start();
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "vehiculo1.txt";
                    Pross.Start();
                    Pross.StartInfo.Arguments = " -S " + "." + " -i " + "vehiculo2.txt";
                    Pross.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("La base de datos CNTRevision fure creada con exito", "Iniciación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La base de datos CNTRevision ya existe en el servidor especificado en conexion.txt", "Error iniciando Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
