using StudentData;

namespace CmdSystem
{
    internal class Cmd4
    {
        private StudentSystem studentSystem = StudentSystem.GetInstance();

        public void HandleCmd()
        {
            studentSystem.ReadStudentData(); // 读取学生数据
        }
    }
}
