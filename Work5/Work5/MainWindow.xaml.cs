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

namespace Work5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> myGame = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
            myGame.Add(new Game { NAME = "Pithfinder", PLATFORM = "PC", GENRE = "RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "NeverWinter nights 2", PLATFORM = "PC", GENRE = "RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "The Witcher 3", PLATFORM = "PC", GENRE = "RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "Pillars of Eternity", PLATFORM = "PC", GENRE = "RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "FINAL FANTASY XV", PLATFORM = "xbox one", GENRE = "Action RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "Hades", PLATFORM = "Sony", GENRE = "Action", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "Path of Exile", PLATFORM = "xbox one", GENRE = "Action RPG", MULTY = "Многопользовательская" });
            myGame.Add(new Game { NAME = "The Legend of Zelda - Breath of the Wild", PLATFORM = "nintendo switch", GENRE = "RPG", MULTY = "Однопольовательская" });
            myGame.Add(new Game { NAME = "World of Warcraft", PLATFORM = "PC", GENRE = "RPG", MULTY = "Многопользовательская" });
            myGame.Add(new Game { NAME = "Warcraft III", PLATFORM = "PC", GENRE = "Strategy", MULTY = "Многопользовательская" });

            foreach (var game in myGame)
            {
                LBGame.Items.Add(game);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            try
            {
                game.NAME = TBname.Text;
                game.GENRE = TBgenre.Text;
                game.MULTY = TBmulty.Text;
                game.PLATFORM = TBplatform.Text;
                LBGame.Items.Add(game);
                myGame.Add(game);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e) //Поиск по жанру
        {
            List<Game> tmpGame = new List<Game>();

            foreach (var obj in myGame)
            {
                Game game = obj as Game;

                if (game.GENRE.ToLower().Contains(TBsort.Text.ToLower()))
                {
                    tmpGame.Add(game);
                }
                LBGame.Items.Clear();
                foreach (var game2 in tmpGame)
                {
                    LBGame.Items.Add(game2);
                }
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            List<Game> tmpGame = new List<Game>();

            foreach (var obj in myGame)
            {
                Game game = obj as Game;

                if (game.PLATFORM.ToLower().Contains(TBsort3.Text.ToLower()))
                {
                    tmpGame.Add(game);
                }
                LBGame.Items.Clear();
                foreach (var game2 in tmpGame)
                {
                    LBGame.Items.Add(game2);
                }
            }
        }
    }
}
