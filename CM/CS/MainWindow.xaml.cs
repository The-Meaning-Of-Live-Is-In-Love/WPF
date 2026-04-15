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
            List<Button> Library_Buttons = new List<Button>();
            Button Library_Button_1 = new Button();
            Library_Button_1.Content = "Произвольное название";
            Library_Button_1.MaxHeight = 30;
            Library_Button_1.MaxWidth = 150;
            Library_Button_1.Click += Library_Button_1_Click;
            Button Library_Button_2 = new Button();
            Library_Button_2.Content = "iostream";
            Library_Button_2.MaxHeight = 30;
            Library_Button_2.MaxWidth = 150;
            Library_Button_2.Click += Library_Button_2_Click;
            Button Library_Button_3 = new Button();
            Library_Button_3.Content = "string";
            Library_Button_3.MaxHeight = 30;
            Library_Button_3.MaxWidth = 150;
            Library_Button_3.Click += Library_Button_3_Click;
            Button Library_Button_4 = new Button();
            Library_Button_4.Content = "vector";
            Library_Button_4.MaxHeight = 30;
            Library_Button_4.MaxWidth = 150;
            Library_Button_4.Click += Library_Button_4_Click;
            Button Library_Button_5 = new Button();
            Library_Button_5.Content = "windows.h";
            Library_Button_5.MaxHeight = 30;
            Library_Button_5.MaxWidth = 150;
            Library_Button_5.Click += Library_Button_5_Click;
            Library_Buttons.Add(Library_Button_1);
            Library_Buttons.Add(Library_Button_2);
            Library_Buttons.Add(Library_Button_3);
            Library_Buttons.Add(Library_Button_4);
            Library_Buttons.Add(Library_Button_5);
            Buttons_Values.ItemsSource = null;
            Buttons_Values.ItemsSource = Library_Buttons;
        }
        private void Library_Button_1_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 1;
            Adding_Code_Text(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_2_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 2;
            Adding_Code_Text(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_3_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 3;
            Adding_Code_Text(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_4_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 4;
            Adding_Code_Text(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_5_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 5;
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
            if (Type_Code_Make == 2)
            {
                Libraryes_List.Add("#include <iostream>");
            }
            if (Type_Code_Make == 3)
            {
                Libraryes_List.Add("#include <string>");
            }
            if (Type_Code_Make == 4)
            {
                Libraryes_List.Add("#include <vector>");
            }
            if (Type_Code_Make == 5)
            {
                Libraryes_List.Add("#include <windows.h>");
            }
        }
    }
}