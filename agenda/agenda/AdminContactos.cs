using System.Data;

namespace agenda
{
    class AdminContactos
    {
        

        public AdminContactos()
        {

            Tabla = new DataTable();

        }

        public DataTable Tabla { get; set; }

        public void AgregarContacto(Contacto contacto)
        {

            DataRow fila = Tabla.NewRow();

        }

    }
}
