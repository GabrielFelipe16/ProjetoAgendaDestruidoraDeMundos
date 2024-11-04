CREATE DATABASE IF NOT EXISTS dbagenda;
USE dbagenda;
CREATE TABLE IF NOT EXISTS usuarios(
	idUsuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(45) NOT NULL,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);