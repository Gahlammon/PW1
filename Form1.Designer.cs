namespace Project1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3movement = new System.Windows.Forms.Button();
            this.button2movement = new System.Windows.Forms.Button();
            this.button1movement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3movement
            // 
            this.button3movement.Location = new System.Drawing.Point(147, 116);
            this.button3movement.Name = "button3movement";
            this.button3movement.Size = new System.Drawing.Size(153, 23);
            this.button3movement.TabIndex = 2;
            this.button3movement.Text = "odbij pionowo";
            this.button3movement.UseVisualStyleBackColor = true;
            this.button3movement.Click += new System.EventHandler(this.button3movement_Click);
            // 
            // button2movement
            // 
            this.button2movement.Location = new System.Drawing.Point(147, 87);
            this.button2movement.Name = "button2movement";
            this.button2movement.Size = new System.Drawing.Size(153, 23);
            this.button2movement.TabIndex = 3;
            this.button2movement.Text = "odbij poziomo";
            this.button2movement.UseVisualStyleBackColor = true;
            this.button2movement.Click += new System.EventHandler(this.button2movement_Click);
            // 
            // button1movement
            // 
            this.button1movement.Location = new System.Drawing.Point(146, 58);
            this.button1movement.Name = "button1movement";
            this.button1movement.Size = new System.Drawing.Size(153, 23);
            this.button1movement.TabIndex = 4;
            this.button1movement.Text = "obróć";
            this.button1movement.UseVisualStyleBackColor = true;
            this.button1movement.Click += new System.EventHandler(this.button1movement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 181);
            this.Controls.Add(this.button1movement);
            this.Controls.Add(this.button2movement);
            this.Controls.Add(this.button3movement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3movement;
        private System.Windows.Forms.Button button2movement;
        private System.Windows.Forms.Button button1movement;
    }
}