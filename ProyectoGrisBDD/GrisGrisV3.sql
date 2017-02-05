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

Date: 2017-02-05 08:50:02
*/


-- ----------------------------
-- Table structure for CENTROEDUCACION
-- ----------------------------
DROP TABLE [dbo].[CENTROEDUCACION]
GO
CREATE TABLE [dbo].[CENTROEDUCACION] (
[IDCENTROEDUCACION] int NOT NULL IDENTITY(1,1) ,
[IDCENTRO] int NULL ,
[NOMBRECENTRO] char(100) NULL 
)


GO

-- ----------------------------
-- Records of CENTROEDUCACION
-- ----------------------------
SET IDENTITY_INSERT [dbo].[CENTROEDUCACION] ON
GO
SET IDENTITY_INSERT [dbo].[CENTROEDUCACION] OFF
GO

-- ----------------------------
-- Table structure for DETALLEFACTURA
-- ----------------------------
DROP TABLE [dbo].[DETALLEFACTURA]
GO
CREATE TABLE [dbo].[DETALLEFACTURA] (
[IDDETALLEFACTURA] int NOT NULL IDENTITY(1,1) ,
[IDSERVICIO] int NULL ,
[IDFACTURA] int NULL ,
[CANTIDADPRODUCTO] int NULL ,
[PRECIOUNITARIO] float(53) NULL ,
[TOTALPRODUCTO] float(53) NULL 
)


GO

-- ----------------------------
-- Records of DETALLEFACTURA
-- ----------------------------
SET IDENTITY_INSERT [dbo].[DETALLEFACTURA] ON
GO
SET IDENTITY_INSERT [dbo].[DETALLEFACTURA] OFF
GO

-- ----------------------------
-- Table structure for DETALLERECIBO
-- ----------------------------
DROP TABLE [dbo].[DETALLERECIBO]
GO
CREATE TABLE [dbo].[DETALLERECIBO] (
[IDDETALLERECIBO] int NOT NULL IDENTITY(1,1) ,
[IDRECIBO] int NULL ,
[IDSERVICIO] int NULL ,
[CANTIDAD] int NULL ,
[PRECIOUNITARIO] float(53) NULL ,
[TOTAL] float(53) NULL 
)


GO

-- ----------------------------
-- Records of DETALLERECIBO
-- ----------------------------
SET IDENTITY_INSERT [dbo].[DETALLERECIBO] ON
GO
SET IDENTITY_INSERT [dbo].[DETALLERECIBO] OFF
GO

-- ----------------------------
-- Table structure for FACTURA
-- ----------------------------
DROP TABLE [dbo].[FACTURA]
GO
CREATE TABLE [dbo].[FACTURA] (
[IDFACTURA] int NOT NULL IDENTITY(1,1) ,
[IDREPRESENTANTE] int NULL ,
[NUMEROFACTURA] char(50) NULL ,
[FECHAFACTURA] char(50) NULL ,
[SUBTOTALFACTURA] float(53) NULL ,
[VALORIVA] float(53) NULL ,
[TOTALFACTURA] float(53) NULL ,
[ESTADOFACTURA] char(20) NULL 
)


GO

-- ----------------------------
-- Records of FACTURA
-- ----------------------------
SET IDENTITY_INSERT [dbo].[FACTURA] ON
GO
SET IDENTITY_INSERT [dbo].[FACTURA] OFF
GO

-- ----------------------------
-- Table structure for PACIENTE
-- ----------------------------
DROP TABLE [dbo].[PACIENTE]
GO
CREATE TABLE [dbo].[PACIENTE] (
[IDPACIENTE] int NOT NULL IDENTITY(1,1) ,
[IDREPRESENTANTE] int NULL ,
[IDCENTROEDUCACION] int NULL ,
[NOMBREPACIENTE] char(100) NULL ,
[CEDULAPACIENTE] char(50) NULL ,
[EDADPACIENTE] char(10) NULL ,
[ENCARGADODECE] char(100) NULL ,
[NOMBREREFERENCIA1] char(100) NULL ,
[TELEFONOREFERENCIA1] char(50) NULL ,
[NOMBREREFERENCIA2] char(100) NULL ,
[TELEFONOREFERENCIA2] char(50) NULL ,
[ESTADOPACIENTE] char(20) NULL ,
[FECHANACIMIENTOPACIENTE] datetime NULL 
)


GO

-- ----------------------------
-- Records of PACIENTE
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PACIENTE] ON
GO
SET IDENTITY_INSERT [dbo].[PACIENTE] OFF
GO

-- ----------------------------
-- Table structure for PACIENTESXPROFESIONAL
-- ----------------------------
DROP TABLE [dbo].[PACIENTESXPROFESIONAL]
GO
CREATE TABLE [dbo].[PACIENTESXPROFESIONAL] (
[IDPACXPROF] int NOT NULL IDENTITY(1,1) ,
[IDPROFESIONAL] int NULL ,
[IDPACIENTE] int NULL 
)


GO

-- ----------------------------
-- Records of PACIENTESXPROFESIONAL
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PACIENTESXPROFESIONAL] ON
GO
SET IDENTITY_INSERT [dbo].[PACIENTESXPROFESIONAL] OFF
GO

-- ----------------------------
-- Table structure for PARAMETROS
-- ----------------------------
DROP TABLE [dbo].[PARAMETROS]
GO
CREATE TABLE [dbo].[PARAMETROS] (
[IDPARAMETROS] int NOT NULL IDENTITY(1,1) ,
[VALORIVA] int NULL ,
[NUMEROFACTURA] int NULL ,
[USUARIO] char(100) NULL ,
[CONTRASENIA] char(100) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[PARAMETROS]', RESEED, 2)
GO

-- ----------------------------
-- Records of PARAMETROS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PARAMETROS] ON
GO
INSERT INTO [dbo].[PARAMETROS] ([IDPARAMETROS], [VALORIVA], [NUMEROFACTURA], [USUARIO], [CONTRASENIA]) VALUES (N'1', null, null, N'admin                                                                                               ', N'Admin123                                                                                            ')
GO
GO
INSERT INTO [dbo].[PARAMETROS] ([IDPARAMETROS], [VALORIVA], [NUMEROFACTURA], [USUARIO], [CONTRASENIA]) VALUES (N'2', N'1', N'12', N'default                                                                                             ', N'1234                                                                                                ')
GO
GO
SET IDENTITY_INSERT [dbo].[PARAMETROS] OFF
GO

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
-- Table structure for RECIBO
-- ----------------------------
DROP TABLE [dbo].[RECIBO]
GO
CREATE TABLE [dbo].[RECIBO] (
[IDRECIBO] int NOT NULL IDENTITY(1,1) ,
[IDREPRESENTANTE] int NULL ,
[NUMERORECIBO] char(50) NULL ,
[FECHARECIBO] datetime NULL ,
[TOTALRECIBO] float(53) NULL ,
[ESTADORECIBO] char(20) NULL 
)


GO

-- ----------------------------
-- Records of RECIBO
-- ----------------------------
SET IDENTITY_INSERT [dbo].[RECIBO] ON
GO
SET IDENTITY_INSERT [dbo].[RECIBO] OFF
GO

-- ----------------------------
-- Table structure for REPRESENTANTE
-- ----------------------------
DROP TABLE [dbo].[REPRESENTANTE]
GO
CREATE TABLE [dbo].[REPRESENTANTE] (
[IDREPRESENTANTE] int NOT NULL IDENTITY(1,1) ,
[NOMBREREPRESENTANTE] char(100) NULL ,
[CEDULAREPRESENTANTE] char(50) NULL ,
[DIRECCIONREPRESENTANTE] char(100) NULL ,
[TELEFONOREPRESENTANTE] char(50) NULL ,
[ESTADOREPRESENTANTE] char(15) NULL 
)


GO

-- ----------------------------
-- Records of REPRESENTANTE
-- ----------------------------
SET IDENTITY_INSERT [dbo].[REPRESENTANTE] ON
GO
SET IDENTITY_INSERT [dbo].[REPRESENTANTE] OFF
GO

-- ----------------------------
-- Table structure for SERVICIO
-- ----------------------------
DROP TABLE [dbo].[SERVICIO]
GO
CREATE TABLE [dbo].[SERVICIO] (
[IDSERVICIO] int NOT NULL IDENTITY(1,1) ,
[NOMBRESERVICIO] char(100) NULL ,
[PRECIOSERVICIO] float(53) NULL ,
[ESTADOSERVICIO] char(20) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[SERVICIO]', RESEED, 19)
GO

-- ----------------------------
-- Records of SERVICIO
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SERVICIO] ON
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'1', N'Tareas Dirigidas                                                                                    ', N'65', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'2', N'Nivelacion Escuela                                                                                  ', N'8', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'3', N'Nivelacion Basico                                                                                   ', N'10', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'4', N'Nivelacion Bachillerato                                                                             ', N'12', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'5', N'Terapia Atencional                                                                                  ', N'8', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'6', N'Terapia Motricidad                                                                                  ', N'8', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'7', N'Terapia Lenguaje                                                                                    ', N'8', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'8', N'Terapia Conductual                                                                                  ', N'11', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'9', N'Terapia Hiperactividad                                                                              ', N'8', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'10', N'Terapia Emocional                                                                                   ', N'10', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'11', N'Terapia Adulto(individual)                                                                          ', N'11', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'12', N'Terapia de Pareja                                                                                   ', N'17', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'13', N'Terapia Familiar                                                                                    ', N'20', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'14', N'Evaluacion Completa                                                                                 ', N'65', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'15', N'Evaluacion de Lenguaje                                                                              ', N'45', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'16', N'Evaluacion Estimulacion Temprana                                                                    ', N'45', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'17', N'Evaluaciones para Adulto                                                                            ', N'85', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'18', N'Servicios Adicionales Almuerzos                                                                     ', N'2', N'Activo              ')
GO
GO
INSERT INTO [dbo].[SERVICIO] ([IDSERVICIO], [NOMBRESERVICIO], [PRECIOSERVICIO], [ESTADOSERVICIO]) VALUES (N'19', N'Programa conductual                                                                                 ', N'1000', N'Inactivo            ')
GO
GO
SET IDENTITY_INSERT [dbo].[SERVICIO] OFF
GO

-- ----------------------------
-- Table structure for SERVICIOSPORPROFESIONAL
-- ----------------------------
DROP TABLE [dbo].[SERVICIOSPORPROFESIONAL]
GO
CREATE TABLE [dbo].[SERVICIOSPORPROFESIONAL] (
[IDSERXPROFESIONAL] int NOT NULL IDENTITY(1,1) ,
[IDPROFESIONAL] int NULL ,
[IDSERVICIO] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[SERVICIOSPORPROFESIONAL]', RESEED, 23)
GO

-- ----------------------------
-- Records of SERVICIOSPORPROFESIONAL
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SERVICIOSPORPROFESIONAL] ON
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'2', N'1', N'3')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'3', N'1', N'4')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'4', N'1', N'8')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'5', N'1', N'10')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'6', N'1', N'11')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'7', N'1', N'12')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'8', N'1', N'13')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'9', N'1', N'14')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'10', N'1', N'17')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'11', N'2', N'1')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'12', N'2', N'3')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'13', N'2', N'4')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'14', N'3', N'1')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'15', N'3', N'2')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'16', N'3', N'5')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'17', N'3', N'6')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'18', N'3', N'7')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'19', N'3', N'8')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'20', N'3', N'9')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'21', N'3', N'10')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'22', N'3', N'15')
GO
GO
INSERT INTO [dbo].[SERVICIOSPORPROFESIONAL] ([IDSERXPROFESIONAL], [IDPROFESIONAL], [IDSERVICIO]) VALUES (N'23', N'3', N'16')
GO
GO
SET IDENTITY_INSERT [dbo].[SERVICIOSPORPROFESIONAL] OFF
GO

-- ----------------------------
-- Table structure for SERVICIOSXPACIENTE
-- ----------------------------
DROP TABLE [dbo].[SERVICIOSXPACIENTE]
GO
CREATE TABLE [dbo].[SERVICIOSXPACIENTE] (
[IDSERVICIOSXPACIENTE] int NOT NULL IDENTITY(1,1) ,
[IDPACIENTE] int NULL ,
[IDSERVICIO] int NULL 
)


GO

-- ----------------------------
-- Records of SERVICIOSXPACIENTE
-- ----------------------------
SET IDENTITY_INSERT [dbo].[SERVICIOSXPACIENTE] ON
GO
SET IDENTITY_INSERT [dbo].[SERVICIOSXPACIENTE] OFF
GO

-- ----------------------------
-- Table structure for TIPOCENTROEDUCACION
-- ----------------------------
DROP TABLE [dbo].[TIPOCENTROEDUCACION]
GO
CREATE TABLE [dbo].[TIPOCENTROEDUCACION] (
[IDCENTRO] int NOT NULL IDENTITY(1,1) ,
[NOMBRETIPOCENTRO] char(50) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[TIPOCENTROEDUCACION]', RESEED, 4)
GO

-- ----------------------------
-- Records of TIPOCENTROEDUCACION
-- ----------------------------
SET IDENTITY_INSERT [dbo].[TIPOCENTROEDUCACION] ON
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'1', N'Inicial                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'2', N'Escuela                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'3', N'Colegio                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'4', N'Universidad                                       ')
GO
GO
SET IDENTITY_INSERT [dbo].[TIPOCENTROEDUCACION] OFF
GO

-- ----------------------------
-- Indexes structure for table CENTROEDUCACION
-- ----------------------------
CREATE INDEX [RELATIONSHIP_1_FK] ON [dbo].[CENTROEDUCACION]
([IDCENTRO] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table CENTROEDUCACION
-- ----------------------------
ALTER TABLE [dbo].[CENTROEDUCACION] ADD PRIMARY KEY ([IDCENTROEDUCACION])
GO

-- ----------------------------
-- Indexes structure for table DETALLEFACTURA
-- ----------------------------
CREATE INDEX [RELATIONSHIP_5_FK] ON [dbo].[DETALLEFACTURA]
([IDFACTURA] ASC) 
GO
CREATE INDEX [RELATIONSHIP_6_FK] ON [dbo].[DETALLEFACTURA]
([IDSERVICIO] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table DETALLEFACTURA
-- ----------------------------
ALTER TABLE [dbo].[DETALLEFACTURA] ADD PRIMARY KEY ([IDDETALLEFACTURA])
GO

-- ----------------------------
-- Indexes structure for table DETALLERECIBO
-- ----------------------------
CREATE INDEX [RELATIONSHIP_12_FK] ON [dbo].[DETALLERECIBO]
([IDRECIBO] ASC) 
GO
CREATE INDEX [RELATIONSHIP_13_FK] ON [dbo].[DETALLERECIBO]
([IDSERVICIO] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table DETALLERECIBO
-- ----------------------------
ALTER TABLE [dbo].[DETALLERECIBO] ADD PRIMARY KEY ([IDDETALLERECIBO])
GO

-- ----------------------------
-- Indexes structure for table FACTURA
-- ----------------------------
CREATE INDEX [RELATIONSHIP_4_FK] ON [dbo].[FACTURA]
([IDREPRESENTANTE] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table FACTURA
-- ----------------------------
ALTER TABLE [dbo].[FACTURA] ADD PRIMARY KEY ([IDFACTURA])
GO

-- ----------------------------
-- Indexes structure for table PACIENTE
-- ----------------------------
CREATE INDEX [RELATIONSHIP_2_FK] ON [dbo].[PACIENTE]
([IDCENTROEDUCACION] ASC) 
GO
CREATE INDEX [RELATIONSHIP_3_FK] ON [dbo].[PACIENTE]
([IDREPRESENTANTE] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table PACIENTE
-- ----------------------------
ALTER TABLE [dbo].[PACIENTE] ADD PRIMARY KEY ([IDPACIENTE])
GO

-- ----------------------------
-- Indexes structure for table PACIENTESXPROFESIONAL
-- ----------------------------
CREATE INDEX [RELATIONSHIP_16_FK] ON [dbo].[PACIENTESXPROFESIONAL]
([IDPACIENTE] ASC) 
GO
CREATE INDEX [RELATIONSHIP_17_FK] ON [dbo].[PACIENTESXPROFESIONAL]
([IDPROFESIONAL] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table PACIENTESXPROFESIONAL
-- ----------------------------
ALTER TABLE [dbo].[PACIENTESXPROFESIONAL] ADD PRIMARY KEY NONCLUSTERED ([IDPACXPROF])
GO

-- ----------------------------
-- Indexes structure for table PARAMETROS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PARAMETROS
-- ----------------------------
ALTER TABLE [dbo].[PARAMETROS] ADD PRIMARY KEY ([IDPARAMETROS])
GO

-- ----------------------------
-- Indexes structure for table PROFESIONAL
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PROFESIONAL
-- ----------------------------
ALTER TABLE [dbo].[PROFESIONAL] ADD PRIMARY KEY ([IDPROFESIONAL])
GO

-- ----------------------------
-- Indexes structure for table RECIBO
-- ----------------------------
CREATE INDEX [RELATIONSHIP_11_FK] ON [dbo].[RECIBO]
([IDREPRESENTANTE] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table RECIBO
-- ----------------------------
ALTER TABLE [dbo].[RECIBO] ADD PRIMARY KEY ([IDRECIBO])
GO

-- ----------------------------
-- Indexes structure for table REPRESENTANTE
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table REPRESENTANTE
-- ----------------------------
ALTER TABLE [dbo].[REPRESENTANTE] ADD PRIMARY KEY ([IDREPRESENTANTE])
GO

-- ----------------------------
-- Indexes structure for table SERVICIO
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SERVICIO
-- ----------------------------
ALTER TABLE [dbo].[SERVICIO] ADD PRIMARY KEY ([IDSERVICIO])
GO

-- ----------------------------
-- Indexes structure for table SERVICIOSPORPROFESIONAL
-- ----------------------------
CREATE INDEX [RELACIONSERVICIOPORPROFESIONAL_FK] ON [dbo].[SERVICIOSPORPROFESIONAL]
([IDSERVICIO] ASC) 
GO
CREATE INDEX [OTRARELACION_FK] ON [dbo].[SERVICIOSPORPROFESIONAL]
([IDPROFESIONAL] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table SERVICIOSPORPROFESIONAL
-- ----------------------------
ALTER TABLE [dbo].[SERVICIOSPORPROFESIONAL] ADD PRIMARY KEY ([IDSERXPROFESIONAL])
GO

-- ----------------------------
-- Indexes structure for table SERVICIOSXPACIENTE
-- ----------------------------
CREATE INDEX [RELATIONSHIP_14_FK] ON [dbo].[SERVICIOSXPACIENTE]
([IDSERVICIO] ASC) 
GO
CREATE INDEX [RELATIONSHIP_15_FK] ON [dbo].[SERVICIOSXPACIENTE]
([IDPACIENTE] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table SERVICIOSXPACIENTE
-- ----------------------------
ALTER TABLE [dbo].[SERVICIOSXPACIENTE] ADD PRIMARY KEY ([IDSERVICIOSXPACIENTE])
GO

-- ----------------------------
-- Indexes structure for table TIPOCENTROEDUCACION
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TIPOCENTROEDUCACION
-- ----------------------------
ALTER TABLE [dbo].[TIPOCENTROEDUCACION] ADD PRIMARY KEY ([IDCENTRO])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[CENTROEDUCACION]
-- ----------------------------
ALTER TABLE [dbo].[CENTROEDUCACION] ADD FOREIGN KEY ([IDCENTRO]) REFERENCES [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[DETALLEFACTURA]
-- ----------------------------
ALTER TABLE [dbo].[DETALLEFACTURA] ADD FOREIGN KEY ([IDFACTURA]) REFERENCES [dbo].[FACTURA] ([IDFACTURA]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[DETALLEFACTURA] ADD FOREIGN KEY ([IDSERVICIO]) REFERENCES [dbo].[SERVICIO] ([IDSERVICIO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[DETALLERECIBO]
-- ----------------------------
ALTER TABLE [dbo].[DETALLERECIBO] ADD FOREIGN KEY ([IDRECIBO]) REFERENCES [dbo].[RECIBO] ([IDRECIBO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[DETALLERECIBO] ADD FOREIGN KEY ([IDSERVICIO]) REFERENCES [dbo].[SERVICIO] ([IDSERVICIO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[FACTURA]
-- ----------------------------
ALTER TABLE [dbo].[FACTURA] ADD FOREIGN KEY ([IDREPRESENTANTE]) REFERENCES [dbo].[REPRESENTANTE] ([IDREPRESENTANTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[PACIENTE]
-- ----------------------------
ALTER TABLE [dbo].[PACIENTE] ADD FOREIGN KEY ([IDCENTROEDUCACION]) REFERENCES [dbo].[CENTROEDUCACION] ([IDCENTROEDUCACION]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[PACIENTE] ADD FOREIGN KEY ([IDREPRESENTANTE]) REFERENCES [dbo].[REPRESENTANTE] ([IDREPRESENTANTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[PACIENTESXPROFESIONAL]
-- ----------------------------
ALTER TABLE [dbo].[PACIENTESXPROFESIONAL] ADD FOREIGN KEY ([IDPACIENTE]) REFERENCES [dbo].[PACIENTE] ([IDPACIENTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[PACIENTESXPROFESIONAL] ADD FOREIGN KEY ([IDPROFESIONAL]) REFERENCES [dbo].[PROFESIONAL] ([IDPROFESIONAL]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RECIBO]
-- ----------------------------
ALTER TABLE [dbo].[RECIBO] ADD FOREIGN KEY ([IDREPRESENTANTE]) REFERENCES [dbo].[REPRESENTANTE] ([IDREPRESENTANTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[SERVICIOSPORPROFESIONAL]
-- ----------------------------
ALTER TABLE [dbo].[SERVICIOSPORPROFESIONAL] ADD FOREIGN KEY ([IDPROFESIONAL]) REFERENCES [dbo].[PROFESIONAL] ([IDPROFESIONAL]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[SERVICIOSPORPROFESIONAL] ADD FOREIGN KEY ([IDSERVICIO]) REFERENCES [dbo].[SERVICIO] ([IDSERVICIO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[SERVICIOSXPACIENTE]
-- ----------------------------
ALTER TABLE [dbo].[SERVICIOSXPACIENTE] ADD FOREIGN KEY ([IDPACIENTE]) REFERENCES [dbo].[PACIENTE] ([IDPACIENTE]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[SERVICIOSXPACIENTE] ADD FOREIGN KEY ([IDSERVICIO]) REFERENCES [dbo].[SERVICIO] ([IDSERVICIO]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
