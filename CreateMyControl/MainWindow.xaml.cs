using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ruma.Controls;

namespace CreateMyControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonTextAndCheck btn = new ButtonTextAndCheck();
            
            btn.CheckBoxCheckStateChanged += Part_CheckBox_Click;
            btn.ButtonClick += btn_ClickButton;
            btn.TextButton = "asdasdasd";
            Grid1.Children.Add(btn);
            string s = qqq.TextButton;

        }

        void btn_ClickButton(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        void Part_CheckBox_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            qqq.IsCheckBoxChecked = false;
        }

    }
}
