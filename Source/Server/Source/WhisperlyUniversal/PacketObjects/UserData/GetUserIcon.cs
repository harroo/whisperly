
public static partial class PacketId {

    public const int GetUserIcon = 3;
}

namespace Packet {

    [System.Serializable]
    public class GetUserIcon {

        public ulong userId;
        public string username;
    }
}
