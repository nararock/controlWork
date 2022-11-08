string[] stringArray = createArray();
Console.WriteLine(String.Join(",", stringArray));

string[] createArray(){
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size]; 
    Console.WriteLine("Заполним массив строками");
    for (int i = 0; i < size; i++){
        Console.Write("Введите строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

