create view CzyIstniejePostac as
select Spis_postaci.Id_postaci, Spis_postaci.Pochodzenie, Zawody.Id_zawodu, Zawody.Nazwa_zawodu, Nazwiska.Id_nazwiska,Nazwiska.Pochodzenie_nazwiska, Nazwiska.Nazwisko, Imiona.Id_imienia, Imiona.Imie, Imiona.Pochodzenie_imienia
From Spis_postaci
Join Zawody on Spis_postaci.Id_zawodu=Zawody.Id_zawodu
Join Nazwiska on Spis_postaci.Id_nazwiska=Nazwiska.Id_nazwiska
Join Imiona on Spis_postaci.Id_imienia=Imiona.Id_imienia