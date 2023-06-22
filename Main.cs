using BTD_Mod_Helper;
using CardMonkeyReimagined;
using MelonLoader;

[assembly: MelonInfo(typeof(CardMonkeyReimaginedMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CardMonkeyReimagined
{
    public class CardMonkeyReimaginedMod : BloonsTD6Mod
    {
        // No Harmony Patches or hooks required for this whole tower!
    }
}