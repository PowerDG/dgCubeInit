using System.Threading.Tasks;

namespace dgCube
{
    public interface IFinancingService
    {
        Task<PaySalariedDetail> PayEmployeeSalaried(PaySalariedInput input);
    }
}