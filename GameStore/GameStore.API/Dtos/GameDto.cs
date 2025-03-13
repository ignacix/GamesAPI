namespace GameStore.API.Dtos
{
    //Record was added in C# 9 and later, so Class was used instead. 
    //See more info: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
    public class GameDto
    {
        public GameDto(int Id, string Name, string Genre, decimal Price, DateOnly ReleaseDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Genre = Genre;
            this.Price = Price;
            this.RealeaseDate = ReleaseDate;
        }

        public int Id { get; set;}
        public string Name { get; set;}
        public string Genre { get; set;}
        public decimal Price {get; set;}
        public DateOnly RealeaseDate {get; set;}
    }
}
