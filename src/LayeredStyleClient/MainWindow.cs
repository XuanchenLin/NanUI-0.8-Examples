using System;
using System.Collections.Generic;
using System.Text;
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;

namespace LayerdStyleClient
{
    class MainWindow : Formium
    {
        public override HostWindowType WindowType => HostWindowType.Layered;
        public override string StartUrl => "http://res.app.local";

        public MainWindow()
        {
            Size = new System.Drawing.Size(400, 400);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

    }
}
