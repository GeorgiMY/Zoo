using Data;
using Zoo.Core;

namespace Zoo.WinFormsApp
{
    public partial class Form1 : Form
    {
        public AnimalController AnimalsController { get; set; }
        public EmployeeController EmployeesController { get; set; }
        public EnclosureController EnclosuresController { get; set; }
        public VisitorController VisitorsController { get; set; }
        public SpeciesController SpeciesController { get; set; }

        public Form1()
        {
            InitializeComponent();
            AnimalsController = new AnimalController();
            EmployeesController = new EmployeeController();
            EnclosuresController = new EnclosureController();
            VisitorsController = new VisitorController();
            SpeciesController = new SpeciesController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> animalNames = AnimalsController.GetAnimalNames();
            foreach (string animalName in animalNames)
            {
                listBox1.Items.Add(animalName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> employeesNames = EmployeesController.GetEmployeeNames();
            foreach (string employeeName in employeesNames)
            {
                listBox1.Items.Add(employeeName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> enclosureNames = EnclosuresController.GetEnclosureNames();
            foreach (string enclosureName in enclosureNames)
            {
                listBox1.Items.Add(enclosureName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> visitorNames = VisitorsController.GetVisitorNames();
            foreach (string visitorName in visitorNames)
            {
                listBox1.Items.Add(visitorName);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> speciesNames = SpeciesController.GetSpeciesNames();
            foreach (string speciesName in speciesNames)
            {
                listBox1.Items.Add(speciesName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
