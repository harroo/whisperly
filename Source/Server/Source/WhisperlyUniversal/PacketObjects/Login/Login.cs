
public static partial class PacketId {

    public const int Login = 0;
}

namespace Packet {

    [System.Serializable]
    public class Login {

        public bool register;

        public string username;
        public string password;
    }
}
