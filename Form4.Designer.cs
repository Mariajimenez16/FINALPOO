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
            txtChat.Location = new Point(142, 34);
            txtChat.Margin = new Padding(4, 5, 4, 5);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(998, 414);
            txtChat.TabIndex = 0;
            // 
            // btnHola
            // 
            btnHola.Location = new Point(214, 484);
            btnHola.Margin = new Padding(4, 5, 4, 5);
            btnHola.Name = "btnHola";
            btnHola.Size = new Size(142, 66);
            btnHola.TabIndex = 1;
            btnHola.Text = "Hola";
            btnHola.UseVisualStyleBackColor = true;
            btnHola.Click += BtnHola_Click;
            // 
            // btnDia
            // 
            btnDia.Location = new Point(400, 484);
            btnDia.Margin = new Padding(4, 5, 4, 5);
            btnDia.Name = "btnDia";
            btnDia.Size = new Size(258, 66);
            btnDia.TabIndex = 2;
            btnDia.Text = "¿Qué día estás disponible?";
            btnDia.UseVisualStyleBackColor = true;
            btnDia.Click += BtnDia_Click;
            // 
            // btnHora
            // 
            btnHora.Location = new Point(686, 484);
            btnHora.Margin = new Padding(4, 5, 4, 5);
            btnHora.Name = "btnHora";
            btnHora.Size = new Size(258, 66);
            btnHora.TabIndex = 3;
            btnHora.Text = "¿A qué hora quieres correr?";
            btnHora.UseVisualStyleBackColor = true;
            btnHora.Click += BtnHora_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(558, 566);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 50);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += BtnVolver_Click;
            // 
            // btnBrunch
            // 
            btnBrunch.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnBrunch.Location = new Point(1036, 499);
            btnBrunch.Margin = new Padding(4, 5, 4, 5);
            btnBrunch.Name = "btnBrunch";
            btnBrunch.Size = new Size(108, 66);
            btnBrunch.TabIndex = 5;
            btnBrunch.Text = "Invitar a Brunch";
            btnBrunch.UseVisualStyleBackColor = true;
            btnBrunch.Click += btnBrunch_Click;
            // 
            // btnMapa
            // 
            btnMapa.BackgroundImage = Properties.Resources.DegradadoFondo;
            btnMapa.Location = new Point(1161, 499);
            btnMapa.Margin = new Padding(4, 5, 4, 5);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(108, 66);
            btnMapa.TabIndex = 6;
            btnMapa.Text = "Rutas";
            btnMapa.UseVisualStyleBackColor = true;
            btnMapa.Click += btnMapa_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1286, 666);
            Controls.Add(btnMapa);
            Controls.Add(btnBrunch);
            Controls.Add(txtChat);
            Controls.Add(btnHola);
            Controls.Add(btnDia);
            Controls.Add(btnHora);
            Controls.Add(btnVolver);
            Margin = new Padding(4, 5, 4, 5);
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


