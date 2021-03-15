using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CHAT
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "SrviceChat" в коде и файле конфигурации.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] //Создается один сервис для всех клиентов
    public class SrviceChat : ISrviceChat
    {
        List<ServerUser> users = new List<ServerUser>(); //Список всех пользователей
        int nextId = 1;

        public int Connect(string name) //Соединение с пользователем
        {
            ServerUser user = new ServerUser()
            {
                ID = nextId,
                Name = name,
                operationContext = OperationContext.Current
            };
            nextId++;

            SendMsg(": "+user.Name + " подключился",0);
            users.Add(user);
            return user.ID;
        }

        public void Disconnect(int id) //Разъединение 
        {
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
            {
                users.Remove(user);
                SendMsg(": " + user.Name + " отключился",0);
            }
        }

        public void SendMsg(string msg, int id) //Отправка сообщений
        {
            foreach(var item in users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = users.FirstOrDefault(i => i.ID == id); //Ищем переданный ID
                if (user != null)
                {
                    answer += ": " + user.Name + " ";
                }
                answer += msg;
                item.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer); //Указываем, что это функция возврата
            }
        }
    }
}
