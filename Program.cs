// 1 КВАДРАТ ЧИСЛА

// Console.Write("input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine(result);

// 2 ПРОВЕРКА ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ ЧИСЛО КВАДРАТУ ВТОРОГО

// Console.Write("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 == square){
//     Console.WriteLine("rigth: ");
// }
// else{
//      Console.WriteLine("falls: ");
// }

//  3 Программа выдает день недели по номеру

// Console.Write("input number of day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7){
//     Console.Write("incorrect day");
// }
// else{
//     if (day == 1){
//         Console.WriteLine("pn");
//     }
//     if (day == 2){
//         Console.WriteLine("vt");
//     }
//     if (day == 3){
//         Console.WriteLine("sr");
//     }
//     if (day == 4){
//         Console.WriteLine("чет");
//     }
//     if (day == 5){
//         Console.WriteLine("pt");
//     }
//     if (day == 6){
//         Console.WriteLine("sub");
//     }
//     if (day == 7){
//         Console.WriteLine("vsk");
//     }
// }

// 4 Написать числа от -N до N, когда вводят число N 

// Console.WriteLine("Write number");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;

// if (num < 0){
//     current = num;
//     num = num * (-1);
// }
// else{
//     current = num * (-1);
// }

// while(current < num -1){
//     current += 1;
//     Console.Write (current + " ");
// }

// 5 Показать последнюю цифру, когда вводят трехзначное число

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 & num < 1000){
//     Console.Write(num % 10);
// }
// else
// {
//     Console.Write("incorrect number");
// }









// ДЗ 

// 1) На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b){
//     Console.Write("a > b");
// }
// else{
//     Console.Write("a < b");
// }

// 2) принимает на вход три числа и выдаёт максимальное из этих чисел

// Console.Write("input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b){
//     if (a > c){
//         Console.Write("a max");
//     }
//     else{
//         Console.Write("c max");
//     }}
// else{
//     if (b > c){
//        Console.Write("b max");
//     }
//     else{
//         Console.Write("c max");
//     }
// }

// 3) на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

// Console.Write("input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0){
//     Console.Write("number correct");
// }
// else{
//     Console.Write("number incorrect");
// }

// 4) на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

// Console.Write("input number N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// int mincurrent = -2;

// if(N > 0){
//     while(N > current){
//         Console.Write(current + " ");
//         current += 2;
//     }
// }
// else{
//     while(N < mincurrent){
//         Console.Write(mincurrent + " ");
//         mincurrent -= 2;
//     }
// }
