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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour V_Recherche.xaml
    /// </summary>
    public partial class V_Recherche : Window
    {
        String steamId;
        String reponse;

        public V_Recherche()
        {
            InitializeComponent();

            
        }

        public V_Recherche(string steamId, string reponse)
        {
            this.steamId = steamId;
            this.reponse = reponse;
            InitializeComponent();

            dynamic listSteam;


            listSteam = Recherche.RequestFriends(steamId);
            Resp.Text = listSteam.friendslist.friends.steamid.ToString();
        }
    }
}
