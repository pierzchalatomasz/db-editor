# DB Editor
MySQL database editor written in C#

##Opis programu

Program służy do edytowania baz danych MySQL poprzez połączenie z serwerem SQL. Edytor ten pozwala nad dokonywać większość operacji na bazach danych, jakie umożliwia nam język MySQL, jednak bez konieczności znajomości tego języka. Dzięki niemu jesteśmy w stanie dodawać nowe bazy danych, usuwać je, dodawać nowe tabele, zmieniać jej strukturę, dodawać lub zmieniać rekordy w tabelach oraz wiele innych. Program ten składa się z okna logowania, która wymaga autoryzacji do dostępu do baz danych dla danego użytkownika oraz głównego okna, za pomocą którego jesteśmy w stanie manipulować bazami. Program ten wymaga dostępu do serwera SQL (w przypadku, gdy jest to zewnętrzny serwer SQL konieczne jest również połączenie z Internetem). 

##Instrukcja obsługi

Program uruchamiamy poprzez dwukrotne kliknięcie w plik o nazwie db-editor.exe. Przy pojawieniu się okienka logowania należy wprowadzić nazwę użytkownika, hasło oraz ewentualnie IP (aby to zrobić, należy kliknąć w przycisk "Zaawansowane"), jeżeli serwer SQL jest zewnętrzny. Jeżeli autoryzacja przebiegnie pomyślnie, powinno pojawić się główne okno do pracy nad bazami danych.


### Contributors:
* Tomasz Pierzchała
* Kamil Kryus
