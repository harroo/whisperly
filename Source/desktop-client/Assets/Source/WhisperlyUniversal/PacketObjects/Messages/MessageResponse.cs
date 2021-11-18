
public static partial class PacketId {

    public const int MessageResponse = 8;
}

namespace Packet {

    [System.Serializable]
    public class MessageResponse {

        public ulong senderId;
        public string username;

        public ulong channelId;

        public string contents;
        public string timeStamp;
    }
}
