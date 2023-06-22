using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using CardMonkeyReimagined.Displays.Projectiles;

namespace CardMonkeyReimagined.Upgrades.MiddlePath
{
    public class AcesWild : ModUpgrade<CardMonkeyReimagined>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 1500;

        public override string DisplayName => "Aces Wild";

        public override string Description =>
            "Powerful Ace cards do more damage, further increased against Ceramic and Fortified Bloons.";

        public override string Portrait => "CardMonkeyReimagined-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var projectile in tower.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                projectile.GetDamageModel().damage++;
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic",
                    1, 3, false, false));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortified",
                    1, 3, false, false));
                projectile.ApplyDisplay<WildAceCardDisplay>();
            }
        }
    }
}