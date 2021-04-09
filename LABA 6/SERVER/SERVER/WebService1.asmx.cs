using System.Web.Services;

namespace SERVER
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : WebService
    {
        //массив рейсов
        REIS[] marshrut = { new REIS("1", "Orel", "14/03/2021 14:43", 10),
                            new REIS("2", "Moscow", "17/03/2021 15:21", 15),
                            new REIS("3", "Novgorod", "19/03/2021 10:12", 11),
                            new REIS("4", "Moscow", "20/03/2021 8:08", 20),
        };
        static int razmer = 100;
        static int[] izm = new int[razmer];
        string[] sbor = new string[razmer];
        string otvet;
        [WebMethod]
        public string ShowMarshrut() //показать все маршруты
        {
            int temp = 0;
            for (int i = 0; i < marshrut.Length; i++)
            {
                int new_colvo = marshrut[i].poluchncolvo() - izm[i];
                marshrut[i].izmencolvo(new_colvo);
                otvet = marshrut[i].id_town + " " + marshrut[i].town + " " + marshrut[i].data + " " + marshrut[i].poluchncolvo();
                sbor[temp] = otvet;
                temp += 1;
            }
            otvet = "";
            for (int i = 0; i < marshrut.Length; i++)
            {
                otvet = otvet + sbor[i] + " ";
                otvet = otvet + "\r\n";
            }
            return otvet;
        }

        [WebMethod]
        public string CheckReis(string Reis) //проверить рейс по названию
        {
            int temp = 0;
            for (int i = 0; i < marshrut.Length; i++)
            {
                bool result = Reis.Equals(marshrut[i].town);
                if (result)
                {
                    otvet = marshrut[i].id_town + " " + marshrut[i].town + " " + marshrut[i].data;
                    sbor[temp] = otvet;
                    temp += 1;
                }
            }
            otvet = "";
            for (int i = 0; i < marshrut.Length; i++)
            {
                otvet = otvet + sbor[i] + " ";
                otvet = otvet + "\r\n";
            }
            return otvet;
        }
        [WebMethod]
        public string Checkbilet(string Reis) //проверить наличие билетов на рейс по названию
        {
            int temp = 0;
            for (int i = 0; i < marshrut.Length; i++)
            {
                bool result = Reis.Equals(marshrut[i].town);
                if (result)
                {
                    int new_colvo = marshrut[i].poluchncolvo() - izm[i];
                    marshrut[i].izmencolvo(new_colvo);
                    otvet = marshrut[i].id_town + " " + marshrut[i].town + " " + marshrut[i].poluchncolvo();
                    sbor[temp] = otvet;
                    temp += 1;
                }
            }
            otvet = "";
            for (int i = 0; i < marshrut.Length; i++)
            {
                otvet = otvet + sbor[i] + " ";
                otvet = otvet + "\r\n";
            }
            return otvet;
        }
        [WebMethod]
        public string Zakazbilet(string id) //заказать билет на рейс по его id
        {
            string temp = "Заказ не удался, кончились билеты";
            for (int i = 0; i < marshrut.Length; i++)
            {
                bool result = id.Equals(marshrut[i].id_town);
                if (result)
                {
                    if (marshrut[i].poluchncolvo() - izm[i] == 0)
                    {
                        return temp;
                    }
                    izm[i] = izm[i] + 1;
                    int new_colvo = marshrut[i].poluchncolvo() - izm[i];
                    marshrut[i].izmencolvo(new_colvo);
                    otvet = marshrut[i].id_town + " " + marshrut[i].town + " " + marshrut[i].data + " " + marshrut[i].poluchncolvo();
                }
            }
            return otvet;
        }

    }
}