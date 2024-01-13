using System.Windows;

namespace sonColorsAndBrushes
{
    /// <summary>
    /// StartMenu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class StartMenu : Window
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            SystemColors sc = new SystemColors();
            sc.ShowDialog();
        }
        private void ColorPicker_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker cp = new ColorPicker();
            cp.ShowDialog();
        }

        private void SolidColorBrushes_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrushes scb = new SolidColorBrushes();
            scb.ShowDialog();
        }

        private void LinearGradientBrushes_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrushes lGb = new LinearGradientBrushes();
            lGb.ShowDialog();
        }

        private void RadialGradientBrush_Click(object sender, RoutedEventArgs e)
        {
            RadialGradientBrush rgb = new RadialGradientBrush();
            rgb.ShowDialog();
        }

        private void DrawingBrushes_Click(object sender, RoutedEventArgs e)
        {
            DrawingBrushes db = new DrawingBrushes();
            db.ShowDialog();
        }

        private void CustomColormapBrushes_Click(object sender, RoutedEventArgs e)
        {
            CustomColormapBrushes ccb = new CustomColormapBrushes();
            ccb.ShowDialog();
        }

        private void CustomColorShading_Click(object sender, RoutedEventArgs e)
        {
            CustomColorShading ccs = new CustomColorShading();
            ccs.ShowDialog();
        }
    }
}
