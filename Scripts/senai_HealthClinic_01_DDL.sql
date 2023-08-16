CREATE DATABASE Health_Clinic_J�lia

CREATE TABLE TipoDeUsuario
(
  IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
  Tipo VARCHAR(20) NOT NULL UNIQUE
)

CREATE TABLE Usuario
(
  IdUsuario INT PRIMARY KEY IDENTITY,
  IdTipoDeUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
  NomeUsuario VARCHAR(100) NOT NULL,
  Email VARCHAR(256) NOT NULL,
  Senha VARCHAR(100) NOT NULL 
)

CREATE TABLE Paciente
(
  IdPaciente INT PRIMARY KEY IDENTITY,
  IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL UNIQUE,
  RG VARCHAR(9) NOT NULL UNIQUE,
  CPF VARCHAR(11) NOT NULL UNIQUE,
  DataNascimento DATE NOT NULL, 
  Telefone VARCHAR(15) 
)

CREATE TABLE Especialidade
(
  IdEspecialidade INT PRIMARY KEY IDENTITY,
  NomeEspecialidade VARCHAR(100) NOT NULL
)

CREATE TABLE Clinica 
(
  IdClinica INT PRIMARY KEY IDENTITY,
  NomeFantasia VARCHAR(100) NOT NULL,
  Endereco VARCHAR(200) NOT NULL,
  CNPJ VARCHAR(14) NOT NULL UNIQUE,
  [Site] VARCHAR(100),
  HorarioAbertura TIME NOT NULL, 
  HorarioFechamento TIME NOT NULL
)

CREATE TABLE Medico
(
  IdMedico INT PRIMARY KEY IDENTITY,
  IdClinica INT FOREIGN KEY REFERENCES Clinica (IdClinica),
  IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario),
  CRM VARCHAR(6) NOT NULL UNIQUE
)

CREATE TABLE MedEspecialidade
(
  IdMedEspecialidade INT PRIMARY KEY IDENTITY,
  IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
  IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade)
)

CREATE TABLE Comentario
(
  IdComentario INT PRIMARY KEY IDENTITY,
  IdPaciente INT FOREIGN KEY REFERENCES Paciente (IdPaciente),
  Avaliacao VARCHAR(256) NOT NULL
)

CREATE TABLE Consulta 
(
  IdConsulta INT PRIMARY KEY IDENTITY,
  IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente),
  IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
  IdComentario INT FOREIGN KEY REFERENCES Comentario (IdComentario),
  DataConsulta DATE NOT NULL,
  HorarioConsulta TIME NOT NULL,
  Prontuario VARCHAR(256) NOT NULL 
)
