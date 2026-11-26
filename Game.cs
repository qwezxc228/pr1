public class Game {
    public string Title;
    public string Genre;
    public int ReleaseYear;
    public double Rating;
    public int HoursPlayed; // Новое поле для ПР №2

    public Game(string title, string genre, int releaseYear) {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = 0.0;
        HoursPlayed = 0; 
    }

    // Новый метод с параметром и защитой (ранний return)
    public void AddHoursPlayed(int hours) {
        if (hours <= 0) {
            return;
        }
        HoursPlayed += hours;
    }
}