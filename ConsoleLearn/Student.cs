namespace Sample
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        private Boolean isHonor()
        {
            return this.gpa > 3.0 ? true : false;
        }

        public string toString()
        {
            // adding ternary operator inside string literals
            return $"<Student {this.name}, {(this.isHonor() ? "Honor" : "Not Honor")}>";
        }

    }

}