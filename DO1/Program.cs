Console.WriteLine("Введите координаты точки A: ");
float x1 = float.Parse(Console.ReadLine());
float y1 = float.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
float x2 = float.Parse(Console.ReadLine());
float y2 = float.Parse(Console.ReadLine());

float deltaX = (x2 - x1);
float deltaY = (y2 - y1);

Double lengthAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

Console.WriteLine($"Длина отрезка AB = { lengthAB}");