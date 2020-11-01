using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ToDoListManager.Windows.NewProjectWindow;
using ToDoListManager.Util;
using ToDoListManager.Windows.NewTaskWindow;
using ToDoListManager.Util.TaskForm;

namespace ToDoListManager
{

    public partial class programBackground : Form
    {
        private static NewProject newProjectWindow = new NewProject();
        private static NewTask newTaskWindow = new NewTask();
        private static int NEW_BUTTON_ID = 0;

        private List<Project> availableProjects;
        private Button selectedProject;

        public programBackground()
        {
            InitializeComponent();

            availableProjects = new List<Project>();

            newProjectWindow.newProjectCreated += NewProjectCreated;

            panNav.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            //Add some Space
            Label space = new Label();
            space.AutoSize = false;
            space.Size = new Size(490, 6);
            space.Dock = DockStyle.Top;
            panNewTasks.Controls.Add(space);

            //Add a new Task
            TaskForm task = new TaskForm("Test");
            task.TopLevel = false;
            //task.Dock = DockStyle.Top;
            //panNewTasks.Controls.Add(task);
            this.Controls.Add(task);
            task.Show();
            ControlExtension.Draggable(task, true);
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            
            newProjectWindow.ShowDialog();
        }

        public void NewProjectCreated(object sender, Project project)
        {
            availableProjects.Add(project);

            Button newProjectButton = new Button();

            newProjectButton.Text = project.name;
            newProjectButton.Width = 300;
            newProjectButton.Height = 50;
            newProjectButton.Font = new Font("Minion Pro", 24);
            newProjectButton.Name = (NEW_BUTTON_ID++) +"";
            newProjectButton.Click += btnProjectSelected_Click;
            newProjectButton.FlatStyle = FlatStyle.Flat;
            newProjectButton.ForeColor = Color.White;
            newProjectButton.FlatAppearance.BorderSize = 0;

            panProjects.Controls.Add(newProjectButton);
            newProjectButton.Dock = DockStyle.Top;
            //Create Button to select project
        }
        private void btnProjectSelected_Click(object sender, EventArgs e)
        {
            //Select the project
            Button selected = (Button)sender;
            selectNavButton(selected);
            deselectNavButton(selectedProject);
            selectedProject = selected;

            //Show all Tasks
            string projectID = selected.Name;
        }
        #region projectSelector
        private void selectNavButton(Button btn)
        {
            if (!panNav.Visible)
            {
                panNav.Show();
            }
            panNav.Height = btn.Height;
            panNav.Top = btn.Top;
            panNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void deselectNavButton(Button btn)
        {
            if (btn == null)
            {
                return;
            }
            btn.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion
    }
}
