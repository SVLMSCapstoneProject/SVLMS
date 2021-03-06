USE [coopdb]
GO
/****** Object:  Table [dbo].[TimeDepositDays]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeDepositDays](
	[timeDayID] [int] NOT NULL,
	[daysNo] [int] NULL,
 CONSTRAINT [PK_TimeDepositDays] PRIMARY KEY CLUSTERED 
(
	[timeDayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeDepositBracket]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeDepositBracket](
	[timeBracketID] [int] NOT NULL,
	[minimumRange] [money] NULL,
	[maximumRange] [money] NULL,
 CONSTRAINT [PK_TimeDepositBracket] PRIMARY KEY CLUSTERED 
(
	[timeBracketID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeDepositRates]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeDepositRates](
	[timeRateID] [int] NOT NULL,
	[daysNo] [int] NULL,
	[minimumRange] [money] NULL,
	[maximumRange] [money] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_TimeDepositRates] PRIMARY KEY CLUSTERED 
(
	[timeRateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeDepositPenalty]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeDepositPenalty](
	[penaltyID] [int] NOT NULL,
	[percentageElapsedMin] [float] NULL,
	[percentageElapsedMax] [float] NULL,
	[rateAdjustment] [float] NULL,
	[changeDatetime] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_TimeDepositPenalty] PRIMARY KEY CLUSTERED 
(
	[penaltyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTimeDesc]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddTimeDesc]  
 @timeDesc varchar(50),
 @penaltyAmount int,
 @isPercentage int,
 @isRemove int
AS  
BEGIN  
   
 declare @timeDepositID int  
   
 select @timeDepositID = ISNULL(MAX(timeDepositID),0) from TimeDeposit  
 select @timeDepositID = @timeDepositID + 1  
   
 insert into TimeDeposit values (@timeDepositID, @timeDesc, CURRENT_TIMESTAMP, @penaltyAmount, @isPercentage, @isRemove)  
END
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserType](
	[userTypeID] [int] NOT NULL,
	[typeName] [varchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[userTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SavingsType]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SavingsType](
	[savingsTypeID] [int] NOT NULL,
	[interestRate] [money] NULL,
	[isPercentage] [int] NULL,
	[savingsName] [varchar](50) NULL,
	[maintainingBalance] [money] NULL,
	[maxWithdrawAmount] [money] NULL,
	[maxWithdrawDuration] [int] NULL,
	[maxWithdrawTime] [int] NULL,
	[noAccountHolders] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_SavingsType] PRIMARY KEY CLUSTERED 
(
	[savingsTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoanType]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoanType](
	[loanTypeID] [int] NOT NULL,
	[loanName] [varchar](50) NULL,
	[maxAmount] [money] NULL,
	[minAmount] [money] NULL,
	[maxTerm] [int] NULL,
	[loanEntitlement] [money] NULL,
	[isPercentageEntitlement] [int] NULL,
	[hasComaker] [int] NULL,
	[hasCollateral] [int] NULL,
	[loanEligibility] [money] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_LoanType] PRIMARY KEY CLUSTERED 
(
	[loanTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MemberType]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberType](
	[memberTypeID] [int] NOT NULL,
	[memberTypeName] [varchar](50) NULL,
	[minimumNoOfShare] [int] NULL,
	[hasCertificate] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_MemberType] PRIMARY KEY CLUSTERED 
(
	[memberTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Indicator]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Indicator](
	[indicatorID] [int] NOT NULL,
	[daysNo] [int] NULL,
	[indicatorDesc] [varchar](50) NULL,
 CONSTRAINT [PK_Indicator] PRIMARY KEY CLUSTERED 
(
	[indicatorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[func_sample]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_sample] (@money money)
RETURNS MONEY  
AS  
BEGIN  
	return @money
END
GO
/****** Object:  Table [dbo].[CheckInformation]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CheckInformation](
	[checkInfoID] [int] NOT NULL,
	[checkNo] [varchar](50) NOT NULL,
	[bankName] [varchar](50) NULL,
	[dateIssued] [date] NULL,
 CONSTRAINT [PK_CheckInformation] PRIMARY KEY CLUSTERED 
(
	[checkInfoID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Charge]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Charge](
	[chargeID] [int] NOT NULL,
	[chargeName] [varchar](50) NULL,
	[amount] [money] NULL,
	[isPercentage] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_Charge] PRIMARY KEY CLUSTERED 
(
	[chargeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ApplicableLoans]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicableLoans](
	[memberTypeID] [int] NOT NULL,
	[loanTypeID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dormancy]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dormancy](
	[dormancyID] [int] NOT NULL,
	[inactivityDuration] [int] NULL,
	[inactivityTime] [int] NULL,
	[deductionAmount] [money] NULL,
	[isPercentage] [int] NULL,
	[deductionEvery] [int] NULL,
	[deductionTime] [int] NULL,
	[status] [int] NULL,
	[isCurrent] [int] NULL,
	[savingsTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Dormancy] PRIMARY KEY CLUSTERED 
(
	[dormancyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanCharges]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanCharges](
	[loanChargeID] [int] NOT NULL,
	[chargeID] [int] NOT NULL,
	[loanTypeID] [int] NOT NULL,
 CONSTRAINT [PK_LoanCharges] PRIMARY KEY CLUSTERED 
(
	[loanChargeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanRates]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanRates](
	[loanRatesID] [int] NOT NULL,
	[interestRate] [money] NULL,
	[isPercentageInterest] [int] NULL,
	[shareRate] [money] NULL,
	[isPercentageShare] [int] NULL,
	[changeDatetime] [datetime] NULL,
	[isCurrent] [int] NULL,
	[effectivityDate] [date] NULL,
	[status] [int] NULL,
	[loanTypeID] [int] NULL,
 CONSTRAINT [PK_LoanRates] PRIMARY KEY CLUSTERED 
(
	[loanRatesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanPenaltySettings]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanPenaltySettings](
	[penaltyID] [int] NOT NULL,
	[penaltyAmount] [money] NULL,
	[duration] [int] NULL,
	[changeDatetime] [datetime] NULL,
	[gracePeriod] [int] NULL,
	[graceTime] [int] NULL,
	[durationTime] [int] NULL,
	[status] [int] NULL,
	[isCurrent] [int] NULL,
	[isPercentage] [int] NULL,
	[isChargeToAmortization] [int] NULL,
	[isChargeToCurrent] [int] NULL,
	[effectivityDate] [date] NULL,
	[loanTypeID] [int] NOT NULL,
 CONSTRAINT [PK_LoanPenaltyHistory] PRIMARY KEY CLUSTERED 
(
	[penaltyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[accountNo] [char](7) NOT NULL,
	[LName] [varchar](50) NULL,
	[FName] [varchar](50) NULL,
	[MName] [varchar](50) NULL,
	[memberBlkNoAddress] [varchar](50) NULL,
	[memberStreetAddress] [varchar](50) NULL,
	[memberBrgyAddress] [varchar](50) NULL,
	[memberCityAddress] [varchar](50) NULL,
	[membershipDate] [date] NULL,
	[birthDate] [date] NULL,
	[gender] [char](1) NULL,
	[telNo] [char](8) NULL,
	[mobileNo] [char](11) NULL,
	[emailAdd] [varchar](50) NULL,
	[passportNo] [char](9) NULL,
	[driverLicenseNo] [char](10) NULL,
	[sssNo] [char](10) NULL,
	[civilStatus] [varchar](20) NULL,
	[educationalAttainment] [varchar](20) NULL,
	[isTerminated] [int] NULL,
	[terminationDate] [date] NULL,
	[terminationReason] [varchar](50) NULL,
	[remarks] [varchar](50) NULL,
	[picture] [varchar](200) NULL,
	[memberTypeID] [int] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[accountNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SavingsAccount]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SavingsAccount](
	[savingsAccountNo] [char](10) NOT NULL,
	[openingDatetime] [datetime] NULL,
	[currentBalance] [money] NULL,
	[isClosed] [int] NULL,
	[closingDatetime] [datetime] NULL,
	[savingsTypeID] [int] NULL,
 CONSTRAINT [PK_SavingsAccount] PRIMARY KEY CLUSTERED 
(
	[savingsAccountNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_TimeDepositPenaltyInfoDisplay]    Script Date: 07/06/2014 23:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_TimeDepositPenaltyInfoDisplay]    
as    
select penaltyID as PenaltyID, percentageElapsedMin as Minimum, percentageElapsedMax as Maximum, rateAdjustment as 'Rate Adjustment',   
CASE WHEN status = 1 THEN 'Active'  
WHEN status = 0 THEN 'Inactive'  
end as Status  from TimeDepositPenalty
GO
/****** Object:  View [dbo].[vw_SavingsType]    Script Date: 07/06/2014 23:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_SavingsType]  
as  
select savingsTypeID as 'Savings Type ID', savingsName as 'Savings Type', interestRate as 'Interest',   
  CASE WHEN isPercentage = 1  
  THEN 'Percentage'  
  else 'Fixed' end as 'Amount'  
from SavingsType
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [int] NOT NULL,
	[LName] [varchar](50) NULL,
	[FName] [varchar](50) NULL,
	[MName] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[userTypeID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUserType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateUserType]
 @userTypeID int,
 @userType varchar(50),  
 @status int  
AS  
BEGIN  
	update UserType set typeName = @userType, status = @status where userTypeID = @userTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMemberType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMemberType] 
 @typeID int,
 @typeName varchar(50),  
 @minimumShare money,
 @hasCertificate int,
 @status int
AS  
BEGIN  
	update MemberType set memberTypeName = @typeName, minimumNoOfShare = @minimumShare,
	hasCertificate = @hasCertificate, status = @status
	where memberTypeID = @typeID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMaintenanceTimeDepositPenalty]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UpdateMaintenanceTimeDepositPenalty]  
@rateAdjustment float,  
@penaltyID int,
@status int  
as  
begin  
update TimeDepositPenalty set rateAdjustment = @rateAdjustment, status = @status where penaltyID = @penaltyID  
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateSavingsType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceUpdateSavingsType]              
 @savingsTypeID int,              
 @savingsName varchar(50),              
 @maintainingBalance money,                               
 @maxWithdrawalAmount money,             
 @maxWithdrawDuration int,          
 @maxWithdrawTime int,           
 @noAccountHolders int,              
 @interestRate money,              
 @isPercentage int,            
 @status int            
AS              
BEGIN              
 declare @interestID int              
 declare @isCurrent int              
              
 --Update Savings Type              
 update SavingsType set savingsName = @savingsName, maintainingBalance = @maintainingBalance,           
 maxWithdrawAmount = @maxWithdrawalAmount, maxWithdrawDuration = @maxWithdrawDuration, maxWithdrawTime = @maxWithdrawTime,          
 noAccountHolders = @noAccountHolders, status = @status, isPercentage = @isPercentage, interestRate  = @interestRate              
 where savingsTypeID = @savingsTypeID                  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateLoanType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceUpdateLoanType]                
 @nextLoanTypeID int,                
 @loanName varchar(50),                
 @minAmount money,                
 @maxAmount money,                
 @maxTerm int,                           
 @loanEntitlement money,      
 @isPercentageEntitlement int,                
 @hasComaker int,           
 @hasCollateral int,        
 @status int,
 @loanEligibility money                 
AS                
BEGIN                
                     
 --insertLoanType                
 update LoanType set loanName = @loanName, maxAmount = @maxAmount, minAmount = @minAmount, maxTerm = @maxTerm, loanEntitlement = @loanEntitlement, isPercentageEntitlement = @isPercentageEntitlement, hasComaker = @hasComaker  
    
, status = @status, hasCollateral = @hasCollateral,loanEligibility = @loanEligibility where loanTypeID = @nextLoanTypeID         
                            
END
GO
/****** Object:  Table [dbo].[TimeDepositInterest]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeDepositInterest](
	[interestID] [int] NOT NULL,
	[interestRate] [float] NULL,
	[changeDatetime] [datetime] NULL,
	[isCurrent] [int] NULL,
	[timeRateID] [int] NULL,
 CONSTRAINT [PK_TimeDepositInterest] PRIMARY KEY CLUSTERED 
(
	[interestID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddSavingsType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceAddSavingsType]            
 @savingsName varchar(50),            
 @maintainingBalance money,                         
 @maxWithdrawalAmount money,            
 @maxWithdrawDuration int,        
 @maxWithdrawTime int,        
 @noAccountHolders int,            
 @interestRate money,            
 @isPercentage int,          
 @status int           
AS            
BEGIN            
 declare @nextSavingsTypeID int                 
            
 select @nextSavingsTypeID = ISNULL(MAX(savingsTypeID),0) from SavingsType            
 select @nextSavingsTypeID = @nextSavingsTypeID + 1            
            
 --insert Savings Type            
 insert into SavingsType (savingsTypeID,interestRate,isPercentage,savingsName,maintainingBalance,maxWithdrawAmount,maxWithdrawDuration,maxWithdrawTime,noAccountHolders,status)
 values(@nextSavingsTypeID, @interestRate, @isPercentage, @savingsName,@maintainingBalance,@maxWithdrawalAmount, @maxWithdrawDuration, @maxWithdrawTime,@noAccountHolders,@status)            
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddLoanType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceAddLoanType]                
 @loanName varchar(50),                
 @minAmount money,                
 @maxAmount money,                
 @maxTerm int,                             
 @loanEntitlement money,        
 @isPercentageEntitlement int,                
 @hasComMaker int,           
 @hasCollateral int,              
 @status int,
 @loanEligibility money             
AS                
BEGIN                
 --local variable                
 declare @nextLoanTypeID int                
 declare @nextLoanHistoryID int                
 declare @isCurrent int                
                
 select @isCurrent = 1                
                
 select @nextLoanTypeID = ISNULL(MAX(loanTypeID),0) from LoanType                
 select @nextLoanTypeID = @nextLoanTypeID + 1                
                
 --insertLoanType                
 insert into LoanType (loanTypeID,loanName,maxAmount,minAmount,maxTerm,loanEntitlement,isPercentageEntitlement,hasComaker,hasCollateral,status,loanEligibility)    
 values (@nextLoanTypeID,@loanName,@maxAmount,@minAmount,@maxTerm,@loanEntitlement,@isPercentageEntitlement,@hasComMaker,@hasCollateral,@status,@loanEligibility)                                   
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateCharges]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceUpdateCharges]  
 @chargeID int,  
 @chargeName varchar(50),  
 @amount money,  
 @isPercentage int,  
 @status int
AS  
BEGIN  
 declare @nextChargeID int  
 select @nextChargeID = ISNULL(MAX(chargeID),0) FROM Charge  
 select @nextChargeID = @nextChargeID + 1  
 --insert into Charge values(@nextChargeID,@chargeName,@amount,@isPercentage,1)  
 update Charge set chargeName = @chargeName, amount = @amount, isPercentage = @isPercentage, status = @status 
 where chargeID = @chargeID  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddCharges]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceAddCharges]    
 @chargeName varchar(50),    
 @amount money,    
 @isPercentage int,  
 @status int  
AS    
BEGIN    
 declare @nextChargeID int    
    
 select @nextChargeID = ISNULL(MAX(chargeID),0) FROM Charge    
 select @nextChargeID = @nextChargeID + 1    
 insert into Charge values(@nextChargeID,@chargeName,@amount,@isPercentage,@status)    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertMaintenanceTimeDepositPenalty]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertMaintenanceTimeDepositPenalty]                
 @minimum float,  
 @maximum float,  
 @rateAdjustment float,       
 @status int
AS  
BEGIN                
 declare @nextID int              
                 
 select @nextID = ISNULL(MAX(penaltyID),0) from TimeDepositPenalty          
 select @nextID = @nextID +1          
  
 insert into TimeDepositPenalty values (@nextID, @minimum, @maximum, @rateAdjustment, GETDATE(), @status)                 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTimeDays]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddTimeDays]  
 @timeDepositID int,
 @daysNo int  
AS  
BEGIN  
 declare @daysID int  
   
 select @daysID = ISNULL(MAX(timeDayID),0) from TimeDepositDays  
 select @daysID = @daysID + 1  
   
 insert into TimeDepositDays values(@daysID,@daysNo, @timeDepositID)  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTimeBracket]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddTimeBracket]  
 @timeDepositID int,
 @minimumRange int,  
 @maximumRange int  
AS  
BEGIN  
 declare @timeBracketID int  
   
 select @timeBracketID = ISNULL(MAX(timeBracketID),0) from TimeDepositBracket  
 select @timeBracketID = @timeBracketID + 1  
   
 insert into TimeDepositBracket values (@timeBracketID, @minimumRange, @maximumRange, @timeDepositID)  
    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddMemberType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddMemberType]  
 @typeName varchar(50),  
 @minimumShare money,
 @hasCertificate int,
 @status int
AS  
BEGIN  
 declare @typeID int  
 select @typeID = ISNULL(MAX(memberTypeID),0) from MemberType  
 select @typeID = @typeID + 1  
 insert into MemberType values (@typeID,@typeName,@minimumShare,@hasCertificate,@status)  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddUserType]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddUserType]
	@userType varchar(50),
	@status int
AS
BEGIN
	declare @userTypeID int
	
	select @userTypeID = ISNULL(MAX(userTypeID),0) FROM UserType
	select @userTypeID = @userTypeID + 1
	
	insert into UserType values (@userTypeID, @userType, @status)
END
GO
/****** Object:  Table [dbo].[Family]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Family](
	[familyID] [int] NOT NULL,
	[LName] [varchar](50) NULL,
	[FName] [varchar](50) NULL,
	[MName] [varchar](50) NULL,
	[birthDate] [date] NULL,
	[gender] [char](1) NULL,
	[relationship] [int] NULL,
	[isDependent] [int] NULL,
	[accountNo] [char](7) NULL,
 CONSTRAINT [PK_Family] PRIMARY KEY CLUSTERED 
(
	[familyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTimeRate]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddTimeRate]  
 @interestRate float,  
 @timeBracketID int,  
 @timeDayID int  
AS  
BEGIN  
 declare @timeRateID int  
 declare @interestID int
 
 select @timeRateID = ISNULL(MAX(timeRateID),0) from timedepositrates  
 select @interestID = ISNULL(MAX(interestID),0) from timedepositinterest
 
 select @timeRateID = @timeRateID + 1  
 select @interestID = @interestID + 1
 
 insert into TimeDepositRates values(@timeRateID, @timeBracketID, @timeDayID)  
 insert into TimeDepositInterest values (@interestID, @interestRate, CURRENT_TIMESTAMP, @timeRateID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddLoanCharges]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AddLoanCharges]
	@chargeID int,
	@loanTypeID int
AS
BEGIN
	declare @loanChargeID int
	select @loanChargeID = ISNULL(MAX(loanChargeID),0) from LoanCharges
	select @loanChargeID = @loanChargeID + 1
	update LoanCharges set status = 0 where loanTypeID = @loanTypeID
	insert into LoanCharges values (@loanChargeID,@chargeID,@loanTypeID,1)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_AddLoanCharge]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddLoanCharge]

	@chargeID int,

	@loanTypeID int

as

begin

	declare @loanChargeID int

	select @loanChargeID = ISNULL(MAX(loanChargeID),0) from LoanCharges

	select @loanChargeID = @loanChargeID + 1

	insert into LoanCharges values(@loanChargeID,@chargeID, @loanTypeID, 1);

end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetNextAccountNo]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetNextAccountNo]
AS
BEGIN
	declare @accountNo char(15)
	declare @ctr int

	select @ctr = ISNULL(MAX(accountNo),0) from Member
	select @ctr = @ctr + 1
	select @accountNo = '0000000';
	select @accountNo =	RTRIM(@accountNo) + CONVERT(varchar,@ctr);
	select @accountNo = RIGHT(RTRIM(@accountNo),7)
	
	return @accountNo
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddTimeDepositRates]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceAddTimeDepositRates]      
 @daysNo int,  
 @minimumRange money,  
 @maximumRange money,      
 @interestRate money,                  
 @status int       
AS                  
BEGIN                  
 declare @nextTimeRateID int                       
 declare @nextInterestID int                       
                  
select @nextTimeRateID = ISNULL(MAX(timeRateID),0) from TimeDepositRates      
select @nextTimeRateID = @nextTimeRateID + 1      
      
select @nextInterestID = ISNULL(MAX(interestID),0) from TimeDepositInterest      
select @nextInterestID = @nextInterestID + 1      
--TimeDepositRates      
insert into TimeDepositRates (timeRateID,daysNo,minimumRange,maximumRange,status)  
values(@nextTimeRateID , @daysNo, @minimumRange,@maximumRange, @status)      
--TimeDepositInterest      
insert into TimeDepositInterest (interestID,interestRate,changeDatetime,timeRateID,isCurrent)
values(@nextInterestID, @interestRate, GETDATE(), @nextTimeRateID,1)      
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddLoanRates]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceAddLoanRates]                          
  @interestRate money,        
  @isPercentageInterest int,           
  @shareRate money,        
  @isPercentageShare int,        
  @effectivityDate date,        
  @status int,        
  @loanTypeID int        
AS                  
BEGIN          
 declare @loanRatesID int
 select @loanRatesID = ISNULL(MAX(loanRatesID),0) from LoanRates
 select @loanRatesID = @loanRatesID + 1
 insert into LoanRates(loanRatesID,interestRate,isPercentageInterest,shareRate,isPercentageShare,changeDatetime,isCurrent,effectivityDate,status,loanTypeID)        
 values (@loanRatesID,@interestRate,@isPercentageInterest,@shareRate,@isPercentageShare,GETDATE(),0,@effectivityDate,@status,@loanTypeID)                   
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddLoanPenalty]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MaintenanceAddLoanPenalty]        
 @penaltyAmount money,        
 @duration int,        
 @gracePeriod int,        
 @graceTime int,        
 @durationTime int,        
 @isPercentage int,        
 @isChargeToAmortization int,        
 @isChargeToCurrent int,        
 @loanTypeID int,        
 @effectivityDate date,
 @status int
AS         
begin        
 declare @nextPenaltyID int        
 update LoanPenaltySettings set isCurrent = 0         
 where loanTypeID = @loanTypeID        
 select @nextPenaltyID = ISNULL(MAX(penaltyID),0) from LoanPenaltySettings        
 select @nextPenaltyID = @nextPenaltyID +1        
 INSERT into LoanPenaltySettings values (@nextPenaltyID,@penaltyAmount, @duration, CURRENT_TIMESTAMP, @gracePeriod, @graceTime, @durationTime, @status,0, @isPercentage, @isChargeToAmortization, @isChargeToCurrent, @effectivityDate,@loanTypeID)        
end
GO
/****** Object:  Table [dbo].[TimeDepositAccount]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeDepositAccount](
	[timeAccountNo] [char](10) NOT NULL,
	[openingDatetime] [datetime] NULL,
	[closingDatetime] [datetime] NULL,
	[isClosed] [int] NULL,
	[currentBalance] [money] NULL,
	[maturityDate] [date] NULL,
	[maturityInstruction] [int] NULL,
	[preterminationPenalty] [money] NULL,
	[accountNo] [char](7) NULL,
	[interestID] [int] NULL,
	[penaltyID] [int] NULL,
	[savingsAccountNo] [char](10) NULL,
 CONSTRAINT [PK_TimeDepositAccount] PRIMARY KEY CLUSTERED 
(
	[timeAccountNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateLoanRates]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceUpdateLoanRates]           
 @loanRatesID int,    
 @interestRate money,    
 @isPercentageInterest int,       
 @shareRate money,    
 @isPercentageShare int,    
 @effectivityDate date,    
 @status int,    
 @loanTypeID int    
AS            
BEGIN            
 update LoanRates set interestRate = @interestRate, isPercentageInterest = @isPercentageInterest, shareRate = @shareRate, isPercentageShare = @isPercentageShare, 
 changeDatetime = GETDATE(), effectivityDate = @effectivityDate,   
 status = @status, loanTypeID = @loanTypeID where loanRatesID = @loanRatesID   
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateLoanPenalty]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MaintenanceUpdateLoanPenalty]        
 @penaltyID int,        
 @penaltyAmount money,            
 @duration int,            
 @gracePeriod int,            
 @graceTime int,            
 @durationTime int,            
 @isPercentage int,            
 @isChargeToAmortization int,            
 @isChargeToCurrent int,            
 @loanTypeID int,            
 @effectivityDate date,    
 @status int    
AS             
begin            
 update LoanPenaltySettings set penaltyAmount = @penaltyAmount, duration = @duration, gracePeriod = @gracePeriod,    
  graceTime = @graceTime, durationTime = @durationTime, isPercentage = @isPercentage, isChargeToAmortization = @isChargeToAmortization,    
  isChargeToCurrent = @isChargeToCurrent, loanTypeID = @loanTypeID, effectivityDate = @effectivityDate, status = @status    
 where penaltyID = @penaltyID    
end
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateDormancy]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MaintenanceUpdateDormancy]                
 @inactivityDuration int,              
 @inactivityTime int,              
 @deductionAmount money,              
 @isPercentage int,              
 @deductionEvery int,              
 @deductionTime int,              
 @savingsTypeID int,           
 @status int        
as              
begin              
      
 update Dormancy set inactivityDuration = @inactivityDuration, inactivityTime = @inactivityTime,       
     deductionAmount = @deductionAmount, isPercentage = @isPercentage, deductionEvery = @deductionEvery,      
     deductionTime = @deductionTime, status = @status    
 where savingsTypeID = @savingsTypeID     
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionTerminateMember]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionTerminateMember]
	@accountNo char(7),
	@terminationDate date,
	@terminationReason varchar(30),
	@remarks varchar(50)
AS
BEGIN
	UPDATE Member set isTerminated = 1, terminationDate = @terminationDate,
	terminationReason = @terminationReason, remarks = @remarks
	where accountNo = @accountNo
END
GO
/****** Object:  View [dbo].[vw_Dormancy]    Script Date: 07/06/2014 23:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_Dormancy]  
as   
select A. dormancyID as 'DormancyID', A.inactivityDuration as 'Inactivity Duration',   
	case when A.inactivityTime = 1 then 'Daily'  
	when A.inactivityTime = 2 then 'Weekly'  
	when A.inactivityTime = 3 then 'Monthly'  
	else 'Yearly'end as 'Interval',  
	A.deductionAmount as 'Deduction Amount',  
	case when A.isPercentage = 1 then 'Percentage'  
	else 'Fixed Amount' end as 'Deduction Rate',  
	B.savingsTypeID as 'Savings Type ID',  
	B.savingsName as 'Savings Name'  
from Dormancy A inner join SavingsType B on (A.savingsTypeID = B.savingsTypeID)
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceUpdateTimeDepositRate]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MaintenanceUpdateTimeDepositRate]        
 @daysNo int,    
 @minimumRange money,    
 @maximumRange money,      
 @interestRate money,        
 @status int,        
 @timeRateID int                      
AS                      
BEGIN                      
 declare @nextinterestID int                           
        
 select @nextinterestID = ISNULL(MAX(interestID),0) from TimeDepositInterest          
 select @nextinterestID = @nextinterestID + 1     
  
 --set current interest rate  
 update TimeDepositInterest set isCurrent = 0 where timeRateID = @timeRateID  
        
 --insert in TimeDepositInterest        
 insert into TimeDepositInterest (interestID, interestRate,changeDatetime,timeRateID,isCurrent)    
 values (@nextinterestID, @interestRate, GETDATE(), @timeRateID,1)        
 --update in TimeDepositRate        
 update TimeDepositRates set status = @status, minimumRange = @minimumRange,    
  maximumRange = @maximumRange, daysNo = @daysNo    
  where timeRateID = @timeRateID    
END
GO
/****** Object:  Table [dbo].[Spouse]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Spouse](
	[accountNo] [char](7) NOT NULL,
	[FName] [varchar](50) NULL,
	[MName] [varchar](50) NULL,
	[LName] [varchar](50) NULL,
	[birthDate] [date] NULL,
 CONSTRAINT [PK_Spouse] PRIMARY KEY CLUSTERED 
(
	[accountNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_LoanPenalty]    Script Date: 07/06/2014 23:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_LoanPenalty]        
as        
        
select A.penaltyID as PenaltyID, B.loanName as 'Loan Type', A.penaltyAmount as 'Penalty Amount',         
  (        
   case when isPercentage = 1 then 'Percentage'        
   else 'Fixed Amount' end        
  ) as 'Penalty Rate',        
    (Convert(varchar(10),A.gracePeriod)   +        
   case when A.graceTime = 1 then ' Days'        
   when A.graceTime = 2 then ' Weeks'        
   when A.graceTime = 3 then ' Months'        
   else ' Years' end        
    ) as 'Grace Period'        
from LoanPenaltySettings A inner join LoanType B on (A.loanTypeID = B.loanTypeID)        
where effectivityDate > CAST(GETDATE() AS DATE)
GO
/****** Object:  Table [dbo].[ShareCapital]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShareCapital](
	[shareID] [int] NOT NULL,
	[accountNo] [char](7) NOT NULL,
	[currentBalance] [money] NULL,
	[isClosed] [int] NULL,
 CONSTRAINT [PK_ShareCapital_1] PRIMARY KEY CLUSTERED 
(
	[shareID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SavingsTransaction]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SavingsTransaction](
	[transactionID] [int] NOT NULL,
	[transactionDatetime] [datetime] NULL,
	[transactionType] [varchar](3) NULL,
	[amount] [money] NULL,
	[currentBalance] [money] NULL,
	[comments] [varchar](50) NULL,
	[controlNo] [varchar](50) NULL,
	[savingsAccountNo] [char](10) NULL,
	[userID] [int] NULL,
 CONSTRAINT [PK_SavingsTransaction_1] PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MemberFinancial]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberFinancial](
	[accountNo] [char](7) NOT NULL,
	[employmentStatus] [int] NULL,
	[incomeSource] [int] NULL,
	[employerName] [varchar](50) NULL,
	[employerAddress] [varchar](70) NULL,
 CONSTRAINT [PK_MemberFinancial] PRIMARY KEY CLUSTERED 
(
	[accountNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MemberAccountHolder]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MemberAccountHolder](
	[accountNo] [char](7) NULL,
	[savingsAccountNo] [char](10) NULL,
	[isPrimary] [int] NULL,
	[isRemoved] [int] NULL,
	[removalDatetime] [datetime] NULL,
	[signatureImage] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoanPayment]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoanPayment](
	[paymentID] [int] NOT NULL,
	[paymentAmount] [money] NULL,
	[paymentDatetime] [datetime] NULL,
	[accountNo] [char](7) NOT NULL,
	[userID] [int] NOT NULL,
 CONSTRAINT [PK_LoanPayment] PRIMARY KEY CLUSTERED 
(
	[paymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Loan](
	[loanNo] [char](7) NOT NULL,
	[requestedAmount] [money] NULL,
	[approvedAmount] [money] NULL,
	[loanDate] [date] NULL,
	[termsOfPayment] [int] NULL,
	[paymentInterval] [int] NULL,
	[statusDate] [date] NULL,
	[status] [int] NULL,
	[isReleased] [int] NULL,
	[releaseCancelDatetime] [datetime] NULL,
	[releaseType] [char](2) NULL,
	[accountNo] [char](7) NULL,
	[loanTypeID] [int] NULL,
	[userID] [int] NULL,
	[penaltyID] [int] NULL,
	[shareID] [int] NULL,
	[loanRatesID] [int] NULL,
	[remarks] [varchar](100) NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[loanNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetShareCapital]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetShareCapital] (@accountNo char(7))    
RETURNS TABLE    
AS    
RETURN    
(    
 select B.shareID, (A.LName+', '+A.FName+' '+A.MName) as MemberName, A.accountNo, B.currentBalance from Member A    
 inner join ShareCapital B on (A.accountNo = B.accountNo)    
 where A.accountNo = @accountNo    
)
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetSavingsAccounts]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetSavingsAccounts] (@accountNo char(7))          
RETURNS TABLE          
AS          
RETURN          
(          
 select D.accountNo as AccountNo, A.savingsAccountNo,(D.LName + ', '+ D.FName + ' '+ D.MName) as MemberName, B.savingsName as 'Savings Name', A.currentBalance as 'Current Balance' from SavingsAccount A inner join SavingsType B          
 on (A.savingsTypeID = B.savingsTypeID) inner join MemberAccountHolder C          
 on (A.savingsAccountNo = C.savingsAccountNo) inner join Member D          
 on (C.accountNo = D.accountNo) where C.accountNo = @accountNo and A.isClosed = '0' and C.isPrimary = 1        
)
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetSavingsAccount]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetSavingsAccount] (@savingsAccountID int)  
RETURNS TABLE  
AS  
RETURN  
(  
 select D.accountNo as AccountNo, A.savingsAccountNo, A.currentBalance,(D.LName + ', '+ D.FName + ' '+ D.MName) as MemberName, B.savingsName from SavingsAccount A inner join SavingsType B  
 on (A.savingsTypeID = B.savingsTypeID) inner join MemberAccountHolder C  
 on (A.savingsAccountNo = C.savingsAccountNo) inner join Member D  
 on (C.accountNo = D.accountNo) where A.savingsAccountNo = @savingsAccountID  
)
GO
/****** Object:  View [dbo].[vw_DormantAccounts]    Script Date: 07/06/2014 23:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_DormantAccounts]                
as              
select C.accountNo as AccountNo, (E.LName + ',' + E.FName +' '+E.MName) as MemberName,B.savingsAccountNo,                 
D.savingsName as SavingsType, B.currentBalance ,(select CAST(MAX(st.transactionDatetime) AS DATE) from SavingsTransaction st where (st.transactionType = 'D' OR st.transactionType = 'W') and st.savingsAccountNo = B.savingsAccountNo) as LastTransaction     
          
from SavingsTransaction A                   
inner join SavingsAccount B on (A.savingsAccountNo = B.savingsAccountNo)                  
inner join MemberAccountHolder C on (B.savingsAccountNo = C.savingsAccountNo)                  
inner join SavingsType D on (B.savingsTypeID = D.savingsTypeID)                  
inner join Member E on (C.accountNo = E.accountNo)                  
where B.isClosed = 0                
GROUP BY B.savingsAccountNo,B.currentBalance,D.savingsTypeID,D.savingsName, C.accountNo, E.LName,E.FName,E.MName               
HAVING (DATEDIFF(DAY,(select CAST(MAX(st.transactionDatetime) AS DATE) from SavingsTransaction st where (st.transactionType = 'D' OR st.transactionType = 'W') and st.savingsAccountNo = B.savingsAccountNo),CURRENT_TIMESTAMP)) >                 
(select top 1 (AA.inactivityDuration*BB.daysNo) from Dormancy AA             
inner join Indicator BB on (AA.inactivityTime = BB.indicatorID)    
where AA.status = 1 )
GO
/****** Object:  Table [dbo].[TimeDepositTransaction]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeDepositTransaction](
	[transactionID] [int] NOT NULL,
	[amount] [money] NULL,
	[transactionType] [char](2) NULL,
	[transactionDatetime] [datetime] NULL,
	[timeAccountNo] [char](10) NULL,
	[userID] [int] NULL,
 CONSTRAINT [PK_TimeDepositTransaction] PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionSavingsShare]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionSavingsShare]        
 --SavingsAccount/ShareID        
 @referenceID int,         
 @isSavings int,        
 @transactionType char(1),        
 @amount money,        
 @userID int        
AS        
BEGIN        
 declare @currentBalance money        
 declare @savingsShareTransactionID int        
         
 select @savingsShareTransactionID = ISNULL(MAX(savingsTransactionID),0) from SavingsShareTransaction        
 select @savingsShareTransactionID = @savingsShareTransactionID + 1        
        
 IF @isSavings = 1        
  BEGIN        
   select @currentBalance = currentBalance from SavingsAccount        
   where savingsAccountID = @referenceID        
           
   IF @transactionType = 'D' --Deposit Amount        
    BEGIN        
     select @currentBalance = @currentBalance + @amount        
    END        
           
   IF @transactionType = 'W' --Withdraw Amount        
    BEGIN        
     select @currentBalance = @currentBalance - @amount        
    END        
            
   IF @transactionType = 'C' --Close account        
    BEGIN        
     select @amount = @currentBalance      
     select @currentBalance = @currentBalance - @currentBalance        
    END        
            
   --Update Savings Account Balance        
   update SavingsAccount set currentBalance = @currentBalance         
   where savingsAccountID = @referenceID        
  END        
         
 IF @isSavings = 0        
  BEGIN                  
    select @currentBalance = currentBalance from ShareCapital  
    where shareID = @referenceID       
      
    if @transactionType = 'D'  
    begin  
   select @currentBalance = currentBalance from ShareCapital where shareID = @referenceID        
      select @currentBalance = @currentBalance + @amount    
    end  
      
    if @transactionType = 'C'  
    begin  
   select @amount = @currentBalance  
   select @currentBalance = 0  
    end  
      
    --Update Share Capital Balance        
    update ShareCapital set currentBalance = @currentBalance, isClosed = 1        
    where shareID = @referenceID   
  END        
         
 --Insert transaction record        
 INSERT SavingsShareTransaction values (@savingsShareTransactionID, @referenceID, @isSavings, CURRENT_TIMESTAMP, @transactionType, @amount,NULL, @userID)        
         
 IF @transactionType = 'C'        
  BEGIN        
   update SavingsAccount set isClosed = 1, closingDatetime = CURRENT_TIMESTAMP where savingsAccountID = @referenceID        
  END        
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionSavingsAccount]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionSavingsAccount]                
	@transactionType char(3),                
	@amount money,                
	@controlNo varchar(50),                
	@savingsAccountNo char(10),                
	@userID int,    
	@comments varchar(50)
AS                
BEGIN                
	declare @transactionID int                
	declare @currentBalance money                
	             
	select @transactionID = ISNULL(MAX(transactionID),0) from SavingsTransaction                
	select @transactionID = @transactionID + 1                
	select @currentBalance = currentBalance from SavingsAccount where savingsAccountNo = @savingsAccountNo              
	            
	IF @transactionType = 'D' OR @transactionType = 'I'                
	BEGIN                
		select @currentBalance = @currentBalance + @amount                
	END                
	             
	IF @transactionType = 'W' OR @transactionType = 'DOR'           
	BEGIN                
		select @currentBalance = @currentBalance - @amount                
	END                
	             
	IF @transactionType = 'C'                
	BEGIN                
		select @amount = @currentBalance                
		select @currentBalance = 0                
		update SavingsAccount set isClosed = 1, closingDatetime = CURRENT_TIMESTAMP where savingsAccountNo = @savingsAccountNo            
	END               
	     
	--Insert Savings Transaction                
	insert into SavingsTransaction(transactionID, transactionDatetime, transactionType,amount,controlNo, savingsAccountNo,userID,comments,currentBalance)                
	values (@transactionID, CURRENT_TIMESTAMP, @transactionType, @amount, @controlNo, @savingsAccountNo, @userID,@comments,@currentBalance)                
	           
	update SavingsAccount set currentBalance = @currentBalance where savingsAccountNo = @savingsAccountNo     
	
	select @transactionID         
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionUpdateMember]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionUpdateMember]        
  --Member Information      
  @accountNo char(7),          
  @LName varchar(50),          
  @FName varchar(50),          
  @MName varchar(50),          
  @blkNoAddress varchar(70),
  @streetAddress varchar(50),          
  @brgyAddress varchar(50),          
  @cityAddress varchar(50),
  @membershipDate date,          
  @birthDate date,          
  @gender char(1),          
  @telNo char(8),          
  @mobileNo char(11),          
  @emailAdd varchar(50),          
  @passportNo char(10),          
  @driverLicenseNo char(10),          
  @sssNo char(10),          
  @civilStatus varchar(50),          
  @educationalAttainment varchar(50),          
  @picture varchar(50),          
  
  --Spouse Information    
  @spouseLName varchar(50),    
  @spouseFName varchar(50),    
  @spouseMName varchar(50),    
  @spouseBirthDate date,    
  
  --Financial Information    
  @employmentStatus int,    
  @incomeSource int,    
  @employerName varchar(50),    
  @employerAddress varchar(50)    
AS          
  
BEGIN          
 --Update Member      
  update Member set LName = @LName, FName = @FName, MName = @MName, memberBlkNoAddress = @blkNoAddress,  
     memberStreetAddress = @streetAddress, memberBrgyAddress = @brgyAddress, memberCityAddress = @cityAddress,
     birthDate = @birthDate, gender = @gender, telno = @telNo,  
     mobileNo = @mobileNo, emailAdd = @emailAdd, passportNo = @passportNo,  
     driverLicenseNo = @driverLicenseNo, sssNo = @sssNo, civilStatus = @civilStatus,  
     educationalAttainment = @educationalAttainment, picture = @picture  
     where accountNo = @accountNo  
  
 --Update Spouse Information   
 update Family set LName = @spouseLName, FName = @spouseFName ,MName = @spouseMName ,birthDate = @spouseBirthDate where accountNo = @accountNo and relationship = 8  
  
 --Update Financial Information    
 update MemberFinancial set employmentStatus = @employmentStatus, incomeSource = @incomeSource,  
          employerName = @employerName, employerAddress = @employerAddress  
          where accountNo = @accountNo  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MaintenanceAddDormancy]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MaintenanceAddDormancy]            
 @inactivityDuration int,            
 @inactivityTime int,            
 @deductionAmount money,            
 @isPercentage int,            
 @deductionEvery int,            
 @deductionTime int,            
 @savingsTypeID int,         
 @status int  
as            
begin            
  declare @dormancyID int            
  declare @isCurrent int             
            
  --DormancyID               
  select @dormancyID = ISNULL(MAX(dormancyID),0) from Dormancy            
  select @dormancyID = @dormancyID + 1            
  
  IF EXISTS (select 1 from Dormancy where savingsTypeID = @savingsTypeID)    
  BEGIN
		exec sp_MaintenanceUpdateDormancy @inactivityDuration, @inactivityTime, @deductionAmount, @isPercentage,@deductionEvery,@deductionTime,@savingsTypeID,@status
  END
  
  ELSE
  BEGIN
		--Insert Dormancy          
		insert into Dormancy (dormancyID,inactivityDuration,inactivityTime,deductionAmount,isPercentage,deductionEvery,deductionTime,status,isCurrent,savingsTypeID)  
		values (@dormancyID,@inactivityDuration,@inactivityTime, @deductionAmount, @isPercentage, @deductionEvery, @deductionTime,@status,0,@savingsTypeID)              
  END
end
GO
/****** Object:  Table [dbo].[FamilyAccountHolder]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FamilyAccountHolder](
	[familyID] [int] NULL,
	[savingsAccountNo] [char](10) NULL,
	[isRemoved] [int] NULL,
	[removalDatetime] [datetime] NULL,
	[signatureImage] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertFamily]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertFamily]  
 @LName varchar(50),  
 @FName varchar(50),  
 @MName varchar(50),  
 @birthDate date,  
 @relationship int,  
 @isDependent int,
 @gender char(1),  
 @accountNo char(7)  
AS  
BEGIN  
 declare @familyID int  
 select @familyID = ISNULL(MAX(familyID),0) from Family  
 select @familyID = @familyID + 1  
   
 insert into Family(familyID, LName, FName,MName,birthDate,relationship,isDependent,accountNo,Gender)  
 values (@familyID,@LName,@FName,@MName,@birthDate,@relationship,@isDependent,@accountNo,@gender)  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateSavingsAccount]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateSavingsAccount]              
 @accountNo char(7),                  
 @savingsTypeID int,              
 @initialDeposit money,              
 @userID int,  
 @signatureImage varchar(50)              
AS              
BEGIN              
 --declare new ID              
 declare @savingsAccountNo char(20)        
 declare @nextID int            
 declare @savingsTransactionID int              
               
 --Get next Savings Account Number        
 select @nextID = ISNULL(MAX(savingsAccountNo),0) from SavingsAccount        
 select @nextID = @nextID +1        
 select @savingsAccountNo = '0000000000' + CAST(@nextID as CHAR)        
 select @savingsAccountNo = RIGHT(RTRIM(@savingsAccountNo),10)        
 print @savingsAccountNo      
               
 --Get next SavingsTransaction ID              
 select @savingsTransactionID = ISNULL(MAX(transactionID),0) FROM SavingsTransaction            
 select @savingsTransactionID = @savingsTransactionID + 1              
               
 --Create new Savings account              
 insert into SavingsAccount(savingsAccountNo, openingDatetime, currentBalance, isClosed, savingsTypeID)              
 values (@savingsAccountNo,CURRENT_TIMESTAMP, @initialDeposit,0, @savingsTypeID)              
                 
 --Insert new Transaction              
 insert into SavingsTransaction (transactionID, transactionDatetime, transactionType, amount, savingsAccountNo, currentBalance, userID)        
 values (@savingsTransactionID, CURRENT_TIMESTAMP, 'D', @initialDeposit, @savingsAccountNo, @initialDeposit,@userID)               
         
 --Insert Account Holder        
 insert into MemberAccountHolder(accountNo, isPrimary, savingsAccountNo, isRemoved, signatureImage) values (@accountNo, 1, @savingsAccountNo,0,@signatureImage)        
END
GO
/****** Object:  Table [dbo].[ShareTransaction]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShareTransaction](
	[transactionID] [int] NOT NULL,
	[transactionDatetime] [datetime] NULL,
	[transactionType] [varchar](3) NULL,
	[amount] [money] NULL,
	[comments] [varchar](50) NULL,
	[shareID] [int] NULL,
	[userID] [int] NULL,
 CONSTRAINT [PK_ShareTransaction] PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetLoanRateAmount]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetLoanRateAmount](@amount money,@loanNo char(7), @rateType int)
RETURNS MONEY
AS
BEGIN

	declare @rateAmount money
	select @rateAmount = (CASE WHEN isPercentage = 1 THEN @amount*D.rateAmount/100 else D.rateAmount end) from Loan B inner join LoanIncludedRates C on (B.loanNo = C.loanNo) 
				inner join LoanRates D on (C.loanRatesID = D.loanRatesID) where D.rateType = @rateType
				and B.loanNo = @loanNo
	return @rateAmount
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BatchInterestComputation]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BatchInterestComputation]          
AS          
BEGIN          
          
 declare @savingsAccountNo char(10)          
 declare @interestAmount money           
           
 select B.savingsAccountNo,(          
  CASE WHEN A.isPercentage = 1 then ((A.interestRate/100)/12)*B.currentBalance          
  else A.interestRate end          
 ) as interest into #tempTable from SavingsType A           
 inner join SavingsAccount B on (A.savingsTypeID = B.savingsTypeID)          
 where B.currentBalance >= A.maintainingBalance        
 and B.savingsAccountNo not in (select C.savingsAccountNo from vw_DormantAccounts C)         
 and (CASE WHEN A.isPercentage = 1 then ((A.interestRate/100)/12)*B.currentBalance          
  else (A.interestRate/12)*B.currentBalance end          
 ) != 0       
          
 WHILE (select count(*) from #tempTable) > 0          
 BEGIN          
  select @savingsAccountNo = savingsAccountNo, @interestAmount = interest from #tempTable          
  exec sp_TransactionSavingsAccount 'I',@interestAmount,'',@savingsAccountNo,NULL,''          
  delete from #tempTable where savingsAccountNo = @savingsAccountNo          
 END          
           
 drop table #tempTable          
END
GO
/****** Object:  StoredProcedure [dbo].[sp_BatchDormancyComputation]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BatchDormancyComputation]    
AS    
BEGIN    
 declare @savingsAccountNo char(10)    
 declare @dormancyFee money    
     
 select C.dormancyID, A.savingsAccountNo,    
  (CASE WHEN DATEDIFF(DAY,(select CAST(MAX(st.transactionDatetime) AS DATE) from SavingsTransaction st where (st.transactionType = 'D' OR st.transactionType = 'W') and st.savingsAccountNo = A.savingsAccountNo),CAST(GETDATE() AS DATE))    
   %(select (C.deductionEvery*II.daysNo) from Indicator II where II.indicatorID = C.deductionTime) = 0    
  then     
   (    
    case when C.isPercentage = 1 then A.currentBalance*(C.deductionAmount/100)    
    else C.deductionAmount end    
   )    
  else 0 end) as dormancyFee into #tempTable     
 from SavingsAccount A     
 inner join SavingsType B on (A.savingsTypeID = B.savingsTypeID)    
 inner join Dormancy C on (B.savingsTypeID = C.savingsTypeID)    
 where C.dormancyID =     
  (    
   select top 1 X.dormancyID from Dormancy X where status = 1 and CAST(GETDATE() AS DATE) > X.effectivityDate     
   and X.savingsTypeID = B.savingsTypeID order by X.effectivityDate desc    
  )    
 and savingsAccountNo in (select vw.savingsAccountNo from vw_DormantAccounts vw)    
 and (CASE WHEN DATEDIFF(DAY,(select CAST(MAX(st.transactionDatetime) AS DATE) from SavingsTransaction st where st.savingsAccountNo = A.savingsAccountNo),CAST(GETDATE() AS DATE))    
   %(select (C.deductionEvery*II.daysNo) from Indicator II where II.indicatorID = C.deductionTime) = 0    
  then     
   (    
    case when C.isPercentage = 1 then A.currentBalance*(C.deductionAmount/100)    
    else C.deductionAmount end    
   )    
  else 0 end) != 0 --if dormancy fee != 0    
     
 --Process the records    
 WHILE (select COUNT(*) from #tempTable) > 0    
 BEGIN    
  select @savingsAccountNo = savingsAccountNo, @dormancyFee = dormancyFee from #tempTable    
  exec sp_TransactionSavingsAccount 'DOR',@dormancyFee,'',@savingsAccountNo,NULL    
  delete from #tempTable where savingsAccountNo = @savingsAccountNo    
 END    
     
 drop table #tempTable    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionTimeDeposit]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionTimeDeposit]      
  @amount money,      
  @transactionType char(1),      
  @userID int,      
  @timeAccountNo char(10)    
AS      
BEGIN      
  declare @nextID int      
  declare @transactionDatetime datetime      
  declare @daysNo int    
  declare @interestID int    
  declare @currentBalance money  
    
  select @currentBalance = currentBalance from TimeDepositAccount  
   where timeAccountNo = @timeAccountNo  
  select @nextID = ISNULL(MAX(transactionID),0) from TimeDepositTransaction      
  select @nextID = @nextID + 1      
    
  select @transactionDatetime = GETDATE()      
    
  IF @transactionType = 'D' OR @transactionType = 'I'  
  BEGIN  
    select @currentBalance = @currentBalance + @amount  
  END  
    
  IF @transactionType = 'C'      
  BEGIN         
    update TimeDepositAccount set closingDatetime = @transactionDatetime, isClosed = 1      
    where timeAccountNo = @timeAccountNo      
  END      
    
  insert into TimeDepositTransaction (transactionID,amount,transactionType,transactionDatetime,timeAccountNo,userID)      
    values (@nextID,@amount,@transactionType,@transactionDatetime,@timeAccountNo,@userID)  
      
  update TimeDepositAccount set currentBalance = @currentBalance where timeAccountNo = @timeAccountNo  
  
  select @nextID
  --IF @transactionType = 'R'    
  --BEGIN    
  -- insert into TimeDepositTransaction (transactionID,amount,transactionType,transactionDatetime,timeAccountNo,userID)      
  -- values (@nextID,@amount,@transactionType,@transactionDatetime,@timeAccountNo,@userID)     
  -- update TimeDepositAccount set currentBalance = @amount, maturityDate = DATEADD(DAY,@daysNo,maturityDate),    
  -- openingDatetime = CAST(maturityDate as DATETIME), interestID = @interestID    
  -- where timeAccountNo = @timeAccountNo    
  --END     
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionShare]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionShare]  
	 @shareID int,  
	 @transactionType char(3),  
	 @amount money,  
	 @comments varchar(50),  
	 @userID int  
AS  
BEGIN  
	 declare @currentBalance money  
	 declare @nextTransactionID int  
	 declare @isClosed int  
	 declare @memberTypeID int
	 declare @accountNo char(7)
	   
	 select @currentBalance = currentBalance from ShareCapital where shareID = @shareID  
	 select @nextTransactionID = ISNULL(MAX(transactionID),0) FROM ShareTransaction  
	 select @nextTransactionID = @nextTransactionID + 1  
	   
	 IF @transactionType = 'D'  
	 BEGIN  
		  select @currentBalance = @currentBalance + @amount  
		  select @isClosed = 0  
		  
		  select @accountNo = accountNo from ShareCapital where shareID = @shareID
		  select top 1 @memberTypeID = memberTypeID from MemberType where status = 1 and @currentBalance >= minimumNoOfShare order by minimumNoOfShare desc
		  update Member set memberTypeID = @memberTypeID where accountNo = @accountNo
	 END  
	   
	 IF @transactionType = 'C'  
	 BEGIN  
		  select @amount = @currentBalance  
		  select @currentBalance = 0  
		  select @isClosed = 1  
	    
	 END  
	   	   
	 --Update Share Capital Table  
	 update ShareCapital set currentBalance = @currentBalance, isClosed = @isClosed where shareID = @shareID  
	   
	 --Insert Share Capital  
	 insert into ShareTransaction values (@nextTransactionID, CURRENT_TIMESTAMP, @transactionType, @amount, @comments, @shareID, @userID)  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanCancellation]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanCancellation]  
 @loanNo char(7),  
 @cancellationRemarks varchar(100)  
AS    
BEGIN    
 UPDATE Loan set isReleased = 0, releaseCancelDatetime = GETDATE(), cancellationRemarks = @cancellationRemarks   
 where loanNo = @loanNo    
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanApproval]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanApproval]          
 @loanNo char(7),          
 @approvedAmount money,          
 @isApproved int,      
 @termsOfPayment int,
 @approvalRemarks varchar(100)          
AS          
BEGIN          
 declare @penaltyID int          
 declare @approvalDate date          
 declare @loanTypeID int         
 declare @loanRatesID int      
          
           
 --select loanTypeID          
 select @loanTypeID = loanTypeID from Loan where loanNo = @loanNo          
           
 --Select approvalDate          
 select @approvalDate = CAST(GETDATE() AS DATE)          
           
 --Select penaltyID          
 select top 1  @penaltyID = penaltyID from LoanPenaltySettings          
  where effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 and loanTypeID = @loanTypeID          
  order by effectivityDate desc          
         
 IF @isApproved = 1        
 BEGIN        
 select top 1 @loanRatesID = loanRatesID from LoanRates B where loanTypeID = @loanTypeID and effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 order by effectivityDate desc        
 END        
         
 --Update loan for approval         
 update Loan set approvedAmount = @approvedAmount, isApproved = @isApproved, penaltyID = @penaltyID, termsOfPayment = @termsOfPayment, loanRatesID = @loanRatesID,       
 approvalDate = @approvalDate, approvalRemarks = @approvalRemarks where loanNo = @loanNo            
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanApplicationUpdate]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanApplicationUpdate]        
 @loanNo char(7),        
 @requestedAmount money,            
 @loanDate date,            
 @termsOfPayment int,            
 @paymentInterval int,            
 @accountNo char(7),            
 @loanTypeID int,  
 @status int,    
 @remarks varchar(100),        
 @approvedAmount money,              
 @userID int            
 --@savingsAccountNo char(10)            
AS            
BEGIN                
 declare @shareID int     
 declare @penaltyID int                
 declare @statusDate date                      
 declare @loanRatesID int                   
             
 --Get Share Capital            
 select @shareID = shareID from ShareCapital where accountNo = @accountNo            
 --Select approvalDate                
 select @statusDate = CAST(GETDATE() AS DATE)                
                 
 --Select penaltyID                
 select top 1  @penaltyID = penaltyID from LoanPenaltySettings                
  where effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 and loanTypeID = @loanTypeID                
  order by effectivityDate desc        
      
 select top 1 @loanRatesID = loanRatesID from LoanRates B where loanTypeID = @loanTypeID and effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 order by effectivityDate desc                 
         
 --IF LEN(@savingsAccountNo) = 0        
 --begin        
 --select @savingsAccountNo = NULL        
 --end         
    
         
 update Loan set requestedAmount = @requestedAmount, loanDate = @loanDate, termsOfPayment = @termsOfPayment, paymentInterval = @paymentInterval,        
  accountNo = @accountNo, loanTypeID = @loanTypeID, userID = @userID, shareID = @shareID,  
  penaltyID = @penaltyID, loanRatesID = @loanRatesID, remarks = @remarks, status = @status,  
  approvedAmount = @approvedAmount, statusDate = @statusDate --, savingsAccountNo = @savingsAccountNo          
  where loanNo = @loanNo        
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanApplicationInsert]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanApplicationInsert]        
 @requestedAmount money,        
 @loanDate date,        
 @termsOfPayment int,        
 @paymentInterval int,        
 @accountNo char(7),        
 @loanTypeID int,  
 @status int,  
 @remarks varchar(100),      
 @approvedAmount money,    
 @userID int        
 --@savingsAccountNo char(10)        
AS        
BEGIN        
 declare @nextID int        
 declare @loanNo char(20)        
 declare @shareID int      
 declare @penaltyID int              
 declare @statusDate date                    
 declare @loanRatesID int      
         
 --Get next ID        
 select @nextID = ISNULL(CAST(MAX(loanNo) AS INT),0) from Loan        
 select @nextID = @nextID + 1        
         
 --Get next LoanNo        
 select @loanNo = '0000000'+ CAST(@nextID as CHAR)        
 select @loanNo = RIGHT(RTRIM(@loanNo),7)        
         
 --Get Share Capital        
 select @shareID = shareID from ShareCapital where accountNo = @accountNo     
   
 --Select approvalDate              
 select @statusDate = CAST(GETDATE() AS DATE)              
               
 --Select penaltyID              
 select top 1  @penaltyID = penaltyID from LoanPenaltySettings              
  where effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 and loanTypeID = @loanTypeID              
  order by effectivityDate desc      
    
 select top 1 @loanRatesID = loanRatesID from LoanRates B where loanTypeID = @loanTypeID and effectivityDate <= CAST(GETDATE() AS DATE) and status = 1 order by effectivityDate desc               
       
 --IF LEN(@savingsAccountNo) = 0      
 --begin      
 --select @savingsAccountNo = NULL      
 --end      
         
 insert into Loan(loanNo, requestedAmount, loanDate, termsOfPayment, paymentInterval, accountNo, loanTypeID, userID, shareID, status,remarks,loanRatesID,penaltyID,statusDate,approvedAmount)        
 values (@loanNo, @requestedAmount, @loanDate, @termsOfPayment, @paymentInterval, @accountNo, @loanTypeID, @userID, @shareID,@status,@remarks,@loanRatesID,@penaltyID,@statusDate,@approvedAmount)        
END
GO
/****** Object:  Table [dbo].[LoanTransactions]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoanTransactions](
	[transactionID] [int] NOT NULL,
	[transactionDatetime] [datetime] NULL,
	[amount] [money] NULL,
	[transactionType] [char](1) NULL,
	[loanNo] [char](7) NULL,
	[userID] [int] NULL,
 CONSTRAINT [PK_LoanTransactions] PRIMARY KEY CLUSTERED 
(
	[transactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChargedFromLoans]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChargedFromLoans](
	[chargeID] [int] NOT NULL,
	[loanNo] [char](7) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Amortization]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Amortization](
	[amortID] [int] NOT NULL,
	[baseAmount] [money] NULL,
	[interest] [money] NULL,
	[shareCapital] [money] NULL,
	[penalty] [money] NULL,
	[totalAmount] [money] NULL,
	[balanceAmount] [money] NULL,
	[dueDate] [date] NULL,
	[isPaid] [int] NULL,
	[isBilled] [int] NULL,
	[isRestructured] [int] NULL,
	[loanNo] [char](7) NULL,
 CONSTRAINT [PK_Amortization] PRIMARY KEY CLUSTERED 
(
	[amortID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comakers]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comakers](
	[comakerID] [int] NOT NULL,
	[loanNo] [char](7) NOT NULL,
	[memberComaker] [char](7) NULL,
	[familyComaker] [int] NOT NULL,
	[blkNoAddressFamily] [varchar](50) NULL,
	[streetAddressFamily] [varchar](50) NULL,
	[brgyAddressFamily] [varchar](50) NULL,
	[cityAddressFamily] [varchar](50) NULL,
 CONSTRAINT [PK_Comakers_1] PRIMARY KEY CLUSTERED 
(
	[comakerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Collateral]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Collateral](
	[collateralID] [int] NOT NULL,
	[collateralName] [varchar](50) NULL,
	[collateralDesc] [varchar](200) NULL,
	[loanNo] [char](7) NULL,
 CONSTRAINT [PK_Collateral] PRIMARY KEY CLUSTERED 
(
	[collateralID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetPenalty]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetPenalty](@loanNo char(7))  
RETURNS TABLE  
AS  
RETURN  
(  
select top 1   
 (  
	CASE WHEN DATEDIFF(DAY,A.dueDate,CAST(GETDATE() AS DATE)) >0
	THEN
	(	
	  CAST(DATEDIFF(DAY,A.dueDate,CAST(GETDATE() AS DATE)) AS MONEY)/  
	  CAST((C.duration*(select I.daysNo from Indicator I where I.indicatorID = C.durationTime)) AS MONEY)*  
	  (  
	   CASE WHEN C.isPercentage = 1  
	   THEN C.penaltyAmount/100  
	   else  
	   C.penaltyAmount end  
	  )*A.balanceAmount  
	)
	ELSE 0 END  
 ) as penalty  
from Amortization A   
inner join Loan B on (A.loanNo = B.loanNo)  
inner join LoanPenaltySettings C on (B.penaltyID = C.penaltyID)  
where A.isRestructured = 0 and isPaid = 0 and A.loanNo = @loanNo  
)
GO
/****** Object:  Table [dbo].[CheckTransactions]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CheckTransactions](
	[transactionID] [int] NULL,
	[transactionTable] [char](3) NULL,
	[checkInfoID] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AmortizationPaid]    Script Date: 07/06/2014 23:39:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmortizationPaid](
	[paymentID] [int] NULL,
	[amortID] [int] NULL,
	[loanPrincipalPayment] [money] NULL,
	[loanPenaltyPayment] [money] NULL,
	[loanInterestPayment] [money] NULL,
	[shareCapital] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateComakers]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateComakers]  
 @comakerID int,  
 @loanNo char(7),  
 @memberComaker char(7),  
 @familyComaker int,
 @blkNoAddressFamily varchar(50),
 @streetAddressFamily varchar(50),
 @brgyAddressFamily varchar(50),
 @cityAddressFamily varchar(50)
AS  
BEGIN  
 update Comakers set memberComaker = @memberComaker, familyComaker = @familyComaker,
 blkNoAddressFamily = @blkNoAddressFamily, streetAddressFamily = @streetAddressFamily,
 brgyAddressFamily = @brgyAddressFamily, cityAddressFamily = @cityAddressFamily
 where comakerID = @comakerID  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCollateral]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateCollateral]
 @collateralID int,
 @collateralName varchar(50),  
 @collateralDescription varchar(200),  
 @loanNo char(7)  
AS  
BEGIN  
 update Collateral set collateralName = @collateralName, collateralDesc = @collateralDescription
 where collateralID = @collateralID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionInsertMember]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionInsertMember]            
  --Member Information          
  @accountNo char(7),              
  @LName varchar(50),              
  @FName varchar(50),              
  @MName varchar(50),              
  @blkNoAddress varchar(50),
  @streetAddress varchar(50),
  @brgyAddress varchar(50),
  @cityAddress varchar(50),
  @membershipDate date,              
  @birthDate date,              
  @gender char(1),              
  @telNo char(8),              
  @mobileNo char(11),              
  @emailAdd varchar(50),              
  @passportNo char(10),              
  @driverLicenseNo char(10),              
  @sssNo char(10),              
  @civilStatus varchar(50),              
  @educationalAttainment varchar(50),              
  @picture varchar(50),              
      
  --Spouse Information        
  @spouseLName varchar(50),        
  @spouseFName varchar(50),        
  @spouseMName varchar(50),        
  @spouseBirthDate date,        
      
  --Financial Information        
  @employmentStatus int,        
  @incomeSource int,        
  @employerName varchar(50),        
  @employerAddress varchar(50),  
    
  @userID int        
AS              
BEGIN                
 declare @shareID int          
 select @shareID = ISNULL(MAX(shareID),0) from ShareCapital          
 select @shareID = @shareID + 1          
      
 --Insert Member          
 insert into Member(accountNo,LName, FName, MName, memberBlkNoAddress,memberStreetAddress, memberBrgyAddress, memberCityAddress, membershipDate, birthDate, gender, telNo, mobileNo, emailAdd,passportNo, driverLicenseNo, sssNo, civilStatus, educationalAttainment, picture, isTerminated)              
 values (@accountNo,@LName, @FName, @MName, @blkNoAddress,@streetAddress,@brgyAddress,@cityAddress, @membershipDate, @birthDate, @gender, @telNo,@mobileNo, @emailAdd,@passportNo, @driverLicenseNo, @sssNo, @civilStatus, @educationalAttainment, @picture, 0)              
      
 --Insert Spouse Information       
 declare @familyID int      
 select @familyID = ISNULL(MAX(familyID),0) from Family      
 select @familyID = @familyID + 1      
     
 IF @civilStatus = 'Married'    
 BEGIN    
  insert into Family(familyID, LName, FName,MName,birthDate,relationship,isDependent,accountNo)      
  values (@familyID,@spouseLName,@spouseFName,@spouseMName,@spouseBirthDate,8,1,@accountNo)      
 END    
       
 --Insert Financial Information        
 insert into MemberFinancial values (@accountNo, @employmentStatus, @incomeSource, @employerName, @employerAddress)        
      
 --Insert Share Capital          
 insert into ShareCapital values (@shareID,@accountNo,0,0)          
   
 exec sp_TransactionShare @shareID,'D',500,'Initial share capital on membership',@userID  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionCreateTimeDeposit]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionCreateTimeDeposit]    
 @timeAccountNo char(10),    
 @amount money,    
 @termDays int,    
 @maturityInstruction int,    
 @accountNo char(7),    
 @savingsAccountNo char(10),    
 @interestID int,  
 @userID int  
AS     
BEGIN    
 IF LEN(@savingsAccountNo) = 0    
 BEGIN    
  select @savingsAccountNo = NULL    
 END    
     
 insert into TimeDepositAccount (timeAccountNo,openingDatetime,isClosed,currentBalance,maturityDate,accountNo,interestID,maturityInstruction,savingsAccountNo)     
 values( @timeAccountNo,CURRENT_TIMESTAMP,0,0,DATEADD(dd,@termDays,CURRENT_TIMESTAMP),@accountNo,@interestID,@maturityInstruction,@savingsAccountNo)    
   
 exec sp_TransactionTimeDeposit @amount,'D',@userID,@timeAccountNo  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanRelease]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanRelease]  
	@releaseType char(2),  
	@loanNo char(7),
	@userID int,
	@transactionID int OUTPUT  
AS  
BEGIN  
	
	declare @amount money
	
	select @amount = approvedAmount from Loan
	select @transactionID = ISNULL(MAX(transactionID),0) from LoanTransactions
	select @transactionID = @transactionID + 1

	update Loan set isReleased = 1, releaseCancelDatetime = CURRENT_TIMESTAMP, releaseType = @releaseType  
	where loanNo = @loanNo  
 
	insert into LoanTransactions(transactionID,transactionDatetime,amount,transactionType,loanNo,userID)
	values (@transactionID,GETDATE(),@amount,'R',@loanNo,@userID)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertAmortization]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertAmortization]      
 @baseAmount money,      
 @interest money,        
 @shareCapital money,      
 @penalty money,      
 @totalAmount money,      
 @dueDate date,      
 @loanNo char(7)      
AS      
BEGIN      
 declare @amortID int      
       
 select @amortID = ISNULL(MAX(amortID),0) from Amortization      
 select @amortID = @amortID + 1      
       
 insert into Amortization(amortID,baseAmount,interest,shareCapital,penalty,balanceAmount, totalAmount,dueDate,isPaid,isBilled, isRestructured,loanNo)      
 values (@amortID,@baseAmount,@interest,@shareCapital,@penalty,@totalAmount, @totalAmount,@dueDate,0,0,0,@loanNo)      
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertComakers]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertComakers]  
 @loanNo char(7),  
 @memberComaker char(7),  
 @familyComaker int,
 @blkNoAddressFamily varchar(50),
 @streetAddressFamily varchar(50),
 @brgyAddressFamily varchar(50),
 @cityAddressFamily varchar(50)
AS  
BEGIN  
   
 declare @nextID int  
 select @nextID = ISNULL(MAX(comakerID),0) from Comakers  
 select @nextID = @nextID + 1  
 insert into Comakers(comakerID,loanNo, memberComaker, familyComaker, blkNoAddressFamily, streetAddressFamily,brgyAddressFamily,cityAddressFamily) 
 values(@nextID, @loanNo, @memberComaker, @familyComaker, @blkNoAddressFamily, @streetAddressFamily, @brgyAddressFamily, @cityAddressFamily)  
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCollateral]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertCollateral]
	@collateralName varchar(50),
	@collateralDescription varchar(200),
	@loanNo char(7)
AS
BEGIN
	declare @nextID int
	select @nextID = ISNULL(MAX(collateralID),0)from Collateral
	select @nextID = @nextID + 1
	insert into Collateral(collateralID,collateralName,collateralDesc,loanNo)
	values (@nextID,@collateralName,@collateralDescription,@loanNo)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCheckInformation]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertCheckInformation]
	@checkNo varchar(50),
	@bankName varchar(50),
	@dateIssued date,
	@transactionID int,
	@transactionTable char(3)
AS
BEGIN
	declare @checkID int
	select @checkID = ISNULL(MAX(checkInfoID),0) from CheckInformation
	select @checkID = @checkID + 1
	
	insert into CheckInformation(checkInfoID,checkNo,bankName,dateIssued) 
	values (@checkID,@checkNo,@bankName,@dateIssued)
	
	insert into CheckTransactions (transactionID,transactionTable,checkInfoID)
	values (@transactionID,@transactionTable,@checkID)
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetAmortizationToBePaid]    Script Date: 07/06/2014 23:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetAmortizationToBePaid](@loanNo char(7), @top int)                                         
RETURNS TABLE                        
AS RETURN                        
(     
	select top(@top) A.amortID,A.dueDate, A.baseAmount, A.interest, A.shareCapital, A.penalty as PenaltyFined,A.balanceAmount,   
		(select ISNULL(SUM(X.loanPenaltyPayment),0) FROM AmortizationPaid X where X.amortID = A.amortID) as PenaltyPaid,                                             
		CASE WHEN DATEDIFF(DAY,A.dueDate, CAST(GETDATE() as date)) > c.gracePeriod*(select I.daysNo from Indicator I where I.indicatorID = C.graceTime)                        
		THEN                        
		(                                             
			CAST(DATEDIFF(DAY,A.dueDate,CAST(getdate() as date)) AS DECIMAL(19,4))/                   
			CAST((C.duration*(select I.daysNo from Indicator I where I.indicatorID = C.durationTime)) AS DECIMAL(19,4))*                  
			CASE WHEN C.isPercentage = 1                        
				 THEN cast(C.penaltyAmount/100 AS DECIMAL(19,4)) * cast(A.baseAmount AS DECIMAL(19,4))
				 
			else 
				 cast(C.penaltyAmount AS DECIMAL(19,4))
			end
			- (select ISNULL(SUM(X.loanPenaltyPayment),0) FROM AmortizationPaid X where X.amortID = A.amortID)
		) 
	ELSE 0 END as Penalty
	from Amortization A                         
	inner join Loan B on (A.loanNo = B.loanNo)                        
	left join LoanPenaltySettings C on (B.penaltyID = C.penaltyID)
	where A.isRestructured = 0 and isPaid = 0 and A.loanNo = @loanNo                      
)
GO
/****** Object:  StoredProcedure [dbo].[sp_TransactionLoanPayment]    Script Date: 07/06/2014 23:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TransactionLoanPayment]        
 --parameters        
	 @paymentAmount decimal(19,4),        
	 @noOfPeriod int,              
	 @userID int,            
	 @loanNo char(7),
	 @savingsAccountNo char(10),
	 @change decimal(19,4) OUTPUT
AS        
BEGIN     
	 --Local variable        
	 declare @nextPaymentID int        
	 declare @penaltyAmount decimal(19,4) 
	 declare @shareAmount decimal(19,4)               
	 declare @interestAmount decimal(19,4)        
	 declare @principal decimal(19,4)    
	 declare @total decimal(19,4)        
	 declare @currentBalance decimal(19,4)         
	 declare @penaltyFined decimal(19,4)      
	 declare @ctr int            
	 declare @accountNo char(7)
	 --declare @principalPayment decimal(19,4)        
	 --declare @penaltyPayment decimal(19,4) 
	 --declare @shareCapital decimal(19,4) 
	 --declare @interestPayment decimal (19,4)
	 declare @shareID int  
	 
	 --To be inserted
	 declare @loanPrincipalPayment decimal(19,4)
	 declare @loanPenaltyPayment decimal(19,4)
	 declare @loanInterestPayment decimal(19,4)
	 declare @shareCapital decimal(19,4)
	 declare @isPaid int
	      
	 select @nextPaymentID = ISNULL(MAX(paymentID),0) from LoanPayment        
	 select @nextPaymentID = @nextPaymentID + 1        
	 select @ctr = 0        
	 
	 select @accountNo = B.accountNo from Loan A inner join Member B on (A.accountNo = B.accountNo) where A.loanNo = @loanNo
	 
	 select * into #tempTable from func_GetAmortizationToBePaid(@loanNo,@noOfPeriod)        
        
	 insert into LoanPayment(paymentID,paymentAmount,paymentDatetime,accountNo,userID)        
	 values (@nextPaymentID,@paymentAmount,CURRENT_TIMESTAMP,@accountNo,@userID)        
         
	 --IF LEN(@savingsAccountNo) != 0
	 --BEGIN
		--exec sp_TransactionSavingsAccount 'W',@paymentAmount,'',@savingsAccountNo,@userID,'Withdrawal for Payment of Loan'
	 --END
		
	 WHILE (select COUNT(*) from #tempTable) > 0         
	 BEGIN        
      		select @isPaid = 0  
      		select @loanPenaltyPayment = 0, @loanPrincipalPayment = 0, @loanPenaltyPayment = 0,@shareCapital = 0         
	  		select top 1 @interestAmount = interest, @shareAmount = shareCapital, @penaltyFined = PenaltyFined,@ctr = amortID, @principal = baseAmount,@penaltyAmount = penalty,@total = (baseAmount+interest+shareCapital), @currentBalance = balanceAmount 
	  		from #tempTable  
            
      		IF @paymentAmount = 0
      		BEGIN
      			BREAK
      		END
      		
      		IF @paymentAmount > 0
      		BEGIN
      			IF @paymentAmount >= @penaltyAmount
      			BEGIN
      				--select @currentBalance = @currentBalance - @penaltyAmount
      				select @loanPenaltyPayment = @penaltyAmount
      				select @paymentAmount = @paymentAmount - @penaltyAmount
      				select @penaltyAmount = 0
      				
      			END
      			
      			ELSE
      			BEGIN
      				select @loanPenaltyPayment = @paymentAmount
      				select @penaltyAmount = @penaltyAmount - @paymentAmount
      				--select @currentBalance = @currentBalance - @paymentAmount
      				select @paymentAmount = 0
      			END
      		END
      		
      		IF @paymentAmount > 0
      		BEGIN
      			IF @paymentAmount >= @interestAmount
      			BEGIN
      				select @currentBalance = @currentBalance - @interestAmount
      				select @loanInterestPayment = @interestAmount
      				select @paymentAmount = @paymentAmount - @interestAmount
      				select @interestAmount = 0
      				
      			END
      			
      			ELSE
      			BEGIN
      				select @loanInterestPayment = @paymentAmount
      				select @interestAmount = @interestAmount - @paymentAmount
      				select @currentBalance = @currentBalance - @paymentAmount
      				select @paymentAmount = 0
      			END
      		END
      		
      		IF @paymentAmount > 0
      		BEGIN
      			IF @paymentAmount >= @principal
      			BEGIN
      				select @currentBalance = @currentBalance - @principal
      				select @loanPrincipalPayment = @principal
      				select @paymentAmount = @paymentAmount - @principal
      				select @principal = 0
      				
      			END
      			
      			ELSE
      			BEGIN
      				select @loanPrincipalPayment = @paymentAmount
      				select @principal = @principal - @paymentAmount
      				select @currentBalance = @currentBalance - @paymentAmount
      				select @paymentAmount = 0
      			END
      		END
      		
      		IF @paymentAmount > 0
      		BEGIN
      			IF @paymentAmount >= @shareAmount
      			BEGIN
      				select @currentBalance = @currentBalance - @shareAmount
      				select @shareCapital = @shareAmount
      				select @paymentAmount = @paymentAmount - @shareAmount
      				select @shareAmount = 0
      				
      			END
      			
      			ELSE
      			BEGIN
      				select @shareCapital = @paymentAmount
      				select @shareAmount = @shareAmount - @paymentAmount
      				select @currentBalance = @currentBalance - @paymentAmount
      				select @paymentAmount = 0
      			END
      		END
      		
      		IF @currentBalance < 0.01
      		BEGIN
      			select @currentBalance = 0
      			select @isPaid = 1
      		END

			--Update Amortization
			Update Amortization set baseAmount = @principal, balanceAmount = @currentBalance, isPaid = @isPaid, 
				interest = @interestAmount, shareCapital = @shareAmount
				where amortID = @ctr
			
			--Insert payments
			insert into AmortizationPaid(paymentID,amortID,loanPenaltyPayment,loanPrincipalPayment,loanInterestPayment,shareCapital)
			values (@nextPaymentID,@ctr,@loanPenaltyPayment,@loanPrincipalPayment,@loanInterestPayment,@shareCapital)
			
      		--Delete processed row from the temp table
	  	delete #tempTable where amortID = @ctr        
	 END        
	 
     select @change = @paymentAmount
 	 drop table #tempTable        
END
GO
/****** Object:  ForeignKey [FK_Amortization_Loan]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Amortization]  WITH CHECK ADD  CONSTRAINT [FK_Amortization_Loan] FOREIGN KEY([loanNo])
REFERENCES [dbo].[Loan] ([loanNo])
GO
ALTER TABLE [dbo].[Amortization] CHECK CONSTRAINT [FK_Amortization_Loan]
GO
/****** Object:  ForeignKey [FK_AmortizationPaid_Amortization]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[AmortizationPaid]  WITH CHECK ADD  CONSTRAINT [FK_AmortizationPaid_Amortization] FOREIGN KEY([amortID])
REFERENCES [dbo].[Amortization] ([amortID])
GO
ALTER TABLE [dbo].[AmortizationPaid] CHECK CONSTRAINT [FK_AmortizationPaid_Amortization]
GO
/****** Object:  ForeignKey [FK_AmortizationPaid_LoanPayment1]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[AmortizationPaid]  WITH CHECK ADD  CONSTRAINT [FK_AmortizationPaid_LoanPayment1] FOREIGN KEY([paymentID])
REFERENCES [dbo].[LoanPayment] ([paymentID])
GO
ALTER TABLE [dbo].[AmortizationPaid] CHECK CONSTRAINT [FK_AmortizationPaid_LoanPayment1]
GO
/****** Object:  ForeignKey [FK_ApplicableLoans_LoanType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ApplicableLoans]  WITH CHECK ADD  CONSTRAINT [FK_ApplicableLoans_LoanType] FOREIGN KEY([loanTypeID])
REFERENCES [dbo].[LoanType] ([loanTypeID])
GO
ALTER TABLE [dbo].[ApplicableLoans] CHECK CONSTRAINT [FK_ApplicableLoans_LoanType]
GO
/****** Object:  ForeignKey [FK_ApplicableLoans_MemberType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ApplicableLoans]  WITH CHECK ADD  CONSTRAINT [FK_ApplicableLoans_MemberType] FOREIGN KEY([memberTypeID])
REFERENCES [dbo].[MemberType] ([memberTypeID])
GO
ALTER TABLE [dbo].[ApplicableLoans] CHECK CONSTRAINT [FK_ApplicableLoans_MemberType]
GO
/****** Object:  ForeignKey [FK_ChargedFromLoans_Charge]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ChargedFromLoans]  WITH CHECK ADD  CONSTRAINT [FK_ChargedFromLoans_Charge] FOREIGN KEY([chargeID])
REFERENCES [dbo].[Charge] ([chargeID])
GO
ALTER TABLE [dbo].[ChargedFromLoans] CHECK CONSTRAINT [FK_ChargedFromLoans_Charge]
GO
/****** Object:  ForeignKey [FK_ChargedFromLoans_Loan]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ChargedFromLoans]  WITH CHECK ADD  CONSTRAINT [FK_ChargedFromLoans_Loan] FOREIGN KEY([loanNo])
REFERENCES [dbo].[Loan] ([loanNo])
GO
ALTER TABLE [dbo].[ChargedFromLoans] CHECK CONSTRAINT [FK_ChargedFromLoans_Loan]
GO
/****** Object:  ForeignKey [FK_CheckTransactions_CheckInformation]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[CheckTransactions]  WITH CHECK ADD  CONSTRAINT [FK_CheckTransactions_CheckInformation] FOREIGN KEY([checkInfoID])
REFERENCES [dbo].[CheckInformation] ([checkInfoID])
GO
ALTER TABLE [dbo].[CheckTransactions] CHECK CONSTRAINT [FK_CheckTransactions_CheckInformation]
GO
/****** Object:  ForeignKey [FK_CheckTransactions_LoanTransactions]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[CheckTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_CheckTransactions_LoanTransactions] FOREIGN KEY([transactionID])
REFERENCES [dbo].[LoanTransactions] ([transactionID])
GO
ALTER TABLE [dbo].[CheckTransactions] NOCHECK CONSTRAINT [FK_CheckTransactions_LoanTransactions]
GO
/****** Object:  ForeignKey [FK_CheckTransactions_SavingsTransaction]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[CheckTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_CheckTransactions_SavingsTransaction] FOREIGN KEY([transactionID])
REFERENCES [dbo].[SavingsTransaction] ([transactionID])
GO
ALTER TABLE [dbo].[CheckTransactions] NOCHECK CONSTRAINT [FK_CheckTransactions_SavingsTransaction]
GO
/****** Object:  ForeignKey [FK_CheckTransactions_TimeDepositTransaction]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[CheckTransactions]  WITH NOCHECK ADD  CONSTRAINT [FK_CheckTransactions_TimeDepositTransaction] FOREIGN KEY([transactionID])
REFERENCES [dbo].[TimeDepositTransaction] ([transactionID])
GO
ALTER TABLE [dbo].[CheckTransactions] NOCHECK CONSTRAINT [FK_CheckTransactions_TimeDepositTransaction]
GO
/****** Object:  ForeignKey [FK_Collateral_Loan]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Collateral]  WITH CHECK ADD  CONSTRAINT [FK_Collateral_Loan] FOREIGN KEY([loanNo])
REFERENCES [dbo].[Loan] ([loanNo])
GO
ALTER TABLE [dbo].[Collateral] CHECK CONSTRAINT [FK_Collateral_Loan]
GO
/****** Object:  ForeignKey [FK_Comakers_Family]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Comakers]  WITH CHECK ADD  CONSTRAINT [FK_Comakers_Family] FOREIGN KEY([familyComaker])
REFERENCES [dbo].[Family] ([familyID])
GO
ALTER TABLE [dbo].[Comakers] CHECK CONSTRAINT [FK_Comakers_Family]
GO
/****** Object:  ForeignKey [FK_Comakers_Loan]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Comakers]  WITH CHECK ADD  CONSTRAINT [FK_Comakers_Loan] FOREIGN KEY([loanNo])
REFERENCES [dbo].[Loan] ([loanNo])
GO
ALTER TABLE [dbo].[Comakers] CHECK CONSTRAINT [FK_Comakers_Loan]
GO
/****** Object:  ForeignKey [FK_Comakers_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Comakers]  WITH CHECK ADD  CONSTRAINT [FK_Comakers_Member] FOREIGN KEY([memberComaker])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[Comakers] CHECK CONSTRAINT [FK_Comakers_Member]
GO
/****** Object:  ForeignKey [FK_Dormancy_SavingsType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Dormancy]  WITH CHECK ADD  CONSTRAINT [FK_Dormancy_SavingsType] FOREIGN KEY([savingsTypeID])
REFERENCES [dbo].[SavingsType] ([savingsTypeID])
GO
ALTER TABLE [dbo].[Dormancy] CHECK CONSTRAINT [FK_Dormancy_SavingsType]
GO
/****** Object:  ForeignKey [FK_Family_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Family]  WITH CHECK ADD  CONSTRAINT [FK_Family_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[Family] CHECK CONSTRAINT [FK_Family_Member]
GO
/****** Object:  ForeignKey [FK_FamilyAccountHolder_Family]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[FamilyAccountHolder]  WITH CHECK ADD  CONSTRAINT [FK_FamilyAccountHolder_Family] FOREIGN KEY([familyID])
REFERENCES [dbo].[Family] ([familyID])
GO
ALTER TABLE [dbo].[FamilyAccountHolder] CHECK CONSTRAINT [FK_FamilyAccountHolder_Family]
GO
/****** Object:  ForeignKey [FK_FamilyAccountHolder_SavingsAccount]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[FamilyAccountHolder]  WITH CHECK ADD  CONSTRAINT [FK_FamilyAccountHolder_SavingsAccount] FOREIGN KEY([savingsAccountNo])
REFERENCES [dbo].[SavingsAccount] ([savingsAccountNo])
GO
ALTER TABLE [dbo].[FamilyAccountHolder] CHECK CONSTRAINT [FK_FamilyAccountHolder_SavingsAccount]
GO
/****** Object:  ForeignKey [FK_Loan_LoanPenaltyHistory]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_LoanPenaltyHistory] FOREIGN KEY([penaltyID])
REFERENCES [dbo].[LoanPenaltySettings] ([penaltyID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_LoanPenaltyHistory]
GO
/****** Object:  ForeignKey [FK_Loan_LoanRates]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_LoanRates] FOREIGN KEY([loanRatesID])
REFERENCES [dbo].[LoanRates] ([loanRatesID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_LoanRates]
GO
/****** Object:  ForeignKey [FK_Loan_LoanType1]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_LoanType1] FOREIGN KEY([loanTypeID])
REFERENCES [dbo].[LoanType] ([loanTypeID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_LoanType1]
GO
/****** Object:  ForeignKey [FK_Loan_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Member]
GO
/****** Object:  ForeignKey [FK_Loan_ShareCapital]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_ShareCapital] FOREIGN KEY([shareID])
REFERENCES [dbo].[ShareCapital] ([shareID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_ShareCapital]
GO
/****** Object:  ForeignKey [FK_Loan_User]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_User] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_User]
GO
/****** Object:  ForeignKey [FK_LoanCharges_Charge]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanCharges]  WITH CHECK ADD  CONSTRAINT [FK_LoanCharges_Charge] FOREIGN KEY([chargeID])
REFERENCES [dbo].[Charge] ([chargeID])
GO
ALTER TABLE [dbo].[LoanCharges] CHECK CONSTRAINT [FK_LoanCharges_Charge]
GO
/****** Object:  ForeignKey [FK_LoanCharges_LoanType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanCharges]  WITH CHECK ADD  CONSTRAINT [FK_LoanCharges_LoanType] FOREIGN KEY([loanTypeID])
REFERENCES [dbo].[LoanType] ([loanTypeID])
GO
ALTER TABLE [dbo].[LoanCharges] CHECK CONSTRAINT [FK_LoanCharges_LoanType]
GO
/****** Object:  ForeignKey [FK_LoanPayment_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanPayment]  WITH CHECK ADD  CONSTRAINT [FK_LoanPayment_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[LoanPayment] CHECK CONSTRAINT [FK_LoanPayment_Member]
GO
/****** Object:  ForeignKey [FK_LoanPayment_User]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanPayment]  WITH CHECK ADD  CONSTRAINT [FK_LoanPayment_User] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[LoanPayment] CHECK CONSTRAINT [FK_LoanPayment_User]
GO
/****** Object:  ForeignKey [FK_LoanPenaltySettings_LoanType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanPenaltySettings]  WITH CHECK ADD  CONSTRAINT [FK_LoanPenaltySettings_LoanType] FOREIGN KEY([loanTypeID])
REFERENCES [dbo].[LoanType] ([loanTypeID])
GO
ALTER TABLE [dbo].[LoanPenaltySettings] CHECK CONSTRAINT [FK_LoanPenaltySettings_LoanType]
GO
/****** Object:  ForeignKey [FK_LoanRates_LoanType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanRates]  WITH CHECK ADD  CONSTRAINT [FK_LoanRates_LoanType] FOREIGN KEY([loanTypeID])
REFERENCES [dbo].[LoanType] ([loanTypeID])
GO
ALTER TABLE [dbo].[LoanRates] CHECK CONSTRAINT [FK_LoanRates_LoanType]
GO
/****** Object:  ForeignKey [FK_LoanTransactions_Loan]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactions_Loan] FOREIGN KEY([loanNo])
REFERENCES [dbo].[Loan] ([loanNo])
GO
ALTER TABLE [dbo].[LoanTransactions] CHECK CONSTRAINT [FK_LoanTransactions_Loan]
GO
/****** Object:  ForeignKey [FK_LoanTransactions_Users]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[LoanTransactions]  WITH CHECK ADD  CONSTRAINT [FK_LoanTransactions_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[LoanTransactions] CHECK CONSTRAINT [FK_LoanTransactions_Users]
GO
/****** Object:  ForeignKey [FK_Member_MemberType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberType] FOREIGN KEY([memberTypeID])
REFERENCES [dbo].[MemberType] ([memberTypeID])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_Member_MemberType]
GO
/****** Object:  ForeignKey [FK_MemberAccountHolder_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[MemberAccountHolder]  WITH CHECK ADD  CONSTRAINT [FK_MemberAccountHolder_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[MemberAccountHolder] CHECK CONSTRAINT [FK_MemberAccountHolder_Member]
GO
/****** Object:  ForeignKey [FK_MemberAccountHolder_SavingsAccount]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[MemberAccountHolder]  WITH CHECK ADD  CONSTRAINT [FK_MemberAccountHolder_SavingsAccount] FOREIGN KEY([savingsAccountNo])
REFERENCES [dbo].[SavingsAccount] ([savingsAccountNo])
GO
ALTER TABLE [dbo].[MemberAccountHolder] CHECK CONSTRAINT [FK_MemberAccountHolder_SavingsAccount]
GO
/****** Object:  ForeignKey [FK_MemberFinancial_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[MemberFinancial]  WITH CHECK ADD  CONSTRAINT [FK_MemberFinancial_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[MemberFinancial] CHECK CONSTRAINT [FK_MemberFinancial_Member]
GO
/****** Object:  ForeignKey [FK_SavingsAccount_SavingsType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[SavingsAccount]  WITH CHECK ADD  CONSTRAINT [FK_SavingsAccount_SavingsType] FOREIGN KEY([savingsTypeID])
REFERENCES [dbo].[SavingsType] ([savingsTypeID])
GO
ALTER TABLE [dbo].[SavingsAccount] CHECK CONSTRAINT [FK_SavingsAccount_SavingsType]
GO
/****** Object:  ForeignKey [FK_SavingsTransaction_SavingsAccount]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[SavingsTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SavingsTransaction_SavingsAccount] FOREIGN KEY([savingsAccountNo])
REFERENCES [dbo].[SavingsAccount] ([savingsAccountNo])
GO
ALTER TABLE [dbo].[SavingsTransaction] CHECK CONSTRAINT [FK_SavingsTransaction_SavingsAccount]
GO
/****** Object:  ForeignKey [FK_SavingsTransaction_Users1]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[SavingsTransaction]  WITH CHECK ADD  CONSTRAINT [FK_SavingsTransaction_Users1] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[SavingsTransaction] CHECK CONSTRAINT [FK_SavingsTransaction_Users1]
GO
/****** Object:  ForeignKey [FK_ShareCapital_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ShareCapital]  WITH CHECK ADD  CONSTRAINT [FK_ShareCapital_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[ShareCapital] CHECK CONSTRAINT [FK_ShareCapital_Member]
GO
/****** Object:  ForeignKey [FK_ShareTransaction_ShareCapital]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ShareTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ShareTransaction_ShareCapital] FOREIGN KEY([shareID])
REFERENCES [dbo].[ShareCapital] ([shareID])
GO
ALTER TABLE [dbo].[ShareTransaction] CHECK CONSTRAINT [FK_ShareTransaction_ShareCapital]
GO
/****** Object:  ForeignKey [FK_ShareTransaction_Users]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[ShareTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ShareTransaction_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[ShareTransaction] CHECK CONSTRAINT [FK_ShareTransaction_Users]
GO
/****** Object:  ForeignKey [FK_Spouse_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Spouse]  WITH CHECK ADD  CONSTRAINT [FK_Spouse_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[Spouse] CHECK CONSTRAINT [FK_Spouse_Member]
GO
/****** Object:  ForeignKey [FK_TimeDepositAccount_Member]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositAccount]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositAccount_Member] FOREIGN KEY([accountNo])
REFERENCES [dbo].[Member] ([accountNo])
GO
ALTER TABLE [dbo].[TimeDepositAccount] CHECK CONSTRAINT [FK_TimeDepositAccount_Member]
GO
/****** Object:  ForeignKey [FK_TimeDepositAccount_SavingsAccount]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositAccount]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositAccount_SavingsAccount] FOREIGN KEY([savingsAccountNo])
REFERENCES [dbo].[SavingsAccount] ([savingsAccountNo])
GO
ALTER TABLE [dbo].[TimeDepositAccount] CHECK CONSTRAINT [FK_TimeDepositAccount_SavingsAccount]
GO
/****** Object:  ForeignKey [FK_TimeDepositAccount_TimeDepositInterest]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositAccount]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositAccount_TimeDepositInterest] FOREIGN KEY([interestID])
REFERENCES [dbo].[TimeDepositInterest] ([interestID])
GO
ALTER TABLE [dbo].[TimeDepositAccount] CHECK CONSTRAINT [FK_TimeDepositAccount_TimeDepositInterest]
GO
/****** Object:  ForeignKey [FK_TimeDepositAccount_TimeDepositPenalty]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositAccount]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositAccount_TimeDepositPenalty] FOREIGN KEY([penaltyID])
REFERENCES [dbo].[TimeDepositPenalty] ([penaltyID])
GO
ALTER TABLE [dbo].[TimeDepositAccount] CHECK CONSTRAINT [FK_TimeDepositAccount_TimeDepositPenalty]
GO
/****** Object:  ForeignKey [FK_TimeDepositInterest_TimeDepositRates]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositInterest]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositInterest_TimeDepositRates] FOREIGN KEY([timeRateID])
REFERENCES [dbo].[TimeDepositRates] ([timeRateID])
GO
ALTER TABLE [dbo].[TimeDepositInterest] CHECK CONSTRAINT [FK_TimeDepositInterest_TimeDepositRates]
GO
/****** Object:  ForeignKey [FK_TimeDepositTransaction_TimeDepositAccount]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositTransaction]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositTransaction_TimeDepositAccount] FOREIGN KEY([timeAccountNo])
REFERENCES [dbo].[TimeDepositAccount] ([timeAccountNo])
GO
ALTER TABLE [dbo].[TimeDepositTransaction] CHECK CONSTRAINT [FK_TimeDepositTransaction_TimeDepositAccount]
GO
/****** Object:  ForeignKey [FK_TimeDepositTransaction_Users]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[TimeDepositTransaction]  WITH CHECK ADD  CONSTRAINT [FK_TimeDepositTransaction_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[TimeDepositTransaction] CHECK CONSTRAINT [FK_TimeDepositTransaction_Users]
GO
/****** Object:  ForeignKey [FK_User_UserType]    Script Date: 07/06/2014 23:39:53 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_UserType] FOREIGN KEY([userTypeID])
REFERENCES [dbo].[UserType] ([userTypeID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_UserType]
GO
