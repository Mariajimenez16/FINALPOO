namespace ProyectoFinalPOO
{
    partial class Form2
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
            label1 = new Label();
            FotoPerfil = new PictureBox();
            AgregarFoto = new Button();
            Nombre = new Label();
            Edad = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCrearPerfil = new Button();
            textoNombre = new Label();
            linkLabel1 = new LinkLabel();
            EdadTexto = new Label();
            GeneroTexto = new Label();
            NivelTexto = new Label();
            NombreTexto = new Label();
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 42);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 0;
            label1.Text = "Perfil";
            label1.Click += label1_Click;
            // 
            // FotoPerfil
            // 
            FotoPerfil.BackColor = Color.Transparent;
            FotoPerfil.BackgroundImage = Properties.Resources.Perfil;
            FotoPerfil.BackgroundImageLayout = ImageLayout.Zoom;
            FotoPerfil.Location = new Point(133, 87);
            FotoPerfil.Name = "FotoPerfil";
            FotoPerfil.Size = new Size(259, 235);
            FotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            FotoPerfil.TabIndex = 1;
            FotoPerfil.TabStop = false;
            // 
            // AgregarFoto
            // 
            AgregarFoto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgregarFoto.Location = new Point(133, 328);
            AgregarFoto.Name = "AgregarFoto";
            AgregarFoto.Size = new Size(259, 33);
            AgregarFoto.TabIndex = 2;
            AgregarFoto.Text = "Agregar Foto del perfil";
            AgregarFoto.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(69, 391);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(89, 25);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre: ";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Edad.Location = new Point(69, 425);
            Edad.Name = "Edad";
            Edad.Size = new Size(65, 25);
            Edad.TabIndex = 4;
            Edad.Text = "Edad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 462);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 5;
            label2.Text = "Género: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 500);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 6;
            label3.Text = "Nivel de experticia:";
            label3.Click += label3_Click;
            // 
            // buttonCrearPerfil
            // 
            buttonCrearPerfil.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCrearPerfil.Location = new Point(194, 543);
            buttonCrearPerfil.Name = "buttonCrearPerfil";
            buttonCrearPerfil.Size = new Size(128, 29);
            buttonCrearPerfil.TabIndex = 7;
            buttonCrearPerfil.Text = "Crear Perfil";
            buttonCrearPerfil.UseVisualStyleBackColor = true;
            buttonCrearPerfil.Click += buttonCrearPerfil_Click;
            // 
            // textoNombre
            // 
            textoNombre.AutoSize = true;
            textoNombre.Location = new Point(146, 391);
            textoNombre.Name = "textoNombre";
            textoNombre.Size = new Size(0, 20);
            textoNombre.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(418, 451);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 9;
            // 
            // EdadTexto
            // 
            EdadTexto.AutoSize = true;
            EdadTexto.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            EdadTexto.Location = new Point(140, 427);
            EdadTexto.Name = "EdadTexto";
            EdadTexto.Size = new Size(45, 23);
            EdadTexto.TabIndex = 10;
            EdadTexto.Text = "edad";
            // 
            // GeneroTexto
            // 
            GeneroTexto.AutoSize = true;
            GeneroTexto.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            GeneroTexto.Location = new Point(146, 464);
            GeneroTexto.Name = "GeneroTexto";
            GeneroTexto.Size = new Size(60, 23);
            GeneroTexto.TabIndex = 11;
            GeneroTexto.Text = "genero";
            // 
            // NivelTexto
            // 
            NivelTexto.AutoSize = true;
            NivelTexto.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NivelTexto.Location = new Point(251, 500);
            NivelTexto.Name = "NivelTexto";
            NivelTexto.Size = new Size(44, 23);
            NivelTexto.TabIndex = 12;
            NivelTexto.Text = "nivel";
            // 
            // NombreTexto
            // 
            NombreTexto.AutoSize = true;
            NombreTexto.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NombreTexto.Location = new Point(152, 393);
            NombreTexto.Name = "NombreTexto";
            NombreTexto.Size = new Size(67, 23);
            NombreTexto.TabIndex = 13;
            NombreTexto.Text = "nombre";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(526, 621);
            Controls.Add(NombreTexto);
            Controls.Add(NivelTexto);
            Controls.Add(GeneroTexto);
            Controls.Add(EdadTexto);
            Controls.Add(linkLabel1);
            Controls.Add(textoNombre);
            Controls.Add(buttonCrearPerfil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Edad);
            Controls.Add(Nombre);
            Controls.Add(AgregarFoto);
            Controls.Add(FotoPerfil);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox FotoPerfil;
        private Button AgregarFoto;
        private Label Nombre;
        private Label Edad;
        private Label label2;
        private Label label3;
        private Button buttonCrearPerfil;
        private Label textoNombre;
        private LinkLabel linkLabel1;
        private Label EdadTexto;
        private Label GeneroTexto;
        private Label NivelTexto;
        private Label NombreTexto;
    }
}