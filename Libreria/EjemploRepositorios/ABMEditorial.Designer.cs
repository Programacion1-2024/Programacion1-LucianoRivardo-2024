namespace CPresentacion
{
    partial class ABMEditorial
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
            tabControl1 = new TabControl();
            tabAlta = new TabPage();
            bt_agregar = new Button();
            label3 = new Label();
            Direccion = new Label();
            label1 = new Label();
            txt_contacto = new TextBox();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            tabModificar = new TabPage();
            label6 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtContacto = new TextBox();
            txtDireccion = new TextBox();
            btModificar = new Button();
            tabInterfaz = new TabPage();
            dgv_editoriales = new DataGridView();
            tabControl1.SuspendLayout();
            tabAlta.SuspendLayout();
            tabModificar.SuspendLayout();
            tabInterfaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_editoriales).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAlta);
            tabControl1.Controls.Add(tabModificar);
            tabControl1.Controls.Add(tabInterfaz);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(bt_agregar);
            tabAlta.Controls.Add(label3);
            tabAlta.Controls.Add(Direccion);
            tabAlta.Controls.Add(label1);
            tabAlta.Controls.Add(txt_contacto);
            tabAlta.Controls.Add(txt_direccion);
            tabAlta.Controls.Add(txt_nombre);
            tabAlta.Location = new Point(4, 24);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3);
            tabAlta.Size = new Size(768, 398);
            tabAlta.TabIndex = 0;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // bt_agregar
            // 
            bt_agregar.Location = new Point(615, 345);
            bt_agregar.Name = "bt_agregar";
            bt_agregar.Size = new Size(75, 23);
            bt_agregar.TabIndex = 6;
            bt_agregar.Text = "Agregar";
            bt_agregar.UseVisualStyleBackColor = true;
            bt_agregar.Click += bt_agregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 91);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Contacto";
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(272, 91);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(57, 15);
            Direccion.TabIndex = 4;
            Direccion.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txt_contacto
            // 
            txt_contacto.Location = new Point(542, 88);
            txt_contacto.Name = "txt_contacto";
            txt_contacto.Size = new Size(100, 23);
            txt_contacto.TabIndex = 2;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(329, 88);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 1;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(106, 88);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 0;
            // 
            // tabModificar
            // 
            tabModificar.Controls.Add(label6);
            tabModificar.Controls.Add(txtId);
            tabModificar.Controls.Add(label5);
            tabModificar.Controls.Add(label4);
            tabModificar.Controls.Add(label2);
            tabModificar.Controls.Add(txtNombre);
            tabModificar.Controls.Add(txtContacto);
            tabModificar.Controls.Add(txtDireccion);
            tabModificar.Controls.Add(btModificar);
            tabModificar.Location = new Point(4, 24);
            tabModificar.Name = "tabModificar";
            tabModificar.Padding = new Padding(3);
            tabModificar.Size = new Size(768, 398);
            tabModificar.TabIndex = 1;
            tabModificar.Text = "Modificar";
            tabModificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 48);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 8;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(331, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 111);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 6;
            label5.Text = "Contacto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 111);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 111);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(537, 108);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(331, 108);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 1;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(653, 349);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 0;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            btModificar.Click += btModificar_Click;
            // 
            // tabInterfaz
            // 
            tabInterfaz.Controls.Add(dgv_editoriales);
            tabInterfaz.Location = new Point(4, 24);
            tabInterfaz.Name = "tabInterfaz";
            tabInterfaz.Padding = new Padding(3);
            tabInterfaz.Size = new Size(768, 398);
            tabInterfaz.TabIndex = 2;
            tabInterfaz.Text = "Ver Editoriales";
            tabInterfaz.UseVisualStyleBackColor = true;
            // 
            // dgv_editoriales
            // 
            dgv_editoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_editoriales.Location = new Point(24, 39);
            dgv_editoriales.Name = "dgv_editoriales";
            dgv_editoriales.Size = new Size(721, 327);
            dgv_editoriales.TabIndex = 0;
            dgv_editoriales.SelectionChanged += ABMEditorial_Load;
            // 
            // ABMEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ABMEditorial";
            Text = "ABMEditorial";
            tabControl1.ResumeLayout(false);
            tabAlta.ResumeLayout(false);
            tabAlta.PerformLayout();
            tabModificar.ResumeLayout(false);
            tabModificar.PerformLayout();
            tabInterfaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_editoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAlta;
        private Label label3;
        private Label Direccion;
        private Label label1;
        private TextBox txt_contacto;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private TabPage tabModificar;
        private Button bt_agregar;
        private TextBox txtNombre;
        private TextBox txtContacto;
        private TextBox txtDireccion;
        private Button btModificar;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtId;
        private TabPage tabInterfaz;
        private DataGridView dgv_editoriales;
    }
}