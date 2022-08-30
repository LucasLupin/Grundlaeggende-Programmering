namespace FiskOop
{
    internal sealed class FreshWater : FishInfo
    {
        public List<FreshColor> FreshColors { get; set; } = new();
    }

    internal class FreshColor : FishInfo
    {
        public string? whatcolor { get; set; }
    }
}
