namespace EventDemo
{
    internal class Student
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                int oldAge = _age;
                _age = value;
                FireStudentAgeChangedEvent(oldAge, _age);
            }
        }

        public Student()
        {
            Name = string.Empty;
        }

        public delegate void StudentAgeChangedDelegate(StudentAgeChangedEventArgs e);

        public event StudentAgeChangedDelegate? StudentAgeChanged;

        private void FireStudentAgeChangedEvent(int oldAge, int newAge)
        {
            if (StudentAgeChanged != null &&
                StudentAgeChanged.GetInvocationList().Length > 0)
            {
                StudentAgeChangedEventArgs e = new()
                {
                    OldAge = oldAge,
                    NewAge = newAge
                };
                StudentAgeChanged(e);
            }
        }
    }
}
