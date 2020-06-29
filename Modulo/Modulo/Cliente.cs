using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Cedula { get; set; }
        public int Contacto { get; set; }

        public string bienvenido()
        {
            return $"Buenas tardes, {Nombre} como podemos ayudarte:";
            }

        public string buenass()
        {

            return $"{Nombre} \n";

        }
    }

}
