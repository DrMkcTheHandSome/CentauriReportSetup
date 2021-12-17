using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentauriReport.Shared.ErrorHandler
{
    [Serializable]
    public class CustomErrorException : Exception
    {
        public CustomErrorException()
        {

        }

        public CustomErrorException(string errorMessage) : base(string.Format("{0}", errorMessage))
        {

        }
    }
}
