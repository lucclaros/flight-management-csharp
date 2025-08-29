using System;
using System.Collections; 
namespace EmpresaAterrizar
{
    class CCatalogo
    { 
        private ArrayList listado;
        public CCatalogo()
        { 
            this.listado = new ArrayList();
        }


        
        public bool Registrar(string cod, string orig, string dest, float prec, string tipo)
        {
            foreach (CAereo aux in this.listado) 
            { 
                if(aux.GetCodigo() == cod) 
                {
                    return false;
                }
            }
            this.listado.Add(new CAereo(cod, orig, dest, prec, tipo)); 
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

