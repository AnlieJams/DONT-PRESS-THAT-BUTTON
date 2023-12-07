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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int value = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            value++;
            if (value == 1)
            {
                MessageBox.Show($"Опа, вы издали звук ЫЫЫЫЫЭЭЭЭЭЭЭА: {value} раз");
            }
            else MessageBox.Show($"Опа, вы издали звук ЫЫЫЫЫЭЭЭЭЭЭЭА: {value} раза");
            if (value == 4)
            {
                MessageBox.Show("так, всё харэ");
            }
        }
    }
}