namespace FFXIVClientStructs.FFXIV.Client.Game.UI;

[StructLayout(LayoutKind.Explicit, Size = 0x908)]
[GenerateInterop]
public unsafe partial struct Hater {
    [FieldOffset(0x00)][FixedSizeArray] internal FixedSizeArray32<HaterInfo> _haterArray;
    [FieldOffset(0x900)] public int HaterArrayLength;
}

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public unsafe partial struct HaterInfo {
    [FieldOffset(0x00), FixedSizeArray(isString: true)] internal FixedSizeArray64<byte> _name;
    [FieldOffset(0x40)] public uint ObjectId;
    [FieldOffset(0x44)] public int Enmity;
}
