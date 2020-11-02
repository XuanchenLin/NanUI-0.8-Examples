using System;
using System.Collections.Generic;
using System.Text;
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;

namespace NativeStyleClient
{
    class MainWindow : Formium
    {
        public override HostWindowType WindowType => HostWindowType.System;
        public override string StartUrl => "https://www.formium.net";

        public MainWindow()
        {
            Size = new System.Drawing.Size(1024, 768);

            DocumentTitleChanged += MainWindow_DocumentTitleChanged;
        }

        private void MainWindow_DocumentTitleChanged(object sender, NetDimension.NanUI.Browser.DocumentTitleChangedEventArgs e)
        {
            Subtitle = e.Title;
        }
    }
}
