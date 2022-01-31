using System;
using System.IO;

namespace Mod2HW1
{
    public enum EventType
    {
        Info,
        Warning,
        Error,
    }

    public class Actions
    {
        public Result FirstMetod()
        {
            Logger.MyInstance.AddLog(EventType.Info, "Start method: FirstMetod");
            return new Result(true, " ");
        }

        public Result SecondMetod()
        {
            Logger.MyInstance.AddLog(EventType.Warning, "Skipped logic in method: SecondMetod");
            return new Result(true, " ");
        }

        public Result ThirdMetod()
        {
            Logger.MyInstance.AddLog(EventType.Error, " ");
            return new Result(false, message: "I broke logic");
        }
    }
}
