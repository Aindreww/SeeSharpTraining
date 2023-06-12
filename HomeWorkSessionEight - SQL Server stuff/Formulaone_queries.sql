USE Formulaone
GO

INSERT INTO Teams (team_id, team_name)
VALUES (1, 'Mercedes'),
       (2, 'Red Bull'),
       (3, 'Ferrari');

INSERT INTO Drivers (driver_id, driver_name, team_id)
VALUES (1, 'Lewis Hamilton', 1),
       (2, 'Max Verstappen', 2),
       (3, 'Charles Leclerc', 3);

/* INSERT INTO Drivers (driver_id, driver_name, team_id)
VALUES
		(3, 'Charles Leclerc', 3);
		*/

INSERT INTO Races (race_id, race_name)
VALUES (1, 'Monaco Grand Prix'),
       (2, 'Italian Grand Prix');

INSERT INTO Race_Results (result_id, race_id, driver_id, position)
VALUES (1, 1, 1, 1),
       (2, 1, 2, 2),
       (3, 1, 3, 3),
       (4, 2, 1, 2),
       (5, 2, 2, 1);

 GO

 SELECT Drivers.driver_name
FROM Drivers
JOIN Teams ON Drivers.team_id = Teams.team_id
WHERE Teams.team_name = 'Mercedes';

SELECT Races.race_name, Race_Results.position
FROM Race_Results
JOIN Races ON Race_Results.race_id = Races.race_id
JOIN Drivers ON Race_Results.driver_id = Drivers.driver_id
WHERE Drivers.driver_name = 'Lewis Hamilton';

SELECT * FROM Drivers ORDER BY driver_id;

SELECT * FROM Teams ORDER BY Team_id;

SELECT * FROM Races ORDER BY race_id;

SELECT * FROM Race_Results ORDER BY race_id;

SELECT CONCAT(Drivers.driver_name, ' - ', Teams.team_name) AS driver_info
FROM Drivers
JOIN Teams ON Drivers.team_id = Teams.team_id;

UPDATE Race_Results
SET driver_id = NULL
WHERE driver_id = 3;

DELETE FROM Drivers
WHERE driver_id = 3;
