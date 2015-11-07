namespace Registration_Form
{
    partial class Registration
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Capcha_textBox = new System.Windows.Forms.TextBox();
            this.FormRegistration = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Capcha = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(89, 79);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(164, 20);
            this.Login_textBox.TabIndex = 0;
            this.Login_textBox.TextChanged += new System.EventHandler(this.Login_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(89, 131);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(164, 20);
            this.Password_textBox.TabIndex = 1;
            // 
            // Capcha_textBox
            // 
            this.Capcha_textBox.Location = new System.Drawing.Point(89, 173);
            this.Capcha_textBox.Name = "Capcha_textBox";
            this.Capcha_textBox.Size = new System.Drawing.Size(164, 20);
            this.Capcha_textBox.TabIndex = 2;
            // 
            // FormRegistration
            // 
            this.FormRegistration.AutoSize = true;
            this.FormRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormRegistration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormRegistration.Location = new System.Drawing.Point(12, 21);
            this.FormRegistration.Name = "FormRegistration";
            this.FormRegistration.Size = new System.Drawing.Size(144, 18);
            this.FormRegistration.TabIndex = 4;
            this.FormRegistration.Text = "Form Registration";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(12, 80);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 16);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(12, 132);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // Capcha
            // 
            this.Capcha.AutoSize = true;
            this.Capcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capcha.Location = new System.Drawing.Point(12, 174);
            this.Capcha.Name = "Capcha";
            this.Capcha.Size = new System.Drawing.Size(55, 16);
            this.Capcha.TabIndex = 7;
            this.Capcha.Text = "Capcha";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(178, 255);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(89, 255);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(67, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 290);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Capcha);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.FormRegistration);
            this.Controls.Add(this.Capcha_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Capcha_textBox;
        private System.Windows.Forms.Label FormRegistration;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Capcha;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Exit;
    }
}

