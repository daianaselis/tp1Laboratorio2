namespace ejercicio4.tp1.lab2
{
    partial class Formulario2
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
            lbltituloform2 = new Label();
            lblCantidadDias = new Label();
            txtBoxCantidaddias = new TextBox();
            btn_alquiler = new Button();
            comboBox_Casa = new ComboBox();
            lblselect = new Label();
            lblCantidadPersonas = new Label();
            comboBoxPersonas = new ComboBox();
            label_direccion = new Label();
            lbl_cantidadormitorios = new Label();
            label1_ = new Label();
            label2_ = new Label();
            lbl_cantidadpisos1 = new Label();
            label3_pisos = new Label();
            label2_cantidadBanios = new Label();
            lblbanios = new Label();
            SuspendLayout();
            // 
            // lbltituloform2
            // 
            lbltituloform2.AutoSize = true;
            lbltituloform2.BackColor = Color.White;
            lbltituloform2.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbltituloform2.Location = new Point(193, 34);
            lbltituloform2.Name = "lbltituloform2";
            lbltituloform2.Size = new Size(105, 32);
            lbltituloform2.TabIndex = 0;
            lbltituloform2.Text = "Alquiler";
            // 
            // lblCantidadDias
            // 
            lblCantidadDias.AutoSize = true;
            lblCantidadDias.BackColor = Color.White;
            lblCantidadDias.Location = new Point(32, 103);
            lblCantidadDias.Name = "lblCantidadDias";
            lblCantidadDias.Size = new Size(181, 15);
            lblCantidadDias.TabIndex = 1;
            lblCantidadDias.Text = "Cantidad de dias que se quedara:";
            // 
            // txtBoxCantidaddias
            // 
            txtBoxCantidaddias.Location = new Point(268, 95);
            txtBoxCantidaddias.Name = "txtBoxCantidaddias";
            txtBoxCantidaddias.Size = new Size(146, 23);
            txtBoxCantidaddias.TabIndex = 2;
            txtBoxCantidaddias.TextChanged += txtBoxCantidaddias_TextChanged;
            txtBoxCantidaddias.KeyPress += txtBoxCantidaddias_KeyPress;
            // 
            // btn_alquiler
            // 
            btn_alquiler.Location = new Point(424, 572);
            btn_alquiler.Name = "btn_alquiler";
            btn_alquiler.Size = new Size(75, 23);
            btn_alquiler.TabIndex = 3;
            btn_alquiler.Text = "Alquilar";
            btn_alquiler.UseVisualStyleBackColor = true;
            btn_alquiler.Click += btn_alquiler_Click;
            // 
            // comboBox_Casa
            // 
            comboBox_Casa.FormattingEnabled = true;
            comboBox_Casa.Items.AddRange(new object[] { "CASA 1", "CASA 2", "CASA 3", "CASA 4" });
            comboBox_Casa.Location = new Point(268, 205);
            comboBox_Casa.Name = "comboBox_Casa";
            comboBox_Casa.Size = new Size(146, 23);
            comboBox_Casa.TabIndex = 4;
            comboBox_Casa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblselect
            // 
            lblselect.AutoSize = true;
            lblselect.BackColor = Color.White;
            lblselect.Location = new Point(98, 213);
            lblselect.Name = "lblselect";
            lblselect.Size = new Size(72, 15);
            lblselect.TabIndex = 5;
            lblselect.Text = "Elija la casa :";
            // 
            // lblCantidadPersonas
            // 
            lblCantidadPersonas.AutoSize = true;
            lblCantidadPersonas.BackColor = Color.White;
            lblCantidadPersonas.Location = new Point(12, 168);
            lblCantidadPersonas.Name = "lblCantidadPersonas";
            lblCantidadPersonas.Size = new Size(233, 15);
            lblCantidadPersonas.TabIndex = 6;
            lblCantidadPersonas.Text = "cantidad de personas que habitaran la casa";
            // 
            // comboBoxPersonas
            // 
            comboBoxPersonas.FormattingEnabled = true;
            comboBoxPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxPersonas.Location = new Point(268, 160);
            comboBoxPersonas.Name = "comboBoxPersonas";
            comboBoxPersonas.Size = new Size(146, 23);
            comboBoxPersonas.TabIndex = 7;
            // 
            // label_direccion
            // 
            label_direccion.AutoSize = true;
            label_direccion.BackColor = SystemColors.ActiveCaption;
            label_direccion.Location = new Point(306, 283);
            label_direccion.Name = "label_direccion";
            label_direccion.Size = new Size(13, 15);
            label_direccion.TabIndex = 8;
            label_direccion.Text = "0";
            // 
            // lbl_cantidadormitorios
            // 
            lbl_cantidadormitorios.AutoSize = true;
            lbl_cantidadormitorios.BackColor = SystemColors.ActiveCaption;
            lbl_cantidadormitorios.Location = new Point(306, 369);
            lbl_cantidadormitorios.Name = "lbl_cantidadormitorios";
            lbl_cantidadormitorios.Size = new Size(13, 15);
            lbl_cantidadormitorios.TabIndex = 9;
            lbl_cantidadormitorios.Text = "0";
            // 
            // label1_
            // 
            label1_.AutoSize = true;
            label1_.BackColor = Color.White;
            label1_.Location = new Point(111, 283);
            label1_.Name = "label1_";
            label1_.Size = new Size(59, 15);
            label1_.TabIndex = 10;
            label1_.Text = "direccion:";
            // 
            // label2_
            // 
            label2_.AutoSize = true;
            label2_.BackColor = Color.White;
            label2_.Location = new Point(78, 369);
            label2_.Name = "label2_";
            label2_.Size = new Size(144, 15);
            label2_.TabIndex = 11;
            label2_.Text = "Cantidad de habitaciones:";
            // 
            // lbl_cantidadpisos1
            // 
            lbl_cantidadpisos1.AutoSize = true;
            lbl_cantidadpisos1.BackColor = Color.White;
            lbl_cantidadpisos1.Location = new Point(100, 436);
            lbl_cantidadpisos1.Name = "lbl_cantidadpisos1";
            lbl_cantidadpisos1.Size = new Size(102, 15);
            lbl_cantidadpisos1.TabIndex = 12;
            lbl_cantidadpisos1.Text = "cantidad de pisos:";
            // 
            // label3_pisos
            // 
            label3_pisos.AutoSize = true;
            label3_pisos.BackColor = SystemColors.ActiveCaption;
            label3_pisos.Location = new Point(306, 436);
            label3_pisos.Name = "label3_pisos";
            label3_pisos.Size = new Size(13, 15);
            label3_pisos.TabIndex = 13;
            label3_pisos.Text = "0";
            // 
            // label2_cantidadBanios
            // 
            label2_cantidadBanios.AutoSize = true;
            label2_cantidadBanios.BackColor = Color.White;
            label2_cantidadBanios.Location = new Point(100, 487);
            label2_cantidadBanios.Name = "label2_cantidadBanios";
            label2_cantidadBanios.Size = new Size(109, 15);
            label2_cantidadBanios.TabIndex = 14;
            label2_cantidadBanios.Text = "Cantidad de baños:";
            // 
            // lblbanios
            // 
            lblbanios.AutoSize = true;
            lblbanios.BackColor = SystemColors.ActiveCaption;
            lblbanios.Location = new Point(306, 487);
            lblbanios.Name = "lblbanios";
            lblbanios.Size = new Size(13, 15);
            lblbanios.TabIndex = 15;
            lblbanios.Text = "0";
            // 
            // Formulario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(526, 620);
            Controls.Add(lblbanios);
            Controls.Add(label2_cantidadBanios);
            Controls.Add(label3_pisos);
            Controls.Add(lbl_cantidadpisos1);
            Controls.Add(label2_);
            Controls.Add(label1_);
            Controls.Add(lbl_cantidadormitorios);
            Controls.Add(label_direccion);
            Controls.Add(comboBoxPersonas);
            Controls.Add(lblCantidadPersonas);
            Controls.Add(lblselect);
            Controls.Add(comboBox_Casa);
            Controls.Add(btn_alquiler);
            Controls.Add(txtBoxCantidaddias);
            Controls.Add(lblCantidadDias);
            Controls.Add(lbltituloform2);
            Name = "Formulario2";
            Text = "Datos del alquiler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltituloform2;
        private Label lblCantidadDias;
        private TextBox txtBoxCantidaddias;
        private Button btn_alquiler;
        private ComboBox comboBox_Casa;
        private Label lblselect;
        private Label lblCantidadPersonas;
        private ComboBox comboBoxPersonas;
        private Label label_direccion;
        private Label lbl_cantidadormitorios;
        private Label label1_;
        private Label label2_;
        private Label lbl_cantidadpisos1;
        private Label label3_pisos;
        private Label label2_cantidadBanios;
        private Label lblbanios;
    }
}