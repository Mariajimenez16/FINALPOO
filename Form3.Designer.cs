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
            pictureBoxFoto.Location = new Point(128, 71);
            pictureBoxFoto.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(205, 267);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 1;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(165, 342);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(127, 28);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Manuel Vélez";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(128, 377);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 3;
            labelEdad.Text = "Edad";
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(128, 410);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(75, 20);
            labelUbicacion.TabIndex = 4;
            labelUbicacion.Text = "Ubicación";
            // 
            // buttonMatch
            // 
            buttonMatch.BackColor = Color.MediumSeaGreen;
            buttonMatch.FlatAppearance.BorderSize = 0;
            buttonMatch.FlatStyle = FlatStyle.Flat;
            buttonMatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMatch.ForeColor = SystemColors.ButtonHighlight;
            buttonMatch.Location = new Point(93, 501);
            buttonMatch.Margin = new Padding(3, 4, 3, 4);
            buttonMatch.Name = "buttonMatch";
            buttonMatch.Size = new Size(69, 30);
            buttonMatch.TabIndex = 5;
            buttonMatch.Text = "Match";
            buttonMatch.UseVisualStyleBackColor = false;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Red;
            buttonSiguiente.FlatAppearance.BorderColor = Color.White;
            buttonSiguiente.FlatAppearance.BorderSize = 0;
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSiguiente.ForeColor = SystemColors.ButtonHighlight;
            buttonSiguiente.Location = new Point(292, 501);
            buttonSiguiente.Margin = new Padding(3, 4, 3, 4);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(84, 30);
            buttonSiguiente.TabIndex = 6;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click_1;
            // 
            // comboBoxFiltroGenero
            // 
            comboBoxFiltroGenero.FormattingEnabled = true;
            comboBoxFiltroGenero.Location = new Point(248, 10);
            comboBoxFiltroGenero.Margin = new Padding(2);
            comboBoxFiltroGenero.Name = "comboBoxFiltroGenero";
            comboBoxFiltroGenero.Size = new Size(146, 28);
            comboBoxFiltroGenero.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 23);
            label1.TabIndex = 8;
            label1.Text = "Preferencia de Genero";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.Coincidencia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(comboBoxFiltroGenero);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonMatch);
            Controls.Add(labelUbicacion);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Controls.Add(pictureBoxFoto);
            Margin = new Padding(3, 4, 3, 4);
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