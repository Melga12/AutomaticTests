using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using ApplicationToLearnTest;

namespace MyTests
{
    class UniversityTests
    {
        [Test]
        public void CheckIfStudentCreate()
        {
            //Arrange
            var student = new Student(1, "Gosia");
            //Assert
            Assert.IsTrue(student.Id == 1 && student.Name == "Gosia");
            Assert.IsInstanceOf(typeof(Student), student);
        }

        [Test]
        public void CheckDepartmentCreate()
        {
            //Arrange
            var student1 = new Student(2, "Iza");
            var student2 = new Student(3, "Mateusz");
            var student3 = new Student(4, "Jarek");
            var student4 = new Student(1, "Gosia");
            var students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            var department = new Department(1, "Physics", students);
            //Assert
            Assert.IsInstanceOf(typeof(Department), department);
            Assert.IsTrue(department.Id == 1 && department.Name == "Physics" && department.Students.Any(s => s.Id == 2 && s.Name == "Iza") && department.Students.Any(s => s.Id == 3 && s.Name == "Mateusz") && department.Students.Any(s => s.Id == 4 && s.Name == "Jarek"));
            Assert.IsTrue(department.Id == 1 && department.Name == "Physics" && department.Students.Any(s => s.Id == 1 && s.Name == "Gosia"));
        }

        [Test]
        public void CheckUniversityCreate()
        {
            //Arrange
            var student1 = new Student(2, "Iza");
            var student4 = new Student(1, "Gosia");
            var students = new List<Student>();
            students.Add(student1);
            students.Add(student4);
            var department1 = new Department(1, "Physics", students);
            var department2 = new Department(2, "Math", students);
            var departments = new List<Department>();
            departments.Add(department1);
            departments.Add(department2);
            var university = new University(1, "UG", departments);
            //Assert
            Assert.IsTrue(university.Id == 1 && university.Name == "UG" && university.Departments.Any(d => d.Id == 1 && d.Name == "Physics") && university.Departments.FirstOrDefault(d => d.Id == 1 && d.Name == "Physics").Students.Any(s => s.Id == 1 && s.Name == "Gosia"));
            Assert.IsTrue(university.Id == 1 && university.Name == "UG" && university.Departments.Any(d => d.Id == 1 && d.Name == "Physics") && university.Departments.FirstOrDefault(d => d.Id == 1 && d.Name == "Physics").Students.Any(s => s.Id == 2 && s.Name == "Iza"));
            Assert.IsTrue(university.Id == 1 && university.Name == "UG" && university.Departments.Any(d => d.Id == 2 && d.Name == "Math") && university.Departments.FirstOrDefault(d => d.Id == 2 && d.Name == "Math").Students.Any(s => s.Id == 1 && s.Name == "Gosia"));
            Assert.IsTrue(university.Id == 1 && university.Name == "UG" && university.Departments.Any(d => d.Id == 2 && d.Name == "Math") && university.Departments.FirstOrDefault(d => d.Id == 2 && d.Name == "Math").Students.Any(s => s.Id == 2 && s.Name == "Iza"));
            Assert.IsInstanceOf(typeof(University), university);
        }
    }
}
