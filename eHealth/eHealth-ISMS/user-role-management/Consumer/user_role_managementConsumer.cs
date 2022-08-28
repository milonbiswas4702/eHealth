using MassTransit;
using user_role_management.Models;
using user_role_management.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace user_role_management.Consumer
{
    public class user_role_managementConsumer : IConsumer<RoleDefinition>, 
                                                IConsumer<RoleDefinitions>, 
                                                IConsumer<RoleDefinitionM>, 
                                                IConsumer<RolePermission>, 
                                                IConsumer<RolePermissions>, 
                                                IConsumer<RolePermissionM>
    {
        private readonly IRoleDefinitionRepos _repository_RoleDefinition;
        private readonly IRolePermissionRepos _repository_RolePermission;

        public feature_access_permissionConsumer(IRoleDefinitionRepos repository)
        {
            _repository = repository;
        }
        public async Task Consume(ConsumeContext<RoleDefinition> context)
        {
            var RoleDefinition = context.Message;

            List<RoleDefinition> RoleDefinitions =  _repository.GetRoleDefinitions();
            var msg = RoleDefinitions.Find(c => c.Id == RoleDefinition.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<RoleDefinitions> context)
        {
            RoleDefinitions msg = new();
            msg.RoleDefinitionList =  _repository.GetRoleDefinitions();
            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<RoleDefinitionM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                RoleDefinition RoleDefinition = new();
                RoleDefinition.Id = context.Message.Id;
                RoleDefinition.ColumnOne = context.Message.ColumnOne;
                RoleDefinition.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository.PostRoleDefinition(RoleDefinition);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }

        public async Task Consume(ConsumeContext<RolePermission> context)
        {
            var RolePermission = context.Message;

            List<RolePermission> RolePermission =  _repository_RolePermission.GetRolePermissions();
            var msg = RolePermissions.Find(c => c.Id == RolePermission.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<RolePermissions> context)
        {
            RolePermissions msg = new();
            msg.RolePermissionList =  _repository_RolePermission.GetRolePermissions();
            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<RolePermissionM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                RolePermission RolePermission = new();
                RolePermission.Id = context.Message.Id;
                RolePermission.ColumnOne = context.Message.ColumnOne;
                RolePermission.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository_RolePermission.PostRolePermission(RolePermission);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
