namespace ejercicio5tp1Laboratorio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_titulo = new Label();
            lbl_Nombre = new Label();
            textBoxNombreCliente = new TextBox();
            lbl_apellido = new Label();
            textBox_Apellidos = new TextBox();
            lbl = new Label();
            textBox_Edad = new TextBox();
            lbl_Fechanac = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbl_Direccion = new Label();
            txtbox_Direccion = new TextBox();
            lbl_celular = new Label();
            textBox_Celular = new TextBox();
            lbl_DNI = new Label();
            textBox_Dni = new TextBox();
            btn_Aceptar = new Button();
            linkLabel1 = new LinkLabel();
            lbl_email = new Label();
            txtbox_Email = new TextBox();
            lbl_genero = new Label();
            rbtn_GeneroDueño = new RadioButton();
            rbtn_generoMujer = new RadioButton();
            rbtn_Otro = new RadioButton();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = Color.LightSalmon;
            label_titulo.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.ForeColor = SystemColors.ActiveCaptionText;
            label_titulo.Location = new Point(143, 39);
            label_titulo.Margin = new Padding(5, 0, 5, 0);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(275, 25);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "Datos de la persona a cargo:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.LightSalmon;
            lbl_Nombre.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(51, 103);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(66, 15);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "Nombres:";
            // 
            // textBoxNombreCliente
            // 
            textBoxNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNombreCliente.Location = new Point(152, 100);
            textBoxNombreCliente.Name = "textBoxNombreCliente";
            textBoxNombreCliente.Size = new Size(213, 23);
            textBoxNombreCliente.TabIndex = 2;
            textBoxNombreCliente.TextChanged += textBox1_TextChanged;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.BackColor = Color.LightSalmon;
            lbl_apellido.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_apellido.Location = new Point(52, 152);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(69, 15);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellidos:";
            // 
            // textBox_Apellidos
            // 
            textBox_Apellidos.BackColor = SystemColors.ButtonHighlight;
            textBox_Apellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Apellidos.Location = new Point(152, 144);
            textBox_Apellidos.Name = "textBox_Apellidos";
            textBox_Apellidos.Size = new Size(213, 23);
            textBox_Apellidos.TabIndex = 4;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.LightSalmon;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(71, 184);
            lbl.Name = "lbl";
            lbl.Size = new Size(33, 15);
            lbl.TabIndex = 5;
            lbl.Text = "Edad";
            // 
            // textBox_Edad
            // 
            textBox_Edad.BackColor = SystemColors.ButtonHighlight;
            textBox_Edad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Edad.Location = new Point(152, 176);
            textBox_Edad.Name = "textBox_Edad";
            textBox_Edad.Size = new Size(132, 23);
            textBox_Edad.TabIndex = 6;
            textBox_Edad.TextChanged += textBox_Edad_TextChanged;
            textBox_Edad.KeyPress += textBox_Edad_KeyPress;
            // 
            // lbl_Fechanac
            // 
            lbl_Fechanac.AutoSize = true;
            lbl_Fechanac.BackColor = Color.LightSalmon;
            lbl_Fechanac.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Fechanac.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Fechanac.Location = new Point(21, 315);
            lbl_Fechanac.Name = "lbl_Fechanac";
            lbl_Fechanac.Size = new Size(135, 15);
            lbl_Fechanac.TabIndex = 7;
            lbl_Fechanac.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(171, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 22);
            dateTimePicker1.TabIndex = 8;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.BackColor = Color.LightSalmon;
            lbl_Direccion.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Direccion.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Direccion.Location = new Point(69, 367);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(68, 15);
            lbl_Direccion.TabIndex = 9;
            lbl_Direccion.Text = "Direccion:";
            // 
            // txtbox_Direccion
            // 
            txtbox_Direccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtbox_Direccion.Location = new Point(171, 357);
            txtbox_Direccion.Name = "txtbox_Direccion";
            txtbox_Direccion.Size = new Size(172, 23);
            txtbox_Direccion.TabIndex = 10;
            txtbox_Direccion.KeyPress += txtbox_Direccion_KeyPress;
            // 
            // lbl_celular
            // 
            lbl_celular.AutoSize = true;
            lbl_celular.BackColor = Color.LightSalmon;
            lbl_celular.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_celular.Location = new Point(45, 406);
            lbl_celular.Name = "lbl_celular";
            lbl_celular.Size = new Size(115, 15);
            lbl_celular.TabIndex = 11;
            lbl_celular.Text = "Telefono/Celular:";
            // 
            // textBox_Celular
            // 
            textBox_Celular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Celular.Location = new Point(171, 398);
            textBox_Celular.Name = "textBox_Celular";
            textBox_Celular.Size = new Size(172, 23);
            textBox_Celular.TabIndex = 12;
            textBox_Celular.KeyPress += textBox_Celular_KeyPress;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.BackColor = Color.LightSalmon;
            lbl_DNI.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DNI.Location = new Point(71, 279);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(34, 15);
            lbl_DNI.TabIndex = 13;
            lbl_DNI.Text = "DNI:";
            // 
            // textBox_Dni
            // 
            textBox_Dni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_Dni.Location = new Point(161, 271);
            textBox_Dni.Name = "textBox_Dni";
            textBox_Dni.Size = new Size(204, 23);
            textBox_Dni.TabIndex = 14;
            textBox_Dni.TextChanged += textBox4_TextChanged;
            textBox_Dni.KeyPress += textBox_Dni_KeyPress;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.MistyRose;
            btn_Aceptar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Aceptar.Location = new Point(390, 523);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(75, 23);
            btn_Aceptar.TabIndex = 15;
            btn_Aceptar.Text = "Siguiente";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(425, 357);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 16;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.BackColor = Color.LightSalmon;
            lbl_email.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(93, 441);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(44, 15);
            lbl_email.TabIndex = 17;
            lbl_email.Text = "Email:";
            // 
            // txtbox_Email
            // 
            txtbox_Email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtbox_Email.Location = new Point(171, 433);
            txtbox_Email.Name = "txtbox_Email";
            txtbox_Email.Size = new Size(172, 23);
            txtbox_Email.TabIndex = 18;
            // 
            // lbl_genero
            // 
            lbl_genero.AutoSize = true;
            lbl_genero.BackColor = Color.LightSalmon;
            lbl_genero.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_genero.Location = new Point(71, 230);
            lbl_genero.Name = "lbl_genero";
            lbl_genero.Size = new Size(55, 15);
            lbl_genero.TabIndex = 19;
            lbl_genero.Text = "Genero:";
            // 
            // rbtn_GeneroDueño
            // 
            rbtn_GeneroDueño.AutoSize = true;
            rbtn_GeneroDueño.BackColor = Color.LightSalmon;
            rbtn_GeneroDueño.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtn_GeneroDueño.Location = new Point(152, 226);
            rbtn_GeneroDueño.Name = "rbtn_GeneroDueño";
            rbtn_GeneroDueño.Size = new Size(74, 19);
            rbtn_GeneroDueño.TabIndex = 20;
            rbtn_GeneroDueño.TabStop = true;
            rbtn_GeneroDueño.Text = "Hombre";
            rbtn_GeneroDueño.UseVisualStyleBackColor = false;
            // 
            // rbtn_generoMujer
            // 
            rbtn_generoMujer.AutoSize = true;
            rbtn_generoMujer.BackColor = Color.LightSalmon;
            rbtn_generoMujer.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtn_generoMujer.Location = new Point(237, 226);
            rbtn_generoMujer.Name = "rbtn_generoMujer";
            rbtn_generoMujer.Size = new Size(61, 19);
            rbtn_generoMujer.TabIndex = 21;
            rbtn_generoMujer.TabStop = true;
            rbtn_generoMujer.Text = "Mujer";
            rbtn_generoMujer.UseVisualStyleBackColor = false;
            // 
            // rbtn_Otro
            // 
            rbtn_Otro.AutoSize = true;
            rbtn_Otro.BackColor = Color.LightSalmon;
            rbtn_Otro.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbtn_Otro.Location = new Point(313, 226);
            rbtn_Otro.Name = "rbtn_Otro";
            rbtn_Otro.Size = new Size(52, 19);
            rbtn_Otro.TabIndex = 22;
            rbtn_Otro.TabStop = true;
            rbtn_Otro.Text = "Otro";
            rbtn_Otro.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(491, 566);
            Controls.Add(rbtn_Otro);
            Controls.Add(rbtn_generoMujer);
            Controls.Add(rbtn_GeneroDueño);
            Controls.Add(lbl_genero);
            Controls.Add(txtbox_Email);
            Controls.Add(lbl_email);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Aceptar);
            Controls.Add(textBox_Dni);
            Controls.Add(lbl_DNI);
            Controls.Add(textBox_Celular);
            Controls.Add(lbl_celular);
            Controls.Add(txtbox_Direccion);
            Controls.Add(lbl_Direccion);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_Fechanac);
            Controls.Add(textBox_Edad);
            Controls.Add(lbl);
            Controls.Add(textBox_Apellidos);
            Controls.Add(lbl_apellido);
            Controls.Add(textBoxNombreCliente);
            Controls.Add(lbl_Nombre);
            Controls.Add(label_titulo);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Datos del due;o";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Label lbl_Nombre;
        private TextBox textBoxNombreCliente;
        private Label lbl_apellido;
        private TextBox textBox_Apellidos;
        private Label lbl;
        private TextBox textBox_Edad;
        private Label lbl_Fechanac;
        private DateTimePicker dateTimePicker1;
        private Label lbl_Direccion;
        private TextBox txtbox_Direccion;
        private Label lbl_celular;
        private TextBox textBox_Celular;
        private Label lbl_DNI;
        private TextBox textBox_Dni;
        private Button btn_Aceptar;
        private LinkLabel linkLabel1;
        private Label lbl_email;
        private TextBox txtbox_Email;
        private Label lbl_genero;
        private RadioButton rbtn_GeneroDueño;
        private RadioButton rbtn_generoMujer;
        private RadioButton rbtn_Otro;
    }
}