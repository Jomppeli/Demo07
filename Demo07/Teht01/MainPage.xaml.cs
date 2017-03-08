using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            randomnumTextBlock.Text = "";

        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            
            int num = int.Parse(textBoxdraws.Text);
            int randnumb;
            List<string> rows = new List<string>();
            string temp;
            string temp2;
            string temp3;
            List<int> randomnums = new List<int>();
            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= 7; i++)
                {
                    randnumb = rand.Next(1, 39 + 1);
                    if (randomnums.Contains(randnumb))
                    {
                        i--;
                        continue;
                    }
                    randomnums.Add(randnumb);


                }
                temp3 = "Row " + j.ToString("00") + ": ";
                temp = temp3 + string.Join(" ", randomnums.ToArray()) + "\n";
                rows.Add(temp);

                temp2 = string.Join("", rows.ToArray());

                randomnumTextBlock.Text = temp2.ToString();
                randomnums.Clear();
            }
             
            
            

        }
    }
}
