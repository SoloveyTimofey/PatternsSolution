using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public struct ComandStatus
    {
        public readonly bool isExecuted;
        public readonly bool isSuccessful;
        public ComandStatus(bool isExecuted, bool isSuccessfull)
        {
            this.isExecuted = isExecuted;
            this.isSuccessful = isSuccessfull;
        }
    }
}
