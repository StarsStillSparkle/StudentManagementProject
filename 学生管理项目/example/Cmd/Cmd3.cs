using StudentData;

namespace CmdSystem
{
    internal class Cmd3
    {
        public static void HandleCmd3()
        {
            StudentSystem.GetInstance().StoreStudentData(); // 存储学生数据
        }
    }
}
