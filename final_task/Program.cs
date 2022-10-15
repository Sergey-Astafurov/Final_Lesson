// Метод который выбирает конкретные строки из массива
string TestLenght(string[] arr)
{
   string newArr = ""; // создаем новую строку куда будем помещать отобраные строки из массива
   for (int i = 0; i < arr.Length; i++)
   { //пишем цикл
      if (arr[i].Length <= 3)
      { //условие чтобы все строки которые по длине меньше или равны трем записывались в новую переменную
         newArr = newArr + arr[i] + " ";
      }


   }
   return newArr; // возвращаем эту переменную
}
//метод вызова результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}
//тело программы
string[] arr = { "1", "23", "455", "88889", "8937423", "5432", "11", "Hell", "Hi" };
string test = TestLenght(arr);
PrintResult(test);