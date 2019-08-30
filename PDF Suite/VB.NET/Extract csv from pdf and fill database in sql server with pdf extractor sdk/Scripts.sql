 
/****** Object:  Table [dbo].[PersonData]    Script Date: 10/18/2018 11:14:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PersonData](
	[id] [varchar](10) NULL,
	[first_name] [varchar](100) NULL,
	[last_name] [varchar](100) NULL,
	[email] [varchar](200) NULL,
	[gender] [varchar](10) NULL,
	[ip_address] [varchar](50) NULL
) ON [PRIMARY]
GO

