USE [bloodpro]
GO

/****** Object:  Table [dbo].[prod]    Script Date: 25-10-2021 14:39:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[prod](
	[ProductId] [int] NOT NULL,
	[ProductName] [varchar](50) NULL,
	[CategoryId] [int] NULL,
	[CategoryName] [varchar](50) NULL,
 CONSTRAINT [PK_prod] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

