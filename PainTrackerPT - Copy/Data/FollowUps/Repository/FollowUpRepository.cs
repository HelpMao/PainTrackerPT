using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using PainTrackerPT.Models;
using PainTrackerPT.Models.Followups;
using PainTrackerPT.Repository;
using Microsoft.EntityFrameworkCore;

namespace PainTrackerPT.Data.FollowUps.Repository
{
    public class FollowUpRepository : IFollowUpRepository
    {
        private readonly PainTrackerPTContext _context;

        public FollowUpRepository(PainTrackerPTContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FollowupsLog>> SelectAll()
        {
            return await _context.FollowupsLog.ToListAsync();
        }

        public async Task<FollowupsLog> SelectById(Guid? id)
        {
            return await _context.FollowupsLog.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<FollowupsLog> Find(Guid? id)
        {
            return await _context.FollowupsLog.FindAsync(id);
        }

        public async void Update(FollowupsLog followupsLog)
        {
            _context.Update(followupsLog);
            await _context.SaveChangesAsync();
        }

        public async void Insert(FollowupsLog followupsLog)
        {
            _context.FollowupsLog.Add(followupsLog);
            await _context.SaveChangesAsync();
        }

        public async void Remove(Guid id)
        {
            FollowupsLog followupsLog = await _context.FollowupsLog.FindAsync(id);
            _context.FollowupsLog.Remove(followupsLog);
            await _context.SaveChangesAsync();
        }

        public Boolean Exists(Guid id)
        {
            return _context.FollowupsLog.Any(e => e.Id == id);
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
