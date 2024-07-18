using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace StudentData
{
    public class Student
    {
        public int ID { get; set; } // 学生ID
        public string Name { get; set; } // 学生姓名
        public int Age { get; set; } // 学生年龄

        public Student() { }

        
        [JsonConstructor]// [JsonConstructor] 属性：告诉JSON反序列化器在反序列化时使用标记的构造函数
        public Student(int id, string name, int age)// 反序列化：将JSON字符串反序列化为对象
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public Student(JObject jObject)// 从JSON对象初始化类实例
        {
            ID = jObject.Value<int>("id");
            Name = jObject.Value<string>("name");
            Age = jObject.Value<int>("age");
        }

        public Student(string line)
        {
            var parts = line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ID = int.Parse(parts[0].Split(':')[1]);
            Name = parts[1].Split(':')[1];
            Age = int.Parse(parts[2].Split(':')[1]);
        }

        public override string ToString()
        {
            return $"ID:{ID}, Name:{Name}, Age:{Age}"; // 返回学生信息字符串
        }
    }
}

