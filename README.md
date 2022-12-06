# Warszat

## Ćwiczenie 1

1. Utwórz klasę `LoanTermShould`
2. Napisz test który zweryfikuje czy `LoanTerm.ToMonths()` zwraca 12.

## Ćwiczenie 2

1. W klasie `LoanTermShould` utwórz test który sprawdzi czy propery `Years` jest ustawione na 1.


---

## Ćwiczenie 3

1. Sprawdź czy dwie instancje `LoanTerm` (`ValueObject`) są sobie równe jeżeli wartości parametru Years są sobie równe.
2. Zakomentuj metody `Equals()` oraz `GetHashCode` i uruchom jeszcze raz test.

## Ćwiczenie 4

1. Porównaj dwie instancje LoanTerm pod kątem referencji (`Is.Not.SameAs()`)
2. Utwórz trzecią zmienną wskazującą na referencję pierwszej (`Is.SameAs`).

## Ćwiczenie 5

1. Utwórz porównaj dwie listy stringów utworzone przy pomocy `new List<string>`.
2. Utwórz trzecią zmienną wskazującą na pierwszą listę i je porównaj.

---

## Ćwiczenie 6
1. Zmień np. metodę `LoanTerm().ToYears` modyfikując kod tak aby zwrócił niepoprawną ilość miesięcy.
2. Zedytuj pierwszy test wykorzystując przeciążoną metodę asercji, która wyświetli customowy komunikat.
3. Uruchom test i zweryfikuj wiadomość w konsoli.


## Ćwiczenie 7
1. Sprawdź czy `0.1 + 0.2 == 0.3` testem
2. Po IsEqualTo(0.3) wciśnij kropkę i zobacz co podpowie Ci Visual Studio.
3. Napisz test tak żeby przeszedł


## Ćwiczenie 8
1. Sprawdź czy `1.0 / 3.0 == 0.3333` testem
2. Napisz test tak żeby przeszedł


---

## Ćwiczenie 9 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy unikalne
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca tyle samo elementów ile mamy w liście LoadProduct (z punktu 2)


## Ćwiczenie 10 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca unikalne elementy


## Ćwiczenie 11 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca odpowiednie wartości dla pierwszego elementu



## Ćwiczenie 12 - Kolekcje
1. Przetestuj metodę `ProductComparer.CompareMonthlyRepayments()`
2. Żeby utworzyć instancję ProductComparer, musisz utworzyć:
   - listę produktów pożyczek (`LoanProduct`) - stwórz trzy
   - nową pożyczkę (`LoanAmount`)
3. Metoda `CompareMonthlyRepayments` zwraca listę i potrzebuje jako parametr warunków: `new LoanTerm(30)` (pożyczka na 30 lat)
4. Sprawdź asercją czy lista zwrócona przez `CompareMonthlyRepayments` zwraca odpowiednie wartości w pierwszym elemencie (sprawdź dokładnie property `ProductName` oraz `InterestRate`, dla property MonthlyRepayment jest większa niż 0)


---

## Ćwiczenie 13 - Łapanie wyjątków
1. Napisz test który złapie wyjątek z klasy LoanTerm.
2. Dla `LoanTerm(0)` powinniśmy otrzymać `ArgumentOutOfRangeException`


---

## Ćwiczenie 14 - Data Driven Tests
1. Utwórz plik Data.csv (pamiętaj o ustawieniu Copy to output directory) z takimi danymi
```csv
200000, 6.5, 30, 1264.14
200000, 10, 30, 1755.14
500000, 10, 30, 4387.86
```
2. Napisz kod w klasie `public class MonthlyRepaymentCsvData` który zwróci listę obiektów `TestCaseData` z danymi pobranymi z pliku .csv
3. Napisz test który przetestuje przy użyciu generatora danych metodę `CalculateMonthlyRepayment()` z klasy `LoanRepaymentCalculator`

Podpowiedź do testu:
```charp
var sut = new LoanRepaymentCalculator();

var monthlyPayment = sut.CalculateMonthlyRepayment(
                            new LoanAmount("USD", principal),
                            interestRate,
                            new LoanTerm(termInYears));

Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));
```
