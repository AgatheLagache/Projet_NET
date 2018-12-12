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
using System.Windows.Shapes;

namespace WPF_NET_Project
{
    /// <summary>
    /// Logique d'interaction pour Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public static Results results = null;
        public Results()
        {
            InitializeComponent();
            Results_Textbox.IsEnabled = false;
        }

        public Results GetResults()
        {
            if (results == null)
            {
                results = new Results();
            }
            results.Show();
            return results;
        }

        private void Results1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
