using StudentData;
using System;
using example.Cmd;

namespace CmdSystem
{
    internal class Cmd2
    {
        public static void HandleCmd2()
        {
            StudentSystem studentSystem = StudentSystem.GetInstance();

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
                int age = Util.ReadInt("Please enter the student's age: ");

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

        private static int ReadNumberOfStudents()
        {
            return Util.ReadInt("Enter the number of students to add:"); // 读取添加学生的数量
        }

        private static int ReadStudentId()
        {
            return Util.ReadInt("Please enter the student's ID: "); // 读取学生ID
        }

        private static string ReadString(string i)
        {
            Console.WriteLine(i);
            return Console.ReadLine(); // 读取字符串输入
        }
    }
}
