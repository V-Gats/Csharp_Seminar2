// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка. 

Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
  Console.WriteLine("Точка находиться в 1 четверти");
else if (x < 0 && y > 0)
  Console.WriteLine("Точка находиться в 2 четверти");
else if (x < 0 && y < 0)
  Console.WriteLine("Точка находиться в 3 четверти");
else if (x > 0 && y < 0)
  Console.WriteLine("Точка находиться в 4 четверти");
else
  Console.WriteLine("Точка находиться на оси");