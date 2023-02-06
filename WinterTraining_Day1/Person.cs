namespace WinterTraining_Day1
{
    internal class Person
    {
        public Person()
        {
            Console.WriteLine("You have created an object");
        }
        public Person(string _name) : this() 
        {
            this.name = _name;
        }


        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public virtual string GetData()
        {
            return $"name = {name}";
        }
    }
}
