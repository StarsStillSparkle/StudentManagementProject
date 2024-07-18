using StudentData;
using System;

namespace CmdSystem
{
    internal class Cmd2
    {
        private StudentSystem studentSystem = StudentSystem.GetInstance();

        private int ReadNumberOfStudents()
        {
            return ReadInt("Enter the number of students to add:"); // 读取添加学生的数量
        }

        private int ReadStudentId()
        {
            return ReadInt("Please enter the student's ID: "); // 读取学生ID
        }

        public static int ReadInt(string i)
        {
            int value;
            while (true)
            {
                Console.WriteLine(i);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid input"); // 无效输入提示
            }
        }

        private string ReadString(string i)
        {
            Console.WriteLine(i);
            return Console.ReadLine(); // 读取字符串输入
        }

        public void HandleCmd()
        {
            int numberOfStudents = ReadNumberOfStudents();
            for (int i = 0; i < numberOfStudents; i++)
            {
                int id;
                while (true)
                {
                    id = ReadStudentId();
                    if (!studentSystem.IsIdExist(id))
                        break;

                    Console.WriteLine("This ID already exists. Please enter a different ID:"); // ID已存在
                }

                string name = ReadString("Please enter the student's name: ");
                int age = ReadInt("Please enter the student's age: ");

                if (studentSystem.AddStudent(id, name, age))
                {
                    Console.WriteLine("Student added successfully"); // 学生添加成功
                }
                else
                {
                    Console.WriteLine("Failed to add student"); // 学生添加失败
                }
            }
        }
    }
}
