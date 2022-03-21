// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите X, отличный от 0");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y, отличный от 0");
int Y = int.Parse(Console.ReadLine());

if (X>0 && Y>0) 
{
    Console.WriteLine("Точка с координатами (X, Y) находится в 1 четверти");
}
if (X>0 && Y<0) 
{
    Console.WriteLine("Точка с координатами (X, Y) находится во 2 четверти");
}
if (X<0 && Y<0) 
{
    Console.WriteLine("Точка с координатами (X, Y) находится в 3 четверти");
}
if (X<0 && Y>0) 
{
    Console.WriteLine("Точка с координатами (X, Y) находится в 4 четверти");
}