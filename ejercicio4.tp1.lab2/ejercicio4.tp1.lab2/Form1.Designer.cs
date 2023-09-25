namespace ejercicio4.tp1.lab2
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
            lblNombre = new Label();
            labelApellido = new Label();
            label3 = new Label();
            textBoxdni = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxCuil = new TextBox();
            label4 = new Label();
            lbltitulo = new Label();
            btnConformar = new Button();
            lblDNI = new Label();
            lblCUIL = new Label();
            labeltelefono = new Label();
            textBoxCelular = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblfechadeNac = new Label();
            lblNrocliente = new Label();
            textBoxNroCliente = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Snow;
            lblNombre.Location = new Point(44, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.BackColor = Color.Snow;
            labelApellido.Location = new Point(43, 165);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 261);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // textBoxdni
            // 
            textBoxdni.Location = new Point(139, 253);
            textBoxdni.Name = "textBoxdni";
            textBoxdni.Size = new Size(210, 23);
            textBoxdni.TabIndex = 3;
            textBoxdni.TextChanged += textBoxdni_TextChanged;
            textBoxdni.KeyPress += textBoxdni_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(139, 106);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(210, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(139, 157);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(210, 23);
            textBoxApellido.TabIndex = 5;
            // 
            // textBoxCuil
            // 
            textBoxCuil.Location = new Point(139, 309);
            textBoxCuil.Name = "textBoxCuil";
            textBoxCuil.Size = new Size(210, 23);
            textBoxCuil.TabIndex = 6;
            textBoxCuil.KeyPress += textBoxCuil_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 334);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Black;
            lbltitulo.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.Snow;
            lbltitulo.Location = new Point(127, 19);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(239, 35);
            lbltitulo.TabIndex = 8;
            lbltitulo.Text = "Datos del cliente:";
            // 
            // btnConformar
            // 
            btnConformar.Location = new Point(335, 520);
            btnConformar.Name = "btnConformar";
            btnConformar.Size = new Size(75, 23);
            btnConformar.TabIndex = 9;
            btnConformar.Text = "Siguiente";
            btnConformar.UseVisualStyleBackColor = true;
            btnConformar.Click += btnConformar_Click;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Snow;
            lblDNI.Location = new Point(67, 261);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 10;
            lblDNI.Text = "DNI:";
            // 
            // lblCUIL
            // 
            lblCUIL.AutoSize = true;
            lblCUIL.BackColor = Color.Snow;
            lblCUIL.Location = new Point(62, 317);
            lblCUIL.Name = "lblCUIL";
            lblCUIL.Size = new Size(35, 15);
            lblCUIL.TabIndex = 11;
            lblCUIL.Text = "CUIL:";
            // 
            // labeltelefono
            // 
            labeltelefono.AutoSize = true;
            labeltelefono.BackColor = Color.Snow;
            labeltelefono.Location = new Point(44, 392);
            labeltelefono.Name = "labeltelefono";
            labeltelefono.Size = new Size(55, 15);
            labeltelefono.TabIndex = 14;
            labeltelefono.Text = "Telefono:";
            // 
            // textBoxCelular
            // 
            textBoxCelular.Location = new Point(139, 384);
            textBoxCelular.Name = "textBoxCelular";
            textBoxCelular.Size = new Size(210, 23);
            textBoxCelular.TabIndex = 15;
            textBoxCelular.KeyPress += textBoxCelular_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // lblfechadeNac
            // 
            lblfechadeNac.AutoSize = true;
            lblfechadeNac.BackColor = Color.Snow;
            lblfechadeNac.Location = new Point(12, 222);
            lblfechadeNac.Name = "lblfechadeNac";
            lblfechadeNac.Size = new Size(117, 15);
            lblfechadeNac.TabIndex = 17;
            lblfechadeNac.Text = "Fecha de nacimiento";
            // 
            // lblNrocliente
            // 
            lblNrocliente.AutoSize = true;
            lblNrocliente.BackColor = Color.Snow;
            lblNrocliente.Location = new Point(33, 444);
            lblNrocliente.Name = "lblNrocliente";
            lblNrocliente.Size = new Size(84, 15);
            lblNrocliente.TabIndex = 18;
            lblNrocliente.Text = "Nro de cliente:";
            // 
            // textBoxNroCliente
            // 
            textBoxNroCliente.Location = new Point(139, 436);
            textBoxNroCliente.Name = "textBoxNroCliente";
            textBoxNroCliente.Size = new Size(210, 23);
            textBoxNroCliente.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(457, 577);
            Controls.Add(textBoxNroCliente);
            Controls.Add(lblNrocliente);
            Controls.Add(lblfechadeNac);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxCelular);
            Controls.Add(labeltelefono);
            Controls.Add(lblCUIL);
            Controls.Add(lblDNI);
            Controls.Add(btnConformar);
            Controls.Add(lbltitulo);
            Controls.Add(label4);
            Controls.Add(textBoxCuil);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxdni);
            Controls.Add(label3);
            Controls.Add(labelApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Datos del cliente:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label labelApellido;
        private Label label3;
        private TextBox textBoxdni;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxCuil;
        private Label label4;
        private Label lbltitulo;
        private Button btnConformar;
        private Label lblDNI;
        private Label lblCUIL;
        private Label labeltelefono;
        private TextBox textBoxCelular;
        private DateTimePicker dateTimePicker1;
        private Label lblfechadeNac;
        private Label lblNrocliente;
        private TextBox textBoxNroCliente;
    }
}