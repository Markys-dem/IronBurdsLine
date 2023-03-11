using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IronBurdsLine.ui
{
    public partial class BootScreen : Form
    {
        public BootScreen()
        {
            InitializeComponent();
        }
            //    BackgroundImage = Image.FromStream(new WebClient().OpenRead("https://yandex.ru/images/search?from=tabbar&text=гифка%20взлёта%20самолёта&p=2&pos=81&rpt=simage&img_url=http%3A%2F%2Fi.gifer.com%2Fembedded%2Fdownload%2FBVKF.gif&lr=2"));
            //    ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
            //}

            //private void OnFrameChanged(object sender, EventArgs e)
            //{
            //    if (InvokeRequired)
            //    {
            //        BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
            //        return;
            //    }
            //    ImageAnimator.UpdateFrames();
            //    Invalidate(false);
            //}
    }
}
