using System;
namespace EmpresaAterrizar
{
    class CAereo : CViaje
    {
        private static float impuesto;
        private string tipo_de_vuelo; // esto deberia ser una clase!

        public static void SetImpuesto(float imp)
        {
            // this.impuesto = imp;
            CAereo.impuesto = imp;
        }
        public CAereo(string cod, string orig, string dest, float pre, string tipo): base(cod, orig, dest) // como no puedo acceder desde aca al constructor de cviaje, lo mando por : base
        {
            this.PrecioViaje = pre;
            this.tipo_de_vuelo = tipo;
        }

        public override string darDatos()
        {
            return base.darDatos() + " - Impuesto de: " + CAereo.impuesto.ToString() + " - Tipo de vuelo: " + this.tipo_de_vuelo; // NO OLVIDARME DEL TOSTRING!!!!!!!!!!!!!!!!!!!!!
        } 

    }
}
