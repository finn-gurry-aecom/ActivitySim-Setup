using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VITM2_Installer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        private bool simple_install;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            string install_type = "";
            // initialise window object
            if (Radio_Simple.IsChecked == true)
            {
                // simple install window
                simple_install = true;
                install_type = "Simple";
            } else
            {
                // manual install window
                simple_install = false;
                install_type = "Manual";
            }
            this.Hide();
            // set window to same location as current
            Licence_Info licence_window = new Licence_Info(install_type);
            licence_window.Left = this.Left;
            licence_window.Top = this.Top;

            licence_window.Show();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            // just close the instance
            this.Close();
            Application.Current.Shutdown();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
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


    // custom
    //          Existing Anaconda/Miniforge? (look into docker)
    //          Anaconda:
    //              install:
    //                  - try to find in path
    //                  - check %LOCALAPPDATA%
    //                  - else ask for path
    //              install local packages to predefined path
    //              
    //          Miniforge:
    //              install:
    //                  - try to find in path
    //                  - check %LOCALAPPDATA%
    //                  - else ask for path
    //              install local packages to predefined path
    //          Docker:
    //              conda or miniforge?
    //              install:
    //                  - try to find in path
    //              set up docker layer
    //              silent install
    //              install local packages to predefined path


    // After install:
    // run conda list
    // compare dependency versions
    // warn if error occured/remove environment


}
