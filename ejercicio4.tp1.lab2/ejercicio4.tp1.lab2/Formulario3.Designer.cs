namespace ejercicio4.tp1.lab2
{
    partial class Formulario3
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
            lblRecibo = new Label();
            SuspendLayout();
            // 
            // lblRecibo
            // 
            lblRecibo.AutoSize = true;
            lblRecibo.Location = new Point(260, 42);
            lblRecibo.Name = "lblRecibo";
            lblRecibo.Size = new Size(123, 15);
            lblRecibo.TabIndex = 0;
            lblRecibo.Text = "Gracias por su alquiler";
            // 
            // Formulario3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(lblRecibo);
            Name = "Formulario3";
            Text = "Formulario3";
            Load += Formulario3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecibo;
    }
}