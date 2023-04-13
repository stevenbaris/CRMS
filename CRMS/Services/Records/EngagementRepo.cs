using CRMS.Data;
using CRMS.Exceptions;
using CRMS.Models.Records;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Services.Records
{
    public class EngagementRepo:IRepository<Engagement>
    {
        private readonly CRMSDbContext _dBcontext;

        public EngagementRepo(CRMSDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }

        public async Task<Engagement> CreateAsync(Engagement engagement)
        {
            try
            {
                _dBcontext.Engagements.Add(engagement);
                await _dBcontext.SaveChangesAsync();
                return engagement;
            }
            catch (Exception ex)
            {
                throw new EngagementException("Error creating engagement.", ex);
            }
        }

        public async Task<Engagement> DeleteAsync(Guid id)
        {
            try
            {
                var engagement = await _dBcontext.Engagements.FindAsync(id);
                if (engagement == null)
                {
                    // throw an exception if the engagement is not found
                    throw new EngagementNotFoundException($"Engagement with id {id} not found.");
                }
                _dBcontext.Engagements.Remove(engagement);
                await _dBcontext.SaveChangesAsync();
                return engagement;
            }
            catch (Exception ex)
            {
                throw new EngagementException($"Error deleting engagement with id {id}.", ex);
            }
        }

        public async Task<List<Engagement>> GetAllAsync()
        {
            try
            {
                var engagements = await _dBcontext.Engagements
                    .AsNoTracking()
                    .Include(engagements => engagements.EngagementType)
                    .Include(engagements => engagements.Effectivity)
                    .Include(engagements => engagements.CommunicationMethod)
                    .Include(engagements => engagements.Contacts)
                    .Include(engagements => engagements.User)
                    .ToListAsync();
                return engagements;
            }
            catch (Exception ex)
            {
                throw new EngagementException("Error getting all engagements.", ex);
            }
        }

        public async Task<Engagement> GetbyIdAsync(Guid id)
        {
            try
            {
                var engagement = await _dBcontext.Engagements
                    .AsNoTracking()
                    .Include(engagements => engagements.EngagementType)
                    .Include(engagements => engagements.Effectivity)
                    .Include(engagements => engagements.CommunicationMethod)
                    .Include(engagements => engagements.Contacts)
                    .Include(engagements => engagements.User)
                    .SingleOrDefaultAsync(c => c.Engagement_Id == id);
                    
                if (engagement == null)
                {
                    throw new EngagementNotFoundException($"Engagement with id {id} not found.");
                }
                return engagement;
            }
            catch (Exception ex)
            {
                throw new EngagementException($"Error getting engagement with id {id}.", ex);
            }
        }

        public async Task<Engagement> UpdateAsync(Engagement engagement)
        {
            try
            {
                if (engagement == null)
                {
                    // provide a more descriptive error message
                    throw new ArgumentNullException(nameof(engagement), "Engagement parameter cannot be null.");
                }
                _dBcontext.Engagements.Update(engagement);
                await _dBcontext.SaveChangesAsync();
                return engagement;
            }
            catch (Exception ex)
            {
                throw new EngagementException($"Error updating engagement with id {engagement.Engagement_Id}.", ex);
            }
        }
    }
}
