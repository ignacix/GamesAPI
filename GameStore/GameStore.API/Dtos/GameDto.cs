namespace GameStore.API.Dtos
{
    //Record was added in C# 9 and later, so Class was used instead. 
    //See more info: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
    public class GameDto
    {
        public GameDto(){
            this.Name = "";
            this.Genre = "";
        }
        public GameDto(int id, string name, string genre, decimal price, DateTime releaseDate)
        {
            this.Id = id;
            this.Name = name;
            this.Genre = genre;
            this.Price = price;
            this.ReleaseDate = releaseDate;
        }

        public int Id { get; set;}
        public string Name { get; set;}
        public string Genre { get; set;}
        public decimal Price {get; set;}
        public DateTime ReleaseDate {get; set;}
    }
}
