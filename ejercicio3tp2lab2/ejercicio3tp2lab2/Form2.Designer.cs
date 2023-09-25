namespace ejercicio3tp2lab2
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
            lbl1form2 = new Label();
            lbl2form2 = new Label();
            lbl3form2 = new Label();
            lbl4form2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lbl1form2
            // 
            lbl1form2.AutoSize = true;
            lbl1form2.Location = new Point(185, 95);
            lbl1form2.Name = "lbl1form2";
            lbl1form2.Size = new Size(38, 15);
            lbl1form2.TabIndex = 0;
            lbl1form2.Text = "label1";
            lbl1form2.Click += lbl1form2_Click;
            // 
            // lbl2form2
            // 
            lbl2form2.AutoSize = true;
            lbl2form2.Location = new Point(185, 161);
            lbl2form2.Name = "lbl2form2";
            lbl2form2.Size = new Size(38, 15);
            lbl2form2.TabIndex = 1;
            lbl2form2.Text = "label2";
            // 
            // lbl3form2
            // 
            lbl3form2.AutoSize = true;
            lbl3form2.Location = new Point(185, 203);
            lbl3form2.Name = "lbl3form2";
            lbl3form2.Size = new Size(38, 15);
            lbl3form2.TabIndex = 2;
            lbl3form2.Text = "label3";
            // 
            // lbl4form2
            // 
            lbl4form2.AutoSize = true;
            lbl4form2.Location = new Point(185, 271);
            lbl4form2.Name = "lbl4form2";
            lbl4form2.Size = new Size(38, 15);
            lbl4form2.TabIndex = 3;
            lbl4form2.Text = "label4";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(329, 337);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(466, 388);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lbl4form2);
            Controls.Add(lbl3form2);
            Controls.Add(lbl2form2);
            Controls.Add(lbl1form2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1form2;
        private Label lbl2form2;
        private Label lbl3form2;
        private Label lbl4form2;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}