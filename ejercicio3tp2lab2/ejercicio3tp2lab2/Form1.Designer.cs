namespace ejercicio3tp2lab2
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
            txtBox3 = new TextBox();
            txtbox1 = new TextBox();
            lblDescripcionProducto = new Label();
            lblPrecioProducto = new Label();
            txtBox2 = new TextBox();
            lbltipoproducto = new Label();
            numericUpDown1 = new NumericUpDown();
            lblCantidad = new Label();
            brnaceptarf1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtBox3
            // 
            txtBox3.Location = new Point(202, 162);
            txtBox3.Name = "txtBox3";
            txtBox3.Size = new Size(207, 23);
            txtBox3.TabIndex = 2;
            txtBox3.TextChanged += txtBox3_TextChanged;
            // 
            // txtbox1
            // 
            txtbox1.Location = new Point(202, 43);
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(207, 23);
            txtbox1.TabIndex = 0;
            txtbox1.TextChanged += txtbox1_TextChanged;
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.BackColor = Color.GhostWhite;
            lblDescripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcionProducto.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcionProducto.Location = new Point(8, 46);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(177, 16);
            lblDescripcionProducto.TabIndex = 3;
            lblDescripcionProducto.Text = "Descripcion del producto:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BackColor = Color.GhostWhite;
            lblPrecioProducto.BorderStyle = BorderStyle.FixedSingle;
            lblPrecioProducto.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioProducto.Location = new Point(88, 117);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(56, 16);
            lblPrecioProducto.TabIndex = 4;
            lblPrecioProducto.Text = "Precio:";
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(202, 110);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(207, 23);
            txtBox2.TabIndex = 1;
            txtBox2.TextChanged += txtBox2_TextChanged;
            // 
            // lbltipoproducto
            // 
            lbltipoproducto.AutoSize = true;
            lbltipoproducto.BackColor = Color.GhostWhite;
            lbltipoproducto.BorderStyle = BorderStyle.FixedSingle;
            lbltipoproducto.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbltipoproducto.Location = new Point(88, 162);
            lbltipoproducto.Name = "lbltipoproducto";
            lbltipoproducto.Size = new Size(42, 16);
            lbltipoproducto.TabIndex = 5;
            lbltipoproducto.Text = "Tipo:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(202, 230);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(207, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.GhostWhite;
            lblCantidad.BorderStyle = BorderStyle.FixedSingle;
            lblCantidad.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.Location = new Point(37, 239);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(131, 16);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad deseada:";
            // 
            // brnaceptarf1
            // 
            brnaceptarf1.Location = new Point(175, 335);
            brnaceptarf1.Name = "brnaceptarf1";
            brnaceptarf1.Size = new Size(133, 23);
            brnaceptarf1.TabIndex = 8;
            brnaceptarf1.Text = "Confirmar";
            brnaceptarf1.UseVisualStyleBackColor = true;
            brnaceptarf1.Click += brnaceptarf1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(466, 388);
            Controls.Add(brnaceptarf1);
            Controls.Add(lblCantidad);
            Controls.Add(numericUpDown1);
            Controls.Add(lbltipoproducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblDescripcionProducto);
            Controls.Add(txtBox3);
            Controls.Add(txtBox2);
            Controls.Add(txtbox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblDescripcionProducto;
        private Label lblPrecioProducto;
        private Label lbltipoproducto;
        private Label lblCantidad;
        private Button brnaceptarf1;
        public TextBox txtBox3;
        public TextBox txtbox1;
        public TextBox txtBox2;
        public NumericUpDown numericUpDown1;
    }
}