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

namespace SendVideoMail
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        SharedAPI sharedAPI;
        const string serverURL = @"\\SHKO\sh_공유폴더";

        public MainWindow()
        {
            InitializeComponent();
            connectShareFolder();
        }

        private void connectShareFolder()
        {
            sharedAPI = new SharedAPI();
            int result = sharedAPI.ConnectRemoteServer(serverURL);
            MessageBox.Show("result  " + result);
        }

    }
}
