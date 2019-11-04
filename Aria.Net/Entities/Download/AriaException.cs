using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria.Net.Entities.Download
{
	public class AriaException : Exception
	{
		public AriaException(int code, string message)
		{
			this.Code = code;
			this.Message = message;
		}

		public int Code { get; }
		public string Message { get; }
	}
}
