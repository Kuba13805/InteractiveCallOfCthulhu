create view ListaPrzedmiotow as
select Spis_postaci.Id_postaci, Rzeczy_osobiste.Nazwa_przedmiotu, Typy_przedmiot�w.Nazwa_typu, Typy_przedmiot�w.Id_typu
From Spis_postaci
Join Rzeczy_osobiste on Spis_postaci.Id_przedmiotu=Rzeczy_osobiste.Id_przedmiotu
Join Typy_przedmiot�w on Rzeczy_osobiste.Id_typu=Typy_przedmiot�w.Id_typu