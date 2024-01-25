//Для улучшения читаемости кода названия переменных были изменены
Console.Clear();
string[] a = ["abc", "1234", ";-)", "q2w"];
int dlinaKonechnogoMassiva = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i].Length<=3) dlinaKonechnogoMassiva++;
}
string[] konechniyMassiv = new string[dlinaKonechnogoMassiva];
int ideksTekushegoMassiva = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i].Length<=3){
        konechniyMassiv[ideksTekushegoMassiva]=a[i];
        ideksTekushegoMassiva++;
    }
}

Console.WriteLine($"Исходный массив: [\"{string.Join("\", \"", a)}\"]");
Console.WriteLine($"Конечныйый массив: [\"{string.Join("\", \"", konechniyMassiv)}\"]");
