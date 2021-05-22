
namespace Adyga_bot.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox_hwid = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.checkBox_passwordChar = new System.Windows.Forms.CheckBox();
            this.button_minimaze = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пароль";
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.ForeColor = System.Drawing.Color.White;
            this.button_enter.Location = new System.Drawing.Point(12, 108);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(255, 30);
            this.button_enter.TabIndex = 42;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // textBox_hwid
            // 
            this.textBox_hwid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_hwid.ForeColor = System.Drawing.Color.White;
            this.textBox_hwid.Location = new System.Drawing.Point(12, 43);
            this.textBox_hwid.Name = "textBox_hwid";
            this.textBox_hwid.ReadOnly = true;
            this.textBox_hwid.Size = new System.Drawing.Size(255, 20);
            this.textBox_hwid.TabIndex = 43;
            this.textBox_hwid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(12, 82);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(255, 20);
            this.textBox_password.TabIndex = 44;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.ForeColor = System.Drawing.Color.White;
            this.checkBox_RememberMe.Location = new System.Drawing.Point(14, 145);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(111, 17);
            this.checkBox_RememberMe.TabIndex = 46;
            this.checkBox_RememberMe.Text = "Запомнить меня";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // checkBox_passwordChar
            // 
            this.checkBox_passwordChar.AutoSize = true;
            this.checkBox_passwordChar.ForeColor = System.Drawing.Color.White;
            this.checkBox_passwordChar.Location = new System.Drawing.Point(131, 145);
            this.checkBox_passwordChar.Name = "checkBox_passwordChar";
            this.checkBox_passwordChar.Size = new System.Drawing.Size(114, 17);
            this.checkBox_passwordChar.TabIndex = 47;
            this.checkBox_passwordChar.Text = "Показать пароль";
            this.checkBox_passwordChar.UseVisualStyleBackColor = true;
            this.checkBox_passwordChar.CheckedChanged += new System.EventHandler(this.checkBox_passwordChar_CheckedChanged);
            // 
            // button_minimaze
            // 
            this.button_minimaze.FlatAppearance.BorderSize = 0;
            this.button_minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimaze.ForeColor = System.Drawing.Color.White;
            this.button_minimaze.Location = new System.Drawing.Point(220, 12);
            this.button_minimaze.Name = "button_minimaze";
            this.button_minimaze.Size = new System.Drawing.Size(23, 23);
            this.button_minimaze.TabIndex = 49;
            this.button_minimaze.Text = "—";
            this.button_minimaze.UseVisualStyleBackColor = true;
            this.button_minimaze.Click += new System.EventHandler(this.button_minimaze_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(244, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(23, 23);
            this.button_exit.TabIndex = 48;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(280, 175);
            this.Controls.Add(this.button_minimaze);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.checkBox_passwordChar);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_hwid);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adyga bot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaveEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TextBox textBox_hwid;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
        private System.Windows.Forms.CheckBox checkBox_passwordChar;
        private System.Windows.Forms.Button button_minimaze;
        private System.Windows.Forms.Button button_exit;
    }
}