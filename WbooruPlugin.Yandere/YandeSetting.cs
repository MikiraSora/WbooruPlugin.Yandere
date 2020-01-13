using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wbooru.Settings;
using Wbooru.Settings.UIAttributes;

namespace WbooruPlugin.Yandere
{
    [Export(typeof(SettingBase))]
    public class YandeSetting:SettingBase
    {
        [NeedRestart]
        [Group("View Options")]
        [Description("每次加载图片信息的数量,0代表采用软件GlobalSetting的GetPictureCountPerLoad选项")]
        [Range(0,100)]
        public int PicturesCountPerRequest { get; set; } = 20;

        [NeedRestart]
        [Group("View Options")]
        [Description("钦定Questionable评价的图片也算是NSFW内容")]
        public bool QuestionableIsNSFW { get; set; } = true;

        /// <summary>
        /// 3是Favourite,只有此值才能添加用户到图片的喜爱列表然后判断是否Vote
        /// </summary>
        [Group("Vote Options")]
        [Description("投票默认值")]
        [Range(1, 3)]
        public int VoteValue { get; set; } = 3;
    }
}
