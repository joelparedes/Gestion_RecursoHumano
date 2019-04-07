
namespace Gestion_RecursoHumano.Repositories
{
    public interface ILicenciaRepository : Base.IBaseRepository<Models.Licencia>
    {
    }
    public class LicenciaRepository : Base.BaseRepository<Models.Licencia>, ILicenciaRepository
    {
        public LicenciaRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}