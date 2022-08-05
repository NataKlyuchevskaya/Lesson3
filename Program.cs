void Zadacha19()
{
//Задача 19 Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли она палиндромом.

    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());  

    if (number > 9999 && number < 100000)
    {
        int digitOne = number % 10; 
        int digitTen = number /10 % 10;
        int digitThausand = number /1000 % 10;
        int digitTenThausand = number /10000;
        if (digitOne == digitTenThausand && digitTen == digitThausand)
        {
            Console.WriteLine("число палиндром");
        }
        else
        {
            Console.WriteLine("число не палиндром"); 
        }
    }
    else
    {
        Console.WriteLine("Введено не пятизначное число");
    }
}


void Zadacha21()
{
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int a_x = 3;
int a_y = 6;
int a_z = 8;
int b_x = 2;
int b_y = 1;
int b_z = -7;
Console.WriteLine($"Координаты точки 1 ({a_x}, {a_y}, {a_z}) и точки 2 ({b_x}, {b_y}, {b_z})"); 
double distanse = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
Console.WriteLine($"расстояние {Math.Round(distanse, 2)}");
/*
int a_x = 7;
int a_y = -5;
int a_z = 0;
int b_x = 1;
int b_y = -1;
int b_z = 9;
Console.WriteLine($"Координаты точки 1 ({a_x}, {a_y}, {a_z}) и точки 2 ({b_x}, {b_y}, {b_z})"); 
double distanse = Math.Sqrt(Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
Console.WriteLine($"расстояние {Math.Round(distanse, 2)}");
*/
}

void Zadacha23()
{
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:  ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1;  i <= number; i++)
    {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
    }
}


//Zadacha19();
//Zadacha21();
Zadacha23();