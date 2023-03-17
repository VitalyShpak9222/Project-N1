
namespace TaskManager
{
    partial class UserFormFristIdea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFormFristIdea));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.taskShowButton = new System.Windows.Forms.Panel();
            this.messageShowButton = new System.Windows.Forms.Panel();
            this.makeRequestButton = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 35);
            this.panel1.TabIndex = 0;
            // 
            // exitLabel
            // 
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitLabel.Location = new System.Drawing.Point(1195, 5);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(26, 26);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.Exit_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.taskShowButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.messageShowButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.makeRequestButton, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.settingsButton, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.exitButton, 0, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.MaximumSize = new System.Drawing.Size(50, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(50, 636);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // taskShowButton
            // 
            this.taskShowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taskShowButton.BackgroundImage")));
            this.taskShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.taskShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskShowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskShowButton.Location = new System.Drawing.Point(2, 2);
            this.taskShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.taskShowButton.Name = "taskShowButton";
            this.taskShowButton.Size = new System.Drawing.Size(46, 46);
            this.taskShowButton.TabIndex = 0;
            // 
            // messageShowButton
            // 
            this.messageShowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("messageShowButton.BackgroundImage")));
            this.messageShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messageShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messageShowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowButton.Location = new System.Drawing.Point(2, 52);
            this.messageShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.messageShowButton.Name = "messageShowButton";
            this.messageShowButton.Size = new System.Drawing.Size(46, 46);
            this.messageShowButton.TabIndex = 1;
            // 
            // makeRequestButton
            // 
            this.makeRequestButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makeRequestButton.BackgroundImage")));
            this.makeRequestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeRequestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeRequestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.makeRequestButton.Location = new System.Drawing.Point(3, 103);
            this.makeRequestButton.Name = "makeRequestButton";
            this.makeRequestButton.Size = new System.Drawing.Size(44, 44);
            this.makeRequestButton.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.Location = new System.Drawing.Point(3, 153);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(44, 44);
            this.settingsButton.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(5, 586);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(50, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1176, 636);
            this.pnlMain.TabIndex = 2;
            // 
            // UserFormFristIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 671);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserFormFristIdea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel taskShowButton;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Panel messageShowButton;
        private System.Windows.Forms.Panel makeRequestButton;
        private System.Windows.Forms.Panel settingsButton;
        private System.Windows.Forms.Panel exitButton;
    }
}