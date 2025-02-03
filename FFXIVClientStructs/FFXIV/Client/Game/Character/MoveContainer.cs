namespace FFXIVClientStructs.FFXIV.Client.Game.Character;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x430)]
public unsafe partial struct MoveContainer {
    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public unsafe partial struct InterpolationState {
        [FieldOffset(0x10)] public float DesiredRotation;
        [FieldOffset(0x14)] public float OriginalRotation;
        [FieldOffset(0x40)] public bool RotationInterpolationInProgress;
    }

    [FieldOffset(0x1C0)] public InterpolationState Interpolation;
}
