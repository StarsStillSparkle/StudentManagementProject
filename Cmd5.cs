using StudentData;
using System;

namespace CmdSystem
{
    internal class Cmd5
    {
        private StudentSystem studentSystem = StudentSystem.GetInstance();

        private int ReadStudentId()
        {
            return Cmd2.ReadInt("Please enter the student's ID to remove: "); // 读取学生ID
        }

        public void HandleCmd()
        {
            StudentSystem studentSystem = StudentSystem.GetInstance();

            int id = ReadStudentId();
            if (studentSystem.IsIdExist(id))
            {
                studentSystem.RemoveStudent(id);
                Console.WriteLine("Student removed successfully"); // 移除成功
            }
            else
            {
                Console.WriteLine("This ID does not exist."); // ID不存在
            }
        }
    }
}
