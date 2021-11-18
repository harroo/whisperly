
public static partial class PacketId {

    public const int GetGroups = 9;
}

namespace Packet {

    [System.Serializable]
    public class GetGroups {

        public ulong userId;
    }
}
