namespace Project1
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
            this.Resault_label = new System.Windows.Forms.Label();
            this.New_game_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resault_label
            // 
            this.Resault_label.AutoSize = true;
            this.Resault_label.Location = new System.Drawing.Point(160, 54);
            this.Resault_label.Name = "Resault_label";
            this.Resault_label.Size = new System.Drawing.Size(51, 20);
            this.Resault_label.TabIndex = 0;
            this.Resault_label.Text = "label1";
            this.Resault_label.Click += new System.EventHandler(this.Resault_label_Click);
            // 
            // New_game_button
            // 
            this.New_game_button.Location = new System.Drawing.Point(106, 99);
            this.New_game_button.Name = "New_game_button";
            this.New_game_button.Size = new System.Drawing.Size(163, 49);
            this.New_game_button.TabIndex = 1;
            this.New_game_button.Text = "NEW GAME";
            this.New_game_button.UseVisualStyleBackColor = true;
            this.New_game_button.Click += new System.EventHandler(this.New_game_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 219);
            this.Controls.Add(this.New_game_button);
            this.Controls.Add(this.Resault_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resault_label;
        private System.Windows.Forms.Button New_game_button;
    }
}