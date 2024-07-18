using System;

namespace CmdSystem
{
    class CmdManager
    {
        private static CmdManager instance;
        private CmdManager() { }

        public static CmdManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CmdManager(); // 实例化单例对象
                }
                return instance;
            }
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nEnter 1 to display students, enter 2 to add students, enter 3 to store file data, enter 4 to read file data, enter 5 to delete student data: ");
                if (!int.TryParse(Console.ReadLine(), out int cmdId))// 转换不成功
                {
                    Console.WriteLine("\nInvalid input");
                    continue;
                }
                Console.WriteLine();
                if (!HandleCmd(cmdId))
                {
                    Console.WriteLine("\nInvalid input");
                }
            }
        }

        private bool HandleCmd(int cmdId)
        {
            switch (cmdId)
            {
                case 1: 
                    Cmd1.HandleCmd1();// 显示学生
                    return true;
                case 2:
                    Cmd2.HandleCmd2(); // 添加学生
                    return true;
                case 3:
                    Cmd3.HandleCmd3(); // 存储学生数据
                    return true;
                case 4:
                    Cmd4.HandleCmd4(); // 读取学生数据
                    return true;
                case 5:
                    Cmd5.HandleCmd5(); // 删除学生数据
                    return true;
                default:
                    return false;
            }
        }
    }
}
