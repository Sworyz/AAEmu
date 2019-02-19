﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCTimeOfDayPacket : GamePacket
    {
        private readonly float _time;

        public SCTimeOfDayPacket(float time) : base(0x0ee, 1)
        {
            _time = time;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_time);
            return stream;
        }
    }
}
