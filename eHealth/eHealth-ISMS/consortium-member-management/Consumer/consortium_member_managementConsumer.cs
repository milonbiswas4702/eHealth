using MassTransit;
using consortium_member_management.Models;
using consortium_member_management.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace consortium_member_management.Consumer
{
    public class consortium_member_managementConsumer : IConsumer<ConsortiumMember>, IConsumer<ConsortiumMembers>, IConsumer<ConsortiumMemberM>
    {
        private readonly IConsortiumMemberRepos _repository;

        public consortium_member_managementConsumer(IConsortiumMemberRepos repository)
        {
            _repository = repository;
        }
        public async Task Consume(ConsumeContext<ConsortiumMember> context)
        {
            var ConsortiumMember = context.Message;

            List<ConsortiumMember> ConsortiumMembers =  _repository.GetConsortiumMembers();
            var msg = ConsortiumMembers.Find(c => c.Id == ConsortiumMember.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<ConsortiumMembers> context)
        {
            ConsortiumMembers msg = new();
            msg.ConsortiumMemberList =  _repository.GetConsortiumMembers();
            await context.RespondAsync(msg);
        }
        public async Task Consume(ConsumeContext<ConsortiumMemberM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                ConsortiumMember ConsortiumMember = new();
                ConsortiumMember.Id = context.Message.Id;
                ConsortiumMember.ColumnOne = context.Message.ColumnOne;
                ConsortiumMember.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository.PostConsortiumMember(ConsortiumMember);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
