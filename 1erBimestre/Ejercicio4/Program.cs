Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 50)
{
    Console.WriteLine("El número está dentro del rango de 1 a 50.");
}
else
{
    Console.WriteLine("El número está fuera del rango de 1 a 50.");
}