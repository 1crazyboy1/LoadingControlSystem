using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using LoadingControlSystem.Model;
using NLog;

namespace LoadingControlSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddBorder();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //ICcard ic = ICcard.GetInstance(0,9600);
            //ic.IC_Connect();
            //ic.GetICDate();
            //ic.IC_Close();
        }
     

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Thread terminalThread = new Thread(terminal);
            terminalThread.Start();
          
        }

        /// <summary>
        /// 刷卡线程
        /// </summary>
        public void terminal()
        {
            while (true)
            {
                Thread.Sleep(300);
            }
        }

        /// <summary>
        /// grid表格画线
        /// </summary>
        public void AddBorder()
        {
            int rows = MainGrid.RowDefinitions.Count;
            int columns = MainGrid.ColumnDefinitions.Count;

            for (int i = 0; i < rows; i++)
            {
                if (i != rows - 1)
                {
                    #region

                    for (int j = 0; j < columns; j++)
                    {
                        Border border = null;
                        if (j == columns - 1)
                        {
                            border = new Border()
                            {
                                BorderBrush = new SolidColorBrush(Colors.Green),
                                BorderThickness = new Thickness(2.5, 2.5, 2.5, 0)
                            };
                        }
                        else
                        {
                            border = new Border()
                            {
                                BorderBrush = new SolidColorBrush(Colors.Green),
                                BorderThickness = new Thickness(2.5, 2.5, 0, 0)
                            };
                        }
                        Grid.SetRow(border, i);
                        Grid.SetColumn(border, j);
                        MainGrid.Children.Add(border);
                    }
                    #endregion
                }
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Border border = null;
                        if (j + 1 != columns)
                        {
                            border = new Border
                            {
                                BorderBrush = new SolidColorBrush(Colors.Green),
                                BorderThickness = new Thickness(2.5, 2.5, 0, 2.5)
                            };
                        }
                        else
                        {
                            border = new Border
                            {
                                BorderBrush = new SolidColorBrush(Colors.Green),
                                BorderThickness = new Thickness(2.5, 2.5, 2.5, 2.5)
                            };
                        }
                        Grid.SetRow(border, i);
                        Grid.SetColumn(border, j);
                        MainGrid.Children.Add(border);
                    }
                }
            }
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
