
namespace Gestion_RecursoHumano.Repositories
{
    public interface IPermisoRepository : Base.IBaseRepository<Models.Permiso>
    {
        //
    }
    public class PermisoRepository : Base.BaseRepository<Models.Permiso>, IPermisoRepository
    {
        public PermisoRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}