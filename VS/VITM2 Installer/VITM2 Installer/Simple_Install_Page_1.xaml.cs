using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VITM2_Installer
{
    /// <summary>
    /// Interaction logic for Simple_Install_Page_1.xaml
    /// </summary>
    public partial class Simple_Install_Page_1 : Window
    {
        public Simple_Install_Page_1()
        {
            InitializeComponent();

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}

// auto or custom install
// request admin rights
// auto:
//          check temporary location
//          check predefined path
//          if files already exist at predefined path:
//              do we delete?
//                  if yes:
//                      rm predefined path
//                  if no:
//                      skip to VITM unpacking?
//          if miniforge doesn't exist:
//              silent install: 'start /wait "" build/Miniforge3-Windows-x86_64.exe /InstallationType=JustMe /RegisterPython=0 /S /D=%UserProfile%\Miniforge3'
//          install local packages to predefined path