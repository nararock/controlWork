string[] stringArray = createArray();
Console.Write("Введите размер строк, которые должны войти в новый массив: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
(string[] newStringArray, int k) = fillArrayWithCondition(stringArray, sizeArray);
Console.WriteLine("Было ["+String.Join(",", stringArray)+"]");
Console.WriteLine("Стало [" + String.Join(",", newStringArray, 0, k) +"]");

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

(string[], int) fillArrayWithCondition(string[] array, int n){
    string[] newArray = new string[array.Length];
    int k = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length == n){
            newArray[k] = array[i];
            k++;
        }            
    }
    return (newArray, k);
}
