using UnityEngine;
using Verse;

namespace EndgameBuildings
{
    public class EGB_Settings : Mod
    {
        public static EGB_SettingsData Settings;
        private const float MAX_FIREFOAM_POPPER_RADIUS = 56.0f;

        /// <summary>
        /// A mandatory constructor.
        /// </summary>
        public EGB_Settings(ModContentPack content) : base(content)
        {
            Settings = GetSettings<EGB_SettingsData>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();
            ls.Begin(inRect);

            string bufferResCost = Settings.HT_ResearchCost.ToString();
            ls.TextFieldNumericLabeled<int>("EGB_HTResearchCost".Translate(), ref Settings.HT_ResearchCost, ref bufferResCost, 0, 100000);

            string bufferReactorOutput = Settings.HT_ReactorOutput.ToString();
            ls.TextFieldNumericLabeled<int>("EGB_HTReactorOutput".Translate(), ref Settings.HT_ReactorOutput, ref bufferReactorOutput, 1, 1000000);

            string bufferPopper = Settings.HT_FireFoamPopperRadius.ToString();
            ls.TextFieldNumericLabeled<float>("EGB_HT_FireFoamPopperRadius".Translate() + Settings.HT_FireFoamPopperRadius.ToString(), ref Settings.HT_FireFoamPopperRadius, ref bufferPopper, 1.0f, MAX_FIREFOAM_POPPER_RADIUS);
            Settings.HT_FireFoamPopperRadius = ls.Slider(Settings.HT_FireFoamPopperRadius, 1.0f, MAX_FIREFOAM_POPPER_RADIUS); // Max allowed by game: 56.6f.

            //ls.CheckboxLabeled("aa".Translate(), ref Settings.ExampleBool, "exampleBoolToolTip");

            //ls.Label("exampleFloatExplanation");
            //Settings.ExampleFloat = ls.Slider(Settings.ExampleFloat, 100f, 300f);

            //Settings.BedLabel = ls.TextEntryLabeled("Bedlabel", Settings.BedLabel);
            EGB_OnDefsLoaded.ApplySettingsToDefs();

            ls.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// <summary>
        /// This is the name as how it'll appear ain the game's settings menu.
        /// </summary>
        public override string SettingsCategory()
        {
            return "EGB_SettingsCategory".Translate();
        }
    }
}
