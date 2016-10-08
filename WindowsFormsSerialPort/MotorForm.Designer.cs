namespace WindowsFormsSerialPort
{
    partial class MotorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.speed_button = new System.Windows.Forms.PictureBox();
            this.enabled_button = new System.Windows.Forms.PictureBox();
            this.direction_button = new System.Windows.Forms.PictureBox();
            this.distance_button = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.speed_textBox = new System.Windows.Forms.TextBox();
            this.enabled_textBox = new System.Windows.Forms.TextBox();
            this.distance_textBox = new System.Windows.Forms.TextBox();
            this.direction_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enabled_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direction_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(82, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // speed_button
            // 
            this.speed_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speed_button.BackgroundImage")));
            this.speed_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speed_button.Location = new System.Drawing.Point(23, 252);
            this.speed_button.Name = "speed_button";
            this.speed_button.Size = new System.Drawing.Size(155, 138);
            this.speed_button.TabIndex = 4;
            this.speed_button.TabStop = false;
            this.speed_button.Click += new System.EventHandler(this.speed_button_Click);
            // 
            // enabled_button
            // 
            this.enabled_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enabled_button.BackgroundImage")));
            this.enabled_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enabled_button.Location = new System.Drawing.Point(23, 95);
            this.enabled_button.Name = "enabled_button";
            this.enabled_button.Size = new System.Drawing.Size(155, 138);
            this.enabled_button.TabIndex = 5;
            this.enabled_button.TabStop = false;
            this.enabled_button.Click += new System.EventHandler(this.enabled_button_Click);
            // 
            // direction_button
            // 
            this.direction_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("direction_button.BackgroundImage")));
            this.direction_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.direction_button.Location = new System.Drawing.Point(23, 407);
            this.direction_button.Name = "direction_button";
            this.direction_button.Size = new System.Drawing.Size(155, 138);
            this.direction_button.TabIndex = 6;
            this.direction_button.TabStop = false;
            this.direction_button.Click += new System.EventHandler(this.direction_button_Click);
            // 
            // distance_button
            // 
            this.distance_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("distance_button.BackgroundImage")));
            this.distance_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.distance_button.Location = new System.Drawing.Point(23, 562);
            this.distance_button.Name = "distance_button";
            this.distance_button.Size = new System.Drawing.Size(155, 138);
            this.distance_button.TabIndex = 7;
            this.distance_button.TabStop = false;
            this.distance_button.Click += new System.EventHandler(this.distance_button_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(208, 95);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(275, 138);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(208, 252);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(275, 138);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(208, 407);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(275, 138);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(208, 562);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(275, 138);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // speed_textBox
            // 
            this.speed_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_textBox.Location = new System.Drawing.Point(251, 300);
            this.speed_textBox.Name = "speed_textBox";
            this.speed_textBox.Size = new System.Drawing.Size(191, 44);
            this.speed_textBox.TabIndex = 12;
            // 
            // enabled_textBox
            // 
            this.enabled_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enabled_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled_textBox.Location = new System.Drawing.Point(251, 142);
            this.enabled_textBox.Name = "enabled_textBox";
            this.enabled_textBox.Size = new System.Drawing.Size(191, 44);
            this.enabled_textBox.TabIndex = 13;
            // 
            // distance_textBox
            // 
            this.distance_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distance_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_textBox.Location = new System.Drawing.Point(251, 610);
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.Size = new System.Drawing.Size(191, 44);
            this.distance_textBox.TabIndex = 14;
            // 
            // direction_textBox
            // 
            this.direction_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.direction_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction_textBox.Location = new System.Drawing.Point(251, 456);
            this.direction_textBox.Name = "direction_textBox";
            this.direction_textBox.Size = new System.Drawing.Size(191, 44);
            this.direction_textBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(507, 722);
            this.Controls.Add(this.direction_textBox);
            this.Controls.Add(this.distance_textBox);
            this.Controls.Add(this.enabled_textBox);
            this.Controls.Add(this.speed_textBox);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.distance_button);
            this.Controls.Add(this.direction_button);
            this.Controls.Add(this.enabled_button);
            this.Controls.Add(this.speed_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enabled_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direction_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox speed_button;
        private System.Windows.Forms.PictureBox enabled_button;
        private System.Windows.Forms.PictureBox direction_button;
        private System.Windows.Forms.PictureBox distance_button;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox speed_textBox;
        private System.Windows.Forms.TextBox enabled_textBox;
        private System.Windows.Forms.TextBox distance_textBox;
        private System.Windows.Forms.TextBox direction_textBox;
    }
}

