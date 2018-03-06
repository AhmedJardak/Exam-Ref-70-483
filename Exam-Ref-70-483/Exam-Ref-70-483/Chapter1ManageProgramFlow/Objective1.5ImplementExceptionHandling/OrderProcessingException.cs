using System;
using System.Runtime.Serialization;

namespace Exam_Ref_70_483.Chapter1ManageProgramFlow.Objective1._5ImplementExceptionHandling
{
	[Serializable]
	public class OrderProcessingException : Exception, ISerializable
	{
		public OrderProcessingException(int orderId)
		{
			OrderId = orderId;
			HelpLink = "http://www.mydomain.com/infoaboutexception";
		}

		public OrderProcessingException(int orderId, string message)
			: base(message)
		{
			OrderId = orderId;
			HelpLink = "http://www.mydomain.com/infoaboutexception";
		}

		public OrderProcessingException(int orderId, string message,
			Exception innerException)
			: base(message, innerException)
		{
			OrderId = orderId;
			HelpLink = "http://www.mydomain.com/infoaboutexception";
		}

		protected OrderProcessingException(SerializationInfo info, StreamingContext context)
		{
			OrderId = (int) info.GetValue("OrderId", typeof(int));
		}

		public int OrderId { get; set; }

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("OrderId", OrderId, typeof(int));
		}
	}
}