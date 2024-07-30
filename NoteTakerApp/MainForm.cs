using System.Data;

namespace NoteTakerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataTable toDoList = new DataTable();
        DataTable doneList = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            //making columns for the to do list
            toDoList.Columns.Add("Task");
            toDoList.Columns.Add("Description");
            toDoList.Columns.Add("Time");
            toDoList.Columns.Add("Urgency");

            //pointing the to do list to the data grid view
            toDoDataGridView.DataSource = toDoList;

            doneList.Columns.Add("Task");
            doneList.Columns.Add("Description");


            doneDataGridView.DataSource = doneList;
        }
    }
}
