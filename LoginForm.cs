using System;
using System.Windows.Forms;

namespace ControlStock
{
    public partial class LoginForm : Form
    {
        public bool AccesoPermitido { get; private set; } = false;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Acceso - Control de Stock";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            // Aquí puedes validar contra base de datos
            if (usuario == "admin" && clave == "123")
            {
                AccesoPermitido = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
