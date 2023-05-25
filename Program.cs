//Задание1
// Напишите программу, которая выводит
//  случайное число из отрезка [10, 99]
//   и показывает наибольшую цифру числа.

// int num = new Random().Next(10,99);
// Console.WriteLine(num);

// int num1=num/10;
// int num2=num%10;
// if (num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

//Задание2
// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1 = num/100;
// int num2 = num%10;

// int result = num1*10+num2;

// Console.WriteLine(result);

//Задание3

//  Console.WriteLine("Введите число");
//  int num1=Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine("Введите число");
//  int num2=Convert.ToInt32(Console.ReadLine());

//  if (num1 % num2 == 0)
//  {
//     Console.WriteLine("Кратно");
//  }
// else
// {
//     Console.Write("Остаток от деления ");
//     Console.Write( num1%num2 );

// }

// && - и
// || - или

//Задание4

// Console.WriteLine("Введите число");
// int num1=Convert.ToInt32(Console.ReadLine());

//  if ((num1 % 7 == 0) && (num1 % 23 == 0))
//  {
//     Console.WriteLine("Да");
//  }
// else
// {
//     Console.Write("Нет");
    
// }


//Задача5

//Напишите программу, которая принимает
//на вход два числа и проверяет,
//является ли одно число квадратом другого.

// Console.WriteLine("Введите первое число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2=Convert.ToInt32(Console.ReadLine());

//  if ((num1 == num2*num2) || (num2 == num1*num1))
//  {
//     Console.WriteLine("Да");
//  }
// else
// {
//     Console.Write("Нет");
    
// }

// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//
//________________ДОМАШНЕЕ ЗАДАНИЕ_________________________

//___________________ЗАДАНИЕ1______________________________

// Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num=Convert.ToInt32(Console.ReadLine());
// if ((num<100)||(num>999))
// {
//     Console.WriteLine($"Не обманывай - число {num} не трехзначное");
// }
// else
// {
//     int num1 = num%100;
//     int num2 = num%10;
//     int result = (num1-num2)/10;

//     Console.WriteLine ($"Вторая цифра числа {num} - это {result}.");
// }

//___________________ЗАДАНИЕ2______________________________

//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите  число");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num>100)
// {
//     while (num>999)
// {
//     num = num/10;
// }
// num = num%10;
// Console.WriteLine($"Третья цифра - {num}.");
    
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет.");
// }

//___________________ЗАДАНИЕ3_____________________________

// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// Console.WriteLine("Введите день недели (цифрой)");
// int num=Convert.ToInt32(Console.ReadLine());
// if (num<=5)
// {
//     Console.WriteLine("Будний день");
// }
// else if(num<=7)
// {
//     Console.WriteLine("Выходной");
// }
// else if (num>7)
// {
//     Console.WriteLine($"В неделего всего 7 дней, а не {num}.");
// }
