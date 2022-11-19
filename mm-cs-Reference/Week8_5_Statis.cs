using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Reference
{

	class AAA : Week8_5_Statis {

		Student Student = new Student("223333");
	}


	class Week8_5_Statis
    {

		public void Ran()
		{
			Student.Count = 100;
			int a = Student.GetCountPlus(2);

            Student s1 = new Student("123234");
			Student s2 = new Student("45645");
			Student s3 = new Student("45645465");

		}
		public class Ball
		{
			Student Student = new Student("12322");
		}
		protected class Student
		{	
			int age;
			public Student(string id)
			{
				_Id = id;
				Count++;
			}
			public static int GetCountPlus(int a)
			{
				return Count + a ;
			}

			public static int Count;

			private string _Id;
			public string Id
			{
				get
				{
					return _Id;
				}

			}
			public string Name { get; set; }
			public string Phone { get; set; }
			public string Address { get; set; }

			public void Save()
			{
			}
		}
	}

   
}
