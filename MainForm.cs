using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ControlStock
{
    public partial class MainForm : Form
    {
        private DatabaseHelper db;
        private CultureInfo cultureDolares = new CultureInfo("en-US");
        private bool pedidosBloqueados = true; // Por defecto bloqueado

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Control de Stock - Droguería";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#f5f7fa");

            db = new DatabaseHelper("controlstock.db");
            CargarDatos();

            // Configurar eventos KeyDown para navegación con Enter
            txtNombre.KeyDown += TxtNombre_KeyDown;
            txtPrecio.KeyDown += TxtPrecio_KeyDown;
            txtNotas.KeyDown += TxtNotas_KeyDown;

            lvPedidos.MouseDown += LvPedidos_MouseDown;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtPrecio.Value == 0)
            {
                MessageBox.Show("Complete los datos correctamente");
                txtNombre.Focus();
                return;
            }

            string nombreMayusculas = txtNombre.Text.ToUpper();
            string notasMayusculas = txtNotas.Text.ToUpper();

            db.AgregarFalla(nombreMayusculas, (decimal)txtPrecio.Value, notasMayusculas);
            CargarDatos();
            txtNombre.Clear();
            txtPrecio.Value = 0;
            txtNotas.Clear();
            txtNombre.Focus(); // Volver al primer campo después de agregar
        }

        private void LvFallas_DoubleClick(object sender, EventArgs e)
        {
            if (lvFallas.SelectedItems.Count == 0) return;

            if (pedidosBloqueados)
            {
                MessageBox.Show("Los pedidos están bloqueados. Ingresa la contraseña para desbloquear.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvFallas.SelectedItems[0].Tag is long id)
            {
                db.PedirFalla(id);
                CargarDatos();
            }
        }

        private void LvPedidos_MouseDown(object sender, MouseEventArgs e)
        {
            if (pedidosBloqueados)
            {
                lvPedidos.SelectedItems.Clear(); // No permite seleccionar mientras está bloqueado
            }
        }

        private void BtnDesbloquear_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                // Propiedades generales del formulario
                form.Text = "";
                form.Size = new Size(350, 180);
                form.FormBorderStyle = FormBorderStyle.None; // Sin borde
                form.StartPosition = FormStartPosition.CenterParent;
                form.BackColor = Color.White;
                form.Padding = new Padding(10);

                // Panel superior azul (header)
                Panel header = new Panel()
                {
                    Dock = DockStyle.Top,
                    Height = 50,
                    BackColor = Color.FromArgb(67, 97, 238),
                };
                Label lblTitulo = new Label()
                {
                    Text = "Desbloquear Pedidos",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                header.Controls.Add(lblTitulo);
                form.Controls.Add(header);

                // Label de instrucciones
                Label lbl = new Label()
                {
                    Text = "Ingresa la contraseña:",
                    Left = 20,
                    Top = 70,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(30, 30, 30)
                };

                // TextBox de contraseña
                TextBox txt = new TextBox()
                {
                    Left = 20,
                    Top = 100,
                    Width = 300,
                    Font = new Font("Segoe UI", 10F),
                    UseSystemPasswordChar = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke
                };

                // Botón OK
                Button btnOk = new Button()
                {
                    Text = "🔓 Desbloquear",
                    Left = 110,
                    Top = 135,
                    Width = 120,
                    Height = 35,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(67, 97, 238),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    DialogResult = DialogResult.OK
                };
                btnOk.FlatAppearance.BorderSize = 0;

                // Añadir controles al formulario
                form.Controls.Add(lbl);
                form.Controls.Add(txt);
                form.Controls.Add(btnOk);

                form.AcceptButton = btnOk;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string password = txt.Text;
                    if (password == "123") // <-- tu contraseña
                    {
                        pedidosBloqueados = false; // desbloquear los pedidos
                        btnDesbloquear.Text = "🔓 Pedidos Desbloqueados";
                        btnDesbloquear.BackColor = Color.Green;
                        MessageBox.Show("Pedidos desbloqueados!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarDatos()
        {
            lvFallas.Items.Clear();
            foreach (var f in db.ObtenerFallas())
            {
                var item = new ListViewItem(f.Name);
                item.SubItems.Add(f.Price.ToString("C2", cultureDolares));
                item.SubItems.Add(f.Notes ?? string.Empty);
                item.SubItems.Add(f.FechaCreacion);
                item.Tag = f.Id;
                lvFallas.Items.Add(item);
            }

            lvPedidos.Items.Clear();
            foreach (var p in db.ObtenerPedidos())
            {
                var item = new ListViewItem(p.Name);
                item.SubItems.Add(p.Price.ToString("C2", cultureDolares));
                item.SubItems.Add(p.Notes ?? string.Empty);
                item.SubItems.Add(p.FechaCreacion);
                item.SubItems.Add(p.FechaPedido);
                lvPedidos.Items.Add(item);
            }
        }

        // MÉTODOS PARA NAVEGACIÓN CON ENTER
        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del sistema
                txtPrecio.Focus();
                txtPrecio.Select(0, txtPrecio.Text.Length); // Selecciona todo el texto
            }
        }

        private void TxtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del sistema
                txtNotas.Focus();
            }
        }

        private void TxtNotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido del sistema
                BtnAgregar_Click(sender, e); // Llama al método de agregar
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtNombre.Focus(); // Poner foco en el campo de nombre al cargar el formulario
        }

        // Eventos KeyPress para validaciones adicionales (opcional)
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Puedes agregar validaciones específicas si es necesario
        }

        private void TxtNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Puedes agregar validaciones específicas si es necesario
        }
    }
}