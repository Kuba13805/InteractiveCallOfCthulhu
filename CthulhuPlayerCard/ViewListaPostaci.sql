create view ListaPostaci as
Select Spis_postaci.Id_postaci, Imiona.Imie, Nazwiska.Nazwisko, Zawody.Nazwa_zawodu
from Spis_postaci
Join Imiona on Spis_postaci.Id_imienia=Imiona.Id_imienia
Join Nazwiska on Spis_postaci.Id_nazwiska=Nazwiska.Id_nazwiska
Join Zawody on Spis_postaci.Id_zawodu=Zawody.Id_zawodu;