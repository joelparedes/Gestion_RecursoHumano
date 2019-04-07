
namespace Gestion_RecursoHumano.Repositories
{
    public interface IDepartamentoRepository : Base.IBaseRepository<Models.Departamento>
    {
    }
    public class DepartamentoRepository : Base.BaseRepository<Models.Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}