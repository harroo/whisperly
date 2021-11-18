
public static partial class PacketId {

    public const int GetMessages = 11;
}

namespace Packet {

    [System.Serializable]
    public class GetMessages {

        public ulong channelId;

        public int amount;
    }
}
