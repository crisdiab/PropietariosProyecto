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

Date: 2017-02-05 07:08:57
*/


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
-- Indexes structure for table PARAMETROS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PARAMETROS
-- ----------------------------
ALTER TABLE [dbo].[PARAMETROS] ADD PRIMARY KEY ([IDPARAMETROS])
GO
