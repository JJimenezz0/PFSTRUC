namespace Polinomios
{
    public class Monomio
    {
        public double Coeficiente;
        public int Exponente;
        public Monomio Siguiente;


        public Monomio(double Coeficiente, int Exponente)
        {
            this.Exponente = Exponente;
            this.Coeficiente= Coeficiente;
        }
    }
}
