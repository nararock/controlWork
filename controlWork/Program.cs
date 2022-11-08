string[] stringArray = createArray();
Console.WriteLine(String.Join(",", stringArray));
string[] newStringArray = fillArrayWithCondition(stringArray, 2);
Console.WriteLine(String.Join(",", newStringArray));

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

string[] fillArrayWithCondition(string[] array, int n){
    string[] newArray = new string[array.Length];
    int k = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length == n){
            newArray[k] = array[i];
            k++;
        }            
    }
    return newArray;
}
