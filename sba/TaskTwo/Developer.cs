namespace TheoryExam
{
    public class Developer : Employee
    {
        // Write your answer for task 2.6 here
        public Developer(string name, int salary) : base(name, salary)
        {
        }
        // Write your answer for task 2.7 here
        public override string Work()
        {
            return "Writing code!";
        }
    }
}
