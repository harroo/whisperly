
public static partial class PacketId {

    public const int UserInfoResponse = 4;
}

namespace Packet {

    [System.Serializable]
    public class UserInfoResponse {

        public ulong userId;

        public string username;
        public string bio;
        public string joinDate;
        public string moto;

        public byte[] profilePicture;
    }
}
