USE [POS]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 11/8/2022 7:51:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RefNbr] [nvarchar](50) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[SupplierContact] [nvarchar](50) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[TotalAmt] [decimal](18, 2) NOT NULL,
	[TotalQty] [int] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedByID] [int] NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[RefNbr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_TotalQty]  DEFAULT ((0)) FOR [TotalQty]
GO


