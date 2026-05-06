public class Program 
{
    static void Main()
    {
        Empleado emp1 = new Empleado 
        (
            "Hilary";
            "1033180509";
            "hilaryossa@gmai.com";
             19;
             1200.20;
            "Veterinaria";
        );

        emp1.MostrarInfo();
        Console.WriteLine("==============================")
        emp1.CalcularSueldo ("Hola");
        
        }
    }
}