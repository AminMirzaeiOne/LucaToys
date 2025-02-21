using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Ui.Controls
{
    public class SunnyButtonPlus : Sunny.UI.UISymbolButton
    {
        private SoundPlayer player = new SoundPlayer(Properties.Resources.LucaToysLite_Resources_ASound);
        public bool Sound { get; set; } = true;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(this.Sound)
                player.Play();
        }
    }
}
