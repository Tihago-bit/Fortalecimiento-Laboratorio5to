int contador = 0;

Console.Write("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

if (numero1 == 0)
{
    contador++;
}

Console.Write("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

if (numero2 == 0)
{
    contador++;
}

Console.Write("Ingrese el tercer número: ");
int numero3 = int.Parse(Console.ReadLine());

if (numero3 == 0)
{
    contador++;
}

Console.WriteLine("La cantidad de números iguales a 0 es: " + contador);