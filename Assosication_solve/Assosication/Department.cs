using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosication
{
    class Department
    {
        private string id;
        private string name;

        private int studentCount;
        private student[] students;

        public Department()
        {
            students = new student[60];
        }

        public Department(string id, string name)
        {
            this.Name = name;
            this.Id = id;
            students = new student[60];
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int StudentCount
        {
            set { this.studentCount = value; }
            get { return this.studentCount; }
        }

        public void AddStudent(params student[] stdns)
        {
            foreach (student s in stdns)
            {
                this.students[this.StudentCount++] = s;
                s.Dept = this;
            }
        }



        public student GetStudent(string id)
        {

            return null;
        }

        public void PrintStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Department Name: {0}", this.Name);
            Console.WriteLine("Department Id: {0}", this.Id);
        }
    }
}
