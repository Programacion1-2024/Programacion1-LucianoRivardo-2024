namespace CPresentacion
{
    partial class ABMAutor
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
            openFileDialog1 = new OpenFileDialog();
            tabModificacion = new TabPage();
            tbIdAutorModificacion = new TextBox();
            tbFechaNacimientoModificacion = new TextBox();
            tbBiografiaModificacion = new TextBox();
            tbEmailModificacion = new TextBox();
            tbNacionalidadModificacion = new TextBox();
            tbTelefonoModificacion = new TextBox();
            tbApellidoModificacion = new TextBox();
            tbNombreModificacion = new TextBox();
            lbIdAutorModificacion = new Label();
            lbFechaNacimientoModificacion = new Label();
            btnActualizar = new Button();
            lbBiografiaModificacion = new Label();
            lbEmailModificacion = new Label();
            lbNacionalidadModificacion = new Label();
            lbTelefonoModificacion = new Label();
            lbApellidoModificacion = new Label();
            bvNombreModificacion = new Label();
            tabAlta = new TabPage();
            lbFechaNacimientoAlta = new Label();
            tbFechaNacimientoAlta = new TextBox();
            tbBiografiaAlta = new TextBox();
            tbEmailAlta = new TextBox();
            tbNacionalidadAlta = new TextBox();
            tbTelefonoAlta = new TextBox();
            tbApellidoAlta = new TextBox();
            tbNombreAlta = new TextBox();
            btnGuardar = new Button();
            lbBiografiaAlta = new Label();
            lbEmailAlta = new Label();
            lbNacionalidadAlta = new Label();
            lbTelefonoAlta = new Label();
            lbApellidoAlta = new Label();
            lblNombreAlta = new Label();
            tabListado = new TabPage();
            bnRecargarAlta = new Button();
            dgvListadoAutores = new DataGridView();
            tabControlPrincipal = new TabControl();
            tabModificacion.SuspendLayout();
            tabAlta.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            tabControlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(tbIdAutorModificacion);
            tabModificacion.Controls.Add(tbFechaNacimientoModificacion);
            tabModificacion.Controls.Add(tbBiografiaModificacion);
            tabModificacion.Controls.Add(tbEmailModificacion);
            tabModificacion.Controls.Add(tbNacionalidadModificacion);
            tabModificacion.Controls.Add(tbTelefonoModificacion);
            tabModificacion.Controls.Add(tbApellidoModificacion);
            tabModificacion.Controls.Add(tbNombreModificacion);
            tabModificacion.Controls.Add(lbIdAutorModificacion);
            tabModificacion.Controls.Add(lbFechaNacimientoModificacion);
            tabModificacion.Controls.Add(btnActualizar);
            tabModificacion.Controls.Add(lbBiografiaModificacion);
            tabModificacion.Controls.Add(lbEmailModificacion);
            tabModificacion.Controls.Add(lbNacionalidadModificacion);
            tabModificacion.Controls.Add(lbTelefonoModificacion);
            tabModificacion.Controls.Add(lbApellidoModificacion);
            tabModificacion.Controls.Add(bvNombreModificacion);
            tabModificacion.Location = new Point(4, 24);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3);
            tabModificacion.Size = new Size(859, 458);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // tbIdAutorModificacion
            // 
            tbIdAutorModificacion.Location = new Point(374, 34);
            tbIdAutorModificacion.Name = "tbIdAutorModificacion";
            tbIdAutorModificacion.Size = new Size(158, 23);
            tbIdAutorModificacion.TabIndex = 0;
            tbIdAutorModificacion.TextChanged += tbIdAutorModificacion_TextChanged;
            // 
            // tbFechaNacimientoModificacion
            // 
            tbFechaNacimientoModificacion.Location = new Point(502, 118);
            tbFechaNacimientoModificacion.Name = "tbFechaNacimientoModificacion";
            tbFechaNacimientoModificacion.Size = new Size(158, 23);
            tbFechaNacimientoModificacion.TabIndex = 4;
            // 
            // tbBiografiaModificacion
            // 
            tbBiografiaModificacion.Location = new Point(225, 227);
            tbBiografiaModificacion.Multiline = true;
            tbBiografiaModificacion.Name = "tbBiografiaModificacion";
            tbBiografiaModificacion.Size = new Size(435, 127);
            tbBiografiaModificacion.TabIndex = 7;
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(225, 165);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(158, 23);
            tbEmailModificacion.TabIndex = 5;
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Location = new Point(225, 118);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(158, 23);
            tbNacionalidadModificacion.TabIndex = 3;
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(502, 165);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(158, 23);
            tbTelefonoModificacion.TabIndex = 6;
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Location = new Point(502, 72);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(158, 23);
            tbApellidoModificacion.TabIndex = 2;
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Location = new Point(225, 72);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(158, 23);
            tbNombreModificacion.TabIndex = 1;
            // 
            // lbIdAutorModificacion
            // 
            lbIdAutorModificacion.AutoSize = true;
            lbIdAutorModificacion.Location = new Point(312, 36);
            lbIdAutorModificacion.Name = "lbIdAutorModificacion";
            lbIdAutorModificacion.Size = new Size(51, 15);
            lbIdAutorModificacion.TabIndex = 27;
            lbIdAutorModificacion.Text = "ID Autor";
            // 
            // lbFechaNacimientoModificacion
            // 
            lbFechaNacimientoModificacion.AutoSize = true;
            lbFechaNacimientoModificacion.Location = new Point(389, 121);
            lbFechaNacimientoModificacion.Name = "lbFechaNacimientoModificacion";
            lbFechaNacimientoModificacion.Size = new Size(103, 15);
            lbFechaNacimientoModificacion.TabIndex = 26;
            lbFechaNacimientoModificacion.Text = "Fecha Nacimiento";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(411, 380);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lbBiografiaModificacion
            // 
            lbBiografiaModificacion.AutoSize = true;
            lbBiografiaModificacion.Location = new Point(134, 230);
            lbBiografiaModificacion.Name = "lbBiografiaModificacion";
            lbBiografiaModificacion.Size = new Size(54, 15);
            lbBiografiaModificacion.TabIndex = 25;
            lbBiografiaModificacion.Text = "Biografia";
            // 
            // lbEmailModificacion
            // 
            lbEmailModificacion.AutoSize = true;
            lbEmailModificacion.Location = new Point(134, 168);
            lbEmailModificacion.Name = "lbEmailModificacion";
            lbEmailModificacion.Size = new Size(36, 15);
            lbEmailModificacion.TabIndex = 24;
            lbEmailModificacion.Text = "Email";
            // 
            // lbNacionalidadModificacion
            // 
            lbNacionalidadModificacion.AutoSize = true;
            lbNacionalidadModificacion.Location = new Point(134, 121);
            lbNacionalidadModificacion.Name = "lbNacionalidadModificacion";
            lbNacionalidadModificacion.Size = new Size(77, 15);
            lbNacionalidadModificacion.TabIndex = 23;
            lbNacionalidadModificacion.Text = "Nacionalidad";
            // 
            // lbTelefonoModificacion
            // 
            lbTelefonoModificacion.AutoSize = true;
            lbTelefonoModificacion.Location = new Point(438, 168);
            lbTelefonoModificacion.Name = "lbTelefonoModificacion";
            lbTelefonoModificacion.Size = new Size(52, 15);
            lbTelefonoModificacion.TabIndex = 19;
            lbTelefonoModificacion.Text = "Telefono";
            // 
            // lbApellidoModificacion
            // 
            lbApellidoModificacion.AutoSize = true;
            lbApellidoModificacion.Location = new Point(439, 74);
            lbApellidoModificacion.Name = "lbApellidoModificacion";
            lbApellidoModificacion.Size = new Size(51, 15);
            lbApellidoModificacion.TabIndex = 17;
            lbApellidoModificacion.Text = "Apellido";
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(134, 72);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(51, 15);
            bvNombreModificacion.TabIndex = 14;
            bvNombreModificacion.Text = "Nombre";
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(lbFechaNacimientoAlta);
            tabAlta.Controls.Add(tbFechaNacimientoAlta);
            tabAlta.Controls.Add(tbBiografiaAlta);
            tabAlta.Controls.Add(tbEmailAlta);
            tabAlta.Controls.Add(tbNacionalidadAlta);
            tabAlta.Controls.Add(tbTelefonoAlta);
            tabAlta.Controls.Add(tbApellidoAlta);
            tabAlta.Controls.Add(tbNombreAlta);
            tabAlta.Controls.Add(btnGuardar);
            tabAlta.Controls.Add(lbBiografiaAlta);
            tabAlta.Controls.Add(lbEmailAlta);
            tabAlta.Controls.Add(lbNacionalidadAlta);
            tabAlta.Controls.Add(lbTelefonoAlta);
            tabAlta.Controls.Add(lbApellidoAlta);
            tabAlta.Controls.Add(lblNombreAlta);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(859, 458);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // lbFechaNacimientoAlta
            // 
            lbFechaNacimientoAlta.AutoSize = true;
            lbFechaNacimientoAlta.Location = new Point(389, 121);
            lbFechaNacimientoAlta.Name = "lbFechaNacimientoAlta";
            lbFechaNacimientoAlta.Size = new Size(103, 15);
            lbFechaNacimientoAlta.TabIndex = 11;
            lbFechaNacimientoAlta.Text = "Fecha Nacimiento";
            // 
            // tbFechaNacimientoAlta
            // 
            tbFechaNacimientoAlta.Location = new Point(502, 118);
            tbFechaNacimientoAlta.Name = "tbFechaNacimientoAlta";
            tbFechaNacimientoAlta.Size = new Size(158, 23);
            tbFechaNacimientoAlta.TabIndex = 3;
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Location = new Point(225, 227);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(435, 127);
            tbBiografiaAlta.TabIndex = 6;
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(225, 165);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(158, 23);
            tbEmailAlta.TabIndex = 4;
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(225, 118);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(158, 23);
            tbNacionalidadAlta.TabIndex = 2;
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(502, 165);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(158, 23);
            tbTelefonoAlta.TabIndex = 5;
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(502, 72);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(158, 23);
            tbApellidoAlta.TabIndex = 1;
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(225, 72);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(158, 23);
            tbNombreAlta.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(411, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lbBiografiaAlta
            // 
            lbBiografiaAlta.AutoSize = true;
            lbBiografiaAlta.Location = new Point(134, 230);
            lbBiografiaAlta.Name = "lbBiografiaAlta";
            lbBiografiaAlta.Size = new Size(54, 15);
            lbBiografiaAlta.TabIndex = 10;
            lbBiografiaAlta.Text = "Biografia";
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(134, 168);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(36, 15);
            lbEmailAlta.TabIndex = 9;
            lbEmailAlta.Text = "Email";
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(134, 121);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(77, 15);
            lbNacionalidadAlta.TabIndex = 7;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(438, 168);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(52, 15);
            lbTelefonoAlta.TabIndex = 5;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(439, 74);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(51, 15);
            lbApellidoAlta.TabIndex = 3;
            lbApellidoAlta.Text = "Apellido";
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(134, 72);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(51, 15);
            lblNombreAlta.TabIndex = 1;
            lblNombreAlta.Text = "Nombre";
            // 
            // tabListado
            // 
            tabListado.Controls.Add(bnRecargarAlta);
            tabListado.Controls.Add(dgvListadoAutores);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(859, 458);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // bnRecargarAlta
            // 
            bnRecargarAlta.Location = new Point(770, 434);
            bnRecargarAlta.Margin = new Padding(3, 2, 3, 2);
            bnRecargarAlta.Name = "bnRecargarAlta";
            bnRecargarAlta.Size = new Size(82, 22);
            bnRecargarAlta.TabIndex = 1;
            bnRecargarAlta.Text = "Recargar";
            bnRecargarAlta.UseVisualStyleBackColor = true;
            bnRecargarAlta.Click += bnRecargarAlta_Click;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.Location = new Point(3, 3);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.RowHeadersWidth = 51;
            dgvListadoAutores.Size = new Size(850, 425);
            dgvListadoAutores.TabIndex = 0;
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Location = new Point(12, 12);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(867, 486);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 510);
            Controls.Add(tabControlPrincipal);
            Name = "ABMAutor";
            Text = "Sistema de Gestion de Libreria";
            Load += ABMAutor_Load;
            tabModificacion.ResumeLayout(false);
            tabModificacion.PerformLayout();
            tabAlta.ResumeLayout(false);
            tabAlta.PerformLayout();
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            tabControlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TabPage tabModificacion;
        private TextBox tbIdAutorModificacion;
        private TextBox tbFechaNacimientoModificacion;
        private TextBox tbBiografiaModificacion;
        private TextBox tbEmailModificacion;
        private TextBox tbNacionalidadModificacion;
        private TextBox tbTelefonoModificacion;
        private TextBox tbApellidoModificacion;
        private TextBox tbNombreModificacion;
        private Label lbIdAutorModificacion;
        private Label lbFechaNacimientoModificacion;
        private Button btnActualizar;
        private Label lbBiografiaModificacion;
        private Label lbEmailModificacion;
        private Label lbNacionalidadModificacion;
        private Label lbTelefonoModificacion;
        private Label lbApellidoModificacion;
        private Label bvNombreModificacion;
        private TabPage tabAlta;
        private Label lbFechaNacimientoAlta;
        private TextBox tbFechaNacimientoAlta;
        private TextBox tbBiografiaAlta;
        private TextBox tbEmailAlta;
        private TextBox tbNacionalidadAlta;
        private TextBox tbTelefonoAlta;
        private TextBox tbApellidoAlta;
        private TextBox tbNombreAlta;
        private Button btnGuardar;
        private Label lbBiografiaAlta;
        private Label lbEmailAlta;
        private Label lbNacionalidadAlta;
        private Label lbTelefonoAlta;
        private Label lbApellidoAlta;
        private Label lblNombreAlta;
        private TabPage tabListado;
        private DataGridView dgvListadoAutores;
        private TabControl tabControlPrincipal;
        private Button bnRecargarAlta;
    }
}