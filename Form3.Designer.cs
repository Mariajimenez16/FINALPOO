namespace ProyectoFinalPOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            labelCoincidencias = new Label();
            pictureBoxFoto = new PictureBox();
            labelNombre = new Label();
            labelEdad = new Label();
            labelUbicacion = new Label();
            buttonMatch = new Button();
            buttonSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // labelCoincidencias
            // 
            labelCoincidencias.AutoSize = true;
            labelCoincidencias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoincidencias.Location = new Point(290, 33);
            labelCoincidencias.Name = "labelCoincidencias";
            labelCoincidencias.Size = new Size(200, 32);
            labelCoincidencias.TabIndex = 0;
            labelCoincidencias.Text = "COINCIDENCIAS";
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Image = Properties.Resources.matchman;
            pictureBoxFoto.InitialImage = (Image)resources.GetObject("pictureBoxFoto.InitialImage");
            pictureBoxFoto.Location = new Point(316, 89);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(156, 153);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 1;
            pictureBoxFoto.TabStop = false;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(345, 255);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(102, 21);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Manuel Vélez";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(328, 291);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(33, 15);
            labelEdad.TabIndex = 3;
            labelEdad.Text = "Edad";
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(412, 291);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(60, 15);
            labelUbicacion.TabIndex = 4;
            labelUbicacion.Text = "Ubicación";
            // 
            // buttonMatch
            // 
            buttonMatch.Location = new Point(307, 335);
            buttonMatch.Name = "buttonMatch";
            buttonMatch.Size = new Size(75, 23);
            buttonMatch.TabIndex = 5;
            buttonMatch.Text = "Match";
            buttonMatch.UseVisualStyleBackColor = true;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(415, 335);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(75, 23);
            buttonSiguiente.TabIndex = 6;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonMatch);
            Controls.Add(labelUbicacion);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Controls.Add(pictureBoxFoto);
            Controls.Add(labelCoincidencias);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCoincidencias;
        private PictureBox pictureBoxFoto;
        private Label labelNombre;
        private Label labelEdad;
        private Label labelUbicacion;
        private Button buttonMatch;
        private Button buttonSiguiente;
    }
}