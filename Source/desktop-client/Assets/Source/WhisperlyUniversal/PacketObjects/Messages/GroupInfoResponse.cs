
public static partial class PacketId {

    public const int GroupInfoResponse = 10;
}

namespace Packet {

    [System.Serializable]
    public class GroupInfoResponse {

        public Group[] groups;

        public class Group {

            public string name;

            public ulong Id;
        }
    }
}
