using RimWorld;
using System;
using System.Linq;
using Verse;

namespace EndgameBuildings
{
    [StaticConstructorOnStartup] // This makes the static constructor get called AFTER defs are loaded.
    public class EGB_OnDefsLoaded
    {
        static EGB_OnDefsLoaded()
        {
            ApplySettingsToDefs();
        }

        public static void ApplySettingsToDefs()
        {
            DefDatabase<ThingDef>.GetNamed("SE_FusionReactor").comps.OfType<CompProperties_Power>().First().basePowerConsumption = -Math.Abs(EGB_Settings.Settings.HT_ReactorOutput);

            ThingDef ht_FireFoamPopper = DefDatabase<ThingDef>.GetNamed("FirefoamPopperMKII");
            ht_FireFoamPopper.comps.OfType<CompProperties_Explosive>().First().explosiveRadius = EGB_Settings.Settings.HT_FireFoamPopperRadius;
            ht_FireFoamPopper.specialDisplayRadius = EGB_Settings.Settings.HT_FireFoamPopperRadius;
        }
    }
}
