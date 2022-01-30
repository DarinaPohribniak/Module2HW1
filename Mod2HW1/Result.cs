namespace Mod2HW1
{
    public class Result
    {
        private bool _status;
        private string _message;

        public Result()
        {
        }

        public bool Status
        {
            get
            {
                return _status;
            }

            set
            {
                if (value)
                {
                    _status = true;
                }
                else
                {
                    _status = false;
                }
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
