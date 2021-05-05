using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SecretSanta.Web.Api;

namespace SecretSanta.Web.Tests.Api
{
    public class TestableUsersClient : IUsersClient
    {
        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public List<User>? GetAllUsersReturnValue {get; set;}
        public int GetAllAsyncInvocationCount {get; set;}
        public Task<ICollection<User>?> GetAllAsync()
        {
            GetAllAsyncInvocationCount++;
            return Task.FromResult<ICollection<User>?>(GetAllUsersReturnValue);
        }

        public Task<ICollection<User>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public int PostAsyncInvocationCount {get; set;}
        public List<User> PostAsyncInvokedParameters {get;} = new();

        public Task<User> PostAsync(User user)
        {
            PostAsyncInvocationCount++;
            PostAsyncInvokedParameters.Add(user);
            return Task.FromResult<User>(user);
        }

        public Task<User> PostAsync(User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task PutAsync(int id, User user)
        {
            throw new System.NotImplementedException();
        }

        public Task PutAsync(int id, User user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}