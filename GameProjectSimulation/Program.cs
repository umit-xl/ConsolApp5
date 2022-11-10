// See https://aka.ms/new-console-template for more information
using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entity;

GamerManager gamerManager = new GamerManager(new UserValidationManager());

GameManager gameManager = new GameManager();

CampaignManager campaignManager = new CampaignManager();

Gamer gamer1 = new Gamer();
gamer1.Id = 1;
gamer1.FirstName = "Ümit";
gamer1.LastName = "Arlı";
gamer1.DateOfBirth = 2000;
gamer1.GamerNick = "umitxl";

gamerManager.Add(gamer1);

Game game1 = new Game();
game1.GameId = 10;
game1.GameName = "God Of War";
game1.GamePrice = 500;

gameManager.Add(game1);
gameManager.SaleGame(gamer1 ,game1);

Campaign campaign1 = new Campaign();
campaign1.CampaingId = 100;
campaign1.CampaignName = "Kara Cuma";
campaign1.DiscountRate = 0.3f;

campaignManager.Add(campaign1);

gameManager.SaleWithCampaign(gamer1, game1, campaign1);
