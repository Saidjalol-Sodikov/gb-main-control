//Для улучшения читаемости кода названия переменных были изменены
//Программу превратил в метод и добавил возможность вычленять разные размеры


//Основной метод программы
string[] KonechniyMassiv (string[] a, int n){
    int dlinaKonechnogoMassiva = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length<=n) dlinaKonechnogoMassiva++;
    }
    string[] konechniyMassiv = new string[dlinaKonechnogoMassiva];
    int ideksTekushegoMassiva = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length<=n){
            konechniyMassiv[ideksTekushegoMassiva]=a[i];
            ideksTekushegoMassiva++;
        }
    }
    return konechniyMassiv;
}

//Очищаем терминал
Console.Clear();

//Начальные данные
string[] ishodniyMassiv = ["abc", "1234", ";-)", "q2w", "ac", "12354", ";)", "q2uuw"];
int limitStroki = 3;

//Находим решение
string[] vihodnoyMassiv = KonechniyMassiv(ishodniyMassiv, limitStroki);

//Выводим результат
Console.WriteLine($"Исходный массив: [\"{string.Join("\", \"", ishodniyMassiv)}\"]");
Console.WriteLine($"Конечныйый массив: [\"{string.Join("\", \"", vihodnoyMassiv)}\"]");
