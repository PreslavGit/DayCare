
INSERT INTO Parents (FirstName, LastName, Email, Phone) 
VALUES 
    ('Димитър', 'Петров', 'dimitar.petrov@gmail.com', '0898497681'),
    ('Иван', 'Иванов', 'i.ivanov@abv.bg', '0887654321'),
    ('Петър', 'Георгиев', 'pet.g78@gmail.com', '0897890123'),
    ('Мариана', 'Павлова', 'mariana89@abv.bg', '0987654320'),
    ('Елена', 'Димитрова', 'el.dimitrova@gmail.com', '0884567890'),
    ('Теодор', 'Тодоров', 'teodor.todorov@gmail.com', '0887109876'),
    ('Петър', 'Стоянов', 'petar.stoyanov@gmail.com', '0875432109'),
    ('Анна-Мария', 'Георгиева', 'ana.georgieva@abv.bg', '0893210987'),
    ('Милена', 'Илиева', 'milena.ilieva@abv.bg', '0886543210'),
    ('Никола', 'Николов', 'nikola.nikolov@gmail.com', '0892876543');


INSERT INTO Relatives (ParentID, Relation, Phone) 
VALUES 
    (1, 'Чичо', '0876543210'),
    (2, 'Леля', '0123456789'),
    (3, 'Дядо', '0888567890'),
    (4, 'Баба', '0898678901'),
    (5, 'Сестра', '0895789012'),
    (6, 'Леля', '0888890123'),
    (7, 'Баба', '0888901234'),
    (8, 'Бавачка', '0889012345'),
    (9, 'Дядо', '0878903456'),
    (10, 'Бавачка', '0890823474');


INSERT INTO Children (ParentID, FirstName, LastName, Age, Grade, Info, Meals) 
VALUES 
    (1, 'Мария', 'Петрова', 14, 7, 'Подготовка за Външно оценяване', 1),
    (2, 'Николай', 'Иванов', 7, 1, 'Да не му се дава телефон преди домашни', 4),
    (3, 'Мариа', 'Георгиева', 8, 2, '', 3),
    (4, 'Стефан', 'Павлов', 11, 5, 'Да не гледа клипове на телефона', 5),
	(4, 'Стоил', 'Павлов', 8, 2, '', 1),
    (5, 'София', 'Илиева', 9, 3, '', 2),
    (6, 'Георги', 'Тодоров', 8, 2, 'Да не се дава сладко', 5),
    (7, 'Анна', 'Стоянова', 10, 4, '', 4),
    (8, 'Иван', 'Георгиев', 6, 1, 'Изпада в истерия ако гледа Том и Джери след 12ч.', 5),
    (9, 'София', 'Илиева', 8, 2, '', 2),
    (10, 'Димитър', 'Николов', 13, 7, 'Подготовка за Външно оценяване', 3),
	(10, 'Ванеса', 'Николова', 7, 1, '', 1);


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
