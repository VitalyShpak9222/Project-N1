
namespace TaskManager
{
    partial class EntryForm
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
            this.ExitLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.entryLabel = new System.Windows.Forms.Label();
            this.registrationStartLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitLabel1
            // 
            this.ExitLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitLabel1.Location = new System.Drawing.Point(649, 1);
            this.ExitLabel1.Name = "ExitLabel1";
            this.ExitLabel1.Size = new System.Drawing.Size(26, 26);
            this.ExitLabel1.TabIndex = 0;
            this.ExitLabel1.Text = "X";
            this.ExitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel1.Click += new System.EventHandler(this.ExitClick);
            this.ExitLabel1.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel1.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ExitLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 30);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(633, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.Fold_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(228, 78);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 23);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(228, 162);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(230, 104);
            this.loginTextBox.MaxLength = 17;
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(222, 40);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(230, 190);
            this.passwordTextBox.MaxLength = 15;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 40);
            this.passwordTextBox.TabIndex = 5;
            // 
            // entryLabel
            // 
            this.entryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.entryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryLabel.Location = new System.Drawing.Point(230, 280);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(222, 40);
            this.entryLabel.TabIndex = 6;
            this.entryLabel.Text = "Войти";
            this.entryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entryLabel.Click += new System.EventHandler(this.EntryLabel_Click);
            // 
            // registrationStartLabel
            // 
            this.registrationStartLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationStartLabel.Location = new System.Drawing.Point(230, 341);
            this.registrationStartLabel.Name = "registrationStartLabel";
            this.registrationStartLabel.Size = new System.Drawing.Size(222, 23);
            this.registrationStartLabel.TabIndex = 7;
            this.registrationStartLabel.Text = "Хотите зарегистрироваться?";
            this.registrationStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrationStartLabel.Click += new System.EventHandler(this.RegistrationLabelClick);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.registrationStartLabel);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label registrationStartLabel;
        private System.Windows.Forms.Label label5;
    }
}