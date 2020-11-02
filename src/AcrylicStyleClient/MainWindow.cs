using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using NetDimension.NanUI;
using NetDimension.NanUI.HostWindow;

namespace AcrylicStyleClient
{
    class MainWindow : Formium
    {
        public override HostWindowType WindowType => HostWindowType.Acrylic;
        public override string StartUrl => "http://www.app.local/";

        public MainWindow()
        {
            Size = new Size(800, 480);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            var mainColor = ColorTranslator.FromHtml("#E83B90");

            Mask.BackColor = mainColor;

            AcrylicWindowProperties.ShadowEffect = ShadowEffect.DropShadow;
            
            AcrylicWindowProperties.ShadowColor = mainColor;



            Resizable = false;
        }

    }
}
