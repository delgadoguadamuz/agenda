using System.Data;

namespace agenda
{
    class AdminContactos
    {
        

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
    }
}
