namespace TheoryExam
{
    public class Manager : Employee
    {
        // Write your answer for task 2.4 here
        public Manager(string name, int salary) : base(name, salary)
        {
        }

        // Write your answer for task 2.5 here
        public override string Work()
        {
            return "Managing team!";
        }
    }
}
