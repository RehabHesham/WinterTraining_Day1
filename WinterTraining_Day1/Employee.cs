namespace WinterTraining_Day1
{
    internal class Employee : Person
    {
        public Employee() : base()
        { }
        public Employee(string _name) : base(_name) { }
        public Employee(string _name,decimal _salary) : this(_name)
        {
            //this.Name = _name;
            this.Salary = _salary;
        }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }
        public override string GetData()
        {
            return $"name = {Name}, salary = {salary}";
        }

        //operator overloading
        //opertor casting
        public static explicit operator Employee(int salary)
        {
            return new Employee()
            {
                Name = "From Casting",
                salary= salary
            };
        }
        public static explicit operator string(Employee employee)
        {
            return employee.Name + employee.salary;
        }
    }
}
