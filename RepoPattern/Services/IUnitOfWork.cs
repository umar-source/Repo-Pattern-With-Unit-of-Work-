using RepoPattern.Interface;
using RepoPattern.Models;

namespace RepoPattern.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepo { get; }
        // Add any additional repositories for other entity types here

        void Commit();
        void Rollback();

    }
}
