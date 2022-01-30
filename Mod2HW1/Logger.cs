using System;

namespace Mod2HW1
{
    public sealed class Logger
    {
        private static readonly Logger Instance = new Logger();
        private string _logData;

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger MyInstance
        {
            get
            {
                return Instance;
            }
        }

        public string LogData
        {
            get
            {
                return _logData;
            }
        }

        public void AddLog(EventType logType, string logMessage)
        {
            string log = $"{DateTime.Now} {logType} {logMessage}\n";
            _logData = LogData + log;
            Console.WriteLine(log);
        }
    }
}
