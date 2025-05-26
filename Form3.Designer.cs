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
            pictureBoxFoto = new PictureBox();
            labelNombre = new Label();
            labelEdad = new Label();
            labelUbicacion = new Label();
            buttonMatch = new Button();
            buttonSiguiente = new Button();
            comboBoxFiltroGenero = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Image = Properties.Resources.matchman;
            pictureBoxFoto.InitialImage = (Image)resources.GetObject("pictureBoxFoto.InitialImage");
            pictureBoxFoto.Location = new Point(160, 89);
            pictureBoxFoto.Margin = new Padding(4, 5, 4, 5);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(256, 334);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 1;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(206, 428);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(158, 32);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Manuel Vélez";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(160, 471);
            labelEdad.Margin = new Padding(4, 0, 4, 0);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(52, 25);
            labelEdad.TabIndex = 3;
            labelEdad.Text = "Edad";
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(160, 513);
            labelUbicacion.Margin = new Padding(4, 0, 4, 0);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(89, 25);
            labelUbicacion.TabIndex = 4;
            labelUbicacion.Text = "Ubicación";
            // 
            // buttonMatch
            // 
            buttonMatch.Location = new Point(105, 626);
            buttonMatch.Margin = new Padding(4, 5, 4, 5);
            buttonMatch.Name = "buttonMatch";
            buttonMatch.Size = new Size(107, 38);
            buttonMatch.TabIndex = 5;
            buttonMatch.Text = "Match";
            buttonMatch.UseVisualStyleBackColor = true;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(365, 626);
            buttonSiguiente.Margin = new Padding(4, 5, 4, 5);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(107, 38);
            buttonSiguiente.TabIndex = 6;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            // 
            // comboBoxFiltroGenero
            // 
            comboBoxFiltroGenero.FormattingEnabled = true;
            comboBoxFiltroGenero.Location = new Point(310, 12);
            comboBoxFiltroGenero.Name = "comboBoxFiltroGenero";
            comboBoxFiltroGenero.Size = new Size(182, 33);
            comboBoxFiltroGenero.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 14);
            label1.Name = "label1";
            label1.Size = new Size(231, 27);
            label1.TabIndex = 8;
            label1.Text = "Preferencia de Genero";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.Coincidencia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(comboBoxFiltroGenero);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonMatch);
            Controls.Add(labelUbicacion);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Controls.Add(pictureBoxFoto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxFoto;
        private Label labelNombre;
        private Label labelEdad;
        private Label labelUbicacion;
        private Button buttonMatch;
        private Button buttonSiguiente;
        private ComboBox comboBoxFiltroGenero;
        private Label label1;
    }
}