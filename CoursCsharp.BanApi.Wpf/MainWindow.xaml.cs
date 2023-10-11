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
using CoursCsharp.BanApi.Api;
using CoursCsharp.BanApi.Api.Model;

namespace CoursCsharp.BanApi.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Attributes

        /// <summary>
        /// API BAN
        /// </summary>
        private Api.BanApi _BanApi = null;

        #endregion

        #region Properties

        /// <summary>
        /// API Ban
        /// </summary>
        public Api.BanApi BanApi { get => _BanApi; set => _BanApi = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Construit la fenêtre principale
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.BanApi = new Api.BanApi();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Lance la recherche à l'API Ban
        /// </summary>
        /// <param name="searchQuery"></param>
        private void Search(string searchQuery)
        {
            BanResult result = this.BanApi.Search(searchQuery);
            this._AddressDataGrid.ItemsSource = result.Features;
        }

        /// <summary>
        /// Méthode de recherche du bouton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _SearchButton_Click(object sender, RoutedEventArgs e) => this.Search(_SearchTextBox.Text);

        /// <summary>
        /// Méthode de recherche par la touche "Entrée"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Search(_SearchTextBox.Text);
            }
        }

        #endregion

    }
}
