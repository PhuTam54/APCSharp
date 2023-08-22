using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment4
{
    internal class StudentManagement
    {
        static List<Student> studentList = new List<Student>();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Update student by ID.");
                Console.WriteLine("3. Delete student by ID.");
                Console.WriteLine("4. Search student by name.");
                Console.WriteLine("5. Sort students by GPA.");
                Console.WriteLine("6. Sort students by name.");
                Console.WriteLine("7. Sort students by ID.");
                Console.WriteLine("8. Display student list.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        SearchStudent();
                        break;
                    case 5:
                        SortByGPA();
                        break;
                    case 6:
                        SortByName();
                        break;
                    case 7:
                        SortById();
                        break;
                    case 8:
                        DisplayStudentList();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
            } while (choice != 0);
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter student information:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Math score: ");
            double mathScore = double.Parse(Console.ReadLine());
            Console.Write("Physics score: ");
            double physicsScore = double.Parse(Console.ReadLine());
            Console.Write("Chemistry score: ");
            double chemistryScore = double.Parse(Console.ReadLine());
            Student student = new Student(id, name, gender, age, mathScore, physicsScore, chemistryScore);
            studentList.Add(student);
        }

        public void UpdateStudent()
        {
            Console.Write("Enter student ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Student student = studentList.Find(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine("Enter new information:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Math score: ");
                double mathScore = double.Parse(Console.ReadLine());
                Console.Write("Physics score: ");
                double physicsScore = double.Parse(Console.ReadLine());
                Console.Write("Chemistry score: ");
                double chemistryScore = double.Parse(Console.ReadLine());
                student.Name = name;
                student.Gender = gender;
                student.Age = age;
                student.MathScore = mathScore;
                student.PhysicsScore = physicsScore;
                student.ChemistryScore = chemistryScore;
                student.GPA = Math.Round((mathScore + physicsScore + chemistryScore) / 3, 2);
                if (student.GPA >= 8)
                {
                    student.Result = "Very Good";
                }
                else if (student.GPA >= 6.5)
                {
                    student.Result = "Good";
                }
                else if (student.GPA >= 5)
                {
                    student.Result = "Average";
                }
                else
                {
                    student.Result = "Weak";
                }
                Console.WriteLine($"Student with ID {id} has been updated successfully.");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        public void DeleteStudent()
        {
            Console.Write("Enter student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Student student = studentList.Find(s => s.Id == id);
            if (student != null)
            {
                studentList.Remove(student);
                Console.WriteLine($"Student with ID {id} has been deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        public void SearchStudent()
        {
            Console.Write("Enter student name to search: ");
            string name = Console.ReadLine();
            List<Student> result = studentList.FindAll(s => s.Name.Equals(name));
            if (result.Count > 0)
            {
                foreach (var student in result)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine($"No student with name {name} found.");
            }
        }

        public void SortByGPA()
        {
            studentList.Sort((s1, s2) => s2.GPA.CompareTo(s1.GPA));
            DisplayStudentList();
        }

        public void SortByName()
        {
            studentList.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            DisplayStudentList();
        }

        public void SortById()
        {
            studentList.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));
            DisplayStudentList();
        }

        public void DisplayStudentList()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
