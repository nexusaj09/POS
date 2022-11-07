USE [POS]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 11/8/2022 7:50:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[LastModifiedByID] [int] NOT NULL
) ON [PRIMARY]
GO


