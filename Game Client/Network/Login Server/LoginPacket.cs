﻿using Elysium_Diamond.Common;

namespace Elysium_Diamond.Network {
    public static class LoginPacket {
        /// <summary>
        /// Envia o nome de usuário e senha
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void Login(string username, string password) {
            var buffer = NetworkSocket.CreateMessage();
            buffer.Write((short)PacketList.CL_LS_Login);
            buffer.Write(Configuration.GAME_VERSION);
            buffer.Write(Configuration.ClientSerial);
            buffer.Write(username);
            buffer.Write(password);
            NetworkSocket.SendData(SocketEnum.LoginServer, buffer);
        }

        /// <summary>
        /// Volta para a tela de login
        /// </summary>
        public static void BackToLogin() {
            var buffer = NetworkSocket.CreateMessage();
            buffer.Write((short)PacketList.CL_LS_BackToLogin);
            NetworkSocket.SendData(SocketEnum.LoginServer, buffer);
        }

        /// <summary>
        /// Envia o id do servidor para conexão
        /// </summary>
        /// <param name="index"></param>
        public static void ConnectWorldServer(int index) {
            var buffer = NetworkSocket.CreateMessage();
            buffer.Write((short)PacketList.CL_LS_WorldServerConnect);
            buffer.Write(index);
            NetworkSocket.SendData(SocketEnum.LoginServer, buffer);
        }

    }
}
