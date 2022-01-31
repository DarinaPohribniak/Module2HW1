namespace Mod2HW1
{
    public class Result
    {
        private static bool _status;
        private static string _message;

        public Result(bool status, string message)
        {
            _status = status;
            _message = message;
        }

        public bool Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = Status;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = "I broke a logic";
            }
        }
    }
}
