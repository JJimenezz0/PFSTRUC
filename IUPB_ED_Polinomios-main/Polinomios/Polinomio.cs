using System;
using System.Windows.Forms;

namespace Polinomios
{
    public class Polinomio
    {
        private Monomio Cabeza;

        public Polinomio()
        {
            Cabeza = null;
        }

        public Monomio GetCabeza()
        {
            return Cabeza;
        }

        public void Agregar(Monomio monomio)
        {
            if (monomio != null)
            {
                if (Cabeza == null)
                {
                    Cabeza = monomio;
                }
                else
                {
                    Monomio apuntador = Cabeza;
                    Monomio predecesor = null;
                    while (apuntador != null)
                    {
                        if (monomio.Exponente == apuntador.Exponente)
                        {
                            apuntador.Coeficiente += monomio.Coeficiente;
                            if (Math.Abs(apuntador.Coeficiente) < 1e-10) // Eliminar términos con coeficiente cero
                            {
                                if (predecesor == null)
                                {
                                    Cabeza = apuntador.Siguiente;
                                }
                                else
                                {
                                    predecesor.Siguiente = apuntador.Siguiente;
                                }
                            }
                            return;
                        }
                        else if (monomio.Exponente > apuntador.Exponente)
                        {
                            if (predecesor == null)
                            {
                                monomio.Siguiente = Cabeza;
                                Cabeza = monomio;
                            }
                            else
                            {
                                monomio.Siguiente = predecesor.Siguiente;
                                predecesor.Siguiente = monomio;
                            }
                            return;
                        }
                        predecesor = apuntador;
                        apuntador = apuntador.Siguiente;
                    }
                    predecesor.Siguiente = monomio; // Insertar al final
                }
            }
        }

        public void Mostrar(Label lbl)
        {
            if (Cabeza == null)
            {
                lbl.Text = "0";
                return;
            }

            Monomio apuntador = Cabeza;
            string resultado = "";

            while (apuntador != null)
            {
                if (apuntador.Coeficiente > 0 && resultado.Length > 0)
                {
                    resultado += "+";
                }
                resultado += $"{apuntador.Coeficiente}x^{apuntador.Exponente}";
                apuntador = apuntador.Siguiente;
            }

            lbl.Text = resultado;
        }

        public Polinomio Derivar()
        {
            Polinomio derivada = new Polinomio();
            Monomio apuntador = Cabeza;

            while (apuntador != null)
            {
                if (apuntador.Exponente != 0)
                {
                    derivada.Agregar(new Monomio(apuntador.Coeficiente * apuntador.Exponente, apuntador.Exponente - 1));
                }
                apuntador = apuntador.Siguiente;
            }

            return derivada;
        }

        public static Polinomio Sumar(Polinomio p1, Polinomio p2)
        {
            Polinomio resultado = new Polinomio();
            Monomio apuntador1 = p1.GetCabeza();
            Monomio apuntador2 = p2.GetCabeza();

            while (apuntador1 != null || apuntador2 != null)
            {
                if (apuntador1 != null && (apuntador2 == null || apuntador1.Exponente > apuntador2.Exponente))
                {
                    resultado.Agregar(new Monomio(apuntador1.Coeficiente, apuntador1.Exponente));
                    apuntador1 = apuntador1.Siguiente;
                }
                else if (apuntador2 != null && (apuntador1 == null || apuntador2.Exponente > apuntador1.Exponente))
                {
                    resultado.Agregar(new Monomio(apuntador2.Coeficiente, apuntador2.Exponente));
                    apuntador2 = apuntador2.Siguiente;
                }
                else
                {
                    double coeficienteSumado = apuntador1.Coeficiente + apuntador2.Coeficiente;
                    if (Math.Abs(coeficienteSumado) > 1e-10) // Solo agregar si el coeficiente no es cero
                    {
                        resultado.Agregar(new Monomio(coeficienteSumado, apuntador1.Exponente));
                    }
                    apuntador1 = apuntador1.Siguiente;
                    apuntador2 = apuntador2.Siguiente;
                }
            }

            return resultado;
        }

        public static Polinomio Restar(Polinomio p1, Polinomio p2)
        {
            Polinomio resultado = new Polinomio();
            Monomio apuntador1 = p1.GetCabeza();
            Monomio apuntador2 = p2.GetCabeza();

            while (apuntador1 != null || apuntador2 != null)
            {
                if (apuntador1 != null && (apuntador2 == null || apuntador1.Exponente > apuntador2.Exponente))
                {
                    resultado.Agregar(new Monomio(apuntador1.Coeficiente, apuntador1.Exponente));
                    apuntador1 = apuntador1.Siguiente;
                }
                else if (apuntador2 != null && (apuntador1 == null || apuntador2.Exponente > apuntador1.Exponente))
                {
                    resultado.Agregar(new Monomio(-apuntador2.Coeficiente, apuntador2.Exponente));
                    apuntador2 = apuntador2.Siguiente;
                }
                else
                {
                    double coeficienteRestado = apuntador1.Coeficiente - apuntador2.Coeficiente;
                    if (Math.Abs(coeficienteRestado) > 1e-10) // Solo agregar si el coeficiente no es cero
                    {
                        resultado.Agregar(new Monomio(coeficienteRestado, apuntador1.Exponente));
                    }
                    apuntador1 = apuntador1.Siguiente;
                    apuntador2 = apuntador2.Siguiente;
                }
            }

            return resultado;
        }

        public static Polinomio Multiplicar(Polinomio p1, Polinomio p2)
        {
            Polinomio resultado = new Polinomio();
            Monomio apuntador1 = p1.GetCabeza();

            while (apuntador1 != null)
            {
                Monomio apuntador2 = p2.GetCabeza();
                while (apuntador2 != null)
                {
                    double coeficienteProducto = apuntador1.Coeficiente * apuntador2.Coeficiente;
                    int exponenteProducto = apuntador1.Exponente + apuntador2.Exponente;
                    resultado.Agregar(new Monomio(coeficienteProducto, exponenteProducto));
                    apuntador2 = apuntador2.Siguiente;
                }
                apuntador1 = apuntador1.Siguiente;
            }

            return resultado;
        }

        public void Dividir(Polinomio divisor, out Polinomio cociente, out Polinomio residuo)
        {
            cociente = new Polinomio();
            residuo = new Polinomio();
            residuo = this; // Inicialmente, el residuo es el dividendo

            while (residuo.GetCabeza() != null && residuo.GetCabeza().Exponente >= divisor.GetCabeza().Exponente)
            {
                double coeficienteCociente = residuo.GetCabeza().Coeficiente / divisor.GetCabeza().Coeficiente;
                int exponenteCociente = residuo.GetCabeza().Exponente - divisor.GetCabeza().Exponente;
                Monomio monomioCociente = new Monomio(coeficienteCociente, exponenteCociente);
                cociente.Agregar(monomioCociente);

                // Restar el divisor multiplicado por el monomioCociente del residuo
                Monomio apuntadorDivisor = divisor.GetCabeza();
                while (apuntadorDivisor != null)
                {
                    double nuevoCoeficiente = apuntadorDivisor.Coeficiente * coeficienteCociente;
                    int nuevoExponente = apuntadorDivisor.Exponente;
                    residuo.Agregar(new Monomio(-nuevoCoeficiente, nuevoExponente)); // Restar directamente
                    apuntadorDivisor = apuntadorDivisor.Siguiente;
                }

                // Limpiar los términos cero en el residuo
                residuo = LimpiarTerminosCero(residuo);
            }
        }

        private Polinomio LimpiarTerminosCero(Polinomio polinomio)
        {
            Polinomio resultado = new Polinomio();
            Monomio apuntador = polinomio.GetCabeza();
            while (apuntador != null)
            {
                if (Math.Abs(apuntador.Coeficiente) > 1e-10) // Solo agregar si el coeficiente no es cero
                {
                    resultado.Agregar(new Monomio(apuntador.Coeficiente, apuntador.Exponente));
                }
                apuntador = apuntador.Siguiente;
            }
            return resultado;
        }
    }
}