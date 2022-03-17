using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Windows;

namespace VITM2_Installer
{
    class Utils
    {
        public static bool install_miniforge(string miniforgeexe, string install_folder)
        {
            string install_command = "start /wait \"\" " + miniforgeexe + " /InstallationType=JustMe /RegisterPython=0 /S /D=" + install_folder + "\\Miniforge3";
            System.Diagnostics.Process.Start("CMD.exe", install_command);

            if (validate_distro(install_folder + "\\Miniforge3"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Small validation function to check distribution is OK to use.
        /// </summary>
        /// <param name="dist_folder">path to main distribution folder</param>
        /// <returns>
        /// True if folder passes check, False otherwise
        /// </returns>
        /// <remarks>
        /// Only checks that folder exists and that activate.bat script is present.
        /// </remarks>
        public static bool validate_distro(string dist_folder)
        {
            // if distribution folder exists and activate script is there, we call it a win.
            if (System.IO.Directory.Exists(dist_folder) && System.IO.File.Exists(System.IO.Path.Combine(dist_folder, "Scripts\\activate.bat")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Attempts to auto-detect location of python distribution service (i.e. Anaconda/Miniconda).
        /// </summary>
        /// <param name="program">Application to search for (Miniconda/Anaconda)</param>
        /// <returns>
        /// Path of distribution if found, otherwise empty string.
        /// </returns>
        /// <remarks>
        /// Searches commonly used locations for installation.
        /// </remarks>
        public static string find_program(string program)
        {
            string location = "";   // final location of program folder
            // convenience variables for %localappdata% and %userprofile%
            string local_app_data = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string personal_folder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Do application-specific checks
            if (program == "Miniforge")
            {
                #if DEBUG
                check_path("Miniforge");
                #endif


                if (System.IO.Directory.Exists(personal_folder + "\\Miniforge3"))
                {
                    location = personal_folder + "\\Miniforge3";
                }
                else if (System.IO.Directory.Exists(local_app_data + "\\miniforge3"))
                {
                    location = local_app_data + "\\miniforge3";
                }
                else if (check_path("Miniforge") != "")
                {
                    location = check_path("Miniforge");
                }
            }
            else if (program == "Anaconda")

                
            {
                #if DEBUG
                check_path("Anaconda");
                #endif

                if (System.IO.Directory.Exists(personal_folder + "\\Continuum\\anaconda3"))
                {
                    location = personal_folder + "\\Continuum\\anaconda3";
                }
                else if (System.IO.Directory.Exists(local_app_data + "\\Continuum\\anaconda3"))
                {
                    location = local_app_data + "\\Continuum\\anaconda3";
                }
                else if (System.IO.Directory.Exists(local_app_data + "\\Anaconda3"))
                {
                    location = local_app_data + "\\Anaconda3";
                }
                else if (check_path("Anaconda") != "")
                {
                    location = check_path("Anaconda");
                }

            }

            return location;
        }

        private static void update_status(string file, ref System.Windows.Controls.TextBlock tb)
        {
            // read file
            System.IO.StreamReader file_obj = System.IO.File.OpenText(file);
            string text = file_obj.ReadToEnd();

            if (text.Contains("create"))
            {
                tb.Text = "Environment successfully created";
            } 
            else if (text.Contains("index"))
            {
                tb.Text = "Creating environment...";
            }
            else if (text.Contains("activate"))
            {
                tb.Text = "Indexing 'pkg' directory...";
            } else
            {
                tb.Text = "Activating conda...";
            }

                
        }

        //[PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        public static bool create_environment(List<string> commands, ref System.Windows.Controls.TextBlock tb, ref System.Windows.Controls.ProgressBar pb)
        {
            bool status = false;
            string current_path = System.IO.Directory.GetCurrentDirectory();

            System.IO.StreamWriter command_file = new System.IO.StreamWriter(current_path + "\\conda_commands.log");

            System.IO.StreamWriter clog = new System.IO.StreamWriter(current_path + "\\conda.log");
            clog.Close();


            //System.Diagnostics.Process env_process = new System.Diagnostics.Process();
            for (int i = 0; i < commands.Count; ++i)
            {
                string full_command = commands[i];
                command_file.WriteLine(full_command);

                //System.Diagnostics.ProcessStartInfo proc_info;
                System.Diagnostics.ProcessStartInfo proc_info = new System.Diagnostics.ProcessStartInfo();
                proc_info.FileName = "CMD.exe";
                proc_info.Arguments = full_command;
                //proc_info.Arguments = "/c echo \"hey there buddy!\" > \"" + current_path + "\\conda.log\" & pause";
                if (full_command.Contains("create"))
                {
                    proc_info.Verb = "runas";
                    proc_info.UseShellExecute = true;
                } else
                {
                    proc_info.CreateNoWindow = true;
                    proc_info.UseShellExecute = false;
                }
                try
                {

                    System.Diagnostics.Process env_process = System.Diagnostics.Process.Start(proc_info);
                    while (!env_process.HasExited)
                    {
                        update_status(current_path + "\\conda.log", ref tb);
                    }
                    
                    // env_process.WaitForExit();
                    System.IO.StreamReader file = System.IO.File.OpenText(current_path + "\\conda.log");
                    List<string> conda_log = new List<string>();
                    string line = "";
                    while (line != null)
                    {
                        line = file.ReadLine();
                        if (line != null)
                        {
                            conda_log.Add(line);
                        }
                    }
                    file.Close();
                    if (conda_log.Count > 0)
                    {

                        if (conda_log[conda_log.Count - 1].Contains("activate"))
                        {
                            tb.Text = "Installation failed.";
                            MessageBox.Show("Environment setup was unsuccessful. \nIt is likely your python environment manager was not correctly installed.");
                            status = false;
                        } else if (conda_log[conda_log.Count - 1].Contains("index"))
                        {
                            tb.Text = "Installation failed.";
                            MessageBox.Show("Environment setup was unsuccessful. \nPlease make sure all dependencies are located in the 'pkgs' folder.");
                            status = false;
                        } else if (conda_log[conda_log.Count - 1].Contains("create"))
                        {
                            tb.Text = "Environment successfully created";
                            MessageBox.Show("Environment setup successful.");
                            status = true;
                        }
                    }
                } catch (System.Exception e)
                {
                    tb.Text = "Installation failed.";
                    pb.IsIndeterminate = false;
                    MessageBox.Show("An unknown error occured:\n" + e.Message);
                }

            }
            pb.IsIndeterminate = false;
            command_file.Close();
            return status;
        }

        /// <summary>
        /// Checks the folders in the 'Path' environment variable for a python distributor application.
        /// </summary>
        /// <param name="dist">Application to search for (Miniconda/Anaconda)</param>
        /// <returns>
        /// Path of distribution if found, otherwise empty string.
        /// </returns>
        /// <remarks>
        /// Returns first folder with activate.bat script found.
        /// </remarks>
        public static string check_path(string dist)
        {
            string[] winpath = Environment.GetEnvironmentVariable("Path").Split(";");
            for (int i = 0; i < winpath.Length; i++)
            {
                string last_folder = winpath[i].Substring(winpath[i].LastIndexOf("\\") + 1);
                if ((dist == "Anaconda" && last_folder == "Anaconda3") || (dist == "Miniforge" && last_folder == "Miniforge3"))
                {
                    if (System.IO.File.Exists(System.IO.Path.Combine(winpath[i], "Scripts\\activate.bat")))
                    {
                        return winpath[i];
                    }
                }
            }
            return "";
        }
    }
}
