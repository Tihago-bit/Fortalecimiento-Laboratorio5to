Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 3 == 0)
{
    Console.WriteLine("El número es múltiplo de 3.");
}
else
{
    Console.WriteLine("El número no es múltiplo de 3.");
}