using System.Windows;
using System.Windows.Media;

namespace RGB_XAML
{
    public partial class CADRE : Window
    {
        public CADRE()
        {
            InitializeComponent();
        }
        private void OnColorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int red = (int)SliderRouge.Value;
            int green = (int)SliderVert.Value;
            int blue = (int)SliderBleu.Value;

            RougeValue.Text = red.ToString();
            VertValue.Text = green.ToString();
            BleuValue.Text = blue.ToString();

            Color color = Color.FromRgb((byte)red, (byte)green, (byte)blue);

            CouleurPreview.Background = new SolidColorBrush(color);

            string hexColor = $"#{red:X2}{green:X2}{blue:X2}";
            RGBCode.Text = hexColor;
        }
        private void CopyToClipboard(object sender, RoutedEventArgs e)
        {
            // Copier le texte affiché dans RGBCode dans le presse-papier
            Clipboard.SetText(RGBCode.Text);
            MessageBox.Show("Code RGB copié dans le presse-papier : " + RGBCode.Text);
        }
    }
}
