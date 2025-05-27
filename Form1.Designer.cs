namespace ProyectoFinalPOO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRunMatch = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            labelUbicacion = new Label();
            buttonContinuar = new Button();
            labelGenero = new Label();
            comboBoxGenero = new ComboBox();
            labelNivel = new Label();
            comboBoxNivel = new ComboBox();
            checkedListBoxUbicacion = new CheckedListBox();
            pictureBox2 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            fileSystemWatcher1 = new FileSystemWatcher();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelRunMatch
            // 
            labelRunMatch.AutoSize = true;
            labelRunMatch.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRunMatch.Location = new Point(86, 26);
            labelRunMatch.Name = "labelRunMatch";
            labelRunMatch.Size = new Size(151, 33);
            labelRunMatch.TabIndex = 0;
            labelRunMatch.Text = "RunMatch";
            labelRunMatch.Click += labelRunMatch_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(86, 108);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(138, 27);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.TextChanged += textBox2_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(86, 84);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.Click += label2_Click;
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUbicacion.Location = new Point(86, 407);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(148, 24);
            labelUbicacion.TabIndex = 2;
            labelUbicacion.Text = "Our Locations";
            labelUbicacion.Click += label4_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinuar.Location = new Point(366, 444);
            buttonContinuar.Margin = new Padding(3, 4, 3, 4);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(211, 64);
            buttonContinuar.TabIndex = 3;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(86, 242);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(57, 20);
            labelGenero.TabIndex = 4;
            labelGenero.Text = "Género";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Femenino ", "Masculino" });
            comboBoxGenero.Location = new Point(86, 266);
            comboBoxGenero.Margin = new Padding(3, 4, 3, 4);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(138, 28);
            comboBoxGenero.TabIndex = 5;
            comboBoxGenero.SelectedIndexChanged += comboBoxGenero_SelectedIndexChanged;
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Location = new Point(86, 322);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(43, 20);
            labelNivel.TabIndex = 6;
            labelNivel.Text = "Nivel";
            // 
            // comboBoxNivel
            // 
            comboBoxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNivel.FormattingEnabled = true;
            comboBoxNivel.Items.AddRange(new object[] { "Principiante", "Medio", "Avanzado" });
            comboBoxNivel.Location = new Point(86, 355);
            comboBoxNivel.Margin = new Padding(3, 4, 3, 4);
            comboBoxNivel.Name = "comboBoxNivel";
            comboBoxNivel.Size = new Size(138, 28);
            comboBoxNivel.TabIndex = 7;
            // 
            // checkedListBoxUbicacion
            // 
            checkedListBoxUbicacion.FormattingEnabled = true;
            checkedListBoxUbicacion.Items.AddRange(new object[] { "Aeroparque Juan Pablo II (Medellín)", "Avenida Las Vegas (Envigado)", "Unidad Deportiva de Belén (Medellín)", "Cerro El Volador (Medellín)", "Cerro Tres Cruces (Medellín)", "Ciclovía Manila - Poblado ", "Parque Tulio Ospina (Bello)", "Unidad Deportiva Atanasio Girardot (Medellín)" });
            checkedListBoxUbicacion.Location = new Point(31, 444);
            checkedListBoxUbicacion.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxUbicacion.Name = "checkedListBoxUbicacion";
            checkedListBoxUbicacion.Size = new Size(269, 136);
            checkedListBoxUbicacion.TabIndex = 9;
            checkedListBoxUbicacion.SelectedIndexChanged += checkedListBoxUbicacion_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MistyRose;
            pictureBox2.Image = Properties.Resources.runmatch_removebg_preview;
            pictureBox2.Location = new Point(24, 11);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(86, 185);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(138, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 161);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 13;
            label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(676, 138);
            label2.Name = "label2";
            label2.Size = new Size(226, 98);
            label2.TabIndex = 14;
            label2.Text = "Corre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(645, 217);
            label3.Name = "label3";
            label3.Size = new Size(158, 52);
            label3.TabIndex = 15;
            label3.Text = "Por La";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(738, 267);
            label4.Name = "label4";
            label4.Size = new Size(147, 60);
            label4.TabIndex = 16;
            label4.Text = "Vida";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RUNNERS_CLUB;
            pictureBox1.Location = new Point(326, 62);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(pictureBox2);
            Controls.Add(checkedListBoxUbicacion);
            Controls.Add(comboBoxNivel);
            Controls.Add(labelNivel);
            Controls.Add(comboBoxGenero);
            Controls.Add(labelGenero);
            Controls.Add(buttonContinuar);
            Controls.Add(labelUbicacion);
            Controls.Add(labelNombre);
            Controls.Add(textBoxNombre);
            Controls.Add(labelRunMatch);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRunMatch;
        private TextBox textBoxNombre;
        private TextBox textBox3;
        private Label labelNombre;
        private Label labelUbicacion;
        private Button buttonContinuar;
        private Label labelGenero;
        private ComboBox comboBoxGenero;
        private Label labelNivel;
        private ComboBox comboBoxNivel;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBoxUbicacion;
        private PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FileSystemWatcher fileSystemWatcher1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
