using System;

namespace Exam_Ref_70_483.Chapter2CreateAndUseType.Objective2._1Createtypes
{
	public class UsingEnum
	{
		public void Execute()
		{
			var day = Days.Sat;
			if ((byte) day == 1)
			{
				Console.WriteLine("Value of Days:" + day);
			}
			FlaggedDays readingDays = FlaggedDays.Monday | FlaggedDays.Saturday;
			Console.WriteLine("Value of reading Days:" + readingDays);
		}

		[Flags]
		enum FlaggedDays
		{
			None = 0x0,
			Sunday = 0x1,
			Monday = 0x2,
			Tuesday = 0x4,
			Wednesday = 0x8,
			Thursday = 0x10,
			Friday = 0x20,
			Saturday = 0x40
		}
		
		//Enum a comme valeur de début 0 mais on peut changer le début à un autre valeur.
		private enum Days : byte
		{
			Sat = 1,
			Sun,
			Mon,
			Tue,
			Wed,
			Thu,
			Fri
		}
	}
}