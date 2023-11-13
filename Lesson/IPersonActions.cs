namespace Lesson
{
  public interface IPersonActions
  {
    Guid Create(PersonInfo request);

    PersonInfo Get(Guid id);
  }
}
