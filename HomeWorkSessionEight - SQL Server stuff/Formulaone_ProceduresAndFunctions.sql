USE Formulaone
GO

--get the total number of drivers in a specific team
CREATE PROCEDURE GetDriverCountByTeam 
    @teamName VARCHAR(100),
    @driverCount INT OUTPUT
AS
BEGIN
    SELECT @driverCount = COUNT(*)
    FROM Drivers
    JOIN Teams ON Drivers.team_id = Teams.team_id
    WHERE Teams.team_name = @teamName;
END;

--DROP PROCEDURE GetDriverCountByTeam;

GO

--calculate the average race result for a specific team
CREATE FUNCTION GetAverageRaceResult
    (@teamName VARCHAR(100))
RETURNS FLOAT
AS
BEGIN
    DECLARE @avgRaceResult FLOAT;
    SELECT @avgRaceResult = AVG(Race_Results.position)
    FROM Race_Results
    JOIN Drivers ON Race_Results.driver_id = Drivers.driver_id
    JOIN Teams ON Drivers.team_id = Teams.team_id
    WHERE Teams.team_name = @teamName;

    RETURN @avgRaceResult;
END;

--DROP FUNCTION GetAverageRaceResult;

GO

SELECT * FROM GetDriverCountByTeam('Mercedes');
