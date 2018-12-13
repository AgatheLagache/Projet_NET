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

namespace WPF_NET_Project
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
