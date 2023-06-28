namespace EmpEspace
{
    public class Empleados
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public Empleados(string? nombre, string? apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.estadoCivil = estadoCivil;
            this.genero = genero;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        internal Cargos Cargo { get => cargo; set => cargo = value; }
        
    }

    


    public enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Especialista = 3,
        Investigador = 4
    }
    
}
