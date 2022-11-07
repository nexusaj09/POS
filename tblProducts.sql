USE [POS]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 11/8/2022 7:52:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductCode] [nvarchar](50) NOT NULL,
	[Barcode] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[BrandName] [nvarchar](50) NULL,
	[GenericName] [nvarchar](50) NULL,
	[Classification] [nvarchar](50) NULL,
	[Formulation] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[UOM] [nvarchar](50) NULL,
	[ReOrderQty] [int] NULL,
	[Qty] [int] NULL,
	[SupplierPrice] [decimal](19, 2) NULL,
	[FinalPrice] [decimal](19, 2) NULL,
	[SRP] [decimal](19, 2) NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
	[MarkUp] [int] NULL,
	[CreatedByID] [int] NOT NULL,
	[LastModifiedByID] [int] NOT NULL,
 CONSTRAINT [PK_Products_1] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Qty]  DEFAULT ((0)) FOR [Qty]
GO


