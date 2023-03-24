
namespace TaskManager
{
    partial class Engineer2_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.UserFormTabControl = new System.Windows.Forms.TabControl();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.Messages = new System.Windows.Forms.TabPage();
            this.Requests = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.settingsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.UserFormTabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 38);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1247, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.Fold_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(1262, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserFormTabControl
            // 
            this.UserFormTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.UserFormTabControl.Controls.Add(this.Tasks);
            this.UserFormTabControl.Controls.Add(this.Messages);
            this.UserFormTabControl.Controls.Add(this.Requests);
            this.UserFormTabControl.Controls.Add(this.Settings);
            this.UserFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFormTabControl.Location = new System.Drawing.Point(0, 38);
            this.UserFormTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.UserFormTabControl.Multiline = true;
            this.UserFormTabControl.Name = "UserFormTabControl";
            this.UserFormTabControl.SelectedIndex = 0;
            this.UserFormTabControl.Size = new System.Drawing.Size(1300, 662);
            this.UserFormTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.UserFormTabControl.TabIndex = 3;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.LightGray;
            this.Tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tasks.ImageIndex = 2;
            this.Tasks.Location = new System.Drawing.Point(25, 4);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tasks.Size = new System.Drawing.Size(1271, 654);
            this.Tasks.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.Color.LightGray;
            this.Messages.ImageIndex = 4;
            this.Messages.Location = new System.Drawing.Point(25, 4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1271, 654);
            this.Messages.TabIndex = 2;
            // 
            // Requests
            // 
            this.Requests.BackColor = System.Drawing.Color.LightGray;
            this.Requests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Requests.ImageIndex = 3;
            this.Requests.Location = new System.Drawing.Point(25, 4);
            this.Requests.Name = "Requests";
            this.Requests.Padding = new System.Windows.Forms.Padding(3);
            this.Requests.Size = new System.Drawing.Size(1271, 654);
            this.Requests.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.LightGray;
            this.Settings.Controls.Add(this.settingsCheckBox);
            this.Settings.Controls.Add(this.label4);
            this.Settings.ImageIndex = 1;
            this.Settings.Location = new System.Drawing.Point(25, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1271, 654);
            this.Settings.TabIndex = 3;
            // 
            // settingsCheckBox
            // 
            this.settingsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsCheckBox.Location = new System.Drawing.Point(151, 103);
            this.settingsCheckBox.Name = "settingsCheckBox";
            this.settingsCheckBox.Size = new System.Drawing.Size(603, 214);
            this.settingsCheckBox.TabIndex = 9;
            this.settingsCheckBox.Text = "Уведомлять об обновлении статуса проблемы";
            this.settingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(143, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Настройки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Engineer2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.UserFormTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Engineer2_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer2_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserFormTabControl.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TabControl UserFormTabControl;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage Requests;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.CheckBox settingsCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}