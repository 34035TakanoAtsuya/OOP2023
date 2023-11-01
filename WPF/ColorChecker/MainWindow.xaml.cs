using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void rSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush bursh = new SolidColorBrush(color);
            colorArea.Background = bursh;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            SolidColorBrush brush = new SolidColorBrush();
            var comboColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = comboColor.Color;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;

            brush.Color = comboColor.Color;
            colorArea.Background = brush;
        }
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void StockButton_Click(object sender, RoutedEventArgs e) {
            var stock = String.Format("R {0} G {1} B {2}",rSlider.Value,gSlider.Value,bSlider.Value);
            ListBox.Items.Add(stock);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] lb = ListBox.SelectedItem.ToString().Split(' ');
            rText.Text = lb[1];
            gText.Text = lb[3];
            bText.Text = lb[5];
        }
    }
}
