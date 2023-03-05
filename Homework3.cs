//Homework 3.
/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int number = 1;
while(number < 10000 || number > 99999)
    {
Console.Write("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());
      }

if(number/10000 == number % 10 && number/1000 % 10 == number % 100 / 10)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}
 */

/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("y", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write("Введите координату " + coorName + " точки " + pointName + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенные координаты А " + xA + ", " + yA + ", " + zA + ". Введенные координаты B " + xB + ", " + yB + ", " + zB);

int diffX = xB - xA;
int diffY = yB - yA;
int diffZ = zB - zA;
double result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2) + Math.Pow(diffZ, 2));

Console.WriteLine("Расстояние между точками равно " + result);
    */


  /*
    //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= N)
{
    Console.Write(Cube(index) + " ");
    index++;
}

double Cube(int x)
{
    return Math.Pow(x, 3);
}
*/
