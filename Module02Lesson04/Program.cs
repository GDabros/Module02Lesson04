// Exercise 01

string firstName = "Grzegorz";
string surname = "Kowalski";
int age = 36;
char sex = 'm';
string pesel = "87080000000";
string idEmployee = "20240329";

Console.WriteLine("Sprawdzanie bazy pracowników...:");
Console.WriteLine($"Pracownik: {firstName} {surname} w wieku {age} lat, o numerze PESEL: {pesel} i identyfikatorze numer: {idEmployee} - widnieje w bazie danych.");


// Exercise 02

char variable1 = 'A';
char variable2 = 'B';
char variable3 = 'C';

Console.WriteLine("Poniżej zmienne w odwrotnej kolejności:");
Console.WriteLine(variable3);
Console.WriteLine(variable2);
Console.WriteLine(variable1);


// Exercise 03

double width = 6;
double length = 4;

double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

Console.WriteLine($"Długość przekątnej = {diagonal}");



// Exercise 04

int variableA = 10;
string variableB = "Szkoła Dotneta";
double variableC = 12.5;

Console.WriteLine($"Zmienna a: {variableA}, zmienna b: {variableB}, zmienna c: {variableC}");


// Exercice 05

Console.WriteLine("Proszę o podanie poniższych danych:");

Console.Write("Imię: ");
string name = Console.ReadLine();

Console.Write("Nazwisko: ");
string lastName = Console.ReadLine();

Console.Write("Narodowość: ");
string nationality = Console.ReadLine();

Console.Write("Numer telefonu: ");
string phoneNumber = Console.ReadLine();
int.Parse(phoneNumber);

Console.Write("Adres Email: ");
string email = Console.ReadLine();

Console.Write("Wzrost (w cm): ");
string height = Console.ReadLine();
int.Parse(height);

Console.Write("Waga (w kg): ");
string weight = Console.ReadLine();
double.Parse(weight);

Console.WriteLine("Zapisano poniższe dane:");
Console.WriteLine($"Imię: {name} {lastName}, Narodowość: {nationality}, numer telefonu: {phoneNumber}, adres E-mail: {email}, wzrost: {height}cm, waga: {weight}kg");


