
namespace PoliceStation
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.Application = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.Button();
            this.Arrest = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllStatements = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Forms = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Application
            // 
            this.Application.BackColor = System.Drawing.Color.DarkCyan;
            this.Application.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Application.ForeColor = System.Drawing.Color.Black;
            this.Application.Location = new System.Drawing.Point(12, 15);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(190, 46);
            this.Application.TabIndex = 0;
            this.Application.Text = "Добавить заявление";
            this.Application.UseVisualStyleBackColor = false;
            this.Application.Click += new System.EventHandler(this.Application_Click);
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.Color.DarkCyan;
            this.Employees.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Employees.Location = new System.Drawing.Point(12, 119);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(190, 46);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Список сотрудников";
            this.Employees.UseVisualStyleBackColor = false;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Arrest
            // 
            this.Arrest.BackColor = System.Drawing.Color.DarkCyan;
            this.Arrest.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Arrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arrest.Location = new System.Drawing.Point(12, 67);
            this.Arrest.Name = "Arrest";
            this.Arrest.Size = new System.Drawing.Size(190, 46);
            this.Arrest.TabIndex = 3;
            this.Arrest.Text = "Регистрация задержания";
            this.Arrest.UseVisualStyleBackColor = false;
            this.Arrest.Click += new System.EventHandler(this.Arrest_Click);
            // 
            // Delay
            // 
            this.Delay.BackColor = System.Drawing.Color.DarkCyan;
            this.Delay.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Delay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delay.Location = new System.Drawing.Point(12, 223);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(190, 46);
            this.Delay.TabIndex = 4;
            this.Delay.Text = "Список задержанных";
            this.Delay.UseVisualStyleBackColor = false;
            this.Delay.Click += new System.EventHandler(this.Delay_Click);
            // 
            // Timetable
            // 
            this.Timetable.BackColor = System.Drawing.Color.DarkCyan;
            this.Timetable.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Timetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timetable.Location = new System.Drawing.Point(12, 171);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(190, 46);
            this.Timetable.TabIndex = 5;
            this.Timetable.Text = "График работы";
            this.Timetable.UseVisualStyleBackColor = false;
            this.Timetable.Click += new System.EventHandler(this.Timetable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 70);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "To protect and to serve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(458, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "✰✰✰✰✰";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(594, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "69";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Park County Police Force";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllStatements
            // 
            this.AllStatements.BackColor = System.Drawing.Color.DarkCyan;
            this.AllStatements.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.AllStatements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllStatements.Location = new System.Drawing.Point(12, 275);
            this.AllStatements.Name = "AllStatements";
            this.AllStatements.Size = new System.Drawing.Size(190, 46);
            this.AllStatements.TabIndex = 7;
            this.AllStatements.Text = "Список заявлений";
            this.AllStatements.UseVisualStyleBackColor = false;
            this.AllStatements.Click += new System.EventHandler(this.AllStatements_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Delay);
            this.panel2.Controls.Add(this.AllStatements);
            this.panel2.Controls.Add(this.Application);
            this.panel2.Controls.Add(this.Employees);
            this.panel2.Controls.Add(this.Timetable);
            this.panel2.Controls.Add(this.Arrest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 508);
            this.panel2.TabIndex = 8;
            // 
            // Forms
            // 
            this.Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Forms.Location = new System.Drawing.Point(213, 70);
            this.Forms.Name = "Forms";
            this.Forms.Size = new System.Drawing.Size(762, 508);
            this.Forms.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Окно авторизации";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.Forms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Application;
        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Arrest;
        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button Timetable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllStatements;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Forms;
        private System.Windows.Forms.Button button1;
    }
}