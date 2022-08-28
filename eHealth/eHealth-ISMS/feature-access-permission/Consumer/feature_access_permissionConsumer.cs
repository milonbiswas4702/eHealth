using MassTransit;
using feature_access_permission.Models;
using feature_access_permission.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace feature_access_permission.Consumer
{
    public class feature_access_permissionConsumer : IConsumer<AccessPermission>, 
                                                     IConsumer<AccessPermissions>, 
                                                     IConsumer<AccessPermissionM>, 
                                                     IConsumer<PageDefination>, 
                                                     IConsumer<PageDefinations>, 
                                                     IConsumer<PageDefinationM>
    {
        private readonly IAccessPermissionRepos _repository_modelOne;
        private readonly IModelOneRepos _repository_modelTwo;

        public feature_access_permissionConsumer(IAccessPermissionRepos repository)
        {
            _repository_modelOne = repository;
        }
        public async Task Consume(ConsumeContext<AccessPermission> context)
        {
            var AccessPermission = context.Message;

            List<AccessPermission> AccessPermissions =  _repository_modelOne.GetAccessPermissions();
            var msg = AccessPermissions.Find(c => c.Id == AccessPermission.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<AccessPermissions> context)
        {
            AccessPermissions msg = new();
            msg.AccessPermissionList =  _repository_modelOne.GetAccessPermissions();
            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<AccessPermissionM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                AccessPermission AccessPermission = new();
                AccessPermission.Id = context.Message.Id;
                AccessPermission.ColumnOne = context.Message.ColumnOne;
                AccessPermission.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository_modelOne.PostAccessPermission(AccessPermission);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }

        public async Task Consume(ConsumeContext<PageDefination> context)
        {
            var PageDefination = context.Message;

            List<PageDefination> PageDefination =  _repository_modelTwo.GetPageDefinations();
            var msg = PageDefinations.Find(c => c.Id == PageDefination.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<PageDefinations> context)
        {
            PageDefinations msg = new();
            msg.PageDefinationList =  _repository_modelTwo.GetPageDefinations();
            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<PageDefinationM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                PageDefination PageDefination = new();
                PageDefination.Id = context.Message.Id;
                PageDefination.ColumnOne = context.Message.ColumnOne;
                PageDefination.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository_modelTwo.PostPageDefination(PageDefination);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
