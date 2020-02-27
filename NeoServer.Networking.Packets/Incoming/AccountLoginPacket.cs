﻿using System;
using NeoServer.Networking.Packets.Outgoing;
using NeoServer.Server.Handlers;
using NeoServer.Server.Handlers.Authentication;
using NeoServer.Server.Model;
using NeoServer.Server.Security;

namespace NeoServer.Networking.Packets.Incoming
{
    public class AccountLoginPacket : IncomingPacket
    {

        public AccountLoginPacket(NetworkMessage message, AccountLoginEventHandler handler) : base(handler)
        {
            var packetPayload = message.GetUInt16();
            var tcpPayload = packetPayload + 2;
            message.SkipBytes(7);
            //var os = message.GetUInt16();
            Version = message.GetUInt16();

            message.SkipBytes(12);

            //// todo: version validation
            
            var encryptedData = message.GetBytes(tcpPayload - message.BytesRead);
            var data = new NetworkMessage(RSA.Decrypt(encryptedData));

            LoadXtea(data);

            Model = new Account(data.GetString(), data.GetString());

        }

        public int Version { get; }
        public override IServerModel Model { get; }

        public override Func<IServerModel, OutgoingPacket> OutputFunc => (model) => new CharacterListPacket((Account)model);
        
    }
}