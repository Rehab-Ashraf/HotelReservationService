#region Using ...
using System;
using System.Collections.Generic;
using System.Text;
#endregion

/*
 * Generated by: CodeGenerator Version 1.0.0.0
 * Generated for: SmarttechSys
 */
namespace Framework.Common.Exceptions
{
    public class HttpResponseException : Exception
    {
        public int Status { get; set; } = 500;

        public object Value { get; set; }
    }
}