using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class PubWithEventKeyword
	{
		public event Action OnChange = delegate { };
		public void Raise()
		{
			OnChange();
		}
	}
	public class UsingTheEventKeyword
	{

	}
}