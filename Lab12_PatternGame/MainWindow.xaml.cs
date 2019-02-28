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

namespace Lab12_PatternGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        King king;
        King oldKing;
        GeometryFactory gfactory = new GeometryFactory();
        WarriorFactory wfactory = new WarriorFactory();
        Map map = new Map();

        public MainWindow()
        {
            InitializeComponent();
            InitMonster();
            Consists.SelectedItem = Consists.Items[0];
        }

        private void InitMonster()
        {
            ChangeHead.SelectedItem = ChangeHead.Items[0];
            ChangeBody.SelectedItem = ChangeBody.Items[0];
            ChangeHands.SelectedItem = ChangeHands.Items[0];
            ChangeLegs.SelectedItem = ChangeLegs.Items[0];
        }

        private void OnCreateMonster(object sender, RoutedEventArgs e)
        {
            var builder = new MonsterBuilder();
            var directorBuilder = new MonsterDirector(builder);
            int index = ChangeBody.SelectedItem.ToString().LastIndexOf(':')+2;
            string head = ChangeHead.SelectedItem.ToString().Substring(index);
            string body = ChangeBody.SelectedItem.ToString().Substring(index);
            string legs = ChangeLegs.SelectedItem.ToString().Substring(index);
            string hands = ChangeHands.SelectedItem.ToString().Substring(index);
            Monster.Text = directorBuilder.CreateMonster(head, body, hands, legs);
        }

        private void OnCreateWarrior(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new Rectangle
            {
                Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
                Stroke = new SolidColorBrush(Color.FromRgb(128, 56, 128)),
                Width = 20,
                Height = 20
            };
            Warriors.Children.Add(rectangle);
            var war = wfactory.CreateGameObject();
            map.AddComponent(war);
            factory.Items.Add(war.Type);
        }

        private void OnCreateGeometry(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse
            {
                Fill = new SolidColorBrush(Color.FromRgb(100, 255, 65)),
                Stroke = new SolidColorBrush(Color.FromRgb(128, 56, 128)),
                Width = 20,
                Height = 20
            };
            Warriors.Children.Add(ellipse);
            var geo = gfactory.CreateGameObject();
            map.AddComponent(geo);
            factory.Items.Add(geo.Type);
        }

        private void OnCreateKing(object sender, RoutedEventArgs e)
        {
            king = King.GetInstance();
            Image image = new Image
            {
                Source = new BitmapImage(new Uri("C:/Users/User/Desktop/product-original.jpg"))
            };
            if (king.Equals(oldKing))
            {
                Figures.Children.Clear();
                Figures.Children.Add(new Ellipse
                {
                    Fill = new SolidColorBrush(Color.FromRgb(100, 255, 65)),
                    Stroke = new SolidColorBrush(Color.FromRgb(128, 56, 128)),
                    Width = 20,
                    Height = 20
                });
            }
            Figures.Children.Add(image);
            oldKing = king;
            king = null;
        }

        private void OnCloneKing(object sender, RoutedEventArgs e)
        {
            try
            {
                var falseKing = oldKing.DeepClone();
                CloneHere.Text += "Король склонирован\\n";
            }
            catch (Exception error)
            {

            }
        }

        private void CookPizza(object sender, RoutedEventArgs e)
        {
            var choose = Consists.SelectedItem.ToString();
            WrapPanel panel = new WrapPanel { Width = 80, Height = 40};
            if (choose.Contains("Сырная"))
            {
                var pizza = new CheesePizza();
                pizza.Consist();
                choose = "Сырная";
                panel.Background = new ImageBrush(new BitmapImage(pizza.ConstPizza));
            }
            else
            {
                var pizza = new VeganPizza();
                pizza.Consist();
                choose = "Вегетарианская";
                panel.Background = new ImageBrush(new BitmapImage(pizza.ConstPizza));
            }
            panel.Children.Add(new TextBlock { Text = choose });
            StructHere.Children.Add(panel);
        }

        private void FindWarrior(object sender, RoutedEventArgs e)
        {
            string title = Warrior.Text ?? "";
            if (map.Find(title) != null)
            {
                MessageBox.Show("Нашли война!");
            }
            else
            {
                MessageBox.Show("Не нашли война!");
            }
        }

        private void MoveWar(object sender, RoutedEventArgs e)
        {
            var war = map.Find("Воин0");
            if (war!=null)
            {
                var adaptedWar = new Adapter(war as Warrior);
                MessageBox.Show(adaptedWar.Move(1, 1));
            }
        }
    }
}
