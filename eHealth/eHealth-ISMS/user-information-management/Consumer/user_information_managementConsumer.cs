using MassTransit;
using user_information_management.Models;
using user_information_management.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace user_information_management.Consumer
{
    public class user_information_managementConsumer : IConsumer<User>, IConsumer<Users>, IConsumer<UserM>
    {
        private readonly IUserRepos _repository;

        public user_information_managementConsumer(IUserRepos repository)
        {
            _repository = repository;
        }
        public async Task Consume(ConsumeContext<User> context)
        {
            var User = context.Message;

            List<User> Users =  _repository.GetUsers();
            var msg = Users.Find(c => c.Id == User.Id);

            await context.RespondAsync(msg);
        }

        public async Task Consume(ConsumeContext<Users> context)
        {
            Users msg = new();
            msg.UserList =  _repository.GetUsers();
            await context.RespondAsync(msg);
        }
        public async Task Consume(ConsumeContext<UserM> context)
        {
            if (context.Message.MethodName == "POST")
            {
                User User = new();
                User.Id = context.Message.Id;
                User.ColumnOne = context.Message.ColumnOne;
                User.ColumnTwo = context.Message.ColumnTwo;
                var msg = _repository.PostUser(User);
                context.Message.Id = msg.Id;
                context.Message.MethodName = null;
                await context.RespondAsync(context.Message);
            }
        }
    }
}
