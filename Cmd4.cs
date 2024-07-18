using StudentData;

namespace CmdSystem
{
    internal class Cmd4
    {
        public static void HandleCmd4()
        {
            StudentSystem.GetInstance().ReadStudentData(); // 读取学生数据
        }
    }
}
