using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkeyReimagined.Upgrades.BottomPath
{
    public class CardCounting : ModUpgrade<CardMonkeyReimagined>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 300;

        public override string Description => "Throws cards faster";

        public override string Portrait => "CardMonkeyReimagined-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.Rate *= .666666f;
            }
        }
    }
}