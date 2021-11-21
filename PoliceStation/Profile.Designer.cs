
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
            this.SuspendLayout();
            // 
            // Application
            // 
            this.Application.Location = new System.Drawing.Point(3, 3);
            this.Application.Name = "Application";
            this.Application.Size = new System.Drawing.Size(190, 91);
            this.Application.TabIndex = 0;
            this.Application.Text = "Добавить заявление";
            this.Application.UseVisualStyleBackColor = true;
            this.Application.Click += new System.EventHandler(this.Application_Click);
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(247, 100);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(182, 98);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Список сотрудников";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // Arrest
            // 
            this.Arrest.Location = new System.Drawing.Point(3, 100);
            this.Arrest.Name = "Arrest";
            this.Arrest.Size = new System.Drawing.Size(190, 92);
            this.Arrest.TabIndex = 3;
            this.Arrest.Text = "Регистрация задержания";
            this.Arrest.UseVisualStyleBackColor = true;
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(3, 198);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(190, 83);
            this.Delay.TabIndex = 4;
            this.Delay.Text = "Список задержанных";
            this.Delay.UseVisualStyleBackColor = true;
            // 
            // Timetable
            // 
            this.Timetable.Location = new System.Drawing.Point(247, 3);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(182, 91);
            this.Timetable.TabIndex = 5;
            this.Timetable.Text = "График работы";
            this.Timetable.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.Timetable);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.Arrest);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Application);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Application;
        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Arrest;
        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button Timetable;
    }
}