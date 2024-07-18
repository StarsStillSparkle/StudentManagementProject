using StudentData;

namespace CmdSystem
{
    internal class Cmd3
    {
        private StudentSystem studentSystem = StudentSystem.GetInstance();

        public void HandleCmd()
        {  
            studentSystem.StoreStudentData(); // 存储学生数据
        }
    }
}
