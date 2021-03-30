using System.Threading.Tasks;

namespace dgCube
{
    public interface ISendMessage
    {
        void SendEmail(Task<PaySalariedDetail> result);
        void SendMessage(Task<PaySalariedDetail> result);
        void PushWeChat(Task<PaySalariedDetail> result);
    }
}