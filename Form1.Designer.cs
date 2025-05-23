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
            labelPreferencia = new Label();
            comboBoxPreferencia = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // labelRunMatch
            // 
            labelRunMatch.AutoSize = true;
            labelRunMatch.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRunMatch.Location = new Point(74, 15);
            labelRunMatch.Margin = new Padding(4, 0, 4, 0);
            labelRunMatch.Name = "labelRunMatch";
            labelRunMatch.Size = new Size(178, 39);
            labelRunMatch.TabIndex = 0;
            labelRunMatch.Text = "RunMatch";
            labelRunMatch.Click += labelRunMatch_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(73, 135);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(171, 31);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.TextChanged += textBox2_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(73, 105);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(78, 25);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.Click += label2_Click;
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUbicacion.Location = new Point(454, 105);
            labelUbicacion.Margin = new Padding(4, 0, 4, 0);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(178, 29);
            labelUbicacion.TabIndex = 2;
            labelUbicacion.Text = "Our Locations";
            labelUbicacion.Click += label4_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinuar.Location = new Point(420, 498);
            buttonContinuar.Margin = new Padding(4, 5, 4, 5);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(264, 80);
            buttonContinuar.TabIndex = 3;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(73, 313);
            labelGenero.Margin = new Padding(4, 0, 4, 0);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(69, 25);
            labelGenero.TabIndex = 4;
            labelGenero.Text = "Género";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Femenino ", "Masculino", "Otro" });
            comboBoxGenero.Location = new Point(73, 343);
            comboBoxGenero.Margin = new Padding(4, 5, 4, 5);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(171, 33);
            comboBoxGenero.TabIndex = 5;
            comboBoxGenero.SelectedIndexChanged += comboBoxGenero_SelectedIndexChanged;
            // 
            // labelPreferencia
            // 
            labelPreferencia.AutoSize = true;
            labelPreferencia.Location = new Point(73, 420);
            labelPreferencia.Margin = new Padding(4, 0, 4, 0);
            labelPreferencia.Name = "labelPreferencia";
            labelPreferencia.Size = new Size(143, 50);
            labelPreferencia.TabIndex = 6;
            labelPreferencia.Text = "Preferencia para \r\ncorrer\r\n";
            // 
            // comboBoxPreferencia
            // 
            comboBoxPreferencia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPreferencia.FormattingEnabled = true;
            comboBoxPreferencia.Items.AddRange(new object[] { "Mujeres ", "Hombres", "Mixto" });
            comboBoxPreferencia.Location = new Point(73, 475);
            comboBoxPreferencia.Margin = new Padding(4, 5, 4, 5);
            comboBoxPreferencia.Name = "comboBoxPreferencia";
            comboBoxPreferencia.Size = new Size(171, 33);
            comboBoxPreferencia.TabIndex = 7;
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Location = new Point(71, 553);
            labelNivel.Margin = new Padding(4, 0, 4, 0);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(51, 25);
            labelNivel.TabIndex = 6;
            labelNivel.Text = "Nivel";
            // 
            // comboBoxNivel
            // 
            comboBoxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNivel.FormattingEnabled = true;
            comboBoxNivel.Items.AddRange(new object[] { "Principiante", "Medio", "Avanzado" });
            comboBoxNivel.Location = new Point(73, 583);
            comboBoxNivel.Margin = new Padding(4, 5, 4, 5);
            comboBoxNivel.Name = "comboBoxNivel";
            comboBoxNivel.Size = new Size(171, 33);
            comboBoxNivel.TabIndex = 7;
            // 
            // checkedListBoxUbicacion
            // 
            checkedListBoxUbicacion.FormattingEnabled = true;
            checkedListBoxUbicacion.Items.AddRange(new object[] { "Aeroparque Juan Pablo II (Medellín)", "Avenida Las Vegas (Envigado)", "Cerro de las Tres Cruces (Medellín)", "Cerro El Picacho (Medellín)", "Cerro El Volador (Medellín)", "Ciclovía del Río (Medellín)", "Corredores Verdes (Medellín)", "Jardín Botánico (Medellín)", "Laguna Fontidueño (Bello)", "Parque Tulio Ospina (Bello)", "Pista de Atletismo Alfonso Galvis (Medellín)", "Unidad Deportiva Atanasio Girardot (Medellín)", "Unidad Deportiva de Belén (Medellín)", "Viva Envigado – Entrada Sabaneta Las Vegas (Envigado)" });
            checkedListBoxUbicacion.Location = new Point(386, 152);
            checkedListBoxUbicacion.Margin = new Padding(4, 5, 4, 5);
            checkedListBoxUbicacion.Name = "checkedListBoxUbicacion";
            checkedListBoxUbicacion.Size = new Size(335, 172);
            checkedListBoxUbicacion.TabIndex = 9;
            checkedListBoxUbicacion.SelectedIndexChanged += checkedListBoxUbicacion_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 192, 192);
            pictureBox2.Image = Properties.Resources.runmatch_removebg_preview;
            pictureBox2.Location = new Point(1057, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 87);
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
            dateTimePicker2.Location = new Point(73, 245);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 31);
            dateTimePicker2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 215);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 13;
            label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(873, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 51);
            label2.TabIndex = 14;
            label2.Text = "Corre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(894, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 36);
            label3.TabIndex = 15;
            label3.Text = "Por La";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(873, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 53);
            label4.TabIndex = 16;
            label4.Text = "Vida";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1143, 750);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(pictureBox2);
            Controls.Add(checkedListBoxUbicacion);
            Controls.Add(comboBoxNivel);
            Controls.Add(comboBoxPreferencia);
            Controls.Add(labelNivel);
            Controls.Add(labelPreferencia);
            Controls.Add(comboBoxGenero);
            Controls.Add(labelGenero);
            Controls.Add(buttonContinuar);
            Controls.Add(labelUbicacion);
            Controls.Add(labelNombre);
            Controls.Add(textBoxNombre);
            Controls.Add(labelRunMatch);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private Label labelPreferencia;
        private ComboBox comboBoxPreferencia;
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
    }
}
