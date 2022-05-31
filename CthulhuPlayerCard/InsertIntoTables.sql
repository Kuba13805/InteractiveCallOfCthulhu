--Wpisanie do tabeli Zawody
	insert into Zawody(Id_zawodu, Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values(1,'Medic','N','N','T','T','N');
	insert into Zawody(Id_zawodu, Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values(2,'Lawyer','T','N','T','N','N');
	insert into Zawody(Id_zawodu, Nazwa_zawodu, Zwiazana_Historia, Zwiazana_Bijatyka, Zwiazana_Spostrzegawczosc, Zwiazana_Pierwsza_Pomoc, Zwiazana_Bron_Palna) values(3,'Investigator','N','T','T','N','T');
	--Wpisanie do tabeli Imiona
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(1,'Jack','English','M');
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(2,'Adolf','German','M');
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(3,'Agnes','English','F');
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(4,'Marek','Polish','M');
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(5,'Ragnar','Nordic','M');
	insert into Imiona(Id_imienia, Imie, Pochodzenie_imienia, Plec_imienia) values(6,'El¿bieta','Polish','F');
	--Wpisanie do tabeli Nazwiska
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(1,'White', 'English');
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(2,'Bauman', 'German');
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(3,'Fisher', 'English');
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(4,'Nowak', 'Polish');
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(5,'Ragnarsson', 'Nordic');
	insert into Nazwiska(Id_nazwiska, Nazwisko, Pochodzenie_nazwiska) values(6,'Mazowiecki', 'Polish');
	--Wpisanie do tabeli Typy_przedmiotow
	insert into Typy_przedmiotów(Id_typu, Nazwa_typu) values(1, 'Watch');
	insert into Typy_przedmiotów(Id_typu, Nazwa_typu) values(2, 'Revolver');
	insert into Typy_przedmiotów(Id_typu, Nazwa_typu) values(3, 'Badge');

	--Wpisanie do tabeli Rzeczy_osobiste
	insert into Rzeczy_osobiste(Id_przedmiotu, Id_typu, Nazwa_przedmiotu) values(1,1,'Golden Watch');
	insert into Rzeczy_osobiste(Id_przedmiotu, Id_typu, Nazwa_przedmiotu) values(2,2,'Revolver from the Great War');
	insert into Rzeczy_osobiste(Id_przedmiotu, Id_typu, Nazwa_przedmiotu) values(3,3,'Detective badge');

	--Wpisanie do tabeli Spis_postaci
	insert into Spis_postaci(Id_postaci, Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(1,1,1,35,1,'M','USA','USA',65,50,50,45,55,60,30,50,45,2,25,50,30,60,90);
	insert into Spis_postaci(Id_postaci, Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(35,2,2,65,3,'M','UK','Germany',45,50,50,45,60,20,50,45,60,1,25,55,50,30,70);
	insert into Spis_postaci(Id_postaci, Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(889,3,1,33,2,'K','USA','USA',65,50,50,45,55,60,50,50,43,1,30,45,50,30,20);
	insert into Spis_postaci(Id_postaci, Id_imienia, Id_nazwiska, Wiek, Id_zawodu, Plec, Miejsce_zamieszkania, Pochodzenie, Sila, Zrecznosc, Kondycja, Wyglad, Wyksztalcenie, Budowa_ciala, Inteligencja, Szczescie, Moc, Id_przedmiotu, Historia, Bijatyka, Spostrzegawczosc, Pierwsza_Pomoc, Bron_Palna)
	values(4012,4,4,50,3,'M','Poland','Poland',55,50,50,45,55,60,50,50,43,1,30,45,50,30,30);