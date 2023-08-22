using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double GPA { get; set; }
        public string Result { get; set; }

        public Student(int id, string name, string gender, int age, double mathScore, double physicsScore, double chemistryScore)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            MathScore = mathScore;
            PhysicsScore = physicsScore;
            ChemistryScore = chemistryScore;
            GPA = Math.Round((mathScore + physicsScore + chemistryScore) / 3, 2);
            if (GPA >= 8)
            {
                Result = "Very Good";
            }
            else if (GPA >= 6.5)
            {
                Result = "Good";
            }
            else if (GPA >= 5)
            {
                Result = "Average";
            }
            else
            {
                Result = "Weak";
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Age: {Age}, Math Score: {MathScore}, Physics Score: {PhysicsScore}, Chemistry Score: {ChemistryScore}, GPA: {GPA}, Result: {Result}";
        }
    }
}
