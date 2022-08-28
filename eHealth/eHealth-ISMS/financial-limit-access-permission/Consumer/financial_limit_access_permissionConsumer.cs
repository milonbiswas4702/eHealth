using MassTransit;
using financial_limit_access_permission.Models;
using financial_limit_access_permission.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace financial_limit_access_permission.Consumer
{
    public class financial_limit_access_permissionConsumer : IConsumer<LimitAccessPermission>, IConsumer<LimitAccessPermissions>, IConsumer<LimitAccessPermissionM>
    {
        private readonly ILimitAccessPermissionRepos _repository;

        public financial_limit_access_permissionConsumer(ILimitAccessPermissionRepos repository)
        {
            _repository = repository;
        }
        public async Task Consume(ConsumeContext<LimitAccessPermission> context)
        {
            var LimitAccessPermission = context.Message;

            List<LimitAccessPermission> LimitAccessPermissions =  _repository.GetLimitAccessPermissions();
            var msg = LimitAccessPermissions.Find(c => c.Id == LimitAccessPermission.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<LimitAccessPermissions> context)
        {
            LimitAccessPermissions msg = new();
            msg.LimitAccessPermissionList =  _repository.GetLimitAccessPermissions();
            await context.RespondAsync(msg);
        }
        public async Task Consume(ConsumeContext<LimitAccessPermissionM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                LimitAccessPermission LimitAccessPermission = new();
                LimitAccessPermission.Id = context.Message.Id;
                LimitAccessPermission.ColumnOne = context.Message.ColumnOne;
                LimitAccessPermission.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository.PostLimitAccessPermission(LimitAccessPermission);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
