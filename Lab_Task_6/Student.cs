using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Student
    {
        String name;
        String id;
        String department;
        float cgpa;
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public String ID
        {
            set { id = value;}
            get { return id; }
        }
        public String Department
        {
            set { department = value; }
            get { return department; }
        }
        public float CGPA
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public Student()
        {
            Console.WriteLine("This Is Empty Constructor For Student Class");
        }
        public Student(String name,String id,String department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department= department;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Student Name:"+name);
            Console.WriteLine("Student Id:"+id);
            Console.WriteLine("Student Department:"+ department);
            Console.WriteLine("Student CGPA:"+cgpa);
        }


    }
}
