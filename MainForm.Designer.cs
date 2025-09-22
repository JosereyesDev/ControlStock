namespace ControlStock
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header = new Panel();
            lblTitulo = new Label();
            split = new SplitContainer();
            formPanel = new Panel();
            btnAgregar = new Button();
            txtNotas = new TextBox();
            lblNotas = new Label();
            // CAMBIO: Reemplazar TextBox por NumericUpDown
            txtPrecio = new NumericUpDown();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lvFallas = new ListView();
            colFallaNombre = new ColumnHeader();
            colFallaPrecio = new ColumnHeader();
            colFallaNotas = new ColumnHeader();
            colFallaFecha = new ColumnHeader();
            pedidosPanel = new Panel();
            lvPedidos = new ListView();
            colPedidoNombre = new ColumnHeader();
            colPedidoPrecio = new ColumnHeader();
            colPedidoNotas = new ColumnHeader();
            colPedidoFechaPedido = new ColumnHeader();
            lblPedidos = new Label();
            topPanel = new Panel();
            btnDesbloquear = new Button();

            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)split).BeginInit();
            split.Panel1.SuspendLayout();
            split.Panel2.SuspendLayout();
            split.SuspendLayout();
            formPanel.SuspendLayout();
            // CAMBIO: Inicializar NumericUpDown
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            pedidosPanel.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();

            // 
            // header
            // 
            header.BackColor = Color.FromArgb(67, 97, 238);
            header.Controls.Add(lblTitulo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(984, 100);
            header.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(984, 100);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Control de Stock - Farma Salud Mauroa";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // split
            // 
            split.Dock = DockStyle.Fill;
            split.Location = new Point(0, 100);
            split.Name = "split";
            // 
            // split.Panel1
            // 
            split.Panel1.Controls.Add(formPanel);
            split.Panel1.Padding = new Padding(10);
            // 
            // split.Panel2
            // 
            split.Panel2.Controls.Add(lvFallas);
            split.Panel2.Controls.Add(pedidosPanel);
            split.Panel2.Controls.Add(topPanel);
            split.Panel2.Padding = new Padding(10);
            split.Size = new Size(984, 561);
            split.SplitterDistance = 350;
            split.TabIndex = 1;

            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.Controls.Add(btnAgregar);
            formPanel.Controls.Add(txtNotas);
            formPanel.Controls.Add(lblNotas);
            formPanel.Controls.Add(txtPrecio);
            formPanel.Controls.Add(lblPrecio);
            formPanel.Controls.Add(txtNombre);
            formPanel.Controls.Add(lblNombre);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(10, 10);
            formPanel.Name = "formPanel";
            formPanel.Padding = new Padding(20);
            formPanel.Size = new Size(330, 541);
            formPanel.TabIndex = 0;

            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(67, 97, 238);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(23, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(280, 40);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregar_Click;

            // 
            // txtNotas
            // 
            txtNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNotas.Location = new Point(23, 162);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(280, 23);
            txtNotas.TabIndex = 5;

            // 
            // lblNotas
            // 
            lblNotas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNotas.AutoSize = true;
            lblNotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotas.Location = new Point(23, 140);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(55, 19);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "NOTAS";

            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.DecimalPlaces = 2;
            txtPrecio.Location = new Point(23, 102);
            txtPrecio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(280, 23);
            txtPrecio.TabIndex = 3;
            txtPrecio.ThousandsSeparator = true;

            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecio.Location = new Point(23, 80);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(136, 19);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "ÚLTIMO PRECIO ($)";

            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(23, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 23);
            txtNombre.TabIndex = 1;

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(23, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(177, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE DEL PRODUCTO";

            // 
            // lvFallas
            // 
            lvFallas.BackColor = Color.WhiteSmoke;
            lvFallas.Columns.AddRange(new ColumnHeader[] {
            colFallaNombre,
            colFallaPrecio,
            colFallaNotas,
            colFallaFecha});
            lvFallas.Dock = DockStyle.Fill;
            lvFallas.FullRowSelect = true;
            lvFallas.Location = new Point(10, 60);
            lvFallas.Name = "lvFallas";
            lvFallas.Size = new Size(610, 291);
            lvFallas.TabIndex = 0;
            lvFallas.UseCompatibleStateImageBehavior = false;
            lvFallas.View = View.Details;
            lvFallas.DoubleClick += LvFallas_DoubleClick;

            // 
            // colFallaNombre
            // 
            colFallaNombre.Text = "Producto";
            colFallaNombre.Width = 180;

            // 
            // colFallaPrecio
            // 
            colFallaPrecio.Text = "Precio";
            colFallaPrecio.Width = 80;

            // 
            // colFallaNotas
            // 
            colFallaNotas.Text = "Notas";
            colFallaNotas.Width = 150;

            // 
            // colFallaFecha
            // 
            colFallaFecha.Text = "Fecha Creación";
            colFallaFecha.Width = 120;

            // 
            // pedidosPanel
            // 
            pedidosPanel.BackColor = Color.White;
            pedidosPanel.Controls.Add(lvPedidos);
            pedidosPanel.Controls.Add(lblPedidos);
            pedidosPanel.Dock = DockStyle.Bottom;
            pedidosPanel.Location = new Point(10, 351);
            pedidosPanel.Name = "pedidosPanel";
            pedidosPanel.Padding = new Padding(10);
            pedidosPanel.Size = new Size(610, 200);
            pedidosPanel.TabIndex = 1;

            // 
            // lvPedidos
            // 
            lvPedidos.BackColor = Color.WhiteSmoke;
            lvPedidos.Columns.AddRange(new ColumnHeader[] {
            colPedidoNombre,
            colPedidoPrecio,
            colPedidoNotas,
            colPedidoFechaPedido});
            lvPedidos.Dock = DockStyle.Fill;
            lvPedidos.FullRowSelect = true;
            lvPedidos.Location = new Point(10, 40);
            lvPedidos.Name = "lvPedidos";
            lvPedidos.Size = new Size(590, 150);
            lvPedidos.TabIndex = 1;
            lvPedidos.UseCompatibleStateImageBehavior = false;
            lvPedidos.View = View.Details;

            // 
            // colPedidoNombre
            // 
            colPedidoNombre.Text = "Producto";
            colPedidoNombre.Width = 150;

            // 
            // colPedidoPrecio
            // 
            colPedidoPrecio.Text = "Precio";
            colPedidoPrecio.Width = 70;

            // 
            // colPedidoNotas
            // 
            colPedidoNotas.Text = "Notas";
            colPedidoNotas.Width = 120;

            // 
            // colPedidoFechaPedido
            // 
            colPedidoFechaPedido.Text = "Pedido";
            colPedidoFechaPedido.Width = 90;

            // 
            // lblPedidos
            // 
            lblPedidos.Dock = DockStyle.Top;
            lblPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPedidos.ForeColor = Color.FromArgb(67, 97, 238);
            lblPedidos.Location = new Point(10, 10);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(590, 30);
            lblPedidos.TabIndex = 0;
            lblPedidos.Text = "Productos Pedidos";
            lblPedidos.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnDesbloquear);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(10, 10);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(610, 50);
            topPanel.TabIndex = 2;

            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = Color.FromArgb(67, 97, 238);
            btnDesbloquear.FlatStyle = FlatStyle.Flat;
            btnDesbloquear.ForeColor = Color.White;
            btnDesbloquear.Location = new Point(10, 10);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(180, 35);
            btnDesbloquear.TabIndex = 0;
            btnDesbloquear.Text = "🔒 Desbloquear Pedidos";
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += BtnDesbloquear_Click;

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(984, 661);
            Controls.Add(split);
            Controls.Add(header);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Stock - Droguería";
            Load += MainForm_Load;
            header.ResumeLayout(false);
            split.Panel1.ResumeLayout(false);
            split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split).EndInit();
            split.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            // CAMBIO: Finalizar inicialización de NumericUpDown
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            pedidosPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label lblTitulo;
        private SplitContainer split;
        private Panel formPanel;
        private Button btnAgregar;
        private TextBox txtNotas;
        private Label lblNotas;
        // CAMBIO: Cambiar de TextBox a NumericUpDown
        private NumericUpDown txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private ListView lvFallas;
        private ColumnHeader colFallaNombre;
        private ColumnHeader colFallaPrecio;
        private ColumnHeader colFallaNotas;
        private ColumnHeader colFallaFecha;
        private Panel pedidosPanel;
        private ListView lvPedidos;
        private ColumnHeader colPedidoNombre;
        private ColumnHeader colPedidoPrecio;
        private ColumnHeader colPedidoNotas;
        private ColumnHeader colPedidoFechaPedido;
        private Label lblPedidos;
        private Button btnDesbloquear;
        private Panel topPanel;
    }
}