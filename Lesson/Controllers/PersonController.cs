using Microsoft.AspNetCore.Mvc;

namespace Lesson.Controllers;

[Route("[controller]")]
public class PersonController : ControllerBase
{
  [HttpPost]
  public Guid Create(
    [FromServices] IPersonActions action,
    [FromBody] PersonInfo request)
  {
    return action.Create(request);
  }

  [HttpGet]
  public PersonInfo Get([FromQuery] Guid id)
  {
    return action.Get(id);
  }
}
