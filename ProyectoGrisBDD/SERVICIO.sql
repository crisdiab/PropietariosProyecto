/*
Navicat SQL Server Data Transfer

Source Server         : LAPTOP-60GQO6T2
Source Server Version : 110000
Source Host           : LAPTOP-60GQO6T2:1433
Source Database       : GrisGris
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2017-02-04 18:27:59
*/


-- ----------------------------
-- Table structure for SERVICIO
-- ----------------------------
DROP TABLE [dbo].[SERVICIO]
GO
CREATE TABLE [dbo].[SERVICIO] (
[IDSERVICIO] int NOT NULL IDENTITY(1,1) ,
[NOMBRESERVICIO] char(100) NULL ,
[PRECIOSERVICIO] float(53) NULL ,
[ESTADOSERVICIO] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[SERVICIO]', RESEED, 19)
GO

-- ----------------------------
-- Records of SERVICIO
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SERVICIO] ON
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'1', N'Tareas Dirigidas                                                                                    ', N'65', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'2', N'Nivelacion Escuela                                                                                  ', N'8', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'3', N'Nivelacion Basico                                                                                   ', N'10', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'4', N'Nivelacion Bachillerato                                                                             ', N'12', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'5', N'Terapia Atencional                                                                                  ', N'8', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'6', N'Terapia Motricidad                                                                                  ', N'8', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'7', N'Terapia Lenguaje                                                                                    ', N'8', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'8', N'Terapia Conductual                                                                                  ', N'11', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'9', N'Terapia Hiperactividad                                                                              ', N'8', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'10', N'Terapia Emocional                                                                                   ', N'10', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'11', N'Terapia Adulto(individual)                                                                          ', N'11', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'12', N'Terapia de Pareja                                                                                   ', N'17', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'13', N'Terapia Familiar                                                                                    ', N'20', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'14', N'Evaluacion Completa                                                                                 ', N'65', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'15', N'Evaluacion de Lenguaje                                                                              ', N'45', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'16', N'Evaluacion Estimulacion Temprana                                                                    ', N'45', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'17', N'Evaluaciones para Adulto                                                                            ', N'85', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'18', N'Servicios Adicionales Almuerzos                                                                     ', N'2', N'Activo')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'19', N'Programa conductual                                                                                 ', N'1000', N'Inactivo')
GO
GO
SET IDENTITY_INSERT [dbo].[SERVICIO] OFF
GO

-- ----------------------------
-- Indexes structure for table SERVICIO
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SERVICIO
-- ----------------------------
ALTER TABLE [dbo].[SERVICIO] ADD PRIMARY KEY ([IDSERVICIO])
GO
