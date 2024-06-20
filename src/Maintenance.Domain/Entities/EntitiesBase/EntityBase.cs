namespace Maintenance.Domain.Entities.EntitiesBase
{
    public class EntityBase
    {
        /// <summary>
        /// Index da entidade.
        /// </summary>
        /// <value></value>
        public virtual long Id { get; set; }

        /// <summary>
        /// Deletado.
        /// </summary>
        /// <value></value>
        public virtual bool Deleted { get; set; }
    }
}