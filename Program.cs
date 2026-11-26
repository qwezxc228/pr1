Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");
Console.WriteLine();
Console.WriteLine("=== КАТАЛОГ ИГР ===");

Game game1 = new Game("The Witcher 3", "RPG", 2015);
Game game2 = new Game("Minecraft", "Sandbox", 2011);
Game game3 = new Game("Cyberpunk 2077", "RPG", 2020);
game1.Rating = 9.8;

Console.WriteLine(">>> Игра 1 <<<");
Console.WriteLine($"Название: {game1.Title}");
Console.WriteLine($"Жанр: {game1.Genre}");
Console.WriteLine($"Год выхода: {game1.ReleaseYear}");
Console.WriteLine($"Рейтинг: {game1.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 2 <<<");
Console.WriteLine($"Название: {game2.Title}");
Console.WriteLine($"Жанр: {game2.Genre}");
Console.WriteLine($"Год выхода: {game2.ReleaseYear}");
Console.WriteLine($"Рейтинг: {game2.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 3 <<<");
Console.WriteLine($"Название: {game3.Title}");
Console.WriteLine($"Жанр: {game3.Genre}");
Console.WriteLine($"Год выхода: {game3.ReleaseYear}");
Console.WriteLine($"Рейтинг: {game3.Rating}");