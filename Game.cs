public class Game {
    private string _title = "Безымянная игра";

    public string Title {
        get {
            return _title;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _title = "Безымянная игра";
                return;
            }

            _title = value.Trim();
        }
    }

    public string Genre { get; private set; }
    public int ReleaseYear { get; private set; }
    public double Rating { get; private set; }
    public int HoursPlayed { get; private set; }

    public Game(string title, string genre, int releaseYear) {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = 0.0;
        HoursPlayed = 0; 
    }

    public void AddHoursPlayed(int hours) {
        if (hours <= 0) {
            return;
        }
        HoursPlayed += hours;
    }
}