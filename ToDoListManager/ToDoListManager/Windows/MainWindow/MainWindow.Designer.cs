namespace ToDoListManager
{
    partial class programBackground
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panProjectNav = new System.Windows.Forms.Panel();
            this.panProjects = new System.Windows.Forms.Panel();
            this.panNav = new System.Windows.Forms.Panel();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panNew = new System.Windows.Forms.Panel();
            this.panNewTasks = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panProjectNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panNew.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panProjectNav
            // 
            this.panProjectNav.AutoScroll = true;
            this.panProjectNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panProjectNav.Controls.Add(this.panProjects);
            this.panProjectNav.Controls.Add(this.panNav);
            this.panProjectNav.Controls.Add(this.btnNewProject);
            this.panProjectNav.Controls.Add(this.btnDeleteSelected);
            this.panProjectNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panProjectNav.Location = new System.Drawing.Point(0, 0);
            this.panProjectNav.Margin = new System.Windows.Forms.Padding(3, 50, 0, 0);
            this.panProjectNav.Name = "panProjectNav";
            this.panProjectNav.Size = new System.Drawing.Size(300, 1080);
            this.panProjectNav.TabIndex = 0;
            // 
            // panProjects
            // 
            this.panProjects.AutoScroll = true;
            this.panProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProjects.Location = new System.Drawing.Point(0, 0);
            this.panProjects.Name = "panProjects";
            this.panProjects.Size = new System.Drawing.Size(300, 980);
            this.panProjects.TabIndex = 3;
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panNav.Location = new System.Drawing.Point(3, 193);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(3, 100);
            this.panNav.TabIndex = 2;
            // 
            // btnNewProject
            // 
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Myriad Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Image = global::ToDoListManager.Properties.Resources.komplex1;
            this.btnNewProject.Location = new System.Drawing.Point(0, 990);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(300, 42);
            this.btnNewProject.TabIndex = 2;
            this.btnNewProject.Text = "Neues Projekt";
            this.btnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Myriad Pro Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Image = global::ToDoListManager.Properties.Resources.komplex1;
            this.btnDeleteSelected.Location = new System.Drawing.Point(0, 1038);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(300, 42);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Lösche Auswahl";
            this.btnDeleteSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnNewTask);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnNewTask
            // 
            this.btnNewTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.ForeColor = System.Drawing.Color.White;
            this.btnNewTask.Location = new System.Drawing.Point(0, 0);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(200, 50);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "Neue Aufgabe";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightGray;
            this.btnExit.Location = new System.Drawing.Point(1571, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panNew
            // 
            this.panNew.Controls.Add(this.panNewTasks);
            this.panNew.Controls.Add(this.label1);
            this.panNew.Location = new System.Drawing.Point(322, 70);
            this.panNew.Name = "panNew";
            this.panNew.Size = new System.Drawing.Size(512, 1000);
            this.panNew.TabIndex = 2;
            // 
            // panNewTasks
            // 
            this.panNewTasks.AutoScroll = true;
            this.panNewTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panNewTasks.Location = new System.Drawing.Point(0, 40);
            this.panNewTasks.Name = "panNewTasks";
            this.panNewTasks.Size = new System.Drawing.Size(512, 960);
            this.panNewTasks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrent);
            this.panel2.Location = new System.Drawing.Point(854, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 1000);
            this.panel2.TabIndex = 3;
            // 
            // lblCurrent
            // 
            this.lblCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCurrent.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.lblCurrent.Location = new System.Drawing.Point(0, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(512, 40);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "In Arbeit";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1386, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 1000);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(63)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Erledigt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panProjectNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "programBackground";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panProjectNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panNew.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panProjectNav;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Panel panProjects;
        private System.Windows.Forms.Panel panNewTasks;
    }
}

