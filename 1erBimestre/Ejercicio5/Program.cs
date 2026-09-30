int contador = 0;

Console.Write("Ingrese el primer número: ");
int numero1 = int.Parse(Console.ReadLine());

if (numero1 > 10)
{
    contador++;
}

Console.Write("Ingrese el segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

if (numero2 > 10)
{
    contador++;
}

Console.Write("Ingrese el tercer número: ");
int numero3 = int.Parse(Console.ReadLine());

if (numero3 > 10)
{
    contador++;
}

Console.Write("Ingrese el cuarto número: ");
int numero4 = int.Parse(Console.ReadLine());

if (numero4 > 10)
{
    contador++;
}

Console.WriteLine("La cantidad de números mayores a 10 es: " + contador);