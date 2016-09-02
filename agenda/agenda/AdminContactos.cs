using System.Data;
using System.IO;

namespace agenda
{
    class AdminContactos
    {

        private string archivo;

        public AdminContactos()
        {

            Tabla = new DataTable();
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Apellido");
            Tabla.Columns.Add("Direccion");
            Tabla.Columns.Add("Telefono Casa");
            Tabla.Columns.Add("Telefono Celular");

        }


        public DataTable Tabla { get; set; }


        public string Archivo { get; set; }


        public void AgregarContacto(Contacto contacto)
        {

            DataRow fila = Tabla.NewRow();

            fila["Nombre"] = contacto.Nombre;
            fila["Apellido"] = contacto.Apellido;
            fila["Direccion"] = contacto.Dirrecion;
            fila["Telefono Casa"] = contacto.TelefonoCasa;
            fila["Telefono Celular"] = contacto.TelefonoCelular;

            Tabla.Rows.Add(fila);



        }

        public void GuardarContactos()
        {

            StreamWriter escritor = new StreamWriter(Archivo);

            foreach (DataRow fila in Tabla.Rows)
            {

                string linea = fila["Nombre"] + "," + fila["Apellido"] + "," + fila["Direccion"] + "," + fila["Telefono Casa"] + "," + fila["Telefono Celular"] + ",";

                escritor.WriteLine(linea);
            }

            escritor.Close();


        }
    }
}
