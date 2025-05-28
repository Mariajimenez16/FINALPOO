namespace ProyectoFinalPOO
{
    partial class Form6
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
            cmbUbicaciones = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBoxRuta2 = new PictureBox();
            pictureBoxRuta1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuta2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuta1).BeginInit();
            SuspendLayout();
            // 
            // cmbUbicaciones
            // 
            cmbUbicaciones.FormattingEnabled = true;
            cmbUbicaciones.Location = new Point(219, 12);
            cmbUbicaciones.Name = "cmbUbicaciones";
            cmbUbicaciones.Size = new Size(423, 28);
            cmbUbicaciones.TabIndex = 0;
            cmbUbicaciones.SelectedIndexChanged += cmbUbicaciones_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBoxRuta2);
            panel1.Controls.Add(pictureBoxRuta1);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 405);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(167, 339);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 5;
            label4.Text = "Ruta 1";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(666, 339);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 3;
            label2.Text = "Ruta 2";
            label2.Click += label2_Click;
            // 
            // pictureBoxRuta2
            // 
            pictureBoxRuta2.Location = new Point(537, 44);
            pictureBoxRuta2.Name = "pictureBoxRuta2";
            pictureBoxRuta2.Size = new Size(405, 281);
            pictureBoxRuta2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRuta2.TabIndex = 1;
            pictureBoxRuta2.TabStop = false;
            pictureBoxRuta2.Click += pictureBox2_Click;
            // 
            // pictureBoxRuta1
            // 
            pictureBoxRuta1.Location = new Point(41, 44);
            pictureBoxRuta1.Name = "pictureBoxRuta1";
            pictureBoxRuta1.Size = new Size(402, 281);
            pictureBoxRuta1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRuta1.TabIndex = 0;
            pictureBoxRuta1.TabStop = false;
            pictureBoxRuta1.Click += pictureBoxRuta1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 3;
            label1.Text = "Ubicaciones Favoritas ";
            label1.Click += label1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DegradadoFondo;
            ClientSize = new Size(1004, 545);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(cmbUbicaciones);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuta2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRuta1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUbicaciones;
        private Panel panel1;
        private PictureBox pictureBoxRuta2;
        private PictureBox pictureBoxRuta1;
        private Label label1;
        private Button button1;
        private Label label4;
        private Label label2;
    }
}