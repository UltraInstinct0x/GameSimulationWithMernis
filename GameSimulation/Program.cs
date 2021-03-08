using GameSimulation.Adapters;
using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer oyuncu = new Gamer()
            {
                FirstName = "Gökhan",
                TcId = "15453713426",
                DateOfBirth = new DateTime(1999, 02, 18),
                LastName = "Güney",
                Id = 1
            };
            gamerManager.Add(oyuncu);
            gamerManager.Remove(oyuncu);
            gamerManager.Update(oyuncu);

            Game oyun = new Game() {Id=1,Name="Wild Rift", Description="Brand new mobile vers" +
                "ion of League of Legends, you can enjoy the rift on your cellular with this one.", Price=100};
            GameManager gameManager = new GameManager();
            gameManager.Add(oyun);
            gameManager.Update(oyun);
            gameManager.Delete(oyun);

            Campaign kampanya = new Campaign() {Id=1,Discount=70,Name="Daft Punk Discount" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(kampanya);
            campaignManager.Edit(kampanya);
            campaignManager.Delete(kampanya);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(oyuncu,oyun);
            salesManager.SellWithDiscount(oyuncu, oyun, kampanya);



        }
    }
}
