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

        // public Empleados(string? nombre, string? apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        // {
        //     this.nombre = nombre;
        //     this.apellido = apellido;
        //     this.fechaNac = fechaNac;
        //     this.estadoCivil = estadoCivil;
        //     this.genero = genero;
        //     this.fechaIngreso = fechaIngreso;
        //     this.sueldoBasico = sueldoBasico;
        //     this.cargo = cargo;
        // }

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

        internal Cargos Cargo { get => cargo; set => cargo = value; }
        
        //metodos de la clase
        public int antiguedad(DateTime fechaIngreso)
        {
            int anti;

            if (fechaNac.Day >= DateTime.Now.Day || fechaIngreso.Month >= DateTime.Now.Month)
            {
                    anti=DateTime.Now.Year-fechaIngreso.Year;
            }
            else
            {
                anti=DateTime.Now.Year-fechaIngreso.Year-1;
            }
            
            return anti;
        }

        public int edad(DateTime fechaNac)
        {
            int edad;

            if (fechaNac.Day >= DateTime.Now.Day || fechaNac.Month >= DateTime.Now.Month)
            {
                edad=DateTime.Now.Year-fechaNac.Year;
            }
            else
            {
                edad=DateTime.Now.Year-fechaNac.Year-1;
            }
            
            return edad;
        }

        public int jubilacion(char genero, DateTime fechaNac)
        {
            int faltan;
            
            if (genero=='M')
            {
                faltan= 65 - edad(fechaNac);
            }
            else
            {
                faltan=60-edad(fechaNac);
            }
            return faltan;
        }

        public double Adicional(double sueldoBasico, DateTime fechaIngreso, Cargos cargos, char estadoCivil)
        {
            double adicional=0;
            if (antiguedad(fechaIngreso)<20)
            {
                adicional+=sueldoBasico*antiguedad(fechaIngreso)/100;
            }
            else
            {
                adicional+=sueldoBasico*20/100+sueldoBasico*(antiguedad(fechaIngreso)-20)*25/100;
            }

            if ((cargo==Cargos.Especialista) || (cargo==Cargos.Ingeniero))
            {
                adicional+=adicional*50/100;
            }

            if (estadoCivil=='C')
            {
                adicional+=15000;
            }
            return adicional;
        }
        public double salario(double sueldoBasico, DateTime fechaIngreso, Cargos cargos, char estadoCivil)
        {
            return sueldoBasico+Adicional( sueldoBasico,  fechaIngreso,  cargos,  estadoCivil);
        }


    }


    public enum Cargos
    {
        Auxiliar = 100000,
        Administrativo = 120000,
        Ingeniero = 200000,
        Especialista = 150000,
        Investigador = 170000
    }
    
}
