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
    /// Interaction logic for Miniforge_Custom_Install.xaml
    /// </summary>
    public partial class Miniforge_Custom_Install : Window
    {
        private string miniforge_standard_exe = "";
        private string miniforgeexe = "";
        public Miniforge_Custom_Install()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string current_path = System.IO.Directory.GetCurrentDirectory();
            string miniforge_path = System.IO.Path.Combine(current_path, "Miniforge");
            miniforgeexe = System.IO.Path.Combine(miniforge_path, miniforge_standard_exe);
            if (System.IO.File.Exists(miniforgeexe))
            {
                Text_Install_Missing.Text = "Miniforge installer found, install?";
                Browse_File_Button.Visibility = Visibility.Hidden;
                Distribution_Path.Visibility = Visibility.Hidden;
            } else
            {
                // we need to prompt for installer
                Browse_File_Button.Visibility = Visibility.Visible;
                Distribution_Path.Visibility = Visibility.Visible;
            }
        }

        private void Install_Button_Click(object sender, RoutedEventArgs e)
        {
            if(System.IO.File.Exists(Distribution_Path.Text))
            {
                miniforgeexe = Distribution_Path.Text;
            }

            if (System.IO.File.Exists(miniforgeexe))
            {
                Text_Install_Missing.IsEnabled = false;
                Browse_File_Button.IsEnabled = false;
                Distribution_Path.IsEnabled = false;

                string local_app_data = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                Progress_Mini_Install.Visibility = Visibility.Visible;
                Utils.install_miniforge(miniforgeexe, local_app_data);
                Progress_Mini_Install.IsIndeterminate = false;
                if (Utils.validate_distro(local_app_data + "\\Miniforge3"))
                {
                    MessageBox.Show("Miniforge successfully installed.");
                }
                else
                {
                    MessageBox.Show("An issue has occurred installing Miniforge.\n\n" + 
                        "If you have provided your own installer please ensure it is correct.\n\n" + 
                        "This installer will now close.");
                }
            } else
            {

            }


            
        }

        private void Browse_File_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new System.Windows.Forms.OpenFileDialog();
            fd.Filter = "Executable files (*.exe)|*.exe";
            System.Windows.Forms.DialogResult result = fd.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                miniforgeexe = fd.FileName;
            }

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
