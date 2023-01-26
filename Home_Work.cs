void MaxNum3(string[] array){

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write($"'{array[i]}'  ");     
    }
}

System.Console.WriteLine("Введите желаемое количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string [] zero = ArrayString(num);
ShowArray(zero);
Console.WriteLine();
Console.WriteLine($"Строки, длина которых меньше либо равна 3 символам!!! ");
MaxNum3(zero);