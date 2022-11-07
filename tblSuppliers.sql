USE [POS]
GO

/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/8/2022 7:52:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Suppliers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Supplier] [nvarchar](255) NOT NULL,
	[Address] [nvarchar](255) NOT NULL,
	[ContactPerson] [nvarchar](50) NOT NULL,
	[ContactNbr] [nvarchar](50) NULL,
	[EMail] [nvarchar](50) NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
	[CreatedByID] [int] NULL,
	[LastModifiedByID] [int] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


