using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTL;

namespace FableWorld
{
    public class ContextManager
    {
        private static ContextManager _contextManager { get; set; }
        private ContextManager()
        {
            ActiveAccountID = 1;
        }

        public static ContextManager Current 
        { 
            get
            {
                if (_contextManager == null)
                    _contextManager = new ContextManager();

                return _contextManager;
            }
        }

        public Int32 ActiveAccountID { get; set; }
    }
}
