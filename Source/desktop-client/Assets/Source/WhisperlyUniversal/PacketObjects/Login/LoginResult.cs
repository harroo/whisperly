
public static partial class PacketId {

    public const int LoginResult = 1;
}

namespace Packet {

    [System.Serializable]
    public class LoginResult {

        public bool register;

        public string username;
        public string password;
    }
}
