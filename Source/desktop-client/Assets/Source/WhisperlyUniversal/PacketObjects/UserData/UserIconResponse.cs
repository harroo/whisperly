
public static partial class PacketId {

    public const int UserIconResponse = 5;
}

namespace Packet {

    [System.Serializable]
    public class UserIconResponse {

        public ulong userId;

        public byte[] profilePicture;
    }
}
