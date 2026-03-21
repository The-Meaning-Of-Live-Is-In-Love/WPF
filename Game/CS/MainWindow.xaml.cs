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

namespace Game
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int Shift_Position_X;
        int Shift_Position_Y;
        int Score_Point_Shift_Position_X = 0;
        int Score_Point_Shift_Position_Y = 0;
        private void Generation_Random_Position()
        {
            Random Random_Value_1 = new Random();
            Score_Point_Shift_Position_X = Random_Value_1.Next(-960, 960);
            Random Random_Value_2 = new Random();
            Score_Point_Shift_Position_Y = Random_Value_2.Next(-540, 540);
        }
        private void Movement(object sender, KeyEventArgs Key_Pressed)
        {
            if (Key_Pressed.Key == Key.S)
            {
                Shift_Position_Y += 1;
                Canvas.SetTop(Player, Shift_Position_Y);
                Canvas.SetTop(Player_Light_1, Shift_Position_Y);
                Canvas.SetTop(Player_Light_2, Shift_Position_Y);
                Checking_Position(Shift_Position_X, Shift_Position_Y);
            }
            if (Key_Pressed.Key == Key.W)
            {
                Shift_Position_Y -= 1;
                Canvas.SetTop(Player, Shift_Position_Y);
                Canvas.SetTop(Player_Light_1, Shift_Position_Y);
                Canvas.SetTop(Player_Light_2, Shift_Position_Y);
                Checking_Position(Shift_Position_X, Shift_Position_Y);
            }
            if (Key_Pressed.Key == Key.D)
            {
                Shift_Position_X += 1;
                Canvas.SetLeft(Player, Shift_Position_X);
                Canvas.SetLeft(Player_Light_1, Shift_Position_X);
                Canvas.SetLeft(Player_Light_2, Shift_Position_X);
                Checking_Position(Shift_Position_X, Shift_Position_Y);
            }
            if (Key_Pressed.Key == Key.A)
            {
                Shift_Position_X -= 1;
                Canvas.SetLeft(Player, Shift_Position_X);
                Canvas.SetLeft(Player_Light_1, Shift_Position_X);
                Canvas.SetLeft(Player_Light_2, Shift_Position_X);
                Checking_Position(Shift_Position_X, Shift_Position_Y);
            }
        }
        private void Checking_Position(int Shift_Position_X, int Shift_Position_Y)
        {
            if ((Shift_Position_X > Score_Point_Shift_Position_X - 15) && (Shift_Position_X < Score_Point_Shift_Position_X + 15) && (Shift_Position_Y > Score_Point_Shift_Position_Y - 15) && (Shift_Position_Y < Score_Point_Shift_Position_Y + 15))
            {
                Score_Point.Opacity = 1;
            }
            else
            {
                Score_Point.Opacity = 0;
            }
            if ((Shift_Position_X > Score_Point_Shift_Position_X - 5) && (Shift_Position_X < Score_Point_Shift_Position_X + 5) && (Shift_Position_Y > Score_Point_Shift_Position_Y - 5) && (Shift_Position_Y < Score_Point_Shift_Position_Y + 5))
            {
                Generation_Random_Position();
                Canvas.SetLeft(Score_Point, Score_Point_Shift_Position_X);
                Canvas.SetTop(Score_Point, Score_Point_Shift_Position_Y);
                Score_Point.Opacity = 0;
            }
        }
    }
}
