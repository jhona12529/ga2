/*
Ejercicio N°2
Hallar la equivalencia de grados Celsius a Fahrenheit.
*/
Console.WriteLine("Ingrese cuantos grados Celsius desea convertir a Fahrenheit");
float c = float.Parse(Console.ReadLine());
float f = (c * 9 / 5) + 32;
Console.WriteLine("La equivalencia o conversion de grados Celsius a Fahrenheit es: " + f);