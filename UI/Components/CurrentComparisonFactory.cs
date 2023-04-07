using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class CurrentComparisonFactory : IComponentFactory
    {
        public string ComponentName => "Comparaison Actuelle";

        public string Description => "Affiche la comparaison actuelle des splits.";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new CurrentComparison(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.CurrentComparison.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.8.16");
    }
}
