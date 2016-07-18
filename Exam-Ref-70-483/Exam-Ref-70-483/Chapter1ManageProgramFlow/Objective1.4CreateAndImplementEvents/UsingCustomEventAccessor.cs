using System;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._4CreateAndImplementEvents
{
	public class UsingCustomEventAccessor
	{
		private class Pub
		{
			private event EventHandler<MyArgs> onChange = delegate { };
			public event EventHandler<MyArgs> OnChange
			{
				add
				{
					lock (onChange)
					{
						onChange += value;
					}
				}
				remove
				{
					lock (onChange)
					{
						onChange -= value;
					}
				}
			}
			public void Raise()
			{
				onChange(this, new MyArgs(42));
			}
		}

		private class MyArgs
		{
			private int _v;

			public MyArgs(int v)
			{
				this._v = v;
			}
		}
	}

	
}