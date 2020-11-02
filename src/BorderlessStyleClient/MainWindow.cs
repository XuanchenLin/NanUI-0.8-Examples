using System;
using System.Collections.Generic;
using System.Text;
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;
using Xilium.CefGlue;

namespace BorderlessStyleClient
{
    class MainWindow : Formium
    {
        public override HostWindowType WindowType => HostWindowType.Borderless;
        public override string StartUrl => "https://cn.bing.com";

        public MainWindow()
        {

            MinimumSize = new System.Drawing.Size(1180, 640);

            Size = new System.Drawing.Size(1280, 720);

            Title = "NanUI 简单客户端";

            Subtitle = "第一个NanUI应用程序";

            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            BorderlessWindowProperties.ShadowEffect = ShadowEffect.DropShadow;

            LoadEnd += BrowserLoadEnd;

            DocumentTitleChanged += MainWindow_DocumentTitleChanged;
        }

        private void MainWindow_DocumentTitleChanged(object sender, NetDimension.NanUI.Browser.DocumentTitleChangedEventArgs e)
        {
            Subtitle = e.Title;
        }

        private void BrowserLoadEnd(object sender, NetDimension.NanUI.Browser.LoadEndEventArgs e)
        {
            if (e.Frame.IsMain && e.HttpStatusCode == 200)
            {
                InjectJavaScriptToBing(e.Frame);
            }
        }


        private void InjectJavaScriptToBing(CefFrame frame)
        {
            if (frame.IsMain)
            {
                // Inject custom scripts to Bing.com to make the navbar dragable. Different from other regions of Bing.com, it's work for Bing China.
                ExecuteJavaScript(@"
(function(){
var style = document.createElement(""style"");
style.type = ""text/css"";

style.innerHTML=`
#hp_sw_hdr{
    z-index:10;
}
.hp_hor_hdr {
    -webkit-app-region: drag;
    background-color:rgba(255,255,255,0.1) !important;
    backdrop-filter:blur(15px);
}
.hp_hor_hdr ul, .hp_hor_hdr #id_h  {
    -webkit-app-region: no-drag;
}
.b_header{
    -webkit-app-region: drag;
}

.b_header > * {
    -webkit-app-region: no-drag;
}
`;

document.getElementsByTagName(""HEAD"").item(0).appendChild(style);
})();
");
            }
        }

    }

}
