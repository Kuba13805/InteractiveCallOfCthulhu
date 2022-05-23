--Tworzenie bazy danych
Create Database Projekt_Cthulhu;
go
Use Projekt_Cthulhu;
go
	--Tworzenie tabeli Zawody
create table Zawody(
	Id_zawodu int identity(1,1) Primary Key,
	Nazwa_zawodu nchar(30) Not Null,
	Zwiazana_Historia nchar(1),
	Zwiazana_Bijatyka nchar(1),
	Zwiazana_Spostrzegawczosc nchar(1),
	Zwiazana_Pierwsza_Pomoc nchar(1),
	Zwiazana_Bron_Palna nchar(1)
	);
	--Tworzenie tabeli Imiona
create table Imiona(
	Id_imienia int identity(1,1) Primary Key,
	Imie nchar(30) Not Null,
	Pochodzenie_imienia nchar(30),
	Plec_imienia nchar(30)
	);
	--Tworzenie tabeli Nazwiska
create table Nazwiska(
	Id_nazwiska int identity(1,1) Primary Key,
	Nazwisko nchar(30) Not Null,
	Pochodzenie_nazwiska nchar(30)
	);
	--Tworzenie tabeli Typy_przedmiotów
	create table Typy_przedmiotów(
	Id_typu smallint identity(1,1) Primary Key,
	Nazwa_typu nchar(30) Not Null,
	);
	-- Tworzenie tabeli Rzeczy_osobiste
create table Rzeczy_osobiste(
	Id_przedmiotu int identity(1,1) Primary Key,
	Id_typu smallint Not Null,
	Nazwa_przedmiotu nchar(30) Not Null
	Constraint relacja5 foreign key(Id_typu) references Typy_przedmiotów(Id_typu)
	On Delete cascade
	On Update cascade,

	);
	--Tworzenie tabeli Spis_postaci
create table Spis_postaci(
	Id_postaci int identity(1,1) Primary Key,
	Id_imienia int Not Null,
	Id_nazwiska int Not Null,
	Wiek smallint Not Null,
	Id_zawodu int Not null,
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
	Id_przedmiotu int,
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
	go
	--Wpisanie do tabeli Zawody
	insert into Zawody(Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values('Lekarz','N','N','T','T','N');
	insert into Zawody(Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values('Prawnik','T','N','T','N','N');
	insert into Zawody(Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values('Detektyw','N','T','T','N','T');
	--Wpisanie do tabeli Imiona
	insert into Imiona(Imie, Pochodzenie_imienia, Plec_imienia) values('Jack','Angielskie','Meski');
	insert into Imiona(Imie, Pochodzenie_imienia, Plec_imienia) values('Adolf','Niemieckie','Meski');
	insert into Imiona(Imie, Pochodzenie_imienia, Plec_imienia) values('Agnes','Angielskie','Zenski');
	--Wpisanie do tabeli Nazwiska
	insert into Nazwiska(Nazwisko, Pochodzenie_nazwiska) values('White', 'Angielskie');
	insert into Nazwiska(Nazwisko, Pochodzenie_nazwiska) values('Bauman', 'Niemieckie');
	insert into Nazwiska(Nazwisko, Pochodzenie_nazwiska) values('Fisher', 'Angielskie');
	--Wpisanie do tabeli Typy_przedmiotow
	insert into Typy_przedmiotów(Nazwa_typu) values('Zegarek');
	insert into Typy_przedmiotów(Nazwa_typu) values('Rewolwer');
	insert into Typy_przedmiotów(Nazwa_typu) values('Odznaka');

	--Wpisanie do tabeli Rzeczy_osobiste
	insert into Rzeczy_osobiste(Id_typu, Nazwa_przedmiotu) values(1,'Zegarek po dziadku');
	insert into Rzeczy_osobiste(Id_typu, Nazwa_przedmiotu) values(2,'Rewolwer z Wielkiej Wojny');
	insert into Rzeczy_osobiste(Id_typu, Nazwa_przedmiotu) values(3,'Odznaka detektywa');

	--Wpisanie do tabeli Spis_postaci
	insert into Spis_postaci(Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(1,1,35,1,'M','USA','USA',65,50,50,45,55,60,30,50,45,2,25,50,30,60,90);
	insert into Spis_postaci(Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(2,2,65,1,'M','Wielka Brytania','Niemcy',45,50,50,45,60,20,50,45,60,1,25,55,50,30,70);
	insert into Spis_postaci(Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(3,1,33,1,'K','USA','USA',65,50,50,45,55,60,50,50,45,1,30,45,50,30,20);
