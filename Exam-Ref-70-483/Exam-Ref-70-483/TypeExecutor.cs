using System;
using System.Collections.Generic;
using System.Reflection;

namespace Exam_Ref_70_483
{
	public class TypeExecutor
	{
		private readonly IList<Type> _types;

		public TypeExecutor(IList<Type> types )
		{
			_types = types;
		}

		public void Execute()
		{
			foreach (var type in _types)
			{
				ExecuteType(type);
			}
		}

		private void ExecuteType(Type type)
		{
			MethodInfo methodInfo = type.GetMethod("Execute");
			object classInstance = Activator.CreateInstance(type, null);
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("Methode before  Execute:" + type.Name);
			Console.WriteLine("--------------------------------------");
			methodInfo.Invoke(classInstance, null);
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("Methode after  Execute:" + type.Name);
			Console.WriteLine("--------------------------------------");
		}
	}
}