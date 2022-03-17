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
using System.Security.Permissions;

namespace VITM2_Installer
{
    /// <summary>
    /// Interaction logic for Manual_Install_Page_1.xaml
    /// </summary>
    public partial class Manual_Install_Page_1 : Window
    {
        public Manual_Install_Page_1()
        {
            InitializeComponent();
        }

        private void Install_Button_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Create loading bar for process
            
            //string minicondaexe = "Miniconda3-latest-Windows-x86_64.exe"; // TODO: update including path
            string current_path = System.IO.Directory.GetCurrentDirectory();
            string pkg_path = System.IO.Path.Combine(current_path, "pkgs");
            string miniforgeexe = "Miniforge3-Windows-x86_64.exe";  // TODO: update including path
            string dist_folder = "";

            // only use local package folder for installation
            if (!System.IO.Directory.Exists(pkg_path))
            {
                MessageBox.Show("Conda packages not found.\nPlease ensure a 'pkgs' folder has been provided with installer.");
                this.Close();
                Application.Current.Shutdown();
            } else
            {
                // if no distribution AND miniforge doesn't exist
                if (Combo_Distributor.Text.Contains("No distribution") && Utils.find_program("Miniforge") == "")
                {
                    MessageBoxResult result = MessageBox.Show("This will temporarily install Miniforge to continue environment setup, continue?", "Install Miniforge", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        // TODO install
                        if (System.IO.File.Exists(miniforgeexe))
                        {
                            // check that miniforge exe has been provided
                            // if not, update Text_Install_Missing and show **SEPARATE** browse (need new control) for selecting file
                            string local_app_data = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                            display_mini_installer();
                            if (Utils.find_program("Miniforge")!="")
                            {
                                dist_folder = Utils.find_program("Miniforge");
                            } else
                            {
                                MessageBox.Show("An issue occured while installing Miniforge");
                                this.Close();
                                Application.Current.Shutdown();
                            }
                        }
                        else
                        {
                            Text_Install_Missing.Text = "Provided Miniforge installer not found. Please provide path to Miniforge3-Windows-x86_64.exe or similar executable.";
                            Text_Install_Missing.Visibility = Visibility.Visible;
                            Distribution_Path.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Installation has been cancelled");
                        this.Close();
                        Application.Current.Shutdown();
                    }

                } // if a custom path has been given
                else if (Distribution_Path.Text != string.Empty)
                {
                    dist_folder = Distribution_Path.Text;
                } // if auto-install has been chosen but miniforge is already installed, just use that
                else if (Combo_Distributor.Text.Contains("No distribution") && Utils.find_program("Miniforge") != "")
                {
                    dist_folder = Utils.find_program("Miniforge");
                    // TODO: convert this into a prompt
                }
                else // otherwise we should be able to auto-detect distro
                {
                    // look for distribution again
                    dist_folder = Utils.find_program(Combo_Distributor.Text);
                }

                List<string> commands = new List<string>();
                string activate_script = System.IO.Path.Combine(dist_folder, "Scripts\\activate.bat");

                string index_command = "/c " + activate_script + " && conda index " + "\"" + pkg_path + "\" && echo \"activate successful\"\n\"index successful\" > \"" + current_path + "\\conda.log\"";

                commands.Add(index_command);
                // commands.Add(" && echo \"activate successful\" > \"" + current_path + "\\conda.log\"");
                // commands.Add(" && conda index " + "\"" + pkg_path + "\"");
                // commands.Add(" && echo \"index successful\" >> \"" + current_path + "\\conda.log\"");

                pkg_path = pkg_path.Replace('\\', '/');

                string create_command = "/c " + activate_script + " && conda create --prefix C:\\ASIM104 python=3.9 activitysim -c \"file:///" + pkg_path + "\" --override-channels -y >> \"" + current_path + "\\conda_create.log\"";

                // write create command for logging purposes
                System.IO.StreamWriter file = new System.IO.StreamWriter(current_path + "\\conda_create.log");
                file.WriteLine(create_command.Replace(" && ", ""));
                file.Close();

                create_command += " && echo \"create successful\" >> \"" + current_path + "\\conda.log\"";

                // commands.Add(" && conda create --prefix C:\\ASIM104 python=3.9 activitysim -c \"file:///" + pkg_path + "\" --override-channels -y >> \"" + current_path + "\\conda_create.log\"");
                // commands.Add(" && echo \"create successful\" >> \"" + current_path + "\\conda.log\"");
                commands.Add(create_command);    

                Progress_Text.Visibility = Visibility.Visible;
                Progress_Env_Create.Visibility = Visibility.Visible;

                Utils.create_environment(commands, ref Progress_Text, ref Progress_Env_Create);

                
            }

        }


        private void display_mini_installer()
        {
            Miniforge_Custom_Install mini_window = new Miniforge_Custom_Install();
            mini_window.Left = this.Left;
            mini_window.Top = this.Top + 20;
            
            mini_window.ShowDialog();
        }
        

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();

        }

        private void Combo_Distributor_DropDownClosed(object sender, EventArgs e)
        {
            // string selection = (sender as ComboBox).SelectedItem as string;
            string selection = Combo_Distributor.Text;
            if (selection!="")
            {
                string dist = Utils.find_program(selection);

                if (selection.Contains("No distribution") && Utils.find_program("Miniforge") != "")
                {
                    Text_Install_Missing.Text = "'No distribution' selected but Miniforge instance has been found. This will be used for environment setup.";
                    Text_Install_Missing.Visibility = Visibility.Visible;
                }
                else if (selection.Contains("No distribution"))
                {
                    Text_Install_Missing.Text = "'No distribution' selected. Miniforge will be temporarily installed and used to set up ActivitySim environment";
                    Text_Install_Missing.Visibility = Visibility.Visible;
                    display_mini_installer();
                }
                else if (dist.Equals(""))
                {
                    Text_Install_Missing.Text = "Install location for " + selection + " not found. Please provide the location of a " + selection + " installation:";
                    Text_Install_Missing.Visibility = Visibility.Visible;
                    Browse_Button.Visibility = Visibility.Visible;
                    Distribution_Path.Visibility = Visibility.Visible;
                }
                else
                {
                    Text_Install_Missing.Visibility = Visibility.Hidden;
                    Browse_Button.Visibility = Visibility.Hidden;
                    //Browse_File_Button.Visibility = Visibility.Hidden;
                    Distribution_Path.Visibility = Visibility.Hidden;
                }
            }

        }

        private void Browse_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fd = new System.Windows.Forms.FolderBrowserDialog();
            var result = fd.ShowDialog();
            
            if (result.ToString() != string.Empty)
            {
                Distribution_Path.Text = fd.SelectedPath;
            }
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }

}

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