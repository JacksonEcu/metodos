using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    class Farmacia
    {

        
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Contactos { get; set; }
        public string Atencion { get; set; }



        public Farmacia()
        { }

        public string bienvenido()
        {
            return $"Buenas tardes tu farmacia del barrio te da la bienvenida: {Nombre} \n Como podemos ayudarte\n";

 }
        public string adios()
        {
            return $"Una execelente tarde gracias por preferirnos {Nombre} \n Vuelva pronto";
        }

    }
}
