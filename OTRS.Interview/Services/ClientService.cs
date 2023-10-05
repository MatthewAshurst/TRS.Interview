using OTRS.Interview.Entities;

namespace OTRS.Interview.Services
{
    public class ClientService
    {
        public void Add(Client entity)
        {
            using (var context = new TrsContext())
            {
                context.Clients.Add(entity);
                context.SaveChanges();
            }
        }

        public void Remove(int ClientId)
        {
            using (var context = new TrsContext())
            {
                var client = context.Clients.Where(c => c.id == ClientId).FirstOrDefault();
                if (client != null)
                {
                    context.Clients.Remove(client);
                    context.SaveChanges();
                }
            }
        }
    }
}
