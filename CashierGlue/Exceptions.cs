using System;
using System.Collections.Generic;
using System.Text;

namespace CashierGlue
{
    class NoteSerialzationFailedException: Exception
    {
        public NoteSerialzationFailedException() { }

        public NoteSerialzationFailedException(string message) : base(message) { }

        public NoteSerialzationFailedException(string message, Exception inner) { }
    }
}
