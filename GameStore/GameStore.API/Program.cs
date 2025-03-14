using GameStore.API.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

GameDto g1 = new GameDto(1,"Street Fighter","Fighting",22,new DateOnly(1998,7,30));
GameDto g2 = new GameDto(2,"Metal Slug","Plataforma",25,new DateOnly(1980,7,30));
GameDto g3 = new GameDto(3,"Prince of Persia","Adventure",50,new DateOnly(2006,4,15));

List<GameDto> gameDtos = new List<GameDto>();
gameDtos.Add(g1);
gameDtos.Add(g2);
gameDtos.Add(g3);


//GET /
app.MapGet("/", () => "hola");

// GET /games
app.MapGet("games", () => gameDtos);

// GET /games/id
app.MapGet("games/{id}",(int id) => gameDtos.Find(game => game.Id == id));

app.Run();
