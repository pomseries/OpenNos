﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject.Packets.ServerPackets
{
    [Header("put")]
    public class PutPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte InventoryId { get; set; }

        [PacketIndex(1)]
        public byte Slot { get; set; }

        [PacketIndex(2)]
        public long ItemId { get; set; }

        [PacketIndex(3)]
        public long Number { get; set; }

        #endregion
    }
}