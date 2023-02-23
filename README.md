# CarRental
Home controller - wyswietla strone startowa z powitaniem i dostępnymi samochodami,
ClientController- wywoływany z paska nawigacyjnego, zawiera widok z formularzem do rejestracji klienta do kontaktu,
	akcja wywołuje ClientService, który dodaje dane klienta do bazy danych
EmployeeController - wywoływany z paska nawigacyjnego, zawiera formularz logowania, który poprzez EmployeeService weryfikuje, czy taki użytkownik występuje w bazie,
	po poprawnym zalogowaniu przekierowuje do wszystkich wypożyczeń
RentalController- Wyświetla w tabeli wszystkie wypożyczenia, zawiera przycisk przekierowujący do dodania nowego pojazdu
NewCarController - Zawiera formularz dodawania nowego auta, poprzez CarService dodaje auto do bazy

CarsController - WebApi REST ze wszystkimi akcjami wykonywanymi przez CarService

Modele:
Car z polami:
	int Id
	string Name 
	string Description 
	double DailyPrice 
	List<Rental> Rental
Client:
	int Id
	string Name 
	string LastName 
	string Email  
	List<Rental> Rentals

Employee:
	int Id 
	string Name 
	string LastName
	string Login 
	string Password
Rental:
	int Id 
	DateTime StartDate
	DateTime EndDate
	double Price 
	Car Car
	Client Client

Utils:
	DbSeeder - zapełniajacy bazę 
	RentalMappingProfile - zawierajacy profile do automappera

Testy:
	Testy dla każdego serwisu napisane w MSTest, z użyciem FluentAssertions i Moq
Dane logowania admina:
	login:admin
	haslo: admin
link do git hub : https://github.com/Mirac00/CarRental
