public class Empleado : Persona 
{
    private double sueldo;
    public string Cargo;
    public double Sueldo
    {
        get {return sueldo;}
        set 
        {
            if(value >= 0)
            {
                sueldo = value;
            } 
            else 
            {
                Console.WriteLine("Sueldo no puede ser negativo!");
            }
        }
    }

    public Empleado 
       (
            string nombre,
            string documento,
            string correo,
            int edad,
            double sueldo,
            string cargo 
        )
        :base(nombre, documento, correo, edad)
        {
            this.sueldo = sueldo;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Cargo: " + Cargo),
            Console.WriteLine("Sueldo: " + Sueldo.ToString("NO"));
        }

        public void CalcularSueldo (string tipo)
        {
            Console.WriteLine(this.sueldo * 0.9);
        }

        public void CalcularSueldo (double descuento)
        {
            Console.WriteLine(this.Sueldo * descuento);
        }


}