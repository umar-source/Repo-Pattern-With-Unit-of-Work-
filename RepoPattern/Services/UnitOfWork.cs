using Microsoft.EntityFrameworkCore;
using RepoPattern.Interface;
using RepoPattern.Models;
namespace RepoPattern.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SchoolDbContext _dbContext;
      
        public UnitOfWork(SchoolDbContext dbContext, IStudentRepository StudentRepository)
        {
            this._dbContext = dbContext;
            this.StudentRepo = StudentRepository;
        }

        // Add private fields for any additional repositories for other entity types here
        public IStudentRepository StudentRepo { get; private set; }
       

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
         
        public void Rollback()
        {
            _dbContext.Dispose();
        }
    }
}
