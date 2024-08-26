namespace WindowsFormsApp1
{
    partial class Form4
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
            this.rdboy = new System.Windows.Forms.RadioButton();
            this.rdpen = new System.Windows.Forms.RadioButton();
            this.rdbook = new System.Windows.Forms.RadioButton();
            this.rdgirl = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdboy
            // 
            this.rdboy.AutoSize = true;
            this.rdboy.BackColor = System.Drawing.Color.Black;
            this.rdboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdboy.ForeColor = System.Drawing.Color.Orange;
            this.rdboy.Location = new System.Drawing.Point(258, 554);
            this.rdboy.Name = "rdboy";
            this.rdboy.Size = new System.Drawing.Size(62, 24);
            this.rdboy.TabIndex = 1;
            this.rdboy.TabStop = true;
            this.rdboy.Tag = "Boy";
            this.rdboy.Text = "Boy";
            this.rdboy.UseVisualStyleBackColor = false;
            this.rdboy.CheckedChanged += new System.EventHandler(this.rdboy_CheckedChanged);
            // 
            // rdpen
            // 
            this.rdpen.AutoSize = true;
            this.rdpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdpen.ForeColor = System.Drawing.Color.Orange;
            this.rdpen.Location = new System.Drawing.Point(877, 554);
            this.rdpen.Name = "rdpen";
            this.rdpen.Size = new System.Drawing.Size(60, 24);
            this.rdpen.TabIndex = 2;
            this.rdpen.TabStop = true;
            this.rdpen.Tag = "Ben";
            this.rdpen.Text = "pen";
            this.rdpen.UseVisualStyleBackColor = true;
            this.rdpen.CheckedChanged += new System.EventHandler(this.rdpen_CheckedChanged);
            // 
            // rdbook
            // 
            this.rdbook.AutoSize = true;
            this.rdbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbook.ForeColor = System.Drawing.Color.Orange;
            this.rdbook.Location = new System.Drawing.Point(673, 554);
            this.rdbook.Name = "rdbook";
            this.rdbook.Size = new System.Drawing.Size(72, 24);
            this.rdbook.TabIndex = 3;
            this.rdbook.TabStop = true;
            this.rdbook.Tag = "Book";
            this.rdbook.Text = "Book";
            this.rdbook.UseVisualStyleBackColor = true;
            this.rdbook.CheckedChanged += new System.EventHandler(this.rdbook_CheckedChanged);
            // 
            // rdgirl
            // 
            this.rdgirl.AutoSize = true;
            this.rdgirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdgirl.ForeColor = System.Drawing.Color.Orange;
            this.rdgirl.Location = new System.Drawing.Point(457, 554);
            this.rdgirl.Name = "rdgirl";
            this.rdgirl.Size = new System.Drawing.Size(61, 24);
            this.rdgirl.TabIndex = 4;
            this.rdgirl.TabStop = true;
            this.rdgirl.Tag = "Girl";
            this.rdgirl.Text = "Girl";
            this.rdgirl.UseVisualStyleBackColor = true;
            this.rdgirl.CheckedChanged += new System.EventHandler(this.rdgirl_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Pen;
            this.pictureBox1.Location = new System.Drawing.Point(258, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imagename
            // 
            this.imagename.AutoSize = true;
            this.imagename.Font = new System.Drawing.Font("Modern No. 20", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagename.ForeColor = System.Drawing.Color.Orange;
            this.imagename.Location = new System.Drawing.Point(535, 19);
            this.imagename.Name = "imagename";
            this.imagename.Size = new System.Drawing.Size(90, 44);
            this.imagename.TabIndex = 5;
            this.imagename.Text = "Boy";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1174, 668);
            this.Controls.Add(this.imagename);
            this.Controls.Add(this.rdgirl);
            this.Controls.Add(this.rdbook);
            this.Controls.Add(this.rdpen);
            this.Controls.Add(this.rdboy);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdboy;
        private System.Windows.Forms.RadioButton rdpen;
        private System.Windows.Forms.RadioButton rdbook;
        private System.Windows.Forms.RadioButton rdgirl;
        private System.Windows.Forms.Label imagename;
    }
}