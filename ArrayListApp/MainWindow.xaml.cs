using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void bttnAdd_Click(object sender, RoutedEventArgs e)
        {
           
            if (txtBox.Text == "")
            {
                MessageBox.Show("Please Input your information");
            }
            else
            {
                arrayList.Add(txtBox.Text);
                MessageBox.Show(" Add Sucessfully");
                txtBox.Clear();
                
                
            }
        }

        private void bttnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text == "")
            {
                MessageBox.Show("Please Input your information");
            }
            else
            {
                arrayList.Remove(txtBox.Text);
                MessageBox.Show("Remove Sucessfully");
                txtBox.Clear();
            }
        }


        private void bttnShow_Click(object sender, RoutedEventArgs e)
        {
            
            if (arrayList.Count == 0)
            {
                MessageBox.Show("Can't Processed");
            }
            else
            {
                arrayList.Sort();

                foreach (string data in arrayList)
                {
                    MessageBox.Show(data);
                    txtBox.Clear();
                }
                MessageBox.Show("Count" + " " + arrayList.Count.ToString());

            }
      
        }

        private void bttnClear_Click(object sender, RoutedEventArgs e)
        {
            if (arrayList.Count == 0)
            {
                MessageBox.Show("Can't Processed");
            }
            else
            {
                txtBox.Clear();
                arrayList.Clear();
                MessageBox.Show("Delete Information Secessfully");

            }

        }

    }
}
