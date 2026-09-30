Console.Write("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("El primer número es mayor.");
}
else if (numero2 > numero1)
{
    Console.WriteLine("El segundo número es mayor.");
}
else
{
    Console.WriteLine("Los dos números son iguales.");
}