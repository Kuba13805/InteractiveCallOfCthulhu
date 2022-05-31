use Projekt_Cthulhu
create table Zawody(
	Id_wpisu int identity(1,1) Primary Key,
	Id_zawodu nchar(4) Unique Not Null,
	Nazwa_zawodu nchar(30) Not Null,
	Zwiazana_Historia nchar(1),
	Zwiazana_Bijatyka nchar(1),
	Zwiazana_Spostrzegawczosc nchar(1),
	Zwiazana_Pierwsza_Pomoc nchar(1),
	Zwiazana_Bron_Palna nchar(1)
	);

create table Imiona(
	Id_wpisu int identity(1,1) Primary Key,
	Id_imienia nchar(4) Unique Not Null,
	Imie nchar(30) Not Null,
	Pochodzenie_imienia nchar(30),
	Plec_imienia nchar(30)
	);

create table Nazwiska(
	Id_wpisu int identity(1,1) Primary Key,
	Id_nazwiska nchar(4) Unique Not Null,
	Nazwisko nchar(30) Not Null,
	Pochodzenie_nazwiska nchar(30)
	);

	create table Typy_przedmiotow(
	Id_wpisu int identity(1,1) Primary Key,
	Id_typu nchar(4) Unique Not Null,
	Nazwa_typu nchar(30) Not Null,
	);

create table Rzeczy_osobiste(
	Id_wpisu int identity(1,1) Primary Key,
	Id_przedmiotu nchar(4) Unique Not Null,
	Id_typu nchar(4) Not Null,
	Nazwa_przedmiotu nchar(30) Not Null
	Constraint relacja5 foreign key(Id_typu) references Typy_przedmiotow(Id_typu)
	On Delete cascade
	On Update cascade,

	);

create table Spis_postaci(
	Id_wpisu int identity(1,1) Primary Key,
	Id_postaci nchar(4) Unique Not Null,
	Id_imienia nchar(4) Not Null,
	Id_nazwiska nchar(4) Not Null,
	Wiek smallint Not Null,
	Id_zawodu nchar(4) Not null,
	Plec nchar(1) Not Null,
	Miejsce_zamieszkania nchar(30),
	Pochodzenie nchar(30),
	Sila smallint,
	Zrecznosc smallint,
	Kondycja smallint,
	Wyglad smallint,
	Wyksztalcenie smallint,
	Budowa_ciala smallint,
	Inteligencja smallint,
	Szczescie tinyint,
	Moc smallint,
	Id_przedmiotu nchar(4),
	Historia tinyint,
	Bijatyka tinyint,
	Spostrzegawczosc tinyint,
	Pierwsza_Pomoc tinyint,
	Bron_Palna tinyint
	Constraint relacja1 foreign key(Id_zawodu) references Zawody(Id_zawodu)
	On Delete cascade
	On Update cascade,
	Constraint relacja2 foreign key(Id_imienia) references Imiona(Id_imienia)
	On Delete cascade
	On Update cascade,
	Constraint relacja3 foreign key(Id_nazwiska) references Nazwiska(Id_nazwiska)
	On Delete cascade
	On Update cascade,
	Constraint relacja4 foreign key(Id_przedmiotu) references Rzeczy_osobiste(Id_przedmiotu)
	On Delete cascade
	On Update cascade,
	);
	