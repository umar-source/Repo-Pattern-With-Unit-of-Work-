using RepoPattern.Interface;
using RepoPattern.Models;
using RepoPattern.Repository;

namespace RepoPattern.Repositories
{
    public class StudentRepository : GenericRepository<Student> , IStudentRepository
    {
        public StudentRepository(SchoolDbContext dbContext) : base(dbContext)
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
