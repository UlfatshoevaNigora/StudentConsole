   public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Оценка: {Grade}";
        }
    }