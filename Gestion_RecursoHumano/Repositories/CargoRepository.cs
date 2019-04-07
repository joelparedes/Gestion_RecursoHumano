
namespace Gestion_RecursoHumano.Repositories
{
    public interface ICargoRepository : Base.IBaseRepository<Models.Cargo>
    {
    }
    public class CargoRepository : Base.BaseRepository<Models.Cargo>, ICargoRepository
    {
        public CargoRepository(Context.GestionContext context) :base (context)
        {
        }
    }
}