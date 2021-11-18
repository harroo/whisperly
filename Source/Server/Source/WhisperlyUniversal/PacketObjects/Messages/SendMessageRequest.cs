
public static partial class PacketId {

    public const int SendMessageRequest = 6;
}

namespace Packet {

    [System.Serializable]
    public class SendMessageRequest {

        public ulong userId;

        public ulong channelId;

        public string contents;
    }
}
