Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);
Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");
artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);
Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");
if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine("\n=== КАТАЛОГ ИГР ===");
Game game1 = new Game("The Witcher 3", "RPG", 2015);
Game game2 = new Game("Minecraft", "Sandbox", 2011);
Game game3 = new Game("Cyberpunk 2077", "RPG", 2020);
Console.WriteLine($">>> {game1.Title} <<<");
Console.WriteLine($"Жанр: {game1.Genre}, Год: {game1.ReleaseYear}, Рейтинг: {game1.Rating}");
Console.WriteLine($"Часов сыграно до: {game1.HoursPlayed}");
game1.AddHoursPlayed(15);
Console.WriteLine($"Часов после добавления 15: {game1.HoursPlayed}");
game1.AddHoursPlayed(-5);
Console.WriteLine($"Часов после добавления -5 (не изменилось): {game1.HoursPlayed}");
Console.WriteLine();
Console.WriteLine($">>> {game2.Title} <<<");
Console.WriteLine($"Жанр: {game2.Genre}, Год: {game2.ReleaseYear}, Рейтинг: {game2.Rating}");
Console.WriteLine($"Часов сыграно: {game2.HoursPlayed}");

Console.WriteLine();

Console.WriteLine($">>> {game3.Title} <<<");
Console.WriteLine($"Жанр: {game3.Genre}, Год: {game3.ReleaseYear}, Рейтинг: {game3.Rating}");
Console.WriteLine($"Часов сыграно: {game3.HoursPlayed}");