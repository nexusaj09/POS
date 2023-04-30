using System.ComponentModel;

namespace POS.Enumerators
{
    public enum TopupType
    {
        [Description("Top-up GCash")]
        TopupGCash = 1,
        [Description("Top-up Drawer")]
        TopupDrawer = 2
    }
}
