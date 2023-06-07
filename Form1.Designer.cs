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
            this.War_button = new System.Windows.Forms.Button();
            this.W_card_button = new System.Windows.Forms.Button();
            this.W_card_view = new System.Windows.Forms.Label();
            this.W_card_view_bot = new System.Windows.Forms.Label();
            this.BJ_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.W_2card_count = new System.Windows.Forms.Label();
            this.W_1card_count = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BJ_listView = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.BJ_stop_button = new System.Windows.Forms.Button();
            this.listView_BOT = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // War_button
            // 
            this.War_button.Location = new System.Drawing.Point(232, 43);
            this.War_button.Name = "War_button";
            this.War_button.Size = new System.Drawing.Size(135, 42);
            this.War_button.TabIndex = 0;
            this.War_button.Text = "War";
            this.War_button.UseVisualStyleBackColor = true;
            this.War_button.Click += new System.EventHandler(this.War_button_Click);
            // 
            // W_card_button
            // 
            this.W_card_button.Location = new System.Drawing.Point(55, 92);
            this.W_card_button.Name = "W_card_button";
            this.W_card_button.Size = new System.Drawing.Size(81, 118);
            this.W_card_button.TabIndex = 1;
            this.W_card_button.Text = "button1";
            this.W_card_button.UseVisualStyleBackColor = true;
            this.W_card_button.Click += new System.EventHandler(this.W_card_button_Click);
            // 
            // W_card_view
            // 
            this.W_card_view.AutoSize = true;
            this.W_card_view.Location = new System.Drawing.Point(215, 141);
            this.W_card_view.Name = "W_card_view";
            this.W_card_view.Size = new System.Drawing.Size(51, 20);
            this.W_card_view.TabIndex = 2;
            this.W_card_view.Text = "label1";
            // 
            // W_card_view_bot
            // 
            this.W_card_view_bot.AutoSize = true;
            this.W_card_view_bot.Location = new System.Drawing.Point(469, 141);
            this.W_card_view_bot.Name = "W_card_view_bot";
            this.W_card_view_bot.Size = new System.Drawing.Size(51, 20);
            this.W_card_view_bot.TabIndex = 3;
            this.W_card_view_bot.Text = "label1";
            // 
            // BJ_Button
            // 
            this.BJ_Button.Location = new System.Drawing.Point(497, 42);
            this.BJ_Button.Name = "BJ_Button";
            this.BJ_Button.Size = new System.Drawing.Size(135, 43);
            this.BJ_Button.TabIndex = 4;
            this.BJ_Button.Text = "Black Jack";
            this.BJ_Button.UseVisualStyleBackColor = true;
            this.BJ_Button.Click += new System.EventHandler(this.BJ_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.W_2card_count);
            this.panel1.Controls.Add(this.W_1card_count);
            this.panel1.Controls.Add(this.W_card_view_bot);
            this.panel1.Controls.Add(this.W_card_view);
            this.panel1.Controls.Add(this.W_card_button);
            this.panel1.Location = new System.Drawing.Point(83, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 316);
            this.panel1.TabIndex = 5;
            // 
            // W_2card_count
            // 
            this.W_2card_count.AutoSize = true;
            this.W_2card_count.Location = new System.Drawing.Point(447, 231);
            this.W_2card_count.Name = "W_2card_count";
            this.W_2card_count.Size = new System.Drawing.Size(51, 20);
            this.W_2card_count.TabIndex = 5;
            this.W_2card_count.Text = "label1";
            // 
            // W_1card_count
            // 
            this.W_1card_count.AutoSize = true;
            this.W_1card_count.Location = new System.Drawing.Point(67, 232);
            this.W_1card_count.Name = "W_1card_count";
            this.W_1card_count.Size = new System.Drawing.Size(51, 20);
            this.W_1card_count.TabIndex = 4;
            this.W_1card_count.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView_BOT);
            this.panel2.Controls.Add(this.BJ_listView);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BJ_stop_button);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 285);
            this.panel2.TabIndex = 4;
            // 
            // BJ_listView
            // 
            this.BJ_listView.HideSelection = false;
            this.BJ_listView.Location = new System.Drawing.Point(26, 47);
            this.BJ_listView.Name = "BJ_listView";
            this.BJ_listView.Size = new System.Drawing.Size(206, 97);
            this.BJ_listView.TabIndex = 2;
            this.BJ_listView.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "DRAW CARD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BJ_stop_button
            // 
            this.BJ_stop_button.Location = new System.Drawing.Point(524, 226);
            this.BJ_stop_button.Name = "BJ_stop_button";
            this.BJ_stop_button.Size = new System.Drawing.Size(91, 34);
            this.BJ_stop_button.TabIndex = 0;
            this.BJ_stop_button.Text = "STOP";
            this.BJ_stop_button.UseVisualStyleBackColor = true;
            this.BJ_stop_button.Click += new System.EventHandler(this.BJ_stop_button_Click);
            // 
            // listView_BOT
            // 
            this.listView_BOT.HideSelection = false;
            this.listView_BOT.Location = new System.Drawing.Point(280, 47);
            this.listView_BOT.Name = "listView_BOT";
            this.listView_BOT.Size = new System.Drawing.Size(206, 97);
            this.listView_BOT.TabIndex = 3;
            this.listView_BOT.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BJ_Button);
            this.Controls.Add(this.War_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button War_button;
        private System.Windows.Forms.Button W_card_button;
        private System.Windows.Forms.Label W_card_view;
        private System.Windows.Forms.Label W_card_view_bot;
        private System.Windows.Forms.Button BJ_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BJ_stop_button;
        private System.Windows.Forms.ListView BJ_listView;
        private System.Windows.Forms.Label W_2card_count;
        private System.Windows.Forms.Label W_1card_count;
        private System.Windows.Forms.ListView listView_BOT;
    }
}