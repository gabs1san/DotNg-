using DotNg1.Models;

namespace DotNg1.Routes;

public static class PeopleRoutes
{

    public static List<People> Peoples = new()
    {
        new People(Guid.NewGuid(), "Gabriel"),
        new People(Guid.NewGuid(), "Marilene"),
        new People(Guid.NewGuid(), "Michael"),
    };
    public static void MapPeopleRoutes(this WebApplication app)
    {
        app.MapGet("peoples", () => Peoples );
    }
}