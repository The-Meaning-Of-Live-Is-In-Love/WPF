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

namespace Code_Maker
{
    public partial class MainWindow : Window
    {
        string Value_Input;
        int Type_Code_Make;
        List<string> Libraryes_List = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Menu_Switching_Library(object sender, RoutedEventArgs Key_Pressed)
        {
            Button Library_Button_1 = new Button();
            Library_Button_1.Content = "Произвольное название";
            Library_Button_1.MaxHeight = 30;
            Library_Button_1.MaxWidth = 150;
            Library_Button_1.Click += Library_Button_1_Click;
            Buttons_Values.Content = Library_Button_1;
        }
        private void Library_Button_1_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 1;
            Adding_Code_Text(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Libraryes_Text_Update(List<string> Libraryes_List)
        {
            Libraryes_Text.ItemsSource = null;
            Libraryes_Text.ItemsSource = Libraryes_List;
        }
        private void Adding_Code_Text(int Type_Code_Make)
        {
            Value_Input = Text_Box.Text;
            if (Type_Code_Make == 1)
            {
                Libraryes_List.Add("#include <" + Value_Input + ">");
            }
        }
    }
}