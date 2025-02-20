using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Ui.Controls
{
    internal class SunnyFormPlus : Sunny.UI.UIForm
    {

        public enum StartupSounds { None, SplashSound, LoginSound }

        private StartupSounds startupSounds = StartupSounds.None;
        private SoundPlayer player = new SoundPlayer();
        public System.Boolean Animation { get; set; } = true;

        public StartupSounds StartupSound
        {
            get { return this.startupSounds; }
            set
            {
                this.startupSounds = value;
            }
        }

    }
}
