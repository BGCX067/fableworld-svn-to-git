-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [CHARACTER_PKG.CREATE]
(
	@name nvarchar(50),
	@race_id int,
	@class_id int,
	@account_id int	
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [character] (name, race_id, class_id, is_male, [str], dex, con, sta, agi, [int], wis, ac, thaco, hp, [level], xp, account_id)
	VALUES (@name, @race_id, @class_id, 1, 12, 12, 12, 12, 12, 12, 12, 10, 15, 10, 1, 0, @account_id);
	
END
GO
