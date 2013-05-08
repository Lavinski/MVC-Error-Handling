using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorHandler.Exceptions
{
	public class BusinessException : Exception
	{
		public BusinessException(string message)
			: base(message)
		{

		}

		public BusinessException(string message, Exception inner)
			: base(message, inner)
		{

		}
	}
}