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
                    new Cmd1().HandleCmd(); // 显示学生
                    break;
                case 2:
                    new Cmd2().HandleCmd(); // 添加学生
                    break;
                case 3:
                    new Cmd3().HandleCmd(); // 存储学生数据
                    break;
                case 4:
                    new Cmd4().HandleCmd(); // 读取学生数据
                    break;
                case 5:
                    new Cmd5().HandleCmd(); // 删除学生数据
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
