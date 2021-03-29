using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CHAT
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "SrviceChat" в коде и файле конфигурации.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class SrviceChat : ISrviceChat
    {
        List<ServerUser> users = new List<ServerUser>();
        int nextId = 1;

        public int Connect(string name)
        {
            ServerUser user = new ServerUser()
            {
                ID = nextId,
                Name = name,
                operationContext = OperationContext.Current
            };
            nextId++;

            SendMsg(": " + user.Name + " подключился", 0);
            Console.WriteLine(user.Name + " подключился");
            users.Add(user);
            return user.ID;
        }

        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
            {
                users.Remove(user);
                SendMsg(": " + user.Name + " отключился", 0);
                Console.WriteLine(user.Name + " отключился");
            }
        }

        public void SendMsg(string msg, int id)
        {
            foreach (var item in users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = users.FirstOrDefault(i => i.ID == id);
                if (user != null)
                {
                    answer += ": " + user.Name + " ";
                }
                answer += msg;
                Console.WriteLine(answer);
                item.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer);
            }
        }
    }
}
