namespace Lands.Models
{
    class Response
    {
        #region Methos
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }
        #endregion
    }
}
