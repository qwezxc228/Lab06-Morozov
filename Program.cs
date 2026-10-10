//Задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     System.Console.Write(i);


// }

//Задание 1.2
// for (int i = 2; i <= 50; i+=2)
// {
//         System.Console.Write(i);
// }

// Задание 2
// int sum1 = 0;
// int c = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum1 += i;
//         System.Console.Write(sum1);
//     }
//     if (i % 7 == 0)
//     {
//         c += 1;
//         System.Console.Write(c);
//     }

// }

//Задание 3
// int num = Convert.ToInt32(Console.ReadLine());
// int minus = 0;
// int plus = 0;
// while (num != 0)
// {
//     if (num > 0)
//     {
//         plus += 1;
//     }
//     if (num < 0)
//     {
//         minus += 1;
//     }
//     num = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine(plus);
// System.Console.WriteLine(minus);

//Пример 4
// string pass;
// int c = 0;
// do
// {
//     System.Console.WriteLine("3 цифры с обратной стороны карты : ");
//     pass = Console.ReadLine();
//     c += 1;
//     if (c > 3)
//     {
//         System.Console.WriteLine("Доступ заблокирован");
//         break;
//     }

// }
// while (pass != "qwe");
// System.Console.WriteLine("проходи емае");

//Задание 5
// int num1 = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < 11; i++)
// {
//     System.Console.WriteLine($"{num1} * {i} = {num1*i}");
// }

//Задание 6
// for (int i = 1;i < 31; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if (i % 10 == 0 && i > 20)
//     {
//         break;
//     }
//     System.Console.WriteLine(i);
// }

//Итоговая задача. «Угадай число»
// int secret = 42;
// for (int i = 1; i < 5; i++)
// {
//     System.Console.Write("введи число: ");
//     int num1 = int.Parse(Console.ReadLine());
//     if (num1 == secret)
//     {
//         System.Console.WriteLine($"Победа! Попыток: {i}");
//         return;
//     }
//     else if (num1 < secret)
//     {
//         System.Console.WriteLine("больше");
//     }
//     else
//     {
//         System.Console.WriteLine("меньше");

//     }

// }
// System.Console.WriteLine("Вы проиграли, число было 42");

