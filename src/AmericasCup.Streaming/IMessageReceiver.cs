using AmericasCup.Streaming.Messages;

namespace AmericasCup.Streaming
{
    public interface IMessageReceiver
    {
        void OnMessageReceived(Message msg);
    }
}

