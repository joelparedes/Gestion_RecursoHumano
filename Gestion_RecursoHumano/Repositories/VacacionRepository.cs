
namespace Gestion_RecursoHumano.Repositories
{
    public interface IVacacionRepository : Base.IBaseRepository<Models.Vacacion>
    {
    }
    public class VacacionRepository : Base.BaseRepository<Models.Vacacion>, IVacacionRepository
    {
        public VacacionRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}