USE master
IF EXISTS(SELECT * FROM sys.databases WHERE NAME='Formulaone')
	DROP DATABASE Formulaone
CREATE DATABASE Formulaone

GO

USE Formulaone
Go

CREATE TABLE Teams (
    team_id INT PRIMARY KEY,
    team_name VARCHAR(100)
);
go

CREATE TABLE Drivers (
    driver_id INT PRIMARY KEY,
    driver_name VARCHAR(100),
    team_id INT,
    FOREIGN KEY (team_id) REFERENCES Teams(team_id)
);
go

CREATE TABLE Races (
    race_id INT PRIMARY KEY,
    race_name VARCHAR(100)
);
go

CREATE TABLE Race_Results (
    result_id INT PRIMARY KEY,
    race_id INT,
    driver_id INT,
    position INT,
    FOREIGN KEY (race_id) REFERENCES Races(race_id),
    FOREIGN KEY (driver_id) REFERENCES Drivers(driver_id)
);