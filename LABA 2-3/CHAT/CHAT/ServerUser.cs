using System.ServiceModel;

namespace CHAT
{
    public class ServerUser //Класс пользователя
    {
        public int ID { get; set; } //свойства с методами установки и получения

        public string Name { get; set; } //свойства с методами установки и получения

        public OperationContext operationContext { get; set; } //Информация о подключении клиента к сервису
    }
}
