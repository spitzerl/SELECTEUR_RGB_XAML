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

        // Méthode qui gère le changement de couleur
        private void OnColorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Récupérer les valeurs des sliders
            int red = (int)SliderRouge.Value;
            int green = (int)SliderVert.Value;
            int blue = (int)SliderBleu.Value;

            // Afficher les valeurs actuelles des sliders dans les TextBlock
            RougeValue.Text = red.ToString();
            VertValue.Text = green.ToString();
            BleuValue.Text = blue.ToString();

            // Créer une nouvelle couleur basée sur les valeurs des sliders
            Color color = Color.FromRgb((byte)red, (byte)green, (byte)blue);

            // Mettre à jour le fond du carré de couleur
            CouleurPreview.Background = new SolidColorBrush(color);
        }
    }
}
