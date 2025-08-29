using System;
using System.Collections; // para el arraylist
namespace EmpresaAterrizar
{
    class CCatalogo
    { // PUNTO A
        private ArrayList listado;
        public CCatalogo()
        { 
            this.listado = new ArrayList();
        }


        // punto b
        public bool Registrar(string cod, string orig, string dest, float prec, string tipo)
        {
            foreach (CAereo aux in this.listado) 
            { 
                if(aux.GetCodigo() == cod) // se manejan los caereo, y puedo ir al getcodigo porque heredó del padre
                {
                    return false;
                }
            }
            this.listado.Add(new CAereo(cod, orig, dest, prec, tipo)); // add y (que se agrega osea un new caereo)
            return true;
        }
        public bool Remover(string cod)
        {
            foreach(CAereo aux in this.listado)
            {
                if(aux.GetCodigo() == cod)
                {
                    this.listado.Remove(aux);
                    return true;
                }
            }
            return false;
        }
        public void Remover()
        {
            this.listado.Clear();
        }




    }
}
