Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 100)
{
    Console.WriteLine("El número es mayor a 100.");
}
else if (numero < 100)
{
    Console.WriteLine("El número es menor a 100.");
}
else
{
    Console.WriteLine("El número es igual a 100.");
}