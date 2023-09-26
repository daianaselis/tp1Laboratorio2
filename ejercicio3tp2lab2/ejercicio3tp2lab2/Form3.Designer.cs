namespace ejercicio3tp2lab2
{
    partial class Form3
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
            labeltotalf3 = new Label();
            lbltitulototal = new Label();
            labelfechayhora = new Label();
            SuspendLayout();
            // 
            // labeltotalf3
            // 
            labeltotalf3.AutoSize = true;
            labeltotalf3.BackColor = SystemColors.ControlLight;
            labeltotalf3.Location = new Point(180, 146);
            labeltotalf3.Name = "labeltotalf3";
            labeltotalf3.Size = new Size(13, 15);
            labeltotalf3.TabIndex = 0;
            labeltotalf3.Text = "$";
            // 
            // lbltitulototal
            // 
            lbltitulototal.AutoSize = true;
            lbltitulototal.BackColor = SystemColors.ControlLight;
            lbltitulototal.Location = new Point(151, 95);
            lbltitulototal.Name = "lbltitulototal";
            lbltitulototal.Size = new Size(122, 15);
            lbltitulototal.TabIndex = 1;
            lbltitulototal.Text = "Su total a pagar es de:";
            // 
            // labelfechayhora
            // 
            labelfechayhora.AutoSize = true;
            labelfechayhora.BackColor = SystemColors.ControlLight;
            labelfechayhora.Location = new Point(180, 213);
            labelfechayhora.Name = "labelfechayhora";
            labelfechayhora.Size = new Size(38, 15);
            labelfechayhora.TabIndex = 2;
            labelfechayhora.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(466, 388);
            Controls.Add(labelfechayhora);
            Controls.Add(lbltitulototal);
            Controls.Add(labeltotalf3);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltotalf3;
        private Label lbltitulototal;
        private Label labelfechayhora;
    }
}