int number = int.Parse(Console.ReadLine());

int units = number % 10;
int tens = number % 100 / 10;
int hundreds = number / 100;

bool sumIsTwoDigit = (units + tens + hundreds).ToString().Length == 2;
bool multIsThreeDigit = (units * tens * hundreds).ToString().Length == 3;

Console.WriteLine($"Сумма цифр числа {(sumIsTwoDigit ? "" : "не ")}является двузначным числом.");
Console.WriteLine($"Произведение цифр числа {(multIsThreeDigit ? "" : "не ")}является трехзначным числом.");