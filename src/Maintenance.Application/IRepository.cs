namespace Maintenance.Application
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Realiza uma busca pelo index.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(
            long id
        );

        /// <summary>
        /// Cria um novo registro.
        /// </summary>
        /// <param name="entity"></param>
        void Create(
            TEntity entity
        );
    }
}