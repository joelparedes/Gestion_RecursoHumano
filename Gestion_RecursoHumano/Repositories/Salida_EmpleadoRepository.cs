
namespace Gestion_RecursoHumano.Repositories
{
    public interface ISalida_EmpleadoRepository : Base.IBaseRepository<Models.Salida_Empleado>
    {
    }
    public class Salida_EmpleadoRepository : Base.BaseRepository<Models.Salida_Empleado>, ISalida_EmpleadoRepository
    {
        public Salida_EmpleadoRepository(Context.GestionContext context): base(context)
        {
        }
    }
}