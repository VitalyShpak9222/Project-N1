
namespace TaskManager
{
    partial class Engineer1_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engineer1_Form));
            this.exitButton = new System.Windows.Forms.Label();
            this.Engineer1FormTabControl = new System.Windows.Forms.TabControl();
            this.Tasks = new System.Windows.Forms.TabPage();
            this.sendToDepartment = new System.Windows.Forms.Label();
            this.department6 = new System.Windows.Forms.Label();
            this.department5 = new System.Windows.Forms.Label();
            this.department4 = new System.Windows.Forms.Label();
            this.department3 = new System.Windows.Forms.Label();
            this.department2 = new System.Windows.Forms.Label();
            this.department1 = new System.Windows.Forms.Label();
            this.problemsPanel = new System.Windows.Forms.Panel();
            this.ProblemsListBox = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DeadlineDate = new System.Windows.Forms.Label();
            this.lowProblemPriority = new System.Windows.Forms.Panel();
            this.hardProblemPriority = new System.Windows.Forms.Panel();
            this.mediumProblemPriority = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.applicantNameLabel = new System.Windows.Forms.Label();
            this.problemIdLabel = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.problemDescription = new System.Windows.Forms.Label();
            this.Messages = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.settingsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Engineer1FormTabControl.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.problemsPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Engineer1FormTabControl
            // 
            this.Engineer1FormTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Engineer1FormTabControl.Controls.Add(this.Tasks);
            this.Engineer1FormTabControl.Controls.Add(this.Messages);
            this.Engineer1FormTabControl.Controls.Add(this.Settings);
            this.Engineer1FormTabControl.ImageList = this.imageList;
            this.Engineer1FormTabControl.Location = new System.Drawing.Point(0, 37);
            this.Engineer1FormTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.Engineer1FormTabControl.Multiline = true;
            this.Engineer1FormTabControl.Name = "Engineer1FormTabControl";
            this.Engineer1FormTabControl.SelectedIndex = 0;
            this.Engineer1FormTabControl.Size = new System.Drawing.Size(1300, 663);
            this.Engineer1FormTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Engineer1FormTabControl.TabIndex = 3;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.LightGray;
            this.Tasks.Controls.Add(this.sendToDepartment);
            this.Tasks.Controls.Add(this.department6);
            this.Tasks.Controls.Add(this.department5);
            this.Tasks.Controls.Add(this.department4);
            this.Tasks.Controls.Add(this.department3);
            this.Tasks.Controls.Add(this.department2);
            this.Tasks.Controls.Add(this.department1);
            this.Tasks.Controls.Add(this.problemsPanel);
            this.Tasks.Controls.Add(this.panel7);
            this.Tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tasks.ImageIndex = 6;
            this.Tasks.Location = new System.Drawing.Point(25, 4);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.Tasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tasks.Size = new System.Drawing.Size(1271, 655);
            this.Tasks.TabIndex = 0;
            // 
            // sendToDepartment
            // 
            this.sendToDepartment.BackColor = System.Drawing.Color.DarkGray;
            this.sendToDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendToDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendToDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendToDepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendToDepartment.Location = new System.Drawing.Point(308, 586);
            this.sendToDepartment.Name = "sendToDepartment";
            this.sendToDepartment.Size = new System.Drawing.Size(378, 54);
            this.sendToDepartment.TabIndex = 8;
            this.sendToDepartment.Text = "Отправить в отдел";
            this.sendToDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendToDepartment.Click += new System.EventHandler(this.SendToDepartment_Click);
            this.sendToDepartment.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.sendToDepartment.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department6
            // 
            this.department6.BackColor = System.Drawing.Color.DarkGray;
            this.department6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department6.Location = new System.Drawing.Point(705, 535);
            this.department6.Name = "department6";
            this.department6.Size = new System.Drawing.Size(273, 40);
            this.department6.TabIndex = 7;
            this.department6.Text = "Отдел 6";
            this.department6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department6.Click += new System.EventHandler(this.Department_Choose);
            this.department6.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department6.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department5
            // 
            this.department5.BackColor = System.Drawing.Color.DarkGray;
            this.department5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department5.Location = new System.Drawing.Point(345, 535);
            this.department5.Name = "department5";
            this.department5.Size = new System.Drawing.Size(312, 40);
            this.department5.TabIndex = 6;
            this.department5.Text = "Отдел 5";
            this.department5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department5.Click += new System.EventHandler(this.Department_Choose);
            this.department5.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department5.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department4
            // 
            this.department4.BackColor = System.Drawing.Color.DarkGray;
            this.department4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department4.Location = new System.Drawing.Point(23, 535);
            this.department4.Name = "department4";
            this.department4.Size = new System.Drawing.Size(270, 40);
            this.department4.TabIndex = 5;
            this.department4.Text = "Отдел 4";
            this.department4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department4.Click += new System.EventHandler(this.Department_Choose);
            this.department4.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department4.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department3
            // 
            this.department3.BackColor = System.Drawing.Color.DarkGray;
            this.department3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department3.Location = new System.Drawing.Point(705, 482);
            this.department3.Name = "department3";
            this.department3.Size = new System.Drawing.Size(273, 40);
            this.department3.TabIndex = 4;
            this.department3.Text = "Отдел 3";
            this.department3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department3.Click += new System.EventHandler(this.Department_Choose);
            this.department3.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department3.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department2
            // 
            this.department2.BackColor = System.Drawing.Color.DarkGray;
            this.department2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department2.Location = new System.Drawing.Point(345, 482);
            this.department2.Name = "department2";
            this.department2.Size = new System.Drawing.Size(312, 40);
            this.department2.TabIndex = 3;
            this.department2.Text = "Отдел 2";
            this.department2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department2.Click += new System.EventHandler(this.Department_Choose);
            this.department2.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department2.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // department1
            // 
            this.department1.BackColor = System.Drawing.Color.DarkGray;
            this.department1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.department1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department1.Location = new System.Drawing.Point(23, 482);
            this.department1.Name = "department1";
            this.department1.Size = new System.Drawing.Size(270, 40);
            this.department1.TabIndex = 2;
            this.department1.Text = "Отдел 1";
            this.department1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.department1.Click += new System.EventHandler(this.Department_Choose);
            this.department1.MouseEnter += new System.EventHandler(this.Object_MouseEnter);
            this.department1.MouseLeave += new System.EventHandler(this.Object_MouseLeave);
            // 
            // problemsPanel
            // 
            this.problemsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.problemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.problemsPanel.Controls.Add(this.ProblemsListBox);
            this.problemsPanel.Location = new System.Drawing.Point(996, 17);
            this.problemsPanel.Name = "problemsPanel";
            this.problemsPanel.Size = new System.Drawing.Size(213, 623);
            this.problemsPanel.TabIndex = 1;
            // 
            // ProblemsListBox
            // 
            this.ProblemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProblemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemsListBox.FormattingEnabled = true;
            this.ProblemsListBox.ItemHeight = 25;
            this.ProblemsListBox.Location = new System.Drawing.Point(0, 0);
            this.ProblemsListBox.Name = "ProblemsListBox";
            this.ProblemsListBox.Size = new System.Drawing.Size(211, 621);
            this.ProblemsListBox.TabIndex = 1;
            this.ProblemsListBox.SelectedIndexChanged += new System.EventHandler(this.ProbemsListBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.DeadlineDate);
            this.panel7.Controls.Add(this.lowProblemPriority);
            this.panel7.Controls.Add(this.hardProblemPriority);
            this.panel7.Controls.Add(this.mediumProblemPriority);
            this.panel7.Controls.Add(this.label29);
            this.panel7.Controls.Add(this.applicantNameLabel);
            this.panel7.Controls.Add(this.problemIdLabel);
            this.panel7.Controls.Add(this.label31);
            this.panel7.Controls.Add(this.label30);
            this.panel7.Controls.Add(this.problemDescription);
            this.panel7.Location = new System.Drawing.Point(23, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(954, 451);
            this.panel7.TabIndex = 0;
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.AutoSize = true;
            this.DeadlineDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeadlineDate.Location = new System.Drawing.Point(434, 34);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.Size = new System.Drawing.Size(0, 29);
            this.DeadlineDate.TabIndex = 9;
            // 
            // lowProblemPriority
            // 
            this.lowProblemPriority.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lowProblemPriority.BackgroundImage")));
            this.lowProblemPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lowProblemPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowProblemPriority.Location = new System.Drawing.Point(657, 23);
            this.lowProblemPriority.Name = "lowProblemPriority";
            this.lowProblemPriority.Size = new System.Drawing.Size(40, 40);
            this.lowProblemPriority.TabIndex = 8;
            this.lowProblemPriority.Click += new System.EventHandler(this.ProblemPriority_Click);
            // 
            // hardProblemPriority
            // 
            this.hardProblemPriority.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hardProblemPriority.BackgroundImage")));
            this.hardProblemPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hardProblemPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardProblemPriority.Location = new System.Drawing.Point(835, 23);
            this.hardProblemPriority.Name = "hardProblemPriority";
            this.hardProblemPriority.Size = new System.Drawing.Size(40, 40);
            this.hardProblemPriority.TabIndex = 7;
            this.hardProblemPriority.Click += new System.EventHandler(this.ProblemPriority_Click);
            // 
            // mediumProblemPriority
            // 
            this.mediumProblemPriority.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediumProblemPriority.BackgroundImage")));
            this.mediumProblemPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumProblemPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumProblemPriority.Location = new System.Drawing.Point(746, 23);
            this.mediumProblemPriority.Name = "mediumProblemPriority";
            this.mediumProblemPriority.Size = new System.Drawing.Size(40, 40);
            this.mediumProblemPriority.TabIndex = 6;
            this.mediumProblemPriority.Click += new System.EventHandler(this.ProblemPriority_Click);
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(596, 84);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(334, 40);
            this.label29.TabIndex = 5;
            this.label29.Text = "Связаться с заявителем";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicantNameLabel
            // 
            this.applicantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicantNameLabel.Location = new System.Drawing.Point(242, 73);
            this.applicantNameLabel.Name = "applicantNameLabel";
            this.applicantNameLabel.Size = new System.Drawing.Size(185, 57);
            this.applicantNameLabel.TabIndex = 4;
            this.applicantNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemIdLabel
            // 
            this.problemIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.problemIdLabel.Location = new System.Drawing.Point(242, 23);
            this.problemIdLabel.Name = "problemIdLabel";
            this.problemIdLabel.Size = new System.Drawing.Size(190, 50);
            this.problemIdLabel.TabIndex = 3;
            this.problemIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(21, 73);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(205, 51);
            this.label31.TabIndex = 2;
            this.label31.Text = "Отправитель";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.DarkGray;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(21, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(210, 50);
            this.label30.TabIndex = 1;
            this.label30.Text = "Id запроса";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemDescription
            // 
            this.problemDescription.BackColor = System.Drawing.SystemColors.Window;
            this.problemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.problemDescription.Location = new System.Drawing.Point(21, 159);
            this.problemDescription.Name = "problemDescription";
            this.problemDescription.Size = new System.Drawing.Size(916, 277);
            this.problemDescription.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.Color.LightGray;
            this.Messages.ImageIndex = 8;
            this.Messages.Location = new System.Drawing.Point(25, 4);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1271, 655);
            this.Messages.TabIndex = 2;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.LightGray;
            this.Settings.Controls.Add(this.settingsCheckBox);
            this.Settings.Controls.Add(this.label4);
            this.Settings.ImageIndex = 5;
            this.Settings.Location = new System.Drawing.Point(25, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1271, 655);
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
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Задания.png");
            this.imageList.Images.SetKeyName(1, "Сообщения.png");
            this.imageList.Images.SetKeyName(2, "Настройки.png");
            this.imageList.Images.SetKeyName(3, "HighPriority.png");
            this.imageList.Images.SetKeyName(4, "LowPriority.png");
            this.imageList.Images.SetKeyName(5, "Settings.png");
            this.imageList.Images.SetKeyName(6, "UserProblems.png");
            this.imageList.Images.SetKeyName(7, "MediumPriority.png");
            this.imageList.Images.SetKeyName(8, "Messages.png");
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(271, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(421, 55);
            this.label8.TabIndex = 7;
            this.label8.Text = "Отправить в отдел";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(650, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отдел 6";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(332, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отдел 5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 50);
            this.label7.TabIndex = 4;
            this.label7.Text = "Отдел 4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(649, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отдел 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(333, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отдел 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отдел 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Location = new System.Drawing.Point(33, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 553);
            this.panel6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Id Запроса";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Отправитель";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(564, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "Связаться с заявителем";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(14, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(856, 288);
            this.label12.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(155, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Id Чела";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(188, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "Login чела";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(389, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(676, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 40);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(740, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 40);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(805, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 40);
            this.panel5.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(18, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 440);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 38);
            this.panel1.TabIndex = 4;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(1237, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 25);
            this.label25.TabIndex = 5;
            this.label25.Text = "-";
            this.label25.Click += new System.EventHandler(this.Fold_Click);
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1262, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "X";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Engineer1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Engineer1FormTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Engineer1_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer1";
            this.Engineer1FormTabControl.ResumeLayout(false);
            this.Tasks.ResumeLayout(false);
            this.problemsPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TabControl Engineer1FormTabControl;
        private System.Windows.Forms.TabPage Tasks;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.CheckBox settingsCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList; 
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel problemsPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label department3;
        private System.Windows.Forms.Label department2;
        private System.Windows.Forms.Label department1;
        private System.Windows.Forms.Label sendToDepartment;
        private System.Windows.Forms.Label department6;
        private System.Windows.Forms.Label department5;
        private System.Windows.Forms.Label department4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label applicantNameLabel;
        private System.Windows.Forms.Label problemIdLabel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label problemDescription;
        private System.Windows.Forms.Panel lowProblemPriority;
        private System.Windows.Forms.Panel hardProblemPriority;
        private System.Windows.Forms.Panel mediumProblemPriority;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox ProblemsListBox;
        private System.Windows.Forms.Label DeadlineDate;
    }
}