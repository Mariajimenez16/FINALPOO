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
            txtHistorial.MaximumSize = new Size(0, 300);
            txtHistorial.Name = "txtHistorial";
            txtHistorial.ScrollBars = ScrollBars.Vertical;
            txtHistorial.Size = new Size(1285, 31);
            txtHistorial.TabIndex = 0;
            // 
            // txtMensaje
            // 
            txtMensaje.Dock = DockStyle.Bottom;
            txtMensaje.Location = new Point(0, 621);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(1285, 31);
            txtMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Dock = DockStyle.Bottom;
            btnEnviar.Location = new Point(0, 587);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(1285, 34);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 652);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(txtHistorial);
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