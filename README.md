# Warszat

## Ćwiczenie 1
1. Przeanalizuj powyższy kod w C#. Napisz go w swoim języku programowania (Kotlin, Swift)

## Ćwiczenie 2

1. Utwórz klasę `LoanTermShould`
2. Napisz test który zweryfikuje czy `LoanTerm.ToMonths()` zwraca 12.

## Ćwiczenie 3

1. W klasie `LoanTermShould` utwórz test który sprawdzi czy propery `Years` jest ustawione na 1.



## Ćwiczenie 4
1. Zmień np. metodę `LoanTerm().ToYears` modyfikując kod tak aby zwrócił niepoprawną ilość miesięcy.
2. Uruchom test i zweryfikuj wiadomość w konsoli.


## Ćwiczenie 5
1. Sprawdź czy `0.1 + 0.2 == 0.3` testem
2. Napisz test tak żeby przeszedł


## Ćwiczenie 6
1. Sprawdź czy `1.0 / 3.0 == 0.3333` testem
2. Napisz test tak żeby przeszedł


---

## Ćwiczenie 7 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy unikalne
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca tyle samo elementów ile mamy w liście LoadProduct (z punktu 2)


## Ćwiczenie 8 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca unikalne elementy


## Ćwiczenie 9 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca odpowiednie wartości dla pierwszego elementu



## Ćwiczenie 10 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca odpowiednie wartości w pierwszym elemencie (sprawdź dokładnie property `ProductName` oraz `InterestRate`, dla property MonthlyRepayment jest większa niż 0)


---

## Ćwiczenie 11 - Łapanie wyjątków
1. Napisz test który złapie wyjątek z klasy LoanTerm.
2. Dla `LoanTerm(0)` powinniśmy otrzymać Exception - sprawdz czy typ i wiadomość się zgadzają


---

## Ćwiczenie 12 - Data Driven Tests
1. Utwórz plik Data.csv z takimi danymi
```csv
200000, 6.5, 30, 1264.14
200000, 10, 30, 1755.14
500000, 10, 30, 4387.86
```
2. Spróbuj napisac test, który przetestuje dane z pliku
