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
        private readonly Logger _logger = Logger.MyInstance;
        private readonly Result _result = new Result();

        public Result FirstMetod()
        {
            _logger.AddLog(EventType.Info, "Start method: FirstMetod");
            _result.Status = true;
            _result.Message = " ";
            return _result;
        }

        public Result SecondMetod()
        {
            _logger.AddLog(EventType.Warning, "Skipped logic in method: SecondMetod");
            _result.Status = true;
            _result.Message = " ";
            return _result;
        }

        public Result ThirdMetod()
        {
            _logger.AddLog(EventType.Error, " ");
            _result.Status = false;
            _result.Message = "I broke a logic";
            return _result;
        }

        public void ExportToFile()
        {
           File.WriteAllText("log.txt", _logger.LogData);
        }

        public void LogError(string errorMes)
        {
            _logger.AddLog(EventType.Error, $"Action failed by a reason: {errorMes}");
        }
    }
}
