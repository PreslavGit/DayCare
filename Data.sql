
INSERT INTO Parents (FirstName, LastName, Email, Phone) 
VALUES 
    ('�������', '������', 'dimitar.petrov@gmail.com', '0898497681'),
    ('����', '������', 'i.ivanov@abv.bg', '0887654321'),
    ('�����', '��������', 'pet.g78@gmail.com', '0897890123'),
    ('�������', '�������', 'mariana89@abv.bg', '0987654320'),
    ('�����', '���������', 'el.dimitrova@gmail.com', '0884567890'),
    ('������', '�������', 'teodor.todorov@gmail.com', '0887109876'),
    ('�����', '�������', 'petar.stoyanov@gmail.com', '0875432109'),
    ('����-�����', '���������', 'ana.georgieva@abv.bg', '0893210987'),
    ('������', '������', 'milena.ilieva@abv.bg', '0886543210'),
    ('������', '�������', 'nikola.nikolov@gmail.com', '0892876543');


INSERT INTO Relatives (ParentID, Relation, Phone) 
VALUES 
    (1, '����', '0876543210'),
    (2, '����', '0123456789'),
    (3, '����', '0888567890'),
    (4, '����', '0898678901'),
    (5, '������', '0895789012'),
    (6, '����', '0888890123'),
    (7, '����', '0888901234'),
    (8, '�������', '0889012345'),
    (9, '����', '0878903456'),
    (10, '�������', '0890823474');


INSERT INTO Children (ParentID, FirstName, LastName, Age, Grade, Info, Meals) 
VALUES 
    (1, '�����', '�������', 14, 7, '���������� �� ������ ���������', 1),
    (2, '�������', '������', 7, 1, '�� �� �� �� ���� ������� ����� �������', 4),
    (3, '�����', '���������', 8, 2, '', 3),
    (4, '������', '������', 11, 5, '�� �� ����� ������� �� ��������', 5),
	(4, '�����', '������', 8, 2, '', 1),
    (5, '�����', '������', 9, 3, '', 2),
    (6, '������', '�������', 8, 2, '�� �� �� ���� ������ = �� ����', 5),
    (7, '����', '��������', 10, 4, '', 4),
    (8, '����', '��������', 6, 1, '������ � ������� ��� ����� ��� � ����� ���� 12�.', 5),
    (9, '�����', '������', 8, 2, '', 2),
    (10, '�������', '�������', 13, 7, '���������� �� ������ ���������', 3),
	(10, '������', '��������', 7, 1, '', 1);


INSERT INTO Payments (ChildID, StartDate, EndDate) 
VALUES 
    (1, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 2, GETDATE())),
    (2, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE())),
    (3, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 2, GETDATE())),
    (4, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE())),
    (5, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 2, GETDATE())),
    (6, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 2, GETDATE())),
    (7, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 2, GETDATE())),
    (8, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE())),
    (9, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 3, GETDATE())),
    (10, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE())),
	(11, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE())),
	(12, DATEADD(DAY, -15, GETDATE()), DATEADD(MONTH, 1, GETDATE()));


INSERT INTO Attendance (ChildID, Date) 
VALUES 
    (1, GETDATE()),
    (2, GETDATE()),
    (3, GETDATE()),
    (4, GETDATE()),
    (5, GETDATE()),
    (6, GETDATE()),
    (7, GETDATE()),
    (8, GETDATE()),
    (9, GETDATE()),
    (10, GETDATE()),
    (11, GETDATE()),
    (12, GETDATE());

INSERT INTO Attendance (ChildID, Date) 
VALUES 
    (1, DATEADD(DAY, -1, GETDATE())),
    (2, DATEADD(DAY, -1, GETDATE())),
    (4, DATEADD(DAY, -1, GETDATE())),
    (7, DATEADD(DAY, -1, GETDATE())),
    (9, DATEADD(DAY, -1, GETDATE()));


INSERT INTO Attendance (ChildID, Date) 
VALUES 
    (1, DATEADD(DAY, -2, GETDATE())),
    (2, DATEADD(DAY, -2, GETDATE())),
    (7, DATEADD(DAY, -2, GETDATE()));
