using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {

        var calc=new Calculadora();
        Console.WriteLine("Ingrese un numero");
        string? ingreso=Console.ReadLine();
        double dato;


        while (!double.TryParse(ingreso, out dato))
        {
            Console.WriteLine("Ingrese un numero por favor: ");
            ingreso=Console.ReadLine();
        }

        Console.WriteLine("Ingrese la operacion que desea hacer: ");
        Console.WriteLine("1-Sumar");
        Console.WriteLine("2-Restar");
        Console.WriteLine("3-Dividir");
        Console.WriteLine("4-Multiplicar");
        Console.WriteLine("5-Limpiar");
        Console.WriteLine("6-Salir");
        ingreso=Console.ReadLine();
        double opcion;
        while (!double.TryParse(ingreso, out opcion) && opcion<1 && opcion >6)
        {
            Console.WriteLine("Ingrese una opcion valida por favor: ");
            ingreso=Console.ReadLine();
        }

        while (opcion!=6)
        {
            switch (opcion)
            {
                case 1: calc.Sumar(dato);
                break;
                case 2: calc.Restar(dato);
                break;
                case 3: calc.Multiplicar(dato);
                break;
                case 4: calc.Dividir(dato);
                break;
            }
            Console.WriteLine("Resultado: "+calc.Resultado +"\n");

            Console.WriteLine("Ingrese un otro numero para operar");
            ingreso=Console.ReadLine();
            while (!double.TryParse(ingreso, out dato))
            {
                Console.WriteLine("Ingrese un numero por favor: ");
                ingreso=Console.ReadLine();
            }
            Console.WriteLine("Ingrese la operacion que desea hacer: ");
            ingreso=Console.ReadLine();
            
            while (!double.TryParse(ingreso, out opcion) && opcion<1 && opcion >6)
            {
                Console.WriteLine("Ingrese una opcion valida por favor: ");
                ingreso=Console.ReadLine();
            }

            if (opcion==5)
            {
                calc.Limpiar();
                Console.WriteLine("Resultado: "+calc.Resultado +"\n");
            }
        }
        
    }
}