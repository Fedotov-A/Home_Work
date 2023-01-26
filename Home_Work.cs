string [] ArrayString(int num){
    string [] array = new string [num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} строку: ");
        array[i] = Console.ReadLine();
        while (array[i] == "")
        {
            Console.WriteLine("Введите корректное значение: ");
            Console.WriteLine($"Введите {i+1} строку: ");
            array[i] = Console.ReadLine();
        }

    }
    return array;
}

void ShowArray(string [] array){
    
    for (int i = 0; i < array.Length; i++){
        Console.Write($"'{array[i]}'  ");
    }
    Console.WriteLine();
}

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
