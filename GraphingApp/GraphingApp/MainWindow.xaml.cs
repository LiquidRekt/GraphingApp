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

namespace GraphingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void drawBaseLine(object sender, EventArgs e)
        {
            //Draw horizontal line graph
            HorizontalLine = new Line();
            HorizontalLine.Stroke = Brushes.Black;
            HorizontalLine.X1 = 0;
            HorizontalLine.Y1 = 250;
            HorizontalLine.X2 = 500;
            HorizontalLine.Y2 = 250;
            HorizontalLine.StrokeThickness = 1;
            graphArea.Children.Add(HorizontalLine);

            //Draw vertical line graph
            VerticalLine = new Line();
            VerticalLine.Stroke = Brushes.Black;
            VerticalLine.X1 = 250;
            VerticalLine.Y1 = 0;
            VerticalLine.X2 = 250;
            VerticalLine.Y2 = 500;
            VerticalLine.StrokeThickness = 1;
            graphArea.Children.Add(VerticalLine);

            //dotDeclare
            dotX1 = new Line();
            dotX2 = new Line();
            dotX3 = new Line();
            dotX4 = new Line();
            dotX5 = new Line();
            dotX6 = new Line();
            dotX7 = new Line();
            dotX8 = new Line();
            dotY1 = new Line();
            dotY2 = new Line();
            dotY3 = new Line();
            dotY4 = new Line();
            dotY5 = new Line();
            dotY6 = new Line();
            dotY7 = new Line();
            dotY8 = new Line();


            //dotStrokes
            dotX1.Stroke = Brushes.Black; dotX1.StrokeThickness = 1;
            dotX2.Stroke = Brushes.Black; dotX2.StrokeThickness = 1;
            dotX3.Stroke = Brushes.Black; dotX3.StrokeThickness = 1;
            dotX4.Stroke = Brushes.Black; dotX4.StrokeThickness = 1;
            dotX5.Stroke = Brushes.Black; dotX5.StrokeThickness = 1;
            dotX6.Stroke = Brushes.Black; dotX6.StrokeThickness = 1;
            dotX7.Stroke = Brushes.Black; dotX7.StrokeThickness = 1;
            dotX8.Stroke = Brushes.Black; dotX8.StrokeThickness = 1;
            dotY1.Stroke = Brushes.Black; dotY1.StrokeThickness = 1;
            dotY2.Stroke = Brushes.Black; dotY2.StrokeThickness = 1;
            dotY3.Stroke = Brushes.Black; dotY3.StrokeThickness = 1;
            dotY4.Stroke = Brushes.Black; dotY4.StrokeThickness = 1;
            dotY5.Stroke = Brushes.Black; dotY5.StrokeThickness = 1;
            dotY6.Stroke = Brushes.Black; dotY6.StrokeThickness = 1;
            dotY7.Stroke = Brushes.Black; dotY7.StrokeThickness = 1;
            dotY8.Stroke = Brushes.Black; dotY8.StrokeThickness = 1;

            //dotPositions
            dotX1.X1 = 50; dotX1.Y1 = 245; dotX1.X2 = 50; dotX1.Y2 = 255;
            dotX2.X1 = 100; dotX2.Y1 = 245; dotX2.X2 = 100; dotX2.Y2 = 255;
            dotX3.X1 = 150; dotX3.Y1 = 245; dotX3.X2 = 150; dotX3.Y2 = 255;
            dotX4.X1 = 200; dotX4.Y1 = 245; dotX4.X2 = 200; dotX4.Y2 = 255;
            dotX5.X1 = 300; dotX5.Y1 = 245; dotX5.X2 = 300; dotX5.Y2 = 255;
            dotX6.X1 = 350; dotX6.Y1 = 245; dotX6.X2 = 350; dotX6.Y2 = 255;
            dotX7.X1 = 400; dotX7.Y1 = 245; dotX7.X2 = 400; dotX7.Y2 = 255;
            dotX8.X1 = 450; dotX8.Y1 = 245; dotX8.X2 = 450; dotX8.Y2 = 255;

            dotY1.X1 = 245; dotY1.Y1 = 50; dotY1.X2 = 255; dotY1.Y2 = 50;
            dotY2.X1 = 245; dotY2.Y1 = 100; dotY2.X2 = 255; dotY2.Y2 = 100;
            dotY3.X1 = 245; dotY3.Y1 = 150; dotY3.X2 = 255; dotY3.Y2 = 150;
            dotY4.X1 = 245; dotY4.Y1 = 200; dotY4.X2 = 255; dotY4.Y2 = 200;
            dotY5.X1 = 245; dotY5.Y1 = 300; dotY5.X2 = 255; dotY5.Y2 = 300;
            dotY6.X1 = 245; dotY6.Y1 = 350; dotY6.X2 = 255; dotY6.Y2 = 350;
            dotY7.X1 = 245; dotY7.Y1 = 400; dotY7.X2 = 255; dotY7.Y2 = 400;
            dotY8.X1 = 245; dotY8.Y1 = 450; dotY8.X2 = 255; dotY8.Y2 = 450;


            graphArea.Children.Add(dotX1);
            graphArea.Children.Add(dotX2);
            graphArea.Children.Add(dotX3);
            graphArea.Children.Add(dotX4);
            graphArea.Children.Add(dotX5);
            graphArea.Children.Add(dotX6);
            graphArea.Children.Add(dotX7);
            graphArea.Children.Add(dotX8);
            graphArea.Children.Add(dotY1);
            graphArea.Children.Add(dotY2);
            graphArea.Children.Add(dotY3);
            graphArea.Children.Add(dotY4);
            graphArea.Children.Add(dotY5);
            graphArea.Children.Add(dotY6);
            graphArea.Children.Add(dotY7);
            graphArea.Children.Add(dotY8);

        }

        double a = 0;
        double b = 0;
        double x = 0;
        double y = 0;
        double rate = 50;
        double crossX = 0;
        double crossY = 0;
        double checkX = 0;
        double checkY = 0;
        double diffX = 0;
        double diffY = 0;

        void getCrossX()
        {
            a = Convert.ToDouble(aInp.Text);
            b = Convert.ToDouble(bInp.Text);
            x = (0 - b) / a;
            crossX = x * rate;
            checkX = crossX;
            if (checkX < 0)
            {
                checkX = 0 - checkX;
            }
            diffX = 250 - checkX;
        }

        void getCrossY()
        {
            b = Convert.ToDouble(bInp.Text);
            y = b;
            crossY = y * rate;
            checkY = crossY;
            if (checkY < 0)
            {
                checkY = 0 - checkY;
            }
            diffY = 250 - checkY;
        }
        
        private void drawGraphLine(object sender, RoutedEventArgs e)
        {
            graphArea.Children.Remove(InputLine);
            getCrossX();
            getCrossY();
            double CompareX = diffX / rate;
            double CompareY = diffY / rate;
            if (CompareX < 0)
            {
                CompareX = 0 - CompareX;
            }
            if (CompareY < 0)
            {
                CompareY = 0 - CompareY;
            }
            //Draw Input Line
            InputLine = new Line();
            InputLine.Stroke = Brushes.Blue;
            InputLine.StrokeThickness = 1;
            if (x == y)
            {
                InputLine.X1 = 0;
                InputLine.Y1 = 500;
                InputLine.X2 = 500;
                InputLine.Y2 = 0;
            } else if (x == -y)
            {
                    
            }
             else if (checkY >= checkX)
            {
                InputLine.X1 = (250 + crossX) + (crossX * 250 / rate);
                InputLine.Y1 = 500;
                InputLine.X2 = 250 - (crossX * diffY / rate);
                InputLine.Y2 = 0;

            } else if (checkY < checkX)
            { 
                InputLine.X1 = 0;
                InputLine.Y1 = (250 + crossX) + (crossX * CompareX);
                InputLine.X2 = 500;
                InputLine.Y2 = (250 + crossX) + (crossX * CompareY);
               
            } else if (x == y)
            {
                InputLine.X1 = 0;
                InputLine.Y1 = 500;
                InputLine.X2 = 500;
                InputLine.Y2 = 0;
            }
            graphArea.Children.Add(InputLine);
        }

    }
}
