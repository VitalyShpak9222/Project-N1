
namespace TaskManager
{
    partial class RegistrationForm
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
            this.passLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.passRepeatLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.repeatPassTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.accessCodeTextBox = new System.Windows.Forms.TextBox();
            this.accessCodeLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.registrationFinishButton = new System.Windows.Forms.Label();
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
            this.ExitLabel1.Click += new System.EventHandler(this.ExitLabelClick);
            this.ExitLabel1.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.ExitLabel1.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            this.label5.Location = new System.Drawing.Point(634, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.Fold_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(171, 43);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 20);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(171, 101);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(72, 20);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(171, 282);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(87, 20);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "Фамилия";
            // 
            // passRepeatLabel
            // 
            this.passRepeatLabel.AutoSize = true;
            this.passRepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRepeatLabel.Location = new System.Drawing.Point(171, 159);
            this.passRepeatLabel.Name = "passRepeatLabel";
            this.passRepeatLabel.Size = new System.Drawing.Size(167, 20);
            this.passRepeatLabel.TabIndex = 5;
            this.passRepeatLabel.Text = "Повторите пароль";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(171, 217);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Имя";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailLabel.Location = new System.Drawing.Point(171, 394);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(40, 20);
            this.mailLabel.TabIndex = 7;
            this.mailLabel.Text = "Mail";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(171, 340);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Статус";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(175, 66);
            this.loginTextBox.MaxLength = 17;
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(325, 32);
            this.loginTextBox.TabIndex = 9;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(175, 124);
            this.passTextBox.MaxLength = 15;
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(325, 32);
            this.passTextBox.TabIndex = 10;
            // 
            // repeatPassTextBox
            // 
            this.repeatPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPassTextBox.Location = new System.Drawing.Point(175, 182);
            this.repeatPassTextBox.MaxLength = 15;
            this.repeatPassTextBox.Multiline = true;
            this.repeatPassTextBox.Name = "repeatPassTextBox";
            this.repeatPassTextBox.PasswordChar = '*';
            this.repeatPassTextBox.Size = new System.Drawing.Size(325, 32);
            this.repeatPassTextBox.TabIndex = 11;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(175, 305);
            this.surnameTextBox.MaxLength = 25;
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(325, 32);
            this.surnameTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(175, 243);
            this.nameTextBox.MaxLength = 25;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 32);
            this.nameTextBox.TabIndex = 13;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailTextBox.Location = new System.Drawing.Point(175, 417);
            this.mailTextBox.MaxLength = 25;
            this.mailTextBox.Multiline = true;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(325, 32);
            this.mailTextBox.TabIndex = 14;
            // 
            // accessCodeTextBox
            // 
            this.accessCodeTextBox.Enabled = false;
            this.accessCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessCodeTextBox.Location = new System.Drawing.Point(175, 533);
            this.accessCodeTextBox.MaxLength = 15;
            this.accessCodeTextBox.Multiline = true;
            this.accessCodeTextBox.Name = "accessCodeTextBox";
            this.accessCodeTextBox.PasswordChar = '*';
            this.accessCodeTextBox.Size = new System.Drawing.Size(325, 32);
            this.accessCodeTextBox.TabIndex = 15;
            this.accessCodeTextBox.Visible = false;
            // 
            // accessCodeLabel
            // 
            this.accessCodeLabel.AutoSize = true;
            this.accessCodeLabel.Enabled = false;
            this.accessCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessCodeLabel.Location = new System.Drawing.Point(173, 510);
            this.accessCodeLabel.Name = "accessCodeLabel";
            this.accessCodeLabel.Size = new System.Drawing.Size(193, 20);
            this.accessCodeLabel.TabIndex = 16;
            this.accessCodeLabel.Text = "Введите код доступа";
            this.accessCodeLabel.Visible = false;
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(175, 363);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(325, 28);
            this.StatusBox.TabIndex = 17;
            this.StatusBox.TextChanged += new System.EventHandler(this.StatusBox_TextUpdate);
            // 
            // registrationFinishButton
            // 
            this.registrationFinishButton.BackColor = System.Drawing.SystemColors.Window;
            this.registrationFinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationFinishButton.Location = new System.Drawing.Point(175, 461);
            this.registrationFinishButton.Name = "registrationFinishButton";
            this.registrationFinishButton.Size = new System.Drawing.Size(325, 40);
            this.registrationFinishButton.TabIndex = 18;
            this.registrationFinishButton.Text = "Зарегистрироваться";
            this.registrationFinishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrationFinishButton.Click += new System.EventHandler(this.RegistrationFinishButton_Click);
            this.registrationFinishButton.MouseEnter += new System.EventHandler(this.RegistrationFinishButton_MouseEnter);
            this.registrationFinishButton.MouseLeave += new System.EventHandler(this.RegistrationFinishButton_MouseLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(680, 601);
            this.Controls.Add(this.registrationFinishButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.accessCodeLabel);
            this.Controls.Add(this.accessCodeTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.repeatPassTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passRepeatLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label passRepeatLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox repeatPassTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox accessCodeTextBox;
        private System.Windows.Forms.Label accessCodeLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label registrationFinishButton;
        private System.Windows.Forms.Label label5;
    }
}