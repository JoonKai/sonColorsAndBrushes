﻿using Microsoft.Samples.CustomControls;
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
using System.Windows.Shapes;

namespace sonColorsAndBrushes
{
    /// <summary>
    /// SolidColorBrushes.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SolidColorBrushes : Window
    {
        public SolidColorBrushes()
        {
            InitializeComponent();

            SolidColorBrush brush = new SolidColorBrush();

            brush = Brushes.Red;
            rect1.Fill = brush;

            brush = new SolidColorBrush(Colors.Green);
            rect2.Fill = brush;

            brush = new SolidColorBrush(Color.FromArgb(100, 0, 0, 255));
            rect3.Fill = brush;

            brush = new SolidColorBrush(Color.FromScRgb(0.5f, 0.7f, 0.0f, 0.5f));
            rect4.Fill = brush;

            brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#CBFFFFAA"));
            rect5.Fill = brush;

        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPickerDialog cPicker = new ColorPickerDialog();
            cPicker.StartingColor = Colors.LightBlue;
            cPicker.Owner = this;
            bool? dialogResult = cPicker.ShowDialog();
            if(dialogResult !=null &&(bool)dialogResult == true)
            {
                rect6.Fill = new SolidColorBrush(cPicker.SelectedColor);
            }
        }
    }
}
