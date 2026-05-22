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
            Style Button_Menu_Style = (Style)Resources["Button_Menu_Style"] ?? new Style(typeof(Button));
            Button_Menu_Style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Cyan));
            Button_Menu_Style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.Black));
            List<Button> Buttons_Menu_List = new List<Button>();
            Button Button_Menu_1 = new Button();
            Button_Menu_1.Content = "Подключение библиотек";
            Button_Menu_1.MaxHeight = 30;
            Button_Menu_1.Width = 200;
            Button_Menu_1.Click += Menu_Switching_Library;
            Button_Menu_1.Style = Button_Menu_Style;
            Button Button_Menu_2 = new Button();
            Button_Menu_2.Content = "Инициализация переменных";
            Button_Menu_2.MaxHeight = 30;
            Button_Menu_2.Width = 200;
            Button_Menu_2.Click += Menu_Switching_Variables;
            Button_Menu_2.Style = Button_Menu_Style;
            Button Button_Menu_3 = new Button();
            Button_Menu_3.Content = "Арифметические операции";
            Button_Menu_3.MaxHeight = 30;
            Button_Menu_3.Width = 200;
            Button_Menu_3.Click += Menu_Switching_Arithmetic_Operations;
            Button_Menu_3.Style = Button_Menu_Style;
            Buttons_Menu_List.Add(Button_Menu_1);
            Buttons_Menu_List.Add(Button_Menu_2);
            Buttons_Menu_List.Add(Button_Menu_3);
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
            MainFunction3.Add("\treturn 0;");
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
        List<string> Variables_List = new List<string>();
        List<string> Arithmetic_Operations_List = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Menu_Switching_Library(object sender, RoutedEventArgs Key_Pressed)
        {
            Style Library_Button_Style = (Style)Resources["Library_Button_Style"] ?? new Style(typeof(Button));
            Library_Button_Style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
            Library_Button_Style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.White));
            List<Button> Library_Buttons = new List<Button>();
            Button Library_Button_1 = new Button();
            Library_Button_1.Content = "Произвольное название";
            Library_Button_1.MaxHeight = 30;
            Library_Button_1.Width = 200;
            Library_Button_1.Click += Library_Button_1_Click;
            Library_Button_1.Style = Library_Button_Style;
            Button Library_Button_2 = new Button();
            Library_Button_2.Content = "iostream";
            Library_Button_2.MaxHeight = 30;
            Library_Button_2.Width = 200;
            Library_Button_2.Click += Library_Button_2_Click;
            Library_Button_2.Style = Library_Button_Style;
            Button Library_Button_3 = new Button();
            Library_Button_3.Content = "string";
            Library_Button_3.MaxHeight = 30;
            Library_Button_3.Width = 200;
            Library_Button_3.Click += Library_Button_3_Click;
            Library_Button_3.Style = Library_Button_Style;
            Button Library_Button_4 = new Button();
            Library_Button_4.Content = "vector";
            Library_Button_4.MaxHeight = 30;
            Library_Button_4.Width = 200;
            Library_Button_4.Click += Library_Button_4_Click;
            Library_Button_4.Style = Library_Button_Style;
            Button Library_Button_5 = new Button();
            Library_Button_5.Content = "windows.h";
            Library_Button_5.MaxHeight = 30;
            Library_Button_5.Width = 200;
            Library_Button_5.Click += Library_Button_5_Click;
            Library_Button_5.Style = Library_Button_Style;
            Library_Buttons.Add(Library_Button_1);
            Library_Buttons.Add(Library_Button_2);
            Library_Buttons.Add(Library_Button_3);
            Library_Buttons.Add(Library_Button_4);
            Library_Buttons.Add(Library_Button_5);
            Buttons_Values.ItemsSource = null;
            Buttons_Values.ItemsSource = Library_Buttons;
        }
        private void ClipBoard (object sender, EventArgs Key_Pressed)
        {
            string ClipBoard_Text = "";
            string ClipBoard_Text_Libraryes = string.Join("\n", Libraryes_List);
            string ClipBoard_Text_Main_Function = string.Join("\n", Variables_List);
            ClipBoard_Text = ClipBoard_Text_Libraryes + "\nUsing namespace std;\nint main()\n{\n" + ClipBoard_Text_Main_Function + "\n\treturn 0;\n}";
            Clipboard.SetText(ClipBoard_Text);
        }
        private void Menu_Switching_Variables(object sender, EventArgs Key_Pressed)
        {
            Style Variable_Button_Style = (Style)Resources["Variable_Button_Style"] ?? new Style(typeof(Button));
            Variable_Button_Style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
            Variable_Button_Style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.White));
            List<Button> Variable_Buttons = new List<Button>();
            Button Variable_Button_1 = new Button();
            Variable_Button_1.Content = "Произвольное название";
            Variable_Button_1.MaxHeight = 30;
            Variable_Button_1.Width = 200;
            Variable_Button_1.Click += Variable_Button_1_Click;
            Variable_Button_1.Style = Variable_Button_Style;
            Button Variable_Button_2 = new Button();
            Variable_Button_2.Content = "int";
            Variable_Button_2.MaxHeight = 30;
            Variable_Button_2.Width = 200;
            Variable_Button_2.Click += Variable_Button_2_Click;
            Variable_Button_2.Style = Variable_Button_Style;
            Button Variable_Button_3 = new Button();
            Variable_Button_3.Content = "float";
            Variable_Button_3.MaxHeight = 30;
            Variable_Button_3.Width = 200;
            Variable_Button_3.Click += Variable_Button_3_Click;
            Variable_Button_3.Style = Variable_Button_Style;
            Button Variable_Button_4 = new Button();
            Variable_Button_4.Content = "double";
            Variable_Button_4.MaxHeight = 30;
            Variable_Button_4.Width = 200;
            Variable_Button_4.Click += Variable_Button_4_Click;
            Variable_Button_4.Style = Variable_Button_Style;
            Button Variable_Button_5 = new Button();
            Variable_Button_5.Content = "string";
            Variable_Button_5.MaxHeight = 30;
            Variable_Button_5.Width = 200;
            Variable_Button_5.Click += Variable_Button_5_Click;
            Variable_Button_5.Style = Variable_Button_Style;
            Button Variable_Button_6 = new Button();
            Variable_Button_6.Content = "bool";
            Variable_Button_6.MaxHeight = 30;
            Variable_Button_6.Width = 200;
            Variable_Button_6.Click += Variable_Button_6_Click;
            Variable_Button_6.Style = Variable_Button_Style;
            Variable_Buttons.Add(Variable_Button_1);
            Variable_Buttons.Add(Variable_Button_2);
            Variable_Buttons.Add(Variable_Button_3);
            Variable_Buttons.Add(Variable_Button_4);
            Variable_Buttons.Add(Variable_Button_5);
            Variable_Buttons.Add(Variable_Button_6);
            Buttons_Values.ItemsSource = null;
            Buttons_Values.ItemsSource = Variable_Buttons;
        }
        private void Menu_Switching_Arithmetic_Operations(object sender, RoutedEventArgs Key_Pressed)
        {
            Style Arithmetic_Operations_Button_Style = (Style)Resources["Arithmetic_Operations_Button_Style"] ?? new Style(typeof(Button));
            Arithmetic_Operations_Button_Style.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.Blue));
            Arithmetic_Operations_Button_Style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.White));
            List<Button> Arithmetic_Operation_Buttons = new List<Button>();
            Button Arithmetic_Operation_Button_1 = new Button();
            Arithmetic_Operation_Button_1.Content = "Произвольный знак";
            Arithmetic_Operation_Button_1.MaxHeight = 30;
            Arithmetic_Operation_Button_1.Width = 200;
            Arithmetic_Operation_Button_1.Click += Arithmetic_Operation_Button_1_Click;
            Arithmetic_Operation_Button_1.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_2 = new Button();
            Arithmetic_Operation_Button_2.Content = "+";
            Arithmetic_Operation_Button_2.MaxHeight = 30;
            Arithmetic_Operation_Button_2.Width = 200;
            Arithmetic_Operation_Button_2.Click += Arithmetic_Operation_Button_2_Click;
            Arithmetic_Operation_Button_2.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_3 = new Button();
            Arithmetic_Operation_Button_3.Content = "-";
            Arithmetic_Operation_Button_3.MaxHeight = 30;
            Arithmetic_Operation_Button_3.Width = 200;
            Arithmetic_Operation_Button_3.Click += Arithmetic_Operation_Button_3_Click;
            Arithmetic_Operation_Button_3.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_4 = new Button();
            Arithmetic_Operation_Button_4.Content = "*";
            Arithmetic_Operation_Button_4.MaxHeight = 30;
            Arithmetic_Operation_Button_4.Width = 200;
            Arithmetic_Operation_Button_4.Click += Arithmetic_Operation_Button_4_Click;
            Arithmetic_Operation_Button_4.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_5 = new Button();
            Arithmetic_Operation_Button_5.Content = "/";
            Arithmetic_Operation_Button_5.MaxHeight = 30;
            Arithmetic_Operation_Button_5.Width = 200;
            Arithmetic_Operation_Button_5.Click += Arithmetic_Operation_Button_5_Click;
            Arithmetic_Operation_Button_5.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_6 = new Button();
            Arithmetic_Operation_Button_6.Content = "%";
            Arithmetic_Operation_Button_6.MaxHeight = 30;
            Arithmetic_Operation_Button_6.Width = 200;
            Arithmetic_Operation_Button_6.Click += Arithmetic_Operation_Button_6_Click;
            Arithmetic_Operation_Button_6.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_7 = new Button();
            Arithmetic_Operation_Button_7.Content = "a++";
            Arithmetic_Operation_Button_7.MaxHeight = 30;
            Arithmetic_Operation_Button_7.Width = 200;
            Arithmetic_Operation_Button_7.Click += Arithmetic_Operation_Button_7_Click;
            Arithmetic_Operation_Button_7.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_8 = new Button();
            Arithmetic_Operation_Button_8.Content = "++a";
            Arithmetic_Operation_Button_8.MaxHeight = 30;
            Arithmetic_Operation_Button_8.Width = 200;
            Arithmetic_Operation_Button_8.Click += Arithmetic_Operation_Button_8_Click;
            Arithmetic_Operation_Button_8.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_9 = new Button();
            Arithmetic_Operation_Button_9.Content = "a--";
            Arithmetic_Operation_Button_9.MaxHeight = 30;
            Arithmetic_Operation_Button_9.Width = 200;
            Arithmetic_Operation_Button_9.Click += Arithmetic_Operation_Button_9_Click;
            Arithmetic_Operation_Button_9.Style = Arithmetic_Operations_Button_Style;
            Button Arithmetic_Operation_Button_10 = new Button();
            Arithmetic_Operation_Button_10.Content = "--a";
            Arithmetic_Operation_Button_10.MaxHeight = 30;
            Arithmetic_Operation_Button_10.Width = 200;
            Arithmetic_Operation_Button_10.Click += Arithmetic_Operation_Button_10_Click;
            Arithmetic_Operation_Button_10.Style = Arithmetic_Operations_Button_Style;
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_1);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_2);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_3);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_4);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_5);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_6);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_7);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_8);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_9);
            Arithmetic_Operation_Buttons.Add(Arithmetic_Operation_Button_10);
            Buttons_Values.ItemsSource = null;
            Buttons_Values.ItemsSource = Arithmetic_Operation_Buttons;
        }
        private void Library_Button_1_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 1;
            Adding_Code_Text_Libraryes(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_2_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 2;
            Adding_Code_Text_Libraryes(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_3_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 3;
            Adding_Code_Text_Libraryes(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_4_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 4;
            Adding_Code_Text_Libraryes(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Library_Button_5_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 5;
            Adding_Code_Text_Libraryes(Type_Code_Make);
            Libraryes_Text_Update(Libraryes_List);
        }
        private void Variable_Button_1_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 1;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Variable_Button_2_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 2;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Variable_Button_3_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 3;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Variable_Button_4_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 4;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Variable_Button_5_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 5;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Variable_Button_6_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 6;
            Adding_Code_Text_Variables(Type_Code_Make);
            Variables_Text_Update(Variables_List);
        }
        private void Arithmetic_Operation_Button_1_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 1;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_2_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 2;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_3_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 3;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_4_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 4;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_5_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 5;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_6_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 6;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_7_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 7;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_8_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 8;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_9_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 9;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Arithmetic_Operation_Button_10_Click(object sender, RoutedEventArgs Key_Pressed)
        {
            Type_Code_Make = 10;
            Adding_Code_Text_Arithmetic_Operations(Type_Code_Make);
            Arithmetic_Operations_Text_Update(Arithmetic_Operations_List);
        }
        private void Libraryes_Text_Update(List<string> Libraryes_List)
        {
            Libraryes_Text.ItemsSource = null;
            Libraryes_Text.ItemsSource = Libraryes_List;
        }
        private void Variables_Text_Update(List<string> Variables_List)
        {
            Main_Function_Text.ItemsSource = null;
            Main_Function_Text.ItemsSource = Variables_List;
        }
        private void Arithmetic_Operations_Text_Update(List<string> Variables_List)
        {
            Main_Function_Text.ItemsSource = null;
            Main_Function_Text.ItemsSource = Arithmetic_Operations_List;
        }
        private void Adding_Code_Text_Libraryes(int Type_Code_Make)
        {
            string Value_Input_Name = Text_Box_Name.Text;
            if (Type_Code_Make == 1)
            {
                Libraryes_List.Add("#include <" + Value_Input_Name + ">");
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
        private void Adding_Code_Text_Variables(int Type_Code_Make)
        {
            string Value_Input_Name = Text_Box_Name.Text;
            string Value_Input_Type = Text_Box_Type.Text;
            string Value_Input_Value = Text_Box_Value.Text;
            if (Type_Code_Make == 1)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + Value_Input_Type + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + Value_Input_Type + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
            if (Type_Code_Make == 2)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + "int" + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + "int" + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
            if (Type_Code_Make == 3)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + "float" + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + "float" + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
            if (Type_Code_Make == 4)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + "double" + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + "double" + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
            if (Type_Code_Make == 5)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + "string" + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + "string" + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
            if (Type_Code_Make == 6)
            {
                if (Value_Input_Value == "")
                {
                    Variables_List.Add('\t' + "bool" + " " + Value_Input_Name + ";");
                }
                else
                {
                    Variables_List.Add('\t' + "bool" + " " + Value_Input_Name + " = " + Value_Input_Value + ";");
                }
            }
        }
        private void Adding_Code_Text_Arithmetic_Operations(int Type_Code_Make)
        {
            string Type = Text_Box_Type.Text;
            string Name = Text_Box_Name.Text;
            string First_Operand = Text_Box_First_Operand.Text;
            string Second_Operand = Text_Box_Second_Operand.Text;
            string Sign = Text_Box_Sign.Text;

            if (Type_Code_Make == 1)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " " + Sign + " " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " " + Sign + " " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 2)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " + " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " + " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 3)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " - " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " - " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 4)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " * " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " * " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 5)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " / " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " / " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 6)
            {
                if (Type == "")
                {
                    Arithmetic_Operations_List.Add('\t' + Name + " = " + First_Operand + " % " + Second_Operand + ";");
                }
                else
                {
                    Arithmetic_Operations_List.Add('\t' + Type + " " + Name + " = " + First_Operand + " % " + Second_Operand + ";");
                }
            }
            if (Type_Code_Make == 7)
            {
                Arithmetic_Operations_List.Add('\t' + Name + "++" + ";");
            }
            if (Type_Code_Make == 8)
            {
                Arithmetic_Operations_List.Add('\t' + "++" + Name + ";");
            }
            if (Type_Code_Make == 9)
            {
                Arithmetic_Operations_List.Add('\t' + Name + "--" + ";");
            }
            if (Type_Code_Make == 10)
            {
                Arithmetic_Operations_List.Add('\t' + "--" + Name + ";");
            }
        }
    }
}