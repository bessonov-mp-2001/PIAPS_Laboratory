using System.ServiceModel;

namespace CHAT
{
    public class ServerUser //Класс пользователя
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext operationContext { get; set; } //Информация о подключении клиента к сервису
    }
}
