INSERT INTO TipoDeUsuario (Tipo)
VALUES ('Administrador'), ('Médico'), ('Paciente');

INSERT INTO Usuario (IdTipoDeUsuario, NomeUsuario, Email, Senha)
VALUES (1, 'Lucas Pereira', 'lucaspereira@gmail.com', 'lucas123'),
       (2, 'Júlia Aben-Athar', 'julia8@gmail.com', 'julia777'),
	   (2, 'Raphaela Ranyol', 'raphaela.ra@gmail.com', 'nWQa2o1'),
	   (2, 'Guilherme Cordeiro', 'guicord@gmail.com', 'cordeiro12034'),
	   (3,'Carlos Roque', 'carlosrq2@gmail.com', 'roque23'),
	   (3,'Eduardo Costa', 'ducosta@gmail.com', 'Ns3JBs9'),
	   (3,'Henrique Gomes', 'gomesHQ12@gmail', 'henrique123gm');

INSERT INTO Paciente (IdUsuario, RG, CPF, DataNascimento, Telefone)	
VALUES (5, '12.345.678-9', '123.456.789-09', '08-01-1985', '(11) 98765-6714'),
       (6, '32.973.823-6', '844.836.243-09', '21-07-1980', '(11) 97264-9284'),
	   (7, '93.234.093-2', '737.827.298-46', '08-08-1988', '(11) 98274-9272');

INSERT INTO Especialidade (NomeEspecialidade)
VALUES ('Cardiologista'),
       ('Psiquiatra'),
	   ('Pediatra'),
	   ('Ortopedista');

INSERT INTO Clinica (NomeFantasia, Endereco, CNPJ, [Site], HorarioAbertura, HorarioFechamento)
VALUES ('Health Clinic', 'Av Paulista, 1200, Jd Paulista, São Paulo', '89.478.454/0001-09', 'healthclinic.com.br', '06:30:00', '20:30:00');

INSERT INTO Medico (IdClinica, IdUsuario, CRM)
VALUES (1, 2, 'CRM/SP123456'),
       (1, 3, 'CRM/SP093645'),
	   (1, 4, 'CRM/SP353489');

INSERT INTO MedEspecialidade (IdMedico, IdEspecialidade)
VALUES (1, 2),
       (2, 1),
	   (3, 3),
	   (3, 4);

INSERT INTO Comentario (IdPaciente, FeedBack)
VALUES (1, 'Gostei muito do atendimento. Fiquei muito satisfeito com a clínica e pretendo fazer meu acompanhamento aqui!'),
       (2, 'Não gostei da clínica, cheguei adiantado e ainda assim tive que ficar esperando masi de 2 horas pois o médico se atrasou.'),
	   (3, 'Clínica boa. Satisfeito.')

INSERT INTO Consulta (IdPaciente, IdMedico, DataConsulta, HorarioConsulta, Prontuario)
VALUES (2, 1, '20-10-2023', '08:30:00', 'Paciente alterado em consultório. Medicação aumentada para 200mg por dia. 100mg antes do almoço e 100mg antes de adormecer.'),
       (1, 2, '01-10-2023', '07:00:00', 'Paciente saudável, consulta apenas para exame de rotina. Resultado do eletrocardiograma dentro da normalidade, nenhuma alteração.'),
	   (3, 3, '15-10-2023', '18:00:00', 'Paciente com lesão no menisco, recuperação demorada. Receitada uso de anti-inflamatório e repouso absoluto. Deverá retornar em 10 dias.')