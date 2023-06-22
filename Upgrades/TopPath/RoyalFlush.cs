using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkeyReimagined.Upgrades.TopPath
{
    public class RoyalFlush : ModUpgrade<CardMonkeyReimagined>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 20000;
        public override int Priority => -2;

        public override string Description => "Cards do 10, 11, 12, 13 and 14 damage.";

        public override string Portrait => "CardMonkeyReimagined-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.range += 10;
            tower.GetAttackModel().range += 10;
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.GetDamageModel().damage += 10;
            }
        }
    }
}