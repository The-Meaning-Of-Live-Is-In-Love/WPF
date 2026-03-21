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
        private void Movement(object sender, KeyEventArgs Key_Pressed)
        {
            if (Key_Pressed.Key == Key.S)
            {
                Shift_Position_Y += 1;
                Canvas.SetTop(Player, Shift_Position_Y);
                Canvas.SetTop(Player_Light_1, Shift_Position_Y);
                Canvas.SetTop(Player_Light_2, Shift_Position_Y);
            }
            if (Key_Pressed.Key == Key.W)
            {
                Shift_Position_Y -= 1;
                Canvas.SetTop(Player, Shift_Position_Y);
                Canvas.SetTop(Player_Light_1, Shift_Position_Y);
                Canvas.SetTop(Player_Light_2, Shift_Position_Y);
            }
            if (Key_Pressed.Key == Key.D)
            {
                Shift_Position_X += 1;
                Canvas.SetLeft(Player, Shift_Position_X);
                Canvas.SetLeft(Player_Light_1, Shift_Position_X);
                Canvas.SetLeft(Player_Light_2, Shift_Position_X);
            }
            if (Key_Pressed.Key == Key.A)
            {
                Shift_Position_X -= 1;
                Canvas.SetLeft(Player, Shift_Position_X);
                Canvas.SetLeft(Player_Light_1, Shift_Position_X);
                Canvas.SetLeft(Player_Light_2, Shift_Position_X);
            }
        }
    }
}
