# amcup-streaming
America's Cup data streaming

## Example of usage
```csharp
  public class MessageReceiver : IMessageReceiver
    {
        public void OnMessageReceived(Message message)
        {
            System.Console.WriteLine("{0} {1} {2}", 
                message.Header.SourceId,
                message.Header.TimeStamp, 
                message.Header.Type
            );
        }
    }
    
  class Program
    {
        static void Main()
        {
            StreamingGateway gateway = new StreamingGateway(new MessageReceiver());
            IStreamingSource source =  new FileSource("test.dump");
            gateway.Connect(source);

            System.Console.ReadLine();
        }

    }
```
    
    
