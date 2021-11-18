
using BlitzBit;

namespace WhisperlyServer.Network {

    public static class Server {

        public static BlitServer server;

        public static void Start () {

            server.onLog = (string message)=>{
                Logging.Log(message);
            };
            server.onWarning = (string message)=>{
                Logging.LogWarning(message);
            };
            server.onError = (string message)=>{
                Logging.LogError(message);
            };

            server.onClientConnect = ClientHandling.OnConnect;
            server.onClientDisconnect = ClientHandling.OnDisconnect;

            server.onUnknownPacket = ClientHandling.OnUnknownPacket;
        }
    }
}
