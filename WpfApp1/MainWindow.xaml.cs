using BLL_.BLL;
using DTO.Model;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            visUsernames();
        }

        UsernamesBLL bll = new UsernamesBLL();
        List<Usernames> list;
        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            ListUsernames.Items.Clear();
            list = bll.getUsernames(tbNameStartWith.Text);
            foreach(Usernames u in list)
            {
                ListUsernames.Items.Add(u);
            }
        }

        private void visUsernames()
        {
            ListUsernames.Items.Clear();
            foreach (Usernames u in bll.AllUsernames())
            {
                ListUsernames.Items.Add(u);
            }
        }

        private void bfind2_Click(object sender, RoutedEventArgs e)
        {
            tBlock.Text = "";
            var tempList = bll.getInfo(tbx2.Text);
            tBlock.Text = $"{tempList[0]}\n{tempList[1]}\n{tempList[2]}";
        }
    }
}
