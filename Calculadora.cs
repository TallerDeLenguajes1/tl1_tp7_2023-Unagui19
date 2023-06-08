namespace EspacioCalculadora
{
    class Calculadora
    {
        private double dato=0;
        public double Resultado { get => dato;}
       public void Sumar(double a)
        {
            dato+=a;
        }
        public void Restar(double a)   
        {
            dato-=a;
        }
        public void Multiplicar(double a)
        {
            dato*=a;
        }
        public void Dividir(double a)
        {
            dato/=a;
        }
        public void Limpiar()
        {
            dato=0;
        }
    }



}