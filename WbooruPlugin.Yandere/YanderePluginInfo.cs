using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wbooru.Kernel.Updater;
using Wbooru.PluginExt;
using Wbooru.Utils;

namespace WbooruPlugin.Yandere
{
    [Export(typeof(PluginInfo))]
    public class YanderePluginInfo : PluginInfo, IPluginUpdatable
    {
        public Version CurrentPluginVersion => GetType().Assembly.GetName().Version;

        public override string PluginName => "Yandere Image Source Plugin";

        public override string PluginAuthor => "MikiraSora";

        public override string PluginDescription => "The plugin could provide image and related functions.";

        public override string PluginProjectWebsite => @"https://github.com/MikiraSora/WbooruPlugin.Yandere";

        public IEnumerable<ReleaseInfo> GetReleaseInfoList()
        {
            return UpdaterHelper.GetGithubAllReleaseInfoList("MikiraSora","WbooruPlugin.Yandere");
        }
    }
}
