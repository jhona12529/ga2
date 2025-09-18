/* 
EJERCICIO N°1
Calcular el área de un triángulo.
*/
Console.writeLine("Ingrese la base del triángulo:");
float b = float.Parse(Console.ReadLine());
Console.writeLine("Ingrese la altura del triángulo:");
float h = float.Parse(Console.ReadLine());
float area = (b * h) / 2;
Console.WriteLine("El área del triángulo es: " + area);
