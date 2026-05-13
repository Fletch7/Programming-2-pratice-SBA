namespace TheoryExam
{
    public partial class Form1 : Form
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();

            // PLEASE DO NOT MODIFY THIS CODE
            employees = new List<Employee>()
            {
                new Manager("John Smith", 75000),
                new Manager("Sarah Johnson", 82000),
                new Manager("Michael Brown", 95000),
                new Manager("Emily Davis", 68000),
                new Manager("David Wilson", 88000),
                new Developer("Alex Chen", 65000),
                new Developer("Jessica Martinez", 72000),
                new Developer("Ryan Thompson", 58000),
                new Developer("Olivia Garcia", 78000),
                new Developer("Daniel Rodriguez", 52000)
            };

            // Write your answer for task 2.8 here
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Salary", "Salary");
            // Write your answer for task 2.9 here
            foreach (Employee temp in employees)
            {
                dataGridView1.Rows.Add(temp.Name, temp.Salary);
            }

            // Write your answer for task 2.10 here
            int numberOfEmployeesOver50K = employees.Count(p => p.Salary >= 50000);
            MessageBox.Show($"Number of employees with salary > = 50000: {numberOfEmployeesOver50K}");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
