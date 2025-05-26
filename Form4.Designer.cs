namespace ProyectoFinalPOO
{
    partial class Form4
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
            txtHistorial = new TextBox();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtHistorial
            // 
            txtHistorial.Dock = DockStyle.Top;
            txtHistorial.Location = new Point(0, 0);
            txtHistorial.Margin = new Padding(2);
            txtHistorial.MaximumSize = new Size(4, 300);
            txtHistorial.Name = "txtHistorial";
            txtHistorial.ScrollBars = ScrollBars.Vertical;
            txtHistorial.Size = new Size(4, 27);
            txtHistorial.TabIndex = 0;
            // 
            // txtMensaje
            // 
            txtMensaje.Dock = DockStyle.Bottom;
            txtMensaje.Location = new Point(0, 495);
            txtMensaje.Margin = new Padding(2);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(1028, 27);
            txtMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Dock = DockStyle.Bottom;
            btnEnviar.Location = new Point(0, 468);
            btnEnviar.Margin = new Padding(2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(1028, 27);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 522);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(txtHistorial);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHistorial;
        private TextBox txtMensaje;
        private Button btnEnviar;
    }
}