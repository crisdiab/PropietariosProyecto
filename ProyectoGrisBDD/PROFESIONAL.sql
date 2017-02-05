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

Date: 2017-02-04 18:58:40
*/


-- ----------------------------
-- Table structure for PROFESIONAL
-- ----------------------------
DROP TABLE [dbo].[PROFESIONAL]
GO
CREATE TABLE [dbo].[PROFESIONAL] (
[IDPROFESIONAL] int NOT NULL IDENTITY(1,1) ,
[NOMBREPROFESIONAL] char(100) NULL ,
[CEDULAPROFESIONAL] char(50) NULL ,
[TITULOPROFESIONAL] char(50) NULL ,
[TELEFONOPROFESIONAL] char(50) NULL ,
[ESTADOPROFESIONAL] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[PROFESIONAL]', RESEED, 3)
GO

-- ----------------------------
-- Records of PROFESIONAL
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PROFESIONAL] ON
GO
INSERT INTO [dbo].[PROFESIONAL] ([IDPROFESIONAL], [NOMBREPROFESIONAL], [CEDULAPROFESIONAL], [TITULOPROFESIONAL], [TELEFONOPROFESIONAL], [ESTADOPROFESIONAL]) VALUES (N'1', N'Maria Alejandra Yanez Heredia                                                                       ', N'1724979214                                        ', N'Psicologa Clinica                                 ', N'0992880665                                        ', N'Activo')
GO
GO
INSERT INTO [dbo].[PROFESIONAL] ([IDPROFESIONAL], [NOMBREPROFESIONAL], [CEDULAPROFESIONAL], [TITULOPROFESIONAL], [TELEFONOPROFESIONAL], [ESTADOPROFESIONAL]) VALUES (N'2', N'Marco Vinicio Yanez heredia                                                                         ', N'1233654528                                        ', N'Profesor                                          ', N'0999889446                                        ', N'Activo')
GO
GO
INSERT INTO [dbo].[PROFESIONAL] ([IDPROFESIONAL], [NOMBREPROFESIONAL], [CEDULAPROFESIONAL], [TITULOPROFESIONAL], [TELEFONOPROFESIONAL], [ESTADOPROFESIONAL]) VALUES (N'3', N'Rosa Patricia Yanez Heredia                                                                         ', N'6325846987                                        ', N'Psicologa Infantil                                ', N'0996643272                                        ', N'Activo')
GO
GO
SET IDENTITY_INSERT [dbo].[PROFESIONAL] OFF
GO

-- ----------------------------
-- Indexes structure for table PROFESIONAL
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PROFESIONAL
-- ----------------------------
ALTER TABLE [dbo].[PROFESIONAL] ADD PRIMARY KEY ([IDPROFESIONAL])
GO
