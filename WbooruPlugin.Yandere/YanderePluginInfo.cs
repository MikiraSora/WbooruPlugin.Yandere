using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wbooru.Kernel.ProgramUpdater;
using Wbooru.PluginExt;
using Wbooru.Utils;

namespace WbooruPlugin.Yandere
{
    public class YanderePluginInfo : PluginInfo, IPluginUpdatable
    {
        public Version CurrentPluginVersion => GetType().Assembly.GetName().Version;

        public override string PluginName => "Yandere Image Source Plugin";

        public override string PluginAuthor => "MikiraSora";

        public override string PluginDescription => "The plugin could provide image and related functions.";

        public IEnumerable<ReleaseInfo> GetReleaseInfoList()
        {
            return UpdaterHelper.GetGithubAllReleaseInfoList("");
        }
    }
}
