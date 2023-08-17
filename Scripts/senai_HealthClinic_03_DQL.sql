SELECT * FROM Clinica
SELECT * FROM Comentario
SELECT * FROM Consulta
SELECT * FROM Especialidade
SELECT * FROM MedEspecialidade
SELECT * FROM Medico
SELECT * FROM Paciente
SELECT * FROM TipoDeUsuario
SELECT * FROM Usuario

--- Id Consulta ------------------
--- Data da Consulta ---------------
--- Horario da Consulta --------------------------
--- Nome da Clinica
--- Nome do Paciente -------------------
--- Nome do Medico -----------------
--- Especialidade do Medico
--- CRM ----------------------
--- Prontuário ou Descricao
--- FeedBack(Comentario da consulta)

SELECT 
    Consulta.IdConsulta, 
    UsuarioPaciente.NomeUsuario AS [Nome do paciente], 
    UsuarioMedico.NomeUsuario AS [Nome do médico],
	Medico.CRM,
	Consulta.DataConsulta AS [Data da consulta],
    CONVERT(VARCHAR(8), Consulta.HorarioConsulta) AS Horario
FROM Consulta
INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.IdPaciente
INNER JOIN Usuario AS UsuarioPaciente ON Paciente.IdUsuario = UsuarioPaciente.IdUsuario
INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Usuario AS UsuarioMedico ON Medico.IdUsuario = UsuarioMedico.IdUsuario;