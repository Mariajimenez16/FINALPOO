namespace ProyectoFinalPOO
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        // Método que se ejecuta al cerrar o eliminar el formulario.
        // Sobrescribe el método Dispose de la clase base para liberar memoria y recursos utilizados.
        // Se usa protected porque es accesible desde clases hijas, y override porque personaliza el comportamiento original.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtChat = new TextBox();
            btnHola = new Button();
            btnDia = new Button();
            btnHora = new Button();
            btnVolver = new Button();
            btnBrunch = new Button();
            btnMapa = new Button();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.Ivory;
            txtChat.Font = new Font("Segoe UI", 12F);
            txtChat.Location = new Point(114, 27);
            txtChat.Margin = new Padding(3, 4, 3, 4);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(799, 332);
            txtChat.TabIndex = 0;
            // 
            // btnHola
            // 
            btnHola.Location = new Point(171, 387);
            btnHola.Margin = new Padding(3, 4, 3, 4);
            btnHola.Name = "btnHola";
            btnHola.Size = new Size(114, 53);
            btnHola.TabIndex = 1;
            btnHola.Text = "Hola";
            btnHola.UseVisualStyleBackColor = true;
            btnHola.Click += BtnHola_Click;
            // 
            // btnDia
            // 
            btnDia.Location = new Point(320, 387);
            btnDia.Margin = new Padding(3, 4, 3, 4);
            btnDia.Name = "btnDia";
            btnDia.Size = new Size(206, 53);
            btnDia.TabIndex = 2;
            btnDia.Text = "¿Qué día estás disponible?";
            btnDia.UseVisualStyleBackColor = true;
            btnDia.Click += BtnDia_Click;
            // 
            // btnHora
            // 
            btnHora.Location = new Point(549, 387);
            btnHora.Margin = new Padding(3, 4, 3, 4);
            btnHora.Name = "btnHora";
            btnHora.Size = new Size(206, 53);
            btnHora.TabIndex = 3;
            btnHora.Text = "¿A qué hora quieres correr?";
            btnHora.UseVisualStyleBackColor = true;
            btnHora.Click += BtnHora_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(446, 453);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += BtnVolver_Click;
            // 
            // btnBrunch
            // 
            btnBrunch.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnBrunch.Location = new Point(829, 399);
            btnBrunch.Margin = new Padding(3, 4, 3, 4);
            btnBrunch.Name = "btnBrunch";
            btnBrunch.Size = new Size(86, 53);
            btnBrunch.TabIndex = 5;
            btnBrunch.Text = "Invitar a Brunch";
            btnBrunch.UseVisualStyleBackColor = true;
            // 
            // btnMapa
            // 
            btnMapa.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnMapa.Location = new Point(929, 399);
            btnMapa.Margin = new Padding(3, 4, 3, 4);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(86, 53);
            btnMapa.TabIndex = 6;
            btnMapa.Text = "Rutas";
            btnMapa.UseVisualStyleBackColor = true;
            btnMapa.Click += btnMapa_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1029, 533);
            Controls.Add(btnMapa);
            Controls.Add(btnBrunch);
            Controls.Add(txtChat);
            Controls.Add(btnHola);
            Controls.Add(btnDia);
            Controls.Add(btnHora);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Chat iniciado con tu match 🏃‍♂️💬";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChat;
        private Button btnHola;
        private Button btnDia;
        private Button btnHora;
        private Button btnVolver;
        private Button btnBrunch;
        private Button btnMapa;
    }
}


