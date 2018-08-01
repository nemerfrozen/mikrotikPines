using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinesRioNaya
{
    public class users
    {
           
            public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Perfil { get; set; }
        public string Tiempo { get; set; }
        public string Deshabilitado { get; set; }


        public users( string Usuario,string Clave,string Perfil,string Tiempo, string Deshabilitado)
            {
               
                this.Usuario = Usuario;
                this.Clave = Clave;
                this.Perfil = Perfil;
                this.Tiempo = Tiempo;
                this.Deshabilitado = Deshabilitado;

                
            }
        
    }
}
