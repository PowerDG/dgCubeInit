using Abp.Application.Services;
using Abp.Authorization;
using dgCube.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dgCube
{
    public  class SalaryApplicationService:ApplicationService
    {

        private readonly ILogger<SalaryApplicationService> _logger;

        private readonly IFinancingService _financingServiceService;

        private readonly ISendMessage _sendMessageService;

        public SalaryApplicationService(
            ILogger<SalaryApplicationService> logger,
            ISendMessage sendMessageService,
            IFinancingService service)
        {
            _logger = logger;
            _sendMessageService = sendMessageService;
            _financingServiceService = service;

        }
        /// <summary>
        /// 发放工资
        /// **不包含业务规则或者知识，
        /// 而只为下一层中的领域对象协调任务，分配工作，使它们互相协作。**
        /// </summary>
        /// <returns></returns>
        [AbpAuthorize(PermissionNames.Pages_Tenants)]
        public async Task<bool> PaySalaried(PaySalariedInput input)
        {
            //A @【**执行顺序 * *以及 * *结果的拼装 * *】
            //B @【隐藏了领域层的复杂性及其内部实现机制】

            //1--行政财务权限【安全认证，权限校验】
            if (!await PermissionChecker.IsGrantedAsync("行政财务权限"))
            {
                return false;
            }

            //2--转账，包含了以下逻辑，在financingServiceService中实现业务
            //（结算工时）查询财务结算薪酬
            //检查支付账号余额是否足够
            //检查目标账户账号是否合法
            var result = _financingServiceService.PayEmployeeSalaried(input);

            //3- 检查转账**任务的进度** 与异常
            await CheckErrors(result);

            //框架平台提供的配置获取 
            var paySalariedSetting= SettingManager
                .GetSettingValueForTenant(input.EmployeeId, 021);
            //4-通知薪酬发放结果
            //【向其他系统发生基于事件的消息通知】
            //【事务控制】
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                ///
                _sendMessageService.SendEmail(result);
                _sendMessageService.SendMessage(result);
                _sendMessageService.PushWeChat(result);
                unitOfWork.Complete();
            }

            return true;
        }

        private Task CheckErrors(Task<PaySalariedDetail> result)
        {
            throw new NotImplementedException();
        }

        public async Task<QuerySalaryOutput> QuerySalary(QuerySalaryInput input)
        {
            var output = new QuerySalaryOutput();
            

            return output;
        }
    }
}
