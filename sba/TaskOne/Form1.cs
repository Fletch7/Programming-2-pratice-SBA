using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TheoryExam
{
    public partial class Form1 : Form
    {
        // PLEASE DO NOT MODIFY THIS CODE
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();

            // PLEASE DO NOT MODIFY THIS CODE
            people = new List<Person>()
            {
                new Person("Alice", "Brown", 17),
                new Person("Ben", "Dawkins", 21),
                new Person("Clara", "Dawson", 34),
                new Person("George", "Miller", 65),
                new Person("Helen", "Turner", 72)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write your answer for task 1.3 here
            List<Person> result = people.Where(p => p.LastName.StartsWith("D")).ToList();


            // Write your answer for task 1.4 here
            listBox1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Write your answer for task 1.5 here
            List<Person> result = people.Where(p => p.Age >= 25 && p.Age <= 50).ToList();

            // Write your answer for task 1.6 here 
            listBox2.DataSource = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
        }
    }
}
