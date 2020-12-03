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

        //public bool ExampleBool;
        //public float ExampleFloat = 200f;
        //public string BedLabel;
        //public ThingDef BedThing;

        //public int BedCost = 10;

        /// <summary>
        /// The part that determines the definitions for loading and saving.
        /// </summary>
        public override void ExposeData()
        {
            Scribe_Values.Look(ref HT_ResearchCost, "HT_ResearchCost", 5000);
            Scribe_Values.Look(ref HT_ReactorOutput, "HT_ReactorPowerOutput", 25000);
            Scribe_Values.Look(ref HT_FireFoamPopperRadius, "HT_FireFoamPopperRadius", 24.9f);

            //Scribe_Values.Look(ref ExampleBool, "exampleBool");
            //Scribe_Values.Look(ref ExampleFloat, "exampleFloat", 200f);
            //Scribe_Values.Look(ref BedLabel, "bedlabel");
            //Log.Warning("--------------------- LOAD (or save?) --------------------");
            //var bedef = DefDatabase<ThingDef>.GetNamed("Bed");
            //Scribe_Defs.Look(ref bedef, "BedThing");//
            //var test = DefDatabase<ThingDef>.GetNamed("Bed");
            //DefDatabase<ThingDef>.ResolveAllReferences();

            // WHERE TERHUTHW IOTHWERPO TJWP TO PUT THIS LINE?
            //DefDatabase<ThingDef>.GetNamed("Bed").label = BedLabel;

            // = "Bart";

            //if (DefDatabase<ThingDef>.GetNamed("Bed") != null)
            //{
            //    Scribe_Values.Look(ref BedLabel, "bed label", "Testing beds");
            //}
            //Scribe_Values.Look(ref DefDatabase<ThingDef>.GetNamed("Bed").costList[0].count);
            base.ExposeData();

            //
        }
    }
}
