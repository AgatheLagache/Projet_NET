using DLL_Library_NET_Project;
using DLL_Library_NET_Project.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace WPF_NET_Project
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private BackgroundWorker thread;
        //NetworkStream serverStream = default(NetworkStream);
        //TcpClient clientSocket = new TcpClient();

        private Random nb_random = new Random();
        private int Nb_Fast_Clients = 1;
        private int Nb_Ordinary_Clients = 1;
        private int Nb_Slow_Clients = 1;
        private int Nb_Waiters = 1;
        private int Nb_Cooks = 1;
        private int Nb_Headwaiters = 1;
        private int Scenario_Nb = 0;
        //Results results = new Results();

        public MainWindow()
        {
            InitializeComponent();
            List<Scenario> scenarioList = History.GetAllScenarioFromDB();
            Scenario_Choice.ItemsSource = scenarioList;
            Scenario_Choice.SelectedItem = scenarioList.First();
            //Scenario_Choice.SelectedItem = scenarioList.Last();
            //Scenario_Choice.SelectedItem = scenarioList.Where(i => i.id == 2).FirstOrDefault();
            Scenario_Choice.DisplayMemberPath = "titre";
            //thread = new BackgroundWorker();
        }

        ///* déclaration du model restaurant de l'interface IRestaurantModel */
        //private IRestaurantModel restaurantModel;

        ///* déclaration de la vue restaurant de l'interface IRestaurantView */
        //private IRestaurantView restaurantView;
        //private IScenario scenario;

        ///* Instancie un nouveau controleur du restaurant */
        //public RestaurantController(IRestaurantModel restaurantModel, IRestaurantView restaurantView)
        //{
        //    this.setRestaurantView(restaurantView);
        //    this.setRestaurantModel(restaurantModel);
        //}

        ///* Récupère le model du restaurant et le retourne */
        //public IRestaurantModel getRestaurantModel()
        //{
        //    return this.restaurantModel;
        //}

        ///* Attribue la valeur du model */
        //private void setRestaurantModel(IRestaurantModel model)
        //{
        //    this.restaurantModel = model;
        //}

        ///* Récupère la vue du restaurant et la retourne */
        //public IRestaurantView getRestaurantView()
        //{
        //    return this.restaurantView;
        //}

        ///* Attribue la valeur de la vue */
        //private void setRestaurantView(IRestaurantView view)
        //{
        //    this.restaurantView = view;
        //}

        ///* Lance la méthode initializeScenario qui permet de choisir un scnario */
        //public void startScenario()
        //{
        //    scenario.initializeScenario(1);
        //}

        ///*  */
        //public void play()
        //{
        //    this.startScenario();
        //}

        ///*  */
        //public void pause()
        //{
        //}

        ///*  */
        //public void replay()
        //{
        //}

        //public void speedUp()
        //{
        //}

        private void Start_Simulation_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Nb_Fast_Clients_Choice.Text, out Nb_Fast_Clients)
                && int.TryParse(Nb_Ordinary_Clients_Choice.Text, out Nb_Ordinary_Clients)
                && int.TryParse(Nb_Slow_Clients_Choice.Text, out Nb_Slow_Clients)
                && int.TryParse(Nb_Waiters_Choice.Text, out Nb_Waiters)
                && int.TryParse(Nb_Cooks_Choice.Text, out Nb_Cooks)
                && int.TryParse(Nb_Waiters_Choice.Text, out Nb_Waiters)
                && (Scenario_Choice.SelectedIndex >= 0))
            {

            }
            else
            {
                Nb_Clients_Random_Click(sender, e);
                Nb_Waiters_Random_Click(sender, e);
                Nb_Cooks_Random_Click(sender, e);
                Nb_Headwaiters_Random_Click(sender, e);
            }

            Parametres.NumberFastClients = int.Parse(Nb_Fast_Clients_Choice.Text);
            Parametres.NumberOrdinaryClients = int.Parse(Nb_Ordinary_Clients_Choice.Text);
            Parametres.NumberSlowClients = int.Parse(Nb_Slow_Clients_Choice.Text);
            Parametres.NumberWaiters = int.Parse(Nb_Waiters_Choice.Text);
            Parametres.NumberCooks = int.Parse(Nb_Cooks_Choice.Text);
            Parametres.NumberHeadwaiters = int.Parse(Nb_Waiters_Choice.Text);
            Parametres.NumberScenario = Scenario_Nb;
            Results results = new Results();
            results.Show();
            MainWindow1.IsEnabled = false;
        }

        private void Nb_Clients_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Fast_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
            Nb_Ordinary_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
            Nb_Slow_Clients_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Nb_Waiters_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Waiters_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Nb_Cooks_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Cooks_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Check_Int_Validity(string Entered_Value, int Destination_Value)
        {
            if (int.TryParse(Entered_Value, out Destination_Value))
            {
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nombre valide entre 1 et 100.");
            }
        }

        private void Nb_Fast_Clients_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Fast_Clients_Choice.Text, Nb_Fast_Clients);
            }
        }

        private void Nb_Ordinary_Clients_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Ordinary_Clients_Choice.Text, Nb_Ordinary_Clients);
            }
        }

        private void Nb_Slow_Clients_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Slow_Clients_Choice.Text, Nb_Slow_Clients);
            }
        }

        private void Nb_Waiters_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Waiters_Choice.Text, Nb_Waiters);
            }
        }

        private void Nb_Cooks_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Cooks_Choice.Text, Nb_Cooks);
            }
        }

        private void Scenario_Random_Click(object sender, RoutedEventArgs e)
        {
            int nb_scenario = 0;
            foreach (var scenario in Scenario_Choice.Items)
            {
                nb_scenario += 1;
            }
            Scenario_Nb = nb_random.Next(0, nb_scenario);
            Scenario_Choice.SelectedIndex = Scenario_Nb;
        }

        private void MainWindow1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Scenario_Choice_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Scenario_Nb = Scenario_Choice.SelectedIndex;
        }

        private void Nb_Headwaiters_Random_Click(object sender, RoutedEventArgs e)
        {
            Nb_Headwaiters_Choice.Text = nb_random.Next(1, 12).ToString();
        }

        private void Nb_Headwaiters_Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Int_Validity(Nb_Headwaiters_Choice.Text, Nb_Headwaiters);
            }
        }
    }
}