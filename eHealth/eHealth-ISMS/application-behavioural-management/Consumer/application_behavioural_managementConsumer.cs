using MassTransit;
using application_behavioural_management.Models;
using application_behavioural_management.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace application_behavioural_management.Consumer
{
    public class application_behavioural_managementConsumer : IConsumer<SecurityPolicySetupMaster>, IConsumer<SecurityPolicySetupMasters>, IConsumer<SecurityPolicySetupMasterM>
    {
        private readonly ISecurityPolicySetupMasterRepos _repository;

        public application_behavioural_managementConsumer(ISecurityPolicySetupMasterRepos repository)
        {
            _repository = repository;
        }
        public async Task Consume(ConsumeContext<SecurityPolicySetupMaster> context)
        {
            var SecurityPolicySetupMaster = context.Message;

            List<SecurityPolicySetupMaster> SecurityPolicySetupMasters =  _repository.GetSecurityPolicySetupMasters();
            var msg = SecurityPolicySetupMasters.Find(c => c.Id == SecurityPolicySetupMaster.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<SecurityPolicySetupMasters> context)
        {
            SecurityPolicySetupMasters msg = new();
            msg.SecurityPolicySetupMasterList =  _repository.GetSecurityPolicySetupMasters();
            await context.RespondAsync(msg);
        }
        public async Task Consume(ConsumeContext<SecurityPolicySetupMasterM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                SecurityPolicySetupMaster SecurityPolicySetupMaster = new();
                SecurityPolicySetupMaster.Id = context.Message.Id;
                SecurityPolicySetupMaster.ColumnOne = context.Message.ColumnOne;
                SecurityPolicySetupMaster.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository.PostSecurityPolicySetupMaster(SecurityPolicySetupMaster);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
