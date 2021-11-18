
using System;
using System.IO;
using System.Collections.Generic;

using UltimateSerializer;

using WhisperlyServer.Network;

namespace WhisperlyServer.Messages {

    public static class Manager {

        public static void Init () {

            EnsureDirectory("chats");
        }

        public static void InitPackets () {

            Server.server.AddPacketT(PacketId.SendMessageRequest, OnMessageRequest);
            Server.server.AddPacketT(PacketId.GetGroups, OnGetGroups);
        }

        private static void OnMessageRequest (int senderId, object raw) {

            Packet.SendMessageRequest sendMessageRequest = (Packet.SendMessageRequest)raw;

            Packet.MessageResponse messageResponse = new Packet.MessageResponse();
            messageResponse.senderId = 0; //TEMP we dont have user id ssytem yet like accounts
            messageResponse.username = ""; // \/
            messageResponse.channelId = sendMessageRequest.channelId;
            messageResponse.contents = sendMessageRequest.contents;
            messageResponse.timeStamp = DateTime.Now.ToString();

            Server.server.RelayAllT(PacketId.MessageResponse, messageResponse);

            string directoryName = "chats/" + sendMessageRequest.channelId.ToString();
            EnsureDirectory(directoryName);
            int count = Directory.GetFiles(directoryName).Length;

            byte[] data = USerialization.Serialize(messageResponse);
            File.WriteAllBytes(directoryName + "/" + count.ToString(), data);
        }

        private static void OnGetGroups (int senderId, object raw) {

            Packet.GetGroups getGroups = (Packet.GetGroups)raw;
        }


        private static void EnsureDirectory (string d) {

            if (!Directory.Exists(d))
                Directory.CreateDirectory(d);
        }
    }
}
