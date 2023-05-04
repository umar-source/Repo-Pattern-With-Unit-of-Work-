using RepoPattern.Models;

namespace RepoPattern.Interface
{
    public interface IStudentRepository : IGenericRepository<Student>, IDisposable
    {
      

    }
}
