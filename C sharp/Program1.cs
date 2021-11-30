// using System;
// using System.Collections.Generic;

// namespace С_
// {
//     class MainClass
//     {
//         static void Main(string[] args) // Main - Основа приложения как обертка в Реакте
//         {
            

//             // ТИПЫ ПЕРЕМЕННЫХ
//             int num = 10; // Число
//             float num_2 = 10.12f; // Дробное число | (f) на конце обьязательно
//             double num_3 = 100.12f; // Дробное число | поддерживает больше чисел чем float
//             char sym = '&'; // Символ | в одинарных ков.
//             string str = "Hi"; // Строка
//             bool isHappy = true; // Буль

//             // ПРЕОБРАЗОВАНИЕ
//             Convert.ToInt32("123"); // Строку в Число
               // 10.ToString(); // Число в строку
               // Debug.log((int)дробное) // Конвертнет Дробное в int (целое)

//             // КОНСОЛЬ
//             Console.WriteLine("Hello World!"); // Выведет в консоли
//             Console.Write("Dima" + num); // Выведет в консоле | операции
//             Console.WriteLine("DD"); // Каждое значение на новой строке
//             // Console.ReadLine(); // Читает то что вводим в консоле
//             // str  = Console.ReadLine();
//             // Console.Write("Ввел = " + str);

//             // УСЛОВНЫЕ ОПЕРАТОРЫ
//             // if/else | switch  - Как и в JS

//             // ЦИКЛЫ
//             // for | while | foreach - Как и в JS
//             // foreach (int el in arr)

//             // МАССИВЫ - точное кол-вою
//             int [] arr = new int[5]; // Кол-во елементов
//             int [] arr_1 = {1,2,3,4}; // Сразу забиваем елементы
//             int [] arr_2 = new int[] {1,2,3,4}; // Сразу забиваем елементы АЛЬТЕРНАТИВА
//             // [1,2,3,4,5]; | Можно указать меньше 5
//             string [] arr2 = new string[3];
//             // ['a','b'];

//             // МАССИВ МНОГОМЕРНЫЙ - точное кол-во
//             int [,] arrr_2 = new int[3, 2] {
//                 {1, 2}, {3, 4}, {5, 6} // не обьекты 
//             };

//             // ДИНАМИЧЕСКИЙ МАССИВ (Список) - без привязки к кол-во.
//             List<int> nums = new List<int> (); // Ключ. слово List и тип int/string
//             // Методы работы
//             nums.Add(1);
//             nums.Remove(1);
//             // ...

//             Print("Print Строка"); // Обратится к функц. которая вернет строку
//             Print(123); // Которая вернет число
            
//         }

//         // FUNCTION
//         // publick - Публичная функция доступная в этом клаасе и его потомках
//         // static - Это функция пренадлежит Классу а не обьекту
//         // void - (ТИП) Означает что функция ничего не вернет
//             // int - (ТИП) Вернет число
//             // string - (ТИП) Вернет строку
//         // str - Примит один параметр типа Строка
//         public static void Print (string str) {
//             Console.WriteLine(str);
//         }
//         public static void Print (int num) {
//             Console.WriteLine(num);
//         }
//     }
// }
