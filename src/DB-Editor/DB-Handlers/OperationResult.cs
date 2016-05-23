using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace DB_Editor.DB_Handlers
{
    public struct OperationResult
    {
        private bool isSucceded_;
        private Exception exception_;
        public OperationResult(bool result, Exception exc)
        {
            isSucceded_ = result;
            exception_ = exc;
        }
        public bool IsSucceded { get { return isSucceded_; }}
        public Exception Exception { get { return exception_; }}
    };
}
