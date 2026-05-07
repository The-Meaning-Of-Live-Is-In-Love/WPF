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
        private void CM_Loaded(object sender, RoutedEventArgs Key_Pressed)
        {
            List<Button> Buttons_Menu_List = new List<Button>();
            Button Button_Menu_1 = new Button();
            Button_Menu_1.Content = "Подключение библиотек";
            Button_Menu_1.MaxHeight = 30;
            Button_Menu_1.Width = 200;
            Button_Menu_1.Click += Menu_Switching_Library;
            Buttons_Menu_List.Add(Button_Menu_1);
            Buttons_Menu.ItemsSource = null;
            Buttons_Menu.ItemsSource = Buttons_Menu_List;
            List<string> Namespace_List = new List<string>();
            Namespace_List.Add("using namespace std;");
            Namespace_Text.ItemsSource = null;
            Namespace_Text.ItemsSource = Namespace_List;
            List<string> MainFunction1 = new List<string>();
            MainFunction1.Add("int main()");
            List<string> MainFunction2 = new List<string>();
            MainFunction2.Add("{");
            List<string> Main_Function = new List<string>();
            List<string> MainFunction3 = new List<string>();
            MainFunction3.Add("    return 0;");
            List<string> MainFunction4 = new List<string>();
            MainFunction4.Add("}");
            Main_Function_1.ItemsSource = null;
            Main_Function_1.ItemsSource = MainFunction1;
            Main_Function_2.ItemsSource = null;
            Main_Function_2.ItemsSource = MainFunction2;
            Main_Function_Text.ItemsSource = null;
            Main_Function_Text.ItemsSource = Main_Function;
            Main_Function_3.ItemsSource = null;
            Main_Function_3.ItemsSource = MainFunction3;
            Main_Function_4.ItemsSource = null;
            Main_Function_4.ItemsSource = MainFunction4;
        }
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
            Library_Button_1.Width = 200;
            Library_Button_1.Click += Library_Button_1_Click;
            Button Library_Button_2 = new Button();
            Library_Button_2.Content = "iostream";
            Library_Button_2.MaxHeight = 30;
            Library_Button_2.Width = 200;
            Library_Button_2.Click += Library_Button_2_Click;
            Button Library_Button_3 = new Button();
            Library_Button_3.Content = "string";
            Library_Button_3.MaxHeight = 30;
            Library_Button_3.Width = 200;
            Library_Button_3.Click += Library_Button_3_Click;
            Button Library_Button_4 = new Button();
            Library_Button_4.Content = "vector";
            Library_Button_4.MaxHeight = 30;
            Library_Button_4.Width = 200;
            Library_Button_4.Click += Library_Button_4_Click;
            Button Library_Button_5 = new Button();
            Library_Button_5.Content = "windows.h";
            Library_Button_5.MaxHeight = 30;
            Library_Button_5.Width = 200;
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
            string Value_Input = Text_Box_1.Text;
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