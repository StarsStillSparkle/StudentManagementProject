using StudentData;
using System;

namespace CmdSystem
{
    internal class Cmd1
    {
        public static void HandleCmd1()
        {
            StudentSystem.GetInstance().PrintStudent(); 
        }
    }
}
