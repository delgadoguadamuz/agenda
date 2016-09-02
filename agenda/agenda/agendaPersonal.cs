using System;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace agenda
{
    public partial class agendaPersonal : Form
    {
        private AdminContactos adminContactos;


        public agendaPersonal()
        {
            InitializeComponent();

            adminContactos = new AdminContactos();

            dgvContactos.DataSource = adminContactos.Tabla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agendaPersonal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto();

            contacto.Nombre = tbxNombre.Text;
            contacto.Apellido = tbxApellido.Text;
            contacto.Dirrecion= tbxDirrecion.Text;
            contacto.TelefonoCasa = Convert.ToInt32(tbxTelefonoCasa.Text);
            contacto.TelefonoCelular = Convert.ToInt32(tbxTelefonoCelular.Text);

            adminContactos.AgregarContacto(contacto);
            LimpiarForm();

        }

        public void LimpiarForm()
        {
            tbxNombre.Text ="";
            tbxApellido.Text ="";
            tbxDirrecion.Text ="";
            tbxTelefonoCasa.Text ="";
            tbxTelefonoCelular.Text ="";
        }

        private void mnsMenu_Click(object sender, EventArgs e)
        {

        }

        private void smiGuardar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(adminContactos.Archivo))
            {
                SaveFileDialog dialogo = new SaveFileDialog();
                dialogo.Title = "Guardar contactos";
                dialogo.Filter = "Archivo de text| *.txt";
                dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                DialogResult resultado = dialogo.ShowDialog();

                if(resultado == DialogResult.OK)
                {

                    adminContactos.Archivo = dialogo.FileName;

                    adminContactos.GuardarContactos();

                    MessageBox.Show("Archivo guardado exitosamente", "Completado");

                }
            }

        }
    }
}
