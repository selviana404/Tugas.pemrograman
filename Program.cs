namespace baru.LatihanInheritance
{
    public class Program
    {

        static void Main( string[] args )
        {
            Person person = new Person("dody",19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("dika",30,"3123","math");
            teacher.GetNameAndAge();

            Student student = new Student("dono",20,"2314","donopamungkas@gmail.com");
            student.GetNameAndAge();
        }
    }
}