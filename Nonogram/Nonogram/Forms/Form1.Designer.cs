namespace Nonogram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_plays = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_plays
            // 
            this.list_plays.BackColor = System.Drawing.Color.DarkKhaki;
            this.list_plays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_plays.FormattingEnabled = true;
            this.list_plays.HorizontalExtent = -1;
            this.list_plays.ItemHeight = 25;
            this.list_plays.Location = new System.Drawing.Point(235, 161);
            this.list_plays.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.list_plays.Name = "list_plays";
            this.list_plays.Size = new System.Drawing.Size(362, 202);
            this.list_plays.TabIndex = 0;
            this.list_plays.MouseHover += new System.EventHandler(this.list_plays_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Нова гра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button_input
            // 
            this.button_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_input.Location = new System.Drawing.Point(292, 429);
            this.button_input.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(250, 63);
            this.button_input.TabIndex = 2;
            this.button_input.Text = "Додати гравця";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            this.button_input.MouseHover += new System.EventHandler(this.button_input_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(738, 300);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Продовжити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(292, 544);
            this.button_output.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(250, 63);
            this.button_output.TabIndex = 4;
            this.button_output.Text = "Видалити гравця";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            this.button_output.MouseHover += new System.EventHandler(this.button_output_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(431, 648);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(738, 544);
            this.exit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(250, 63);
            this.exit.TabIndex = 6;
            this.exit.Text = "Вихід";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(738, 429);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 63);
            this.button6.TabIndex = 7;
            this.button6.Text = "Налаштування";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(505, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(563, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nonogram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nonogram.Properties.Resources.abstraction2;
            this.ClientSize = new System.Drawing.Size(1245, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_plays);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nonogram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox list_plays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}