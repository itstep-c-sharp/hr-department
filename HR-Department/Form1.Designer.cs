namespace HR_Department
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompanyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DepartmentsList = new System.Windows.Forms.ComboBox();
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpecField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PositionField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SalaryField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExperField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthField = new System.Windows.Forms.DateTimePicker();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компанияToolStripMenuItem,
            this.департаментыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компанияToolStripMenuItem
            // 
            this.компанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCompanyItem});
            this.компанияToolStripMenuItem.Name = "компанияToolStripMenuItem";
            this.компанияToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.компанияToolStripMenuItem.Text = "Компания";
            // 
            // департаментыToolStripMenuItem
            // 
            this.департаментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDepartmentItem,
            this.DelDepartmentItem,
            this.EditDepartmentItem});
            this.департаментыToolStripMenuItem.Name = "департаментыToolStripMenuItem";
            this.департаментыToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.департаментыToolStripMenuItem.Text = "Департаменты";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmployeeItem,
            this.DelEmployeeItem,
            this.EditEmployeeItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // EditCompanyItem
            // 
            this.EditCompanyItem.Name = "EditCompanyItem";
            this.EditCompanyItem.Size = new System.Drawing.Size(153, 26);
            this.EditCompanyItem.Text = "Изменить";
            // 
            // AddDepartmentItem
            // 
            this.AddDepartmentItem.Name = "AddDepartmentItem";
            this.AddDepartmentItem.Size = new System.Drawing.Size(181, 26);
            this.AddDepartmentItem.Text = "Добавить";
            this.AddDepartmentItem.Click += new System.EventHandler(this.AddDepartmentItem_Click);
            // 
            // DelDepartmentItem
            // 
            this.DelDepartmentItem.Name = "DelDepartmentItem";
            this.DelDepartmentItem.Size = new System.Drawing.Size(181, 26);
            this.DelDepartmentItem.Text = "Удалить";
            this.DelDepartmentItem.Click += new System.EventHandler(this.DelDepartmentItem_Click);
            // 
            // EditDepartmentItem
            // 
            this.EditDepartmentItem.Name = "EditDepartmentItem";
            this.EditDepartmentItem.Size = new System.Drawing.Size(181, 26);
            this.EditDepartmentItem.Text = "Изменить";
            this.EditDepartmentItem.Click += new System.EventHandler(this.EditDepartmentItem_Click);
            // 
            // AddEmployeeItem
            // 
            this.AddEmployeeItem.Name = "AddEmployeeItem";
            this.AddEmployeeItem.Size = new System.Drawing.Size(153, 26);
            this.AddEmployeeItem.Text = "Добавить";
            // 
            // DelEmployeeItem
            // 
            this.DelEmployeeItem.Name = "DelEmployeeItem";
            this.DelEmployeeItem.Size = new System.Drawing.Size(153, 26);
            this.DelEmployeeItem.Text = "Удалить";
            // 
            // EditEmployeeItem
            // 
            this.EditEmployeeItem.Name = "EditEmployeeItem";
            this.EditEmployeeItem.Size = new System.Drawing.Size(153, 26);
            this.EditEmployeeItem.Text = "Изменить";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Caption);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 83);
            this.panel1.TabIndex = 1;
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Caption.ForeColor = System.Drawing.Color.DarkCyan;
            this.Caption.Location = new System.Drawing.Point(229, 24);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(558, 32);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "Отдел кадров компании \"CompanyName\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeesList);
            this.groupBox1.Controls.Add(this.DepartmentsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 439);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Департаменты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BirthField);
            this.groupBox2.Controls.Add(this.ExperField);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SalaryField);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PositionField);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SpecField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PhoneField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EmailField);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NameField);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(615, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 439);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персональная информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PhotoBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(256, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 439);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото сотрудника";
            // 
            // DepartmentsList
            // 
            this.DepartmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsList.FormattingEnabled = true;
            this.DepartmentsList.Location = new System.Drawing.Point(6, 23);
            this.DepartmentsList.Name = "DepartmentsList";
            this.DepartmentsList.Size = new System.Drawing.Size(244, 26);
            this.DepartmentsList.TabIndex = 0;
            this.DepartmentsList.SelectedIndexChanged += new System.EventHandler(this.DepartmentsList_SelectedIndexChanged);
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.ItemHeight = 18;
            this.EmployeesList.Location = new System.Drawing.Point(6, 55);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.ScrollAlwaysVisible = true;
            this.EmployeesList.Size = new System.Drawing.Size(244, 382);
            this.EmployeesList.TabIndex = 1;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия, Имя";
            // 
            // NameField
            // 
            this.NameField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameField.Location = new System.Drawing.Point(11, 44);
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(234, 24);
            this.NameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailField.Location = new System.Drawing.Point(13, 146);
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.Size = new System.Drawing.Size(234, 24);
            this.EmailField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail:";
            // 
            // PhoneField
            // 
            this.PhoneField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneField.Location = new System.Drawing.Point(13, 198);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(234, 24);
            this.PhoneField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(10, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // SpecField
            // 
            this.SpecField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpecField.Location = new System.Drawing.Point(13, 250);
            this.SpecField.Name = "SpecField";
            this.SpecField.ReadOnly = true;
            this.SpecField.Size = new System.Drawing.Size(234, 24);
            this.SpecField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Специальность";
            // 
            // PositionField
            // 
            this.PositionField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PositionField.Location = new System.Drawing.Point(13, 302);
            this.PositionField.Name = "PositionField";
            this.PositionField.ReadOnly = true;
            this.PositionField.Size = new System.Drawing.Size(234, 24);
            this.PositionField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(10, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Должность";
            // 
            // SalaryField
            // 
            this.SalaryField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalaryField.Location = new System.Drawing.Point(13, 355);
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.ReadOnly = true;
            this.SalaryField.Size = new System.Drawing.Size(234, 24);
            this.SalaryField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(10, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Зарплата";
            // 
            // ExperField
            // 
            this.ExperField.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExperField.Location = new System.Drawing.Point(13, 406);
            this.ExperField.Name = "ExperField";
            this.ExperField.ReadOnly = true;
            this.ExperField.Size = new System.Drawing.Size(234, 24);
            this.ExperField.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(10, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Стаж";
            // 
            // BirthField
            // 
            this.BirthField.Location = new System.Drawing.Point(13, 95);
            this.BirthField.Name = "BirthField";
            this.BirthField.Size = new System.Drawing.Size(232, 24);
            this.BirthField.TabIndex = 16;
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::HR_Department.Properties.Resources.profile;
            this.PhotoBox.Location = new System.Drawing.Point(0, 23);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(353, 410);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HR_Department.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления отделом кадров компании";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCompanyItem;
        private System.Windows.Forms.ToolStripMenuItem департаментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem DelDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem EditDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmployeeItem;
        private System.Windows.Forms.ToolStripMenuItem DelEmployeeItem;
        private System.Windows.Forms.ToolStripMenuItem EditEmployeeItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DepartmentsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.DateTimePicker BirthField;
        private System.Windows.Forms.TextBox ExperField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SalaryField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PositionField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SpecField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PhotoBox;
    }
}

