//Console.WriteLine("Введите уравнение.");
string urav = "";
//urav = Console.ReadLine();
urav = "-233+|-54|-12+234562x = 7";
Console.WriteLine(urav);
char[] urav3 = urav.ToCharArray(); // Перевод массив string в массив char.
char str = '|'; // Ввод символа который будим искать.
char str1 = '1';
char st = 'x'; // Ввод символа который будим искать.
char str2 = '1';

int x = -1, y = -1, z = -1, e = 0, q = 0, w = 0, o = 0, p = 0;

for (int i = 0; i < urav3.Length; i++)
{
    str1 = urav3[i];

    if (str1 == str && x == -1) // Поиск первой |.
    {
        x = i;
    }
    else if (str1 == str && y == -1) // Поиск второй |.
    {
        y = i;
    }


}
string modul = "";
for (int qwe = x + 1; qwe < y; qwe++) { // Запись числа находящегося между первой | и второй |.
    modul += urav3[qwe];
}
int mod = int.Parse(modul); // Парсирования получившегося числа из string в int.
if (mod < 0) mod *= -1; // Если чисо отрицательно, то домножаем на -1.

for (int i = 0; i < urav3.Length; i++) // Поиск х.
{
    str2 = urav3[i];

    if (str2 == st)
    {
        z = i;
    }
}

char[] urav2 = new char[z]; // Создаём массив длинноё до х.

for (int i = 0; i < urav2.Length; i++) // Записывем значения примера в массив до х. 
{
    urav2[i] = urav3[i];
}

string s = "";
for (int i = 0; i < urav2.Length; i++) s += urav2[i]; // Переводим получившийся кусок в string.

// Переворачиваем кусок уровнения.
char[] urav1 = s.ToCharArray(); // Перевод массив string в массив char.
Array.Reverse(urav1);
s = new string(urav1);
char[] urav4 = s.ToCharArray(); // Перевод массив string в массив char.

for (int i = 0; i < urav4.Length; i++) // Поиск первого попавшегося символа справо от числа.
{
    
   if (urav4[i] == '=' || urav4[i] == '+' || urav4[i] == '/' || urav4[i] == '%' || urav4[i] == '*' || urav4[i] == '|')
    {
        break;
    }
    o++; // Находим длинну множетеля х.
}

string trup = "";

for (int i = 0; i < o;i++) trup += urav4[i]; // Записываем множетель х.
char[] urav6 = trup.ToCharArray(); // Перевод массив string в массив char.
Array.Reverse(urav6);
trup = new string(urav6); // Переворачиваем число обратно.
int urav7 = int.Parse(trup); // Парсирования string в int.

Console.Write("Модуль числа: ");
Console.WriteLine(mod);
Console.Write("Множитель: ");
Console.WriteLine(urav7);