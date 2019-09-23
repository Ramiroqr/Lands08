using System;
using System.Collections.Generic;
using System.Text;

namespace Land.Models
{
    class Response
    {
        #region Properties
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
