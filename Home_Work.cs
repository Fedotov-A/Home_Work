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