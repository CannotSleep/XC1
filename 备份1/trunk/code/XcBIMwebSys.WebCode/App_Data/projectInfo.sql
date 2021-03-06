USE [XcBIMwebSys]
GO
/****** Object:  Table [dbo].[ProjectInfo]    Script Date: 2018/5/3 15:58:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProjectInfo](
	[ID] [uniqueidentifier] NOT NULL,
	[ProjectName] [varchar](50) NULL,
	[ProjectType] [int] NULL,
	[AccountID] [uniqueidentifier] NULL,
	[ProjectAddress] [varchar](50) NULL,
	[ProjectSbeummary] [varchar](max) NULL,
	[StartTime] [date] NULL,
	[EndTime] [date] NULL,
	[CreateTime] [datetime] NULL,
	[Remarks] [varchar](500) NULL,
 CONSTRAINT [PK_ProjectInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'ProjectName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目类型 （枚举类型）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'ProjectType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'负责人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'AccountID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'ProjectAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'ProjectSbeummary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目开始日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProjectInfo', @level2type=N'COLUMN',@level2name=N'Remarks'
GO
