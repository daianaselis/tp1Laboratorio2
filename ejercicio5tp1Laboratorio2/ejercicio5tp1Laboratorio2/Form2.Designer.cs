namespace ejercicio5tp1Laboratorio2
{
    partial class Form2
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
            lbl_Titulo = new Label();
            lbl_NombreMascota = new Label();
            txtBox_NombreMASCOTA = new TextBox();
            lbl_apellidodela_Mascota = new Label();
            txtBox_Apellidomascota = new TextBox();
            lbl_dni_mascota = new Label();
            txt_Box_DniMascota = new TextBox();
            lbl_especie = new Label();
            txt_Especie = new TextBox();
            lbl_raza = new Label();
            textBox_Raza = new TextBox();
            lbl_Genero_Mascota = new Label();
            rbtn_Hembra = new RadioButton();
            rbtn_macho = new RadioButton();
            lbl_EdadMascota = new Label();
            textBox_EdadMascota = new TextBox();
            btn_Finalizar = new Button();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.BackColor = SystemColors.ButtonHighlight;
            lbl_Titulo.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(156, 56);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(191, 25);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Datos del paciente:";
            // 
            // lbl_NombreMascota
            // 
            lbl_NombreMascota.AutoSize = true;
            lbl_NombreMascota.BackColor = SystemColors.ButtonHighlight;
            lbl_NombreMascota.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreMascota.Location = new Point(32, 126);
            lbl_NombreMascota.Name = "lbl_NombreMascota";
            lbl_NombreMascota.Size = new Size(145, 15);
            lbl_NombreMascota.TabIndex = 1;
            lbl_NombreMascota.Text = "Nombre de la mascota:";
            // 
            // txtBox_NombreMASCOTA
            // 
            txtBox_NombreMASCOTA.Location = new Point(193, 118);
            txtBox_NombreMASCOTA.Name = "txtBox_NombreMASCOTA";
            txtBox_NombreMASCOTA.Size = new Size(170, 23);
            txtBox_NombreMASCOTA.TabIndex = 2;
            txtBox_NombreMASCOTA.TextChanged += txtBox_NombreMASCOTA_TextChanged;
            // 
            // lbl_apellidodela_Mascota
            // 
            lbl_apellidodela_Mascota.AutoSize = true;
            lbl_apellidodela_Mascota.BackColor = SystemColors.ButtonHighlight;
            lbl_apellidodela_Mascota.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_apellidodela_Mascota.Location = new Point(106, 159);
            lbl_apellidodela_Mascota.Name = "lbl_apellidodela_Mascota";
            lbl_apellidodela_Mascota.Size = new Size(69, 15);
            lbl_apellidodela_Mascota.TabIndex = 3;
            lbl_apellidodela_Mascota.Text = "Apellidos:";
            // 
            // txtBox_Apellidomascota
            // 
            txtBox_Apellidomascota.Location = new Point(193, 151);
            txtBox_Apellidomascota.Name = "txtBox_Apellidomascota";
            txtBox_Apellidomascota.Size = new Size(170, 23);
            txtBox_Apellidomascota.TabIndex = 4;
            // 
            // lbl_dni_mascota
            // 
            lbl_dni_mascota.AutoSize = true;
            lbl_dni_mascota.BackColor = SystemColors.ButtonHighlight;
            lbl_dni_mascota.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_dni_mascota.Location = new Point(46, 196);
            lbl_dni_mascota.Name = "lbl_dni_mascota";
            lbl_dni_mascota.Size = new Size(132, 15);
            lbl_dni_mascota.TabIndex = 5;
            lbl_dni_mascota.Text = "DNI de la MASCOTA:";
            // 
            // txt_Box_DniMascota
            // 
            txt_Box_DniMascota.Location = new Point(193, 188);
            txt_Box_DniMascota.Name = "txt_Box_DniMascota";
            txt_Box_DniMascota.Size = new Size(170, 23);
            txt_Box_DniMascota.TabIndex = 6;
            txt_Box_DniMascota.TextChanged += txt_Box_DniMascota_TextChanged;
            txt_Box_DniMascota.KeyPress += txt_Box_DniMascota_KeyPress;
            // 
            // lbl_especie
            // 
            lbl_especie.AutoSize = true;
            lbl_especie.BackColor = SystemColors.ButtonHighlight;
            lbl_especie.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_especie.Location = new Point(115, 246);
            lbl_especie.Name = "lbl_especie";
            lbl_especie.Size = new Size(56, 15);
            lbl_especie.TabIndex = 7;
            lbl_especie.Text = "Especie:";
            lbl_especie.Click += label1_Click;
            // 
            // txt_Especie
            // 
            txt_Especie.Location = new Point(193, 238);
            txt_Especie.Name = "txt_Especie";
            txt_Especie.Size = new Size(170, 23);
            txt_Especie.TabIndex = 8;
            // 
            // lbl_raza
            // 
            lbl_raza.AutoSize = true;
            lbl_raza.BackColor = SystemColors.ButtonHighlight;
            lbl_raza.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_raza.Location = new Point(124, 313);
            lbl_raza.Name = "lbl_raza";
            lbl_raza.Size = new Size(39, 15);
            lbl_raza.TabIndex = 9;
            lbl_raza.Text = "Raza:";
            // 
            // textBox_Raza
            // 
            textBox_Raza.Location = new Point(193, 305);
            textBox_Raza.Name = "textBox_Raza";
            textBox_Raza.Size = new Size(170, 23);
            textBox_Raza.TabIndex = 10;
            // 
            // lbl_Genero_Mascota
            // 
            lbl_Genero_Mascota.AutoSize = true;
            lbl_Genero_Mascota.BackColor = SystemColors.ButtonHighlight;
            lbl_Genero_Mascota.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Genero_Mascota.Location = new Point(124, 360);
            lbl_Genero_Mascota.Name = "lbl_Genero_Mascota";
            lbl_Genero_Mascota.Size = new Size(51, 15);
            lbl_Genero_Mascota.TabIndex = 11;
            lbl_Genero_Mascota.Text = "Genero";
            // 
            // rbtn_Hembra
            // 
            rbtn_Hembra.AutoSize = true;
            rbtn_Hembra.BackColor = SystemColors.ButtonHighlight;
            rbtn_Hembra.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtn_Hembra.Location = new Point(193, 358);
            rbtn_Hembra.Name = "rbtn_Hembra";
            rbtn_Hembra.Size = new Size(73, 19);
            rbtn_Hembra.TabIndex = 12;
            rbtn_Hembra.TabStop = true;
            rbtn_Hembra.Text = "Hembra";
            rbtn_Hembra.UseVisualStyleBackColor = false;
            // 
            // rbtn_macho
            // 
            rbtn_macho.AutoSize = true;
            rbtn_macho.BackColor = SystemColors.ButtonHighlight;
            rbtn_macho.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtn_macho.Location = new Point(298, 358);
            rbtn_macho.Name = "rbtn_macho";
            rbtn_macho.Size = new Size(65, 19);
            rbtn_macho.TabIndex = 13;
            rbtn_macho.TabStop = true;
            rbtn_macho.Text = "Macho";
            rbtn_macho.UseVisualStyleBackColor = false;
            // 
            // lbl_EdadMascota
            // 
            lbl_EdadMascota.AutoSize = true;
            lbl_EdadMascota.BackColor = SystemColors.ButtonHighlight;
            lbl_EdadMascota.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EdadMascota.Location = new Point(124, 280);
            lbl_EdadMascota.Name = "lbl_EdadMascota";
            lbl_EdadMascota.Size = new Size(41, 15);
            lbl_EdadMascota.TabIndex = 14;
            lbl_EdadMascota.Text = "Edad:";
            // 
            // textBox_EdadMascota
            // 
            textBox_EdadMascota.Location = new Point(193, 272);
            textBox_EdadMascota.Name = "textBox_EdadMascota";
            textBox_EdadMascota.Size = new Size(100, 23);
            textBox_EdadMascota.TabIndex = 15;
            textBox_EdadMascota.TextChanged += textBox_EdadMascota_TextChanged;
            textBox_EdadMascota.KeyPress += textBox_EdadMascota_KeyPress;
            // 
            // btn_Finalizar
            // 
            btn_Finalizar.BackColor = SystemColors.ButtonHighlight;
            btn_Finalizar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Finalizar.Location = new Point(412, 430);
            btn_Finalizar.Name = "btn_Finalizar";
            btn_Finalizar.Size = new Size(75, 23);
            btn_Finalizar.TabIndex = 16;
            btn_Finalizar.Text = "Finalizar.";
            btn_Finalizar.UseVisualStyleBackColor = false;
            btn_Finalizar.Click += btn_Finalizar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_09_25_at_20_18_41;
            ClientSize = new Size(520, 479);
            Controls.Add(btn_Finalizar);
            Controls.Add(textBox_EdadMascota);
            Controls.Add(lbl_EdadMascota);
            Controls.Add(rbtn_macho);
            Controls.Add(rbtn_Hembra);
            Controls.Add(lbl_Genero_Mascota);
            Controls.Add(textBox_Raza);
            Controls.Add(lbl_raza);
            Controls.Add(txt_Especie);
            Controls.Add(lbl_especie);
            Controls.Add(txt_Box_DniMascota);
            Controls.Add(lbl_dni_mascota);
            Controls.Add(txtBox_Apellidomascota);
            Controls.Add(lbl_apellidodela_Mascota);
            Controls.Add(txtBox_NombreMASCOTA);
            Controls.Add(lbl_NombreMascota);
            Controls.Add(lbl_Titulo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Label lbl_NombreMascota;
        private TextBox txtBox_NombreMASCOTA;
        private Label lbl_apellidodela_Mascota;
        private TextBox txtBox_Apellidomascota;
        private Label lbl_dni_mascota;
        private TextBox txt_Box_DniMascota;
        private Label lbl_especie;
        private TextBox txt_Especie;
        private Label lbl_raza;
        private TextBox textBox_Raza;
        private Label lbl_Genero_Mascota;
        private RadioButton rbtn_Hembra;
        private RadioButton rbtn_macho;
        private Label lbl_EdadMascota;
        private TextBox textBox_EdadMascota;
        private Button btn_Finalizar;
    }
}