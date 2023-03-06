using AutoMapper;

namespace mm_cs_DataManipulation
{
    public class Mapping
    {
        public void Run()
        {
            Person person = new Person() { Id = 1, Name = "Yossi",Taz=123423 };

            // Student student = new Student() { Id = person.Id, Name =person.Name };


            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person, Student>().ForMember(stu=>stu.Mispar,per=>per.MapFrom(src=>src.Taz)));
            var mapper = new Mapper(config);

            Student student = mapper.Map<Student>(person);
            
        }
    }

    class Person
    {
        public int Taz { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int age;
    }

    class Student
    {
        // Mispar is same meaning of Taz
        public int Mispar { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

}