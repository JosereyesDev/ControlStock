using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlStock
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIngresar;
        private Button btnCancelar;
        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblClave;
        private Panel panel;

        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(120, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 25);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.Location = new Point(120, 108);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '●';
            txtClave.Size = new Size(180, 25);
            txtClave.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(52, 152, 219);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(40, 160);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 35);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(127, 140, 141);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(170, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🔒 Control de Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(20, 70);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F);
            lblClave.Location = new Point(20, 110);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(82, 19);
            lblClave.TabIndex = 3;
            lblClave.Text = "Contraseña:";
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblUsuario);
            panel.Controls.Add(txtUsuario);
            panel.Controls.Add(lblClave);
            panel.Controls.Add(txtClave);
            panel.Controls.Add(btnIngresar);
            panel.Controls.Add(btnCancelar);
            panel.Location = new Point(5, 7);
            panel.Name = "panel";
            panel.Size = new Size(320, 230);
            panel.TabIndex = 0;
            // 
            // LoginForm
            // 
            AcceptButton = btnIngresar;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(331, 244);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso - Control de Stock";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
