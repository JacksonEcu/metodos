using System;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" FARMACIAS ECONOMICAS");
            var farmacia = new Farmacia();
            farmacia.Nombre = "Economicas";
           farmacia.Ubicacion = "Parque la carolina";
           farmacia.Contactos = 0959818472;
           farmacia.Atencion = "De lunes a viernes";

            string bienv = farmacia.bienvenido();
            Console.Write(bienv);

         

            Cliente cliente = new Cliente();
            
            cliente.Nombre = "Jackson";
            cliente.Direccion = "Quito";
            cliente.Cedula = 1750090137;
            cliente.Contacto = 0959818472;

            string bu = cliente.buenass();
            Console.Write(bu);
            Dispensa dispensa = new Dispensa();
            dispensa.Nombre = "Lemonflu";
            dispensa.Proveniencia = "Ecuador";
            dispensa.Marca= "lemonflu 5000ml";
            dispensa.Color = "Caja verde";

            string disp = dispensa.dispe();
            Console.Write(disp);

            Uso uso = new Uso ();

            uso.Cantidad = 2;
            uso.tomas = "2 Veces al dia";
            uso.Advertencia = "Abierto";
            uso.Caducidad = "Maximo 30 dias";

            string us = uso.cantidad();
            Console.Write(us);


            Factura factura = new Factura();


            factura.Gerente = "Jose luis";
            factura.numfact = 0123;
            factura.Inventario = "Disponible";
            factura.estimado = "15 dias laborables\n";

            string fa = factura.Fact();
            Console.Write(fa);

            string ad = farmacia.adios();
            Console.Write(ad);
            Console.ReadKey();
        }
    }
}
