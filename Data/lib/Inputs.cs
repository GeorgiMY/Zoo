using Data;

namespace Zoo.Data.lib
{
    public static class Inputs
    {
        public static void InputIt()
        {
            ZooContext context = new ZooContext();
            //if (context.GameCompanies.Any()) return;

            //using (StreamReader reader = new StreamReader("input.txt"))
            //{
            //    List<Player> players = new List<Player>();
            //    List<GameCompany> companies = new List<GameCompany>();
            //    List<Creator> creators = new List<Creator>();
            //    List<Game> games = new List<Game>();
            //    List<(int CreatorIndex, int GameIndex)> creatorGameLinks = new List<(int CreatorIndex, int GameIndex)>();
            //    List<string> achievementNames = new List<string>();

            //    string line;
            //    int i = 0;

            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        if (i < 5) players.Add(new Player { Name = line });
            //        else if (i < 10) companies.Add(new GameCompany { Name = line });
            //        else if (i < 15) creators.Add(new Creator { Name = line });
            //        else if (i < 20)
            //        {
            //            int[] parts = line.Split(' ').Select(int.Parse).ToArray();
            //            creatorGameLinks.Add((parts[0], parts[1]));
            //        }
            //        else if (i < 25) achievementNames.Add(line);
            //        else if (i < 30)
            //        {
            //            GameCompany company = companies[i - 25];
            //            games.Add(new Game { Name = line, GameCompany = company });
            //        }

            //        i++;
            //    }

            //    context.Players.AddRange(players);
            //    context.GameCompanies.AddRange(companies);
            //    context.Creators.AddRange(creators);
            //    context.Games.AddRange(games);
            //    context.SaveChanges();

            //    for (int j = 0; j < 5; j++)
            //    {
            //        context.Achievements.Add(new Achievement
            //        {
            //            Name = achievementNames[j],
            //            PlayerId = players[j].PlayerId,
            //            GameId = games[j].GameId
            //        });
            //    }

            //    foreach (var (creatorIdx, gameIdx) in creatorGameLinks)
            //    {
            //        context.CreatorGames.Add(new CreatorGame
            //        {
            //            CreatorId = creators[creatorIdx].CreatorId,
            //            GameId = games[gameIdx].GameId
            //        });
            //    }

            //    context.SaveChanges();
            //}
        }

    }
}
