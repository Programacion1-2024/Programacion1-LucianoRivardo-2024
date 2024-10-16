namespace CPresentacion
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            label1 = new Label();
            rjButton1 = new RJButton();
            bt_editoriales = new RJButton();
            bt_libros = new RJButton();
            rJfotos1 = new RJfotos();
            ((System.ComponentModel.ISupportInitialize)rJfotos1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 193);
            label1.Name = "label1";
            label1.Size = new Size(334, 81);
            label1.TabIndex = 3;
            label1.Text = "Libreria ICES";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.SlateBlue;
            rjButton1.BackgroundColor = Color.SlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(32, 22);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 4;
            rjButton1.Text = "AUTORES";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // bt_editoriales
            // 
            bt_editoriales.BackColor = Color.MediumSlateBlue;
            bt_editoriales.BackgroundColor = Color.MediumSlateBlue;
            bt_editoriales.BorderColor = Color.PaleVioletRed;
            bt_editoriales.BorderRadius = 15;
            bt_editoriales.BorderSize = 0;
            bt_editoriales.FlatAppearance.BorderSize = 0;
            bt_editoriales.FlatStyle = FlatStyle.Flat;
            bt_editoriales.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_editoriales.ForeColor = Color.White;
            bt_editoriales.Location = new Point(322, 22);
            bt_editoriales.Name = "bt_editoriales";
            bt_editoriales.Size = new Size(150, 40);
            bt_editoriales.TabIndex = 5;
            bt_editoriales.Text = "EDITORIALES";
            bt_editoriales.TextColor = Color.White;
            bt_editoriales.UseVisualStyleBackColor = false;
            bt_editoriales.Click += bt_editoriales_Click_1;
            // 
            // bt_libros
            // 
            bt_libros.BackColor = Color.MediumOrchid;
            bt_libros.BackgroundColor = Color.MediumOrchid;
            bt_libros.BorderColor = Color.PaleVioletRed;
            bt_libros.BorderRadius = 15;
            bt_libros.BorderSize = 0;
            bt_libros.FlatAppearance.BorderSize = 0;
            bt_libros.FlatStyle = FlatStyle.Flat;
            bt_libros.ForeColor = Color.White;
            bt_libros.Location = new Point(621, 22);
            bt_libros.Name = "bt_libros";
            bt_libros.Size = new Size(150, 40);
            bt_libros.TabIndex = 6;
            bt_libros.Text = "LIBROS";
            bt_libros.TextColor = Color.White;
            bt_libros.UseVisualStyleBackColor = false;
            bt_libros.Click += bt_libros_Click_1;
            // 
            // rJfotos1
            // 
            rJfotos1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rJfotos1.BorderColor = Color.RoyalBlue;
            rJfotos1.BorderColor2 = Color.HotPink;
            rJfotos1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rJfotos1.BorderSize = 3;
            rJfotos1.GradientAngle = 50F;
            rJfotos1.Image = (Image)resources.GetObject("rJfotos1.Image");
            rJfotos1.Location = new Point(59, 135);
            rJfotos1.Name = "rJfotos1";
            rJfotos1.Size = new Size(182, 182);
            rJfotos1.SizeMode = PictureBoxSizeMode.StretchImage;
            rJfotos1.TabIndex = 7;
            rJfotos1.TabStop = false;
            // 
            // InterfazPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(rJfotos1);
            Controls.Add(bt_libros);
            Controls.Add(bt_editoriales);
            Controls.Add(rjButton1);
            Controls.Add(label1);
            Name = "InterfazPrincipal";
            Text = "InterfazPrincipal";
            ((System.ComponentModel.ISupportInitialize)rJfotos1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RJButton rjButton1;
        private RJButton bt_editoriales;
        private RJButton bt_libros;
        private RJfotos rJfotos1;
    }
}