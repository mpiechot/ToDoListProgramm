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

namespace ToDoListManager.Util.TaskForm
{
    public partial class TaskForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public TaskForm(string taskDescription)
        {
            init(taskDescription);
        }
        public TaskForm(string taskDescription, DateTime startDate, DateTime endDate)
        {
            initWithDate(taskDescription,startDate,endDate);
        }

        private void init(string taskDescription)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            lblTaskDescription.Text = taskDescription;
        }
        private void initWithDate(string taskDescription, DateTime start, DateTime end)
        {
            init(taskDescription);

            lblStartDate.Text = start.ToString();
            lblEndDate.Text = end.ToString();
        }
        private void TaskForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
