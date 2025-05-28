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
            txtChat.Location = new Point(100, 20);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(700, 250);
            txtChat.TabIndex = 0;
            // 
            // btnHola
            // 
            btnHola.Location = new Point(150, 290);
            btnHola.Name = "btnHola";
            btnHola.Size = new Size(100, 40);
            btnHola.TabIndex = 1;
            btnHola.Text = "Hola";
            btnHola.UseVisualStyleBackColor = true;
            btnHola.Click += BtnHola_Click;
            // 
            // btnDia
            // 
            btnDia.Location = new Point(280, 290);
            btnDia.Name = "btnDia";
            btnDia.Size = new Size(180, 40);
            btnDia.TabIndex = 2;
            btnDia.Text = "¿Qué día estás disponible?";
            btnDia.UseVisualStyleBackColor = true;
            btnDia.Click += BtnDia_Click;
            // 
            // btnHora
            // 
            btnHora.Location = new Point(480, 290);
            btnHora.Name = "btnHora";
            btnHora.Size = new Size(180, 40);
            btnHora.TabIndex = 3;
            btnHora.Text = "¿A qué hora quieres correr?";
            btnHora.UseVisualStyleBackColor = true;
            btnHora.Click += BtnHora_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(390, 340);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += BtnVolver_Click;
            // 
            // btnBrunch
            // 
            btnBrunch.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnBrunch.Location = new Point(725, 299);
            btnBrunch.Name = "btnBrunch";
            btnBrunch.Size = new Size(75, 40);
            btnBrunch.TabIndex = 5;
            btnBrunch.Text = "Invitar a Brunch";
            btnBrunch.UseVisualStyleBackColor = true;
            // 
            // btnMapa
            // 
            btnMapa.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnMapa.Location = new Point(813, 299);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(75, 40);
            btnMapa.TabIndex = 6;
            btnMapa.Text = "Rutas";
            btnMapa.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(900, 400);
            Controls.Add(btnMapa);
            Controls.Add(btnBrunch);
            Controls.Add(txtChat);
            Controls.Add(btnHola);
            Controls.Add(btnDia);
            Controls.Add(btnHora);
            Controls.Add(btnVolver);
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

