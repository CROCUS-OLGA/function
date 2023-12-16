// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
// Вид 1 ничего не принимают (не принимают никаких аргументов) и ничего не возвращают
// void Method1()
// {

//     Console.WriteLine("Автор.....");
// }
// Method1();    

// Вид 2
// void Method2(string msg)
// {

//     Console.WriteLine(msg);
// }
// Method2("Текст соообщения"); 


// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

//Method21(msg: "Текст", count: 4);    
// Method21(count: 4, msg: "новый текст");  
///// Вид 3. методы, которые что-то возвращают, но ничего не принимают.
///
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year =Method3();
// Console.WriteLine(year);
///// Вид 4. Методы, которые что-то принимают и что-то возвращают
///
// string Method4( int count, string text)
// {
//     int i=0;
//     String result=String.Empty;
//     while (i<count)
//     {
//        result= result+text;
//        i++;
//     }
//     return result;   
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);
// -------------------------------------------------------
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);
//-------------------------------------------------------------
// Таблица умножения
// for (int i = 2; i <=10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i*j}");
//     }
//     Console.WriteLine();
// }
//-----------------------------------------------------------------
// дан текст. В тексте нужно заменить все пробелы черточками, 
// маленькие буквы к большими буквами К.
// Маленькие буквы с большими буквами С.
// string text = "-Я думаю, - сказал князь, - что,-"
//               +"ежеле бы вас послали вместо нашего милого Винценгероде."
//               +"вы бы взяли приступом согласие прусского короля."
//               +"Вы так красноречивы. Так дадите мне чаю?";
// // string s = "qwerty"
// //            012
// // s[3] //r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"newValue";
//         else result = result + $"text[i)";
//     }

//     return result;
// }
// string newText = Replace(text,  ' ', '|');
// Console.WriteLine(newText);
//--------------------------------------------------------------------
// int[] arr = { 2, 3, 5, 1, 6, 8, 2, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);