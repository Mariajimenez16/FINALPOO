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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            buttonMatch = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 51);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Coincidencias";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.matchman;
            pictureBox1.Location = new Point(136, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 309);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 2;
            label2.Text = "Manuel Vélez";
            // 
            // buttonMatch
            // 
            buttonMatch.Location = new Point(136, 360);
            buttonMatch.Name = "buttonMatch";
            buttonMatch.Size = new Size(75, 23);
            buttonMatch.TabIndex = 3;
            buttonMatch.Text = "Match 💗";
            buttonMatch.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 360);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 3;
            button2.Text = "Siguiente ✖️";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonMatch);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button buttonMatch;
        private Button button2;
    }
}