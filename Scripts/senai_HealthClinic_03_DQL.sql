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
--- Nome da Clinica ----------------
--- Nome do Paciente -------------------
--- Nome do Medico -----------------
--- Especialidade do Medico --------------------------
--- CRM ----------------------
--- Prontu�rio ou Descricao
--- FeedBack(Comentario da consulta)

SELECT 
    Consulta.IdConsulta, 
    Consulta.DataConsulta AS [Data Consulta], 
    CONVERT(VARCHAR(8), Consulta.HorarioConsulta) AS [Hor�rio Consulta],
    Clinica.NomeFantasia AS Cl�nica,
    UsuarioPaciente.NomeUsuario AS [Nome do paciente], 
    UsuarioMedico.NomeUsuario AS [Nome do m�dico], 
    Especialidade.NomeEspecialidade AS Especialidade,
    Medico.CRM,
    Consulta.Prontuario AS Prontu�rio,
    ISNULL(Comentario.Feedback, 'Nenhum coment�rio') AS Coment�rio
FROM Consulta
INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.IdPaciente
INNER JOIN Usuario AS UsuarioPaciente ON Paciente.IdUsuario = UsuarioPaciente.IdUsuario
INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Usuario AS UsuarioMedico ON Medico.IdUsuario = UsuarioMedico.IdUsuario
INNER JOIN Especialidade ON Consulta.IdEspecialidade = Especialidade.IdEspecialidade
LEFT JOIN Comentario ON Consulta.IdConsulta = Comentario.IdConsulta
INNER JOIN Clinica ON Medico.IdClinica = Clinica.IdClinica;