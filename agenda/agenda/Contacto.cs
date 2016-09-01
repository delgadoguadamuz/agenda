using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Contacto
    {

        string nombre;

        string apellido;

        string dirrecion;

        int telefonoCasa;

        int telefonoCelular;


        public string Nombre { get; set; }

        public string  Apellido { get; set; }

        public string  Dirrecion { get; set; }

        public int TelefonoCasa { get; set; }

        public int TelefonoCelular { get; set; }


        public string Imprimir()
        {

            return Nombre + "," + Apellido + "," + Dirrecion + "," + TelefonoCasa + "," + TelefonoCelular;

        }





    }
}
