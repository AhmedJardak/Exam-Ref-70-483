using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Exam_Ref_70_483.Chapter4ImplementDataAccess.Objective4._4SerializeaAndDeserializeData
{
	public class UsingJsonSerializer
	{
		public static void Execute()
		{
			var p = new Person
			{
				Id = 1,
				Name = "John Doe"
			};
			using (var stream = new MemoryStream())
			{
				var ser = new DataContractJsonSerializer(typeof (Person));
				ser.WriteObject(stream, p);
				stream.Position = 0;
				var streamReader = new StreamReader(stream);
				Console.WriteLine(streamReader.ReadToEnd()); // Displays {“Id”:1,”Name”:”John Doe”}
				stream.Position = 0;
				var result = (Person) ser.ReadObject(stream);
			}
		}
	}

	[DataContract]
	public class Person
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string Name { get; set; }
	}
}