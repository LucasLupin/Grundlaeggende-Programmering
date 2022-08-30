namespace FiskOop
{
    internal sealed class SaltWater : FishInfo
    {
        public List<SaltColor> SaltColors { get; set; } = new();
    }

    internal class SaltColor : FishInfo
    {
        public string? whatcolor { get; set; }
    }
}