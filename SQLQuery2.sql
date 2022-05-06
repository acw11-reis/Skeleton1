USE [p2500575]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_Table77_SelectAll]

SELECT	@return_value as 'Return Value'

GO
