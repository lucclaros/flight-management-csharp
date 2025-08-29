using System;
namespace EmpresaAterrizar
{
    class CAereo : CViaje
    {
        private static float impuesto;
        private string tipo_de_vuelo; 

        public static void SetImpuesto(float imp)
        {
            
            CAereo.impuesto = imp;
        }
        public CAereo(string cod, string orig, string dest, float pre, string tipo): base(cod, orig, dest) 
        {
            this.PrecioViaje = pre;
            this.tipo_de_vuelo = tipo;
        }

        public override string darDatos()
        {
            return base.darDatos() + " - Impuesto de: " + CAereo.impuesto.ToString() + " - Tipo de vuelo: " + this.tipo_de_vuelo; 
        } 

    }
}

