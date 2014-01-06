using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fanqieWPF
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void label1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tabChanged(All_TODO);
        }

        private void label2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tabChanged(TODAY);
 
        }

        private void label3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tabChanged(START);
        }

        private void tabChanged(TextBlock text) 
        {
            FontWeight normalFontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromString("Normal");
            All_TODO.FontWeight = normalFontWeight;
            TODAY.FontWeight = normalFontWeight;
            START.FontWeight = normalFontWeight;

            text.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromString("Bold");
        }

        private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        //recentTODO.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromString("Bold");

        /* 
        private void recentTODO_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) 
            {
                recentTODO.FontWeight = (FontWeight)System.ComponentModel.TypeDescriptor.GetConverter(typeof(FontWeight)).ConvertFromString("Bold");
            }            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }
         */
    }
}
