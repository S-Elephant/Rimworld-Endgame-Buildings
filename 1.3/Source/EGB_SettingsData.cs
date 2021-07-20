using Verse;

namespace EndgameBuildings
{
    /// <summary>
    /// https://rimworldwiki.com/wiki/Modding_Tutorials/ModSettings#DoSettingsWindowContent
    /// </summary>

    public class EGB_SettingsData : ModSettings
    {
        public int HT_ResearchCost = 5000;
        public int HT_ReactorOutput = -25000;
        public float HT_FireFoamPopperRadius = 24.9f;

        /// <summary>
        /// The part that determines the definitions for loading and saving.
        /// </summary>
        public override void ExposeData()
        {
            Scribe_Values.Look(ref HT_ResearchCost, "HT_ResearchCost", 5000);
            Scribe_Values.Look(ref HT_ReactorOutput, "HT_ReactorPowerOutput", 25000);
            Scribe_Values.Look(ref HT_FireFoamPopperRadius, "HT_FireFoamPopperRadius", 24.9f);

            base.ExposeData();
        }
    }
}
