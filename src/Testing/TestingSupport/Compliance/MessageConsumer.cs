using System;
using Wolverine;
using Wolverine.Attributes;
using TestMessages;

namespace TestingSupport.Compliance
{
    public class MessageConsumer
    {


        public void Consume(Message1 message, Envelope envelope)
        {
        }

        [RequeueOn(typeof(DivideByZeroException))]
        public void Consume(Message2 message, Envelope envelope)
        {
            if (envelope.Attempts < 2) throw new DivideByZeroException();

        }

        public void Consume(TimeoutsMessage message, Envelope envelope)
        {
            if (envelope.Attempts < 2) throw new TimeoutException();

        }
    }
}