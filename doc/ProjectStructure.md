Struktura projektu
------------------
* `Components:`
  * Poszczególne okna znajdują się w katalogu `Components`.
  * Pojedynczy komponent, może zmieniać swoje stany, które znajdują się w katalogu `Components/{{nazwa_komponentu}}/States`.
  * Kazdy stan korzysta z kontrolki użytkownika, która jest jego reprezentacją graficzną (`Components/{{nazwa_komponentu}}/States/{{nazwa_stanu}}/{{nazwa_stanu}}Control.cs`).
  * Aby zbudować kontrolkę użytkownika, obsługującą interfejs graficzny stanu, używa się kontrolek, które znajdują się w katalogu `Components/{{nazwa_komponentu}}/States/{{nazwa_stanu}}/Partials`
* `DB-Connection` - manager połączenia z bazą danych
* `DB-Handlers` - klasy narzędziowe, służące do wykonywania operacji
  na bazie danych
* `Dependencies`
* `Events`
