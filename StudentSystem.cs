using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace StudentData
{
    public class StudentSystem
    {
        private static StudentSystem instance;
        private Dictionary<int, Student> studentDict = new Dictionary<int, Student>();// dictionary方法

        string filePath;

        private StudentSystem() 
        {
            string folderPath = @"D:\code\C#\学生管理项目\text"; // 文件夹路径
            string fileName = "output.json"; // 文件名
            this.filePath = Path.Combine(folderPath, fileName); // 组合成完整文件路径
        }

        public static StudentSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new StudentSystem();
            }
            return instance;
        }

        public Dictionary<int, Student> GetStudentDict()
        {
            return studentDict;
        }

        public void PrintStudent()// cmd1
        {
            foreach (var student in studentDict.Values)
            {
                Console.WriteLine(student);
            }
        }

        public bool AddStudent(int id, string name, int age)// cmd2
        {
            if (IsIdExist(id))
            {
                return false;
            }

            studentDict.Add(id, new Student(id, name, age));
            return true; 
        }

        public bool IsIdExist(int id)
        {
            return studentDict.ContainsKey(id); // 检查ID是否存在
        }

        public void StoreStudentData() // cmd3
        {
            if (studentDict.Count == 0)
            {
                Console.WriteLine("No data existing");
                return;
            }

            try
            {
                File.WriteAllText(this.filePath, JsonConvert.SerializeObject(studentDict.Values.ToList())); // 将学生数据写入文件
                Console.WriteLine("Successfully written");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Write error: {e.Message}");
            }
        }

        public void ReadStudentData()// cmd4
        {
            if (!File.Exists(this.filePath))
            {
                Console.WriteLine("\nFile does not exist");
                return;
            }

            try
            {
                var students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(this.filePath));
                studentDict = students.ToDictionary(s => s.ID); // 从文件读取学生数据并转换为字典
                Console.WriteLine($"Successfully read: {this.filePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Read error: {e.Message}");
            }
        }

        public void RemoveStudent(int id) // cmd5
        {
            studentDict.Remove(id); // 删除指定ID的学生
            PrintStudent();
        }
    }
}
