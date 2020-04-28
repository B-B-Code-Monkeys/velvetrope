using System;
using System.Threading.Tasks;

namespace VelvetRope.Client.Web.Data
{
    public class EventService
    {
        public Task<Event[]> GetNewEvents()
        {
            return Task.FromResult(new[]
            {
                new Event { Name = "Show 1",  Description = "Lorem ipsum dolor set", StartDate = DateTime.Parse("4/27/2020")},
                new Event { Name = "Show 2",  Description = "Lorem ipsum dolor set", StartDate = DateTime.Parse("3/25/2020")},
                new Event { Name = "Show 3",  Description = "Lorem ipsum dolor set", StartDate = DateTime.Parse("2/28/2020")},
            });
        }
    }
}
