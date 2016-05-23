Stan
----
Stan przechowuje informacje takie jak:
* Nazwa stanu
* Nazwa stanu następnego
* Nazwa stanu poprzedniego
* Tekst do wyświetlenia na przycisku, który powoduje przejście do następnego stanu
  (przycisk przechodzący do wcześniejszego stanu jest zawsze podpisany jako "Back")
* Kontrolki wyświetlane, w lewym i prawym panelu (najprawdopodobniej po refaktoryzacji
  zostanie tylko jedna kontrolka, gdyż kontrolka w lewym panelu będzie wspólna dla wszystkich stanów)
* Metoda wywoływana przy zmianie na stan następny `OnNextState()`, gdzie można implementować
  np. walidację wprowadzonych danych i ewentualny zapis
* Metoda wywoływana przy zmianie na stan poprzedni `OnPrevState()`, gdzie można implementować
  np. zapytanie użytkownika, czy na pewno chce porzucić wprowadzone zmiany

Mechanizm zmiany stanów MainWindow
----------------------------------
* Poszczegolne stany są przechowywane w klasie Model komponentu MainWindow.
* Po wciśnięciu każdego z przyciskow znajdujących się na dole prawego panelu
  wywoływane jest zdarzenie `StateChangeRequestEvents.StateChangeRequest`, na które nasłuchuje
  metoda `ChangeState(object sender, StateChangeRequestEventArgs args)` klasy Presenter. Odpowiada ona za wywołanie
  `OnNextState()` lub `OnPrevState()`, a następnie zmianę aktywnego stanu.
* `StateChangeRequestEventArgs` zawierają informacje takie jak:
  * nazwa stanu do, którego należy przejść
  * `enum StateOrder`, który informuje, czy jest to stan typu Next, czy Prev
  * ewentualne dane w postaci `Dictionary<string, string>`, np. ID tabeli
    (docelowo każdy stan będzie potrafił na podstawie tych danych wyświetlić odpowiednie wartości w poszczególnych polach)
