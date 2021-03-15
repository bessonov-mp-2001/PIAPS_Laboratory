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
using ChatClient.ServiceChat;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISrviceChatCallback
    {
        bool isConnected = false;
        SrviceChatClient client;
        int ID;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        void ConnectUser() //Функция соединенния пользователя
        {
            if (!isConnected)
            {
                client = new SrviceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(tbUserName.Text);
                tbUserName.IsEnabled = false;
                bConDisc.Content = "Disconnect";
                isConnected = true;
            }
        }

        void DisconnectUser() //Функция разъединения пользователя
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                tbUserName.IsEnabled = true;
                bConDisc.Content = "Connect";
                isConnected = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Обработчик кнопки присоединения/разъединения 
        {
            if (isConnected)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        public void MsgCallback(string msg) //Получить сообщение от сервера
        {
            lbChat.Items.Add(msg);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) //обработчик внештатного выхода
        {
            DisconnectUser();
        }

        private void Button_send(object sender, RoutedEventArgs e) //функция отправки сообщения
        {
            if (client != null && tbMessage.Text!="")
            {
                client.SendMsg(tbMessage.Text, ID);
                tbMessage.Text = string.Empty;
            }
        }
    }
}
