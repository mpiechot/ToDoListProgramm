using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListManager.Util;

namespace ToDoListManager.Windows.NewProjectWindow
{
    public partial class NewProject : Form
    {
        public EventHandler<Project> newProjectCreated;

        public NewProject()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Project newProject = new Project(txfName.Text);
            newProjectCreated.Invoke(this, newProject);
            this.Close();
        }
    }
}
