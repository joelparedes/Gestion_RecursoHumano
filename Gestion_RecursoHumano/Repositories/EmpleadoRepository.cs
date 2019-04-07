
namespace Gestion_RecursoHumano.Repositories
{
    public interface IEmpleadoRepository : Base.IBaseRepository<Models.Empleado>
    {
    }
    public class EmpleadoRepository : Base.BaseRepository<Models.Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(Context.GestionContext context) : base(context)
        {
        }
    }
}