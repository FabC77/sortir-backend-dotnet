using Domain.models.entities;
using Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DbInitializer
    {

        public static void Initialize(SortirContext context)
        {
            if (!context.EventStatus.Any())
            {
                var eventStatus = new EventStatus[]
                {
new EventStatus {Name="In_Progress" },
new EventStatus {Name="Draft" },
new EventStatus {Name="Closed" },
new EventStatus {Name="Cancelled" },
new EventStatus {Name="Finished" },
new EventStatus {Name="Open" },

                };
                context.EventStatus.AddRange(eventStatus);
                context.SaveChanges();

            }
        }
    }
}
