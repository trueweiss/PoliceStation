
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
            this.Application = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.Button();
            this.Arrest = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Application
            // 
            this.Application.BackColor = System.Drawing.Color.DarkCyan;
            this.Application.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Application.ForeColor = System.Drawing.Color.Black;
            this.Application.Location = new System.Drawing.Point(12, 78);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(190, 91);
            this.Application.TabIndex = 0;
            this.Application.Text = "Добавить заявление";
            this.Application.UseVisualStyleBackColor = false;
            this.Application.Click += new System.EventHandler(this.Application_Click);
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.Color.DarkCyan;
            this.Employees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employees.Location = new System.Drawing.Point(237, 175);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(182, 98);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Список сотрудников";
            this.Employees.UseVisualStyleBackColor = false;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Arrest
            // 
            this.Arrest.BackColor = System.Drawing.Color.DarkCyan;
            this.Arrest.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Arrest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Arrest.Location = new System.Drawing.Point(12, 175);
            this.Arrest.Name = "Arrest";
            this.Arrest.Size = new System.Drawing.Size(190, 98);
            this.Arrest.TabIndex = 3;
            this.Arrest.Text = "Регистрация задержания";
            this.Arrest.UseVisualStyleBackColor = false;
            this.Arrest.Click += new System.EventHandler(this.Arrest_Click);
            // 
            // Delay
            // 
            this.Delay.BackColor = System.Drawing.Color.DarkCyan;
            this.Delay.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.Delay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delay.Location = new System.Drawing.Point(12, 279);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(190, 83);
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
            this.Timetable.Location = new System.Drawing.Point(237, 78);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(182, 91);
            this.Timetable.TabIndex = 5;
            this.Timetable.Text = "График работы";
            this.Timetable.UseVisualStyleBackColor = false;
            this.Timetable.Click += new System.EventHandler(this.Timetable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-42, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 70);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(238, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "✰✰✰✰✰";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 21);
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
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Park County Police Force";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "To protect and to serve";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Timetable);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.Arrest);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Application);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}