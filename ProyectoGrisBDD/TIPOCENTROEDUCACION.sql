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

Date: 2017-02-04 18:57:33
*/


-- ----------------------------
-- Table structure for TIPOCENTROEDUCACION
-- ----------------------------
DROP TABLE [dbo].[TIPOCENTROEDUCACION]
GO
CREATE TABLE [dbo].[TIPOCENTROEDUCACION] (
[IDCENTRO] int NOT NULL ,
[NOMBRETIPOCENTRO] char(50) NULL 
)


GO

-- ----------------------------
-- Records of TIPOCENTROEDUCACION
-- ----------------------------
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'1', N'Escuela                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'2', N'Colegio                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'3', N'Inicial                                           ')
GO
GO
INSERT INTO [dbo].[TIPOCENTROEDUCACION] ([IDCENTRO], [NOMBRETIPOCENTRO]) VALUES (N'4', N'Universidad                                       ')
GO
GO

-- ----------------------------
-- Indexes structure for table TIPOCENTROEDUCACION
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table TIPOCENTROEDUCACION
-- ----------------------------
ALTER TABLE [dbo].[TIPOCENTROEDUCACION] ADD PRIMARY KEY ([IDCENTRO])
GO
