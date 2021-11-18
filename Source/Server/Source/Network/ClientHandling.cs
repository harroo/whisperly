
namespace WhisperlyServer.Network {

    public static class ClientHandling {

        public static void OnConnect (int clientId) {

        }

        public static void OnDisconnect (int clientId) {

        }

        public static void OnUnknownPacket (int clientId, int packetId, byte[] data) {

            Logging.LogWarning(
                "Unknown Packet of type `" + packetId.ToString() +
                "' from `" + clientId.ToString() +
                "' with a length of `" + data.Length + "'."
            );
        }
    }
}
