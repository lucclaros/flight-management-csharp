using System;
using System.Diagnostics;

namespace EmpresaAterrizar
{
    abstract class CViaje : IComparable
    {
        private string codigo;
        private string origen;
        private string destino;
        private float precio;

        public CViaje(string cod, string orig, string dest)
        {
            this.codigo = cod;
            this.origen = orig;
            this.destino = dest;
        }
        public string GetOrigen()
        {
            return this.origen;
        }
        public string GetDestino()
        {
            return this.destino;
        }
        public string GetCodigo()
        {
            return this.codigo;
        }
        public float PrecioViaje
        {
            set { this.precio = value; }
            get { return this.precio; }
        }
        public float darPrecio(float cuotas)
        {
            if (cuotas == 1)
            {
                return this.precio;
            }
            else if (cuotas == 3)
            {
                return this.precio + (this.precio * 0.1F);
            }
            else if (cuotas == 6)
            {
                return this.precio + (this.precio * 0.2F);
            }
            else if (cuotas == 12)
            {
                return this.precio + (this.precio * 0.4F);
            }
            else
            {
                Console.WriteLine("Solo pueden ser cuotas de 1, 3, 6 o 12");
                return -1;
            }
        }
        public virtual string darDatos()
        {
            string datos = "Codigo del vuelo: " + this.codigo;
            datos += " - Origen del vuelo: " + this.origen;
            datos += " - Destino: " + this.destino;
            datos += " - Precio: " + this.precio.ToString(); 
            return datos;
        }
        public int CompareTo(Object? obj)
        {

            if (this.origen == ((CViaje)obj).GetOrigen() && this.destino == ((CViaje)obj).GetDestino())
            {
                return 0;
            }
            else if (this.origen == ((CViaje)obj).GetOrigen() && this.destino != ((CViaje)obj).GetDestino())
            {
                return 1;
            }
            else if (this.origen != ((CViaje)obj).GetOrigen() && this.destino == ((CViaje)obj).GetDestino())
            {
                return 2;
            }

            return 3;
        }
    }

}
