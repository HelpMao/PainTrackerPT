using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PainTrackerPT.Models.Followups;

namespace PainTrackerPT.Repository
{
    public interface IFollowUpRepository
    {
        Task<IEnumerable<FollowupsLog>> SelectAll();
        Task<FollowupsLog> SelectById(Guid? id);
        Task<FollowupsLog> Find(Guid? id);
        void Update(FollowupsLog followupsLog);
        void Remove(Guid id);
        void Insert(FollowupsLog followupsLog);
        Boolean Exists(Guid id);
        Task<int> Save();
    }
}
