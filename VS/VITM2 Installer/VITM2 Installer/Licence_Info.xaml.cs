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
    /// Interaction logic for Licence_Info.xaml
    /// </summary>
    public partial class Licence_Info : Window
    {
        private string next_window;
        public Licence_Info(string t_next_window)
        {
            InitializeComponent();
            this.next_window = t_next_window;
        }



        private void Agree_Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Button_Next.IsEnabled = false;
        }


        private void Agree_Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Button_Next.IsEnabled = true;
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            if (Agree_Checkbox.IsChecked.Value)
            {
                this.Hide();
                // initialise window object
                Window install_window = new Window();
                if (next_window=="Manual")
                {
                    // manual install window
                    install_window = new Manual_Install_Page_1();

                } else if (next_window=="Simple")
                {
                    // simple install window
                    install_window = new Simple_Install_Page_1();
                }
                else
                {
                    MessageBox.Show("An unknown error has occured. The installation has been cancelled");
                    this.Close();
                    Application.Current.Shutdown();
                }

                this.Hide();
                // set window to same location as current
                install_window.Left = this.Left;
                install_window.Top = this.Top;

                install_window.Show();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

    }
}
