/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Question_no]
      ,[Q_Statment]
      ,[Option_A]
      ,[Option_B]
      ,[Selected]
  FROM [Quiz_App].[dbo].[Question]