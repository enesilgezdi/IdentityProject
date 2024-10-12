using IdentityProject.WebApi1.Models;

namespace IdentityProject.WebApi1.Repository.Abstracts;

public interface IEntityRepository<TEntity> where TEntity : Entity, new()
{
    TEntity? GetById(int id);
    List<TEntity> GetAll();

    TEntity Add(TEntity user);

    TEntity Update(TEntity user);

    TEntity Delete(int id);



}
