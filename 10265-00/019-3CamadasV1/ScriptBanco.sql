USE MASTER 

IF EXISTS (SELECT * FROM SYS.DATABASES WHERE NAME = 'DADOS')
	DROP DATABASE DADOS
	
CREATE DATABASE DADOS
GO

USE DADOS

CREATE TABLE PESSOA 
(
	PESSOA_ID INT IDENTITY PRIMARY KEY, 
	PESSOA_NOME VARCHAR(50), 
	PESSOA_SEXO CHAR(1)
)

INSERT 
	PESSOA
VALUES 
	('AD�O', 'M'), 
	('EVA', 'F'), 
	('CAIM', 'M'), 
	('ABEL', 'M')
	
