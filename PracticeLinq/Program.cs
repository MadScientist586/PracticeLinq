List<string> VideoGames = new()
{ "Splatoon 3",
    "Zelda",
    "Minecraft",
    "Jedi: Fallen Order",
    "ClusterTruck",
    "Fall Guys",
    "Rec Room",
    "Roblox",
    "Super Mario Bros.",
    "Destiny 2"
};
VideoGames.OrderBy(VideoGames => VideoGames.Length)
    .ThenBy(VideoGames => VideoGames)
    .ToList()
    .ForEach(VideoGames => Console.WriteLine(VideoGames));

