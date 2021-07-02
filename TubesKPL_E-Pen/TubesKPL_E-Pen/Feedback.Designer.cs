
namespace TubesKPL_E_Pen
{
    partial class Feedback
    {
        FeedbackModel starText = new FeedbackModel();

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
            this.button1Star = new System.Windows.Forms.Button();
            this.button2Star = new System.Windows.Forms.Button();
            this.button3Star = new System.Windows.Forms.Button();
            this.button4Star = new System.Windows.Forms.Button();
            this.button5Star = new System.Windows.Forms.Button();
            this.buttonKonfirmasi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Star
            // 
            this.button1Star.Location = new System.Drawing.Point(66, 82);
            this.button1Star.Name = "button1Star";
            this.button1Star.Size = new System.Drawing.Size(68, 83);
            this.button1Star.TabIndex = 0;
            this.button1Star.Text = starText.getStarText(FeedbackModel.Star.STAR1);
            this.button1Star.UseVisualStyleBackColor = true;
            this.button1Star.Click += new System.EventHandler(this.button1Star_Click);
            // 
            // button2Star
            // 
            this.button2Star.Location = new System.Drawing.Point(140, 82);
            this.button2Star.Name = "button2Star";
            this.button2Star.Size = new System.Drawing.Size(68, 83);
            this.button2Star.TabIndex = 1;
            this.button2Star.Text = starText.getStarText(FeedbackModel.Star.STAR2);
            this.button2Star.UseVisualStyleBackColor = true;
            this.button2Star.Click += new System.EventHandler(this.button2Star_Click);
            // 
            // button3Star
            // 
            this.button3Star.Location = new System.Drawing.Point(214, 82);
            this.button3Star.Name = "button3Star";
            this.button3Star.Size = new System.Drawing.Size(68, 83);
            this.button3Star.TabIndex = 2;
            this.button3Star.Text = starText.getStarText(FeedbackModel.Star.STAR3);
            this.button3Star.UseVisualStyleBackColor = true;
            this.button3Star.Click += new System.EventHandler(this.button3Star_Click);
            // 
            // button4Star
            // 
            this.button4Star.Location = new System.Drawing.Point(288, 82);
            this.button4Star.Name = "button4Star";
            this.button4Star.Size = new System.Drawing.Size(68, 83);
            this.button4Star.TabIndex = 3;
            this.button4Star.Text = starText.getStarText(FeedbackModel.Star.STAR4);
            this.button4Star.UseVisualStyleBackColor = true;
            this.button4Star.Click += new System.EventHandler(this.button4Star_Click);
            // 
            // button5Star
            // 
            this.button5Star.Location = new System.Drawing.Point(362, 82);
            this.button5Star.Name = "button5Star";
            this.button5Star.Size = new System.Drawing.Size(68, 83);
            this.button5Star.TabIndex = 4;
            this.button5Star.Text = starText.getStarText(FeedbackModel.Star.STAR5);
            this.button5Star.UseVisualStyleBackColor = true;
            this.button5Star.Click += new System.EventHandler(this.button5Star_Click);
            // 
            // buttonKonfirmasi
            // 
            this.buttonKonfirmasi.Location = new System.Drawing.Point(162, 325);
            this.buttonKonfirmasi.Name = "buttonKonfirmasi";
            this.buttonKonfirmasi.Size = new System.Drawing.Size(168, 50);
            this.buttonKonfirmasi.TabIndex = 5;
            this.buttonKonfirmasi.Text = "Konfirmasi";
            this.buttonKonfirmasi.UseVisualStyleBackColor = true;
            this.buttonKonfirmasi.Click += new System.EventHandler(this.buttonKonfirmasi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(140, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(214, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(288, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 50);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(362, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 50);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 148);
            this.textBox1.TabIndex = 11;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonKonfirmasi);
            this.Controls.Add(this.button5Star);
            this.Controls.Add(this.button4Star);
            this.Controls.Add(this.button3Star);
            this.Controls.Add(this.button2Star);
            this.Controls.Add(this.button1Star);
            this.Name = "Feedback";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Star;
        private System.Windows.Forms.Button button2Star;
        private System.Windows.Forms.Button button3Star;
        private System.Windows.Forms.Button button4Star;
        private System.Windows.Forms.Button button5Star;
        private System.Windows.Forms.Button buttonKonfirmasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}