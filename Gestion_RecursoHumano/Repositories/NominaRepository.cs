
namespace Gestion_RecursoHumano.Repositories
{
    public interface INominaRepository : Base.IBaseRepository<Models.Nomina>
    {
    }
    public class NominaRepository : Base.BaseRepository<Models.Nomina>, INominaRepository
    {
        public NominaRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}