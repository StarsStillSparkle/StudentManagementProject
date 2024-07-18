using StudentData;
using System;

namespace CmdSystem
{
    internal class Cmd1
    {
        private StudentSystem studentSystem = StudentSystem.GetInstance();

        public void HandleCmd()
        {
            var studentDict = studentSystem.GetStudentDict();
            if (studentDict.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                studentSystem.PrintStudent(); // 打印学生信息
            }
        }
    }
}
