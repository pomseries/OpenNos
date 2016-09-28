﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNos.Domain;

namespace OpenNos.Handler
{
    [Header("clist")]
    class ClistPacket : PacketBase
    {

        #region Properties

        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public byte Unknown { get; set; }

        [PacketIndex(3)]
        public byte Gender { get; set; }

        [PacketIndex(4)]
        public byte HairStyle { get; set; }

        [PacketIndex(5)]
        public byte HairColor { get; set; }

        [PacketIndex(6)]
        public byte Unknown1 { get; set; }

        [PacketIndex(7)]
        public ClassType Class { get; set; }

        [PacketIndex(8)]
        public byte Level { get; set; }

        [PacketIndex(9)]
        public byte HeroLevel { get; set; }

        [PacketIndex(10)]
        public List<short?> Equipments { get; set; }

        [PacketIndex(11)]
        public byte JobLevel { get; set; }

        [PacketIndex(12)]
        public byte QuestCompletion { get; set; }

        [PacketIndex(13)]
        public byte QuestPart { get; set; }

        [PacketIndex(14)]
        public Nullable<short> Pets { get; set; }

        [PacketIndex(15)]
        public byte Unknown2 { get; set; }

        [PacketIndex(16)]
        public byte Unknown3 { get; set; }

        #endregion
    }
}
    // Session.SendPacket($"clist {character.Slot} {character.Name} 0 {character.Gender} {character.HairStyle} {character.HairColor} 0 {character.Class} {character.Level} {character.HeroLevel} {(equipment[(byte)EquipmentType.Hat] != null ? equipment[(byte)EquipmentType.Hat].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.Armor] != null ? equipment[(byte)EquipmentType.Armor].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.WeaponSkin] != null ? equipment[(byte)EquipmentType.WeaponSkin].ItemVNum : equipment[(byte)EquipmentType.MainWeapon] != null ? equipment[(byte)EquipmentType.MainWeapon].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.SecondaryWeapon] != null ? equipment[(byte)EquipmentType.SecondaryWeapon].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.Mask] != null ? equipment[(byte)EquipmentType.Mask].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.Fairy] != null ? equipment[(byte)EquipmentType.Fairy].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.CostumeSuit] != null ? equipment[(byte)EquipmentType.CostumeSuit].ItemVNum : -1)}.{(equipment[(byte)EquipmentType.CostumeHat] != null ? equipment[(byte)EquipmentType.CostumeHat].ItemVNum : -1)} {character.JobLevel}  1 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 {(equipment[(byte)EquipmentType.Hat] != null && equipment[(byte)EquipmentType.Hat].Item.IsColored ? equipment[(byte)EquipmentType.Hat].Design : 0)} 0");
    /*clist 0 Uppermost 0 0 3 7 0 2 92 1 340.-1.4903.4912.227.803.625.654 80  5 1 0.1508.0.1506.0.821.0.535.0.333.0.319.0.317.0.176.0.9.-1.-1.-1.-1.-1.-1.-1.-1 0 0*/