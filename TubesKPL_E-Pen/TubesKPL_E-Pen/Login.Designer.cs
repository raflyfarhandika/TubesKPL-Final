
namespace TubesKPL_E_Pen
{
    partial class Login
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
            this.butnRegister = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.forgetPass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butnRegister
            // 
            this.butnRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.butnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.butnRegister.ForeColor = System.Drawing.Color.White;
            this.butnRegister.Location = new System.Drawing.Point(46, 500);
            this.butnRegister.Name = "butnRegister";
            this.butnRegister.Size = new System.Drawing.Size(277, 44);
            this.butnRegister.TabIndex = 24;
            this.butnRegister.Text = "Register";
            this.butnRegister.UseVisualStyleBackColor = false;
            this.butnRegister.Click += new System.EventHandler(this.butnRegister_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.chkShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkShowPass.Location = new System.Drawing.Point(171, 357);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(139, 21);
            this.chkShowPass.TabIndex = 23;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // forgetPass
            // 
            this.forgetPass.AutoSize = true;
            this.forgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.forgetPass.ForeColor = System.Drawing.Color.DarkCyan;
            this.forgetPass.Location = new System.Drawing.Point(197, 561);
            this.forgetPass.Name = "forgetPass";
            this.forgetPass.Size = new System.Drawing.Size(82, 17);
            this.forgetPass.TabIndex = 22;
            this.forgetPass.Text = "Click Here";
            this.forgetPass.Click += new System.EventHandler(this.forgetPass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(63, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Forget Password?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkCyan;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(46, 441);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(277, 44);
            this.LoginButton.TabIndex = 20;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // inputPass
            // 
            this.inputPass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inputPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputPass.Location = new System.Drawing.Point(46, 323);
            this.inputPass.Multiline = true;
            this.inputPass.Name = "inputPass";
            this.inputPass.PasswordChar = '•';
            this.inputPass.Size = new System.Drawing.Size(277, 28);
            this.inputPass.TabIndex = 18;
            this.inputPass.TextChanged += new System.EventHandler(this.inputPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(41, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // inputUsername
            // 
            this.inputUsername.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inputUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(46, 252);
            this.inputUsername.Multiline = true;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(277, 28);
            this.inputUsername.TabIndex = 19;
            this.inputUsername.TextChanged += new System.EventHandler(this.inputUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(41, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Welcome Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hey, Im E-PEN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.Controls.Add(this.butnRegister);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.forgetPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnRegister;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Label forgetPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}