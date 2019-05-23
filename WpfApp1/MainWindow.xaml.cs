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

using System.Windows.Forms;
using System.Drawing;
//AxTeeChart和TeeChart
//using AxTeeChart;
using TeeChart;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int i = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string messageto = "You did not enter a server name. Cancel this operation?";
            string caption = "No Server Name Specified";
            ///MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            ///DialogResult result1;

            // Displays the MessageBox.

            System.Windows.MessageBox.Show(messageto, caption);

            for(Int32 c = 0; c < 254; c++)
            {                               
                SolidColorBrush sob = new SolidColorBrush();
                sob.Color = System.Windows.Media.Color.FromRgb((byte)c, (byte)(255 - c), (byte)c);
                //button.Background = sob;
                this.Background = sob;
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }

            for (Int32 c = 254; c >= 0; c--)
            {                              
                SolidColorBrush sob = new SolidColorBrush();
                sob.Color = System.Windows.Media.Color.FromRgb((byte)c, (byte)(255 - c), (byte)c);
                //button.Background = sob;
                this.Background = sob;
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            anotherClass1 acs = new anotherClass1();            
            acs.saysomething(20, i);
            i++;
            //while (Visible)
            //{
            //    for (int c = 0; c < 254; c++)
            //    {
            //        this.BackColor = Color.FromArgb(c, 255 - c, c);
            //        Application.DoEvents();
            //        System.Threading.Thread.Sleep(3);
            //    }

            //    for (int c = 254; c >= 0; c--)
            //    {
            //        this.BackColor = Color.FromArgb(c, 255 - c, c);
            //        Application.DoEvents();
            //        System.Threading.Thread.Sleep(3);
            //    }
            //} 


            //强制类型转换测试代码：
            //////int myInt = 10;
            //////byte myByte = (byte)myInt;
            //////double myDouble = (double)myByte;
            //////bool myBool = (bool)myDouble;
            //////string myString = "false";
            //////myBool = (bool)myString;
            //////myString = (string)myInt;
            //////myString = myInt.ToString();
            //////myBool = (bool)myByte;
            //////myByte = (byte)myBool;
            //////short myShort = (short)myInt;
            //////char myChar = 'X';
            //////myString = (string)myChar;
            //////long myLong = (long)myInt;
            //////decimal myDecimal = (decimal)myLong;
            //////myString = myString + myInt + myByte + myDouble + myChar;

        }
    }
}
