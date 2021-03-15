using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

    class REIS
    {
        public string id_town; // идентификатор
        public string town; // город назначения
        public string data; // дата и время отправки
        private int colvo; // количество
        public REIS(string id_town, string town, string data, int colvo)
        {
            this.id_town = id_town;
            this.town = town;
            this.data = data;
            this.colvo = colvo;
        }

        public void izmencolvo(int value)
        {
            this.colvo = value;
        }
        public int poluchncolvo()
        {
            return colvo;
        }
    }

    public class WebService1 : System.Web.Services.WebService
    {
        REIS[] marshrut = { new REIS("1", "Orel", "14/03/2021 14:43", 10),
                            new REIS("2", "Moscow", "17/03/2021 15:21", 15),
                            new REIS("3", "Novgorod", "19/03/2021 10:12", 11),
                            new REIS("4", "Moscow", "20/03/2021 8:08", 20),
        };
        static int razmer = 4;
        static int[] izm = new int[razmer];
        string[] sbor = new string[razmer];
        string otvet;
        [WebMethod]
        public string ShowMarshrut()
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
        public string CheckReis(string Reis)
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
        public string Checkbilet(string Reis)
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
        public string Zakazbilet(string id)
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