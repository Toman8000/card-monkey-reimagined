using System.Collections.Generic;
using System.Linq;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using CardMonkeyReimagined.Displays.Projectiles;

namespace CardMonkeyReimagined
{
    /// <summary>
    /// The main class that adds the core tower to the game
    /// </summary>
    public class CardMonkeyReimagined : ModTower
    {
        // public override string Portrait => "Don't need to override this, using the default of Name-Portrait";
        // public override string Icon => "Don't need to override this, using the default of Name-Icon";

        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 510;

        public override int TopPathUpgrades => 3;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 4;
        public override string Description => "Throws playing cards at Bloons";

        // public override string DisplayName => "Don't need to override this, the default turns it into 'Card Monkey'"

        //public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;

            var projectile = attackModel.weapons[0].projectile;
            projectile.ApplyDisplay<RedCardDisplay>(); // Make the projectiles look like Cards
            projectile.pierce += 2;
        }

        /// <summary>
        /// Make Card Monkey go right after the Boomerang Monkey in the shop
        /// <br />
        /// If we didn't have this, it would just put it at the end of the Primary section
        /// </summary>
        public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
        {
            return towerSet.First(model => model.towerId == TowerType.WizardMonkey).towerIndex + 1;
        }

        /// <summary>
        /// Support the Ultimate Crosspathing Mod
        /// <br />
        /// That mod will handle actually allowing the upgrades to happen in the UI
        /// </summary>
        public override bool IsValidCrosspath(int[] tiers) =>
            ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
    }
}