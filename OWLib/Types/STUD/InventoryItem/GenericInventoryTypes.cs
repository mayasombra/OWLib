﻿using System.Runtime.InteropServices;

namespace OWLib.Types.STUD.InventoryItem {
    public enum InventoryRarity : uint {
        Common = 0,
        Rare = 1,
        Epic = 2,
        Legendary = 3
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct InventoryItemHeader {
        public STUDInstanceInfo instance;
        public OWRecord name;
        public OWRecord icon;
        public OWRecord unk1;
        public OWRecord unk2;
        public OWRecord unk3;
        public ulong unk4;
        public ulong unk5;
        public OWRecord unk6;
        public InventoryRarity rarity;
        public uint amount;
    };

    public interface IInventorySTUDInstance : ISTUDInstance {
        InventoryItemHeader Header {
            get;
        }
    }
}
