using IAGrim.UI.Misc;

namespace IAGrim.Services.MessageProcessor
{
    interface IMessageProcessor {
        void Process(MessageType type, byte[] data);
    }
}
