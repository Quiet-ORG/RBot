using RBot.Flash;

namespace RBot
{
    public class ScriptLite : ScriptableObject
    {
        [ObjectBinding("litePreference.data.bDebugger")]
        public bool Debugger { get; set; }

        [ObjectBinding("litePreference.data.bHideUI")]
        public bool HideUI { get; set; }

        [ObjectBinding("litePreference.data.bMonsType")]
        public bool ShowMonsterType { get; set; }

        [ObjectBinding("litePreference.data.bSmoothBG")]
        public bool SmoothBackground { get; set; }

        [ObjectBinding("litePreference.data.bUntargetSelf")]
        public bool UntargetSelf { get; set; }

        [ObjectBinding("litePreference.data.bUntargetDead")]
        public bool UntargetDead { get; set; }

        [ObjectBinding("litePreference.data.bDisSkillAnim")]
        public bool DisableSkillAnimations { get; set; }

        [ObjectBinding("litePreference.data.bCustomDrops")]
        public bool CustomDropsUI { get; set; }

        [ObjectBinding("litePreference.data.bReaccept")]
        public bool ReacceptQuest { get; set; }

        [ObjectBinding("litePreference.data.bBattlepet")]
        public bool BattlePet { get; set; }

        [ObjectBinding("litePreference.data.bSkillCD")]
        public bool SkillCoolDown { get; set; }

        /// <summary>
        /// Returns a lite option bool.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="optionName"></param>
        /// <returns>optionName</returns>
        public T Get<T>(string optionName)
        {
            return Bot.GetGameObject<T>($"litePreference.data.{optionName}");
        }

        /// <summary>
        /// Set your own lite settings.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void Set<T>(string optionName, T value)
        {
            Bot.SetGameObject($"litePreference.data.{optionName}", value);
        }
    }
}