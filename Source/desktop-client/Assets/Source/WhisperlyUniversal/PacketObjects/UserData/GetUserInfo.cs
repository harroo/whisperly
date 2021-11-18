
public static partial class PacketId {

    public const int GetUserInfo = 2;
}

namespace Packet {

    [System.Serializable]
    public class GetUserInfo {

        public ulong userId;
        public string username;
    }
}
