using DemoApi.Data;
using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Repository
{
    public class TlmAppRepository : ITlmAppRepository
    {
        private readonly DemoDbContext _context;

        public TlmAppRepository(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TlmApp>> GetAllTlmApps()
        {
            return await _context.TlmApps.ToListAsync();
        }

        public async Task<TlmApp?> GetTlmAppById(string id)
        {
            return await _context.TlmApps.FirstOrDefaultAsync(t => t.TJX_App_ID == id);
        }

        public async Task<TlmApp> SaveTlmApp(TlmApp tlmApp)
        {
            await _context.TlmApps.AddAsync(tlmApp);
            await _context.SaveChangesAsync();
            return tlmApp;
        }

        public async Task<TlmApp> UpdateTlmApp(TlmApp tlmApp)
        {
            var existingTlmApp = await _context.TlmApps.FirstOrDefaultAsync(t => t.TJX_App_ID == tlmApp.TJX_App_ID);
            if (existingTlmApp == null)
                throw new KeyNotFoundException("TlmApp not found");

            existingTlmApp.App_Name = tlmApp.App_Name;
            existingTlmApp.App_Description = tlmApp.App_Description;
            existingTlmApp.App_status = tlmApp.App_status;
            existingTlmApp.app_owner = tlmApp.app_owner;
            existingTlmApp.App_Initial_Deploy_Date = tlmApp.App_Initial_Deploy_Date;
            existingTlmApp.User_Interface_Type = tlmApp.User_Interface_Type;
            existingTlmApp.App_Type = tlmApp.App_Type;
            existingTlmApp.App_Accessability = tlmApp.App_Accessability;
            existingTlmApp.External_Vendor_Name = tlmApp.External_Vendor_Name;
            existingTlmApp.Solution_Delivery_Area = tlmApp.Solution_Delivery_Area;
            existingTlmApp.Functional_Area = tlmApp.Functional_Area;
            existingTlmApp.Legal_Requirement = tlmApp.Legal_Requirement;
            existingTlmApp.Business_Criticality = tlmApp.Business_Criticality;
            existingTlmApp.App_Defined_Responsiveness = tlmApp.App_Defined_Responsiveness;
            existingTlmApp.App_Performance_Satisfaction = tlmApp.App_Performance_Satisfaction;
            existingTlmApp.Skill_Availability = tlmApp.Skill_Availability;
            existingTlmApp.Sensitive_Data_Applicable = tlmApp.Sensitive_Data_Applicable;
            existingTlmApp.App_Authentication = tlmApp.App_Authentication;
            existingTlmApp.App_Support_Team = tlmApp.App_Support_Team;
            existingTlmApp.Num_Screens = tlmApp.Num_Screens;
            existingTlmApp.Future_Scalability = tlmApp.Future_Scalability;
            existingTlmApp.COTS_Customization = tlmApp.COTS_Customization;
            existingTlmApp.Automation_Deployment = tlmApp.Automation_Deployment;
            existingTlmApp.Source_code_Location = tlmApp.Source_code_Location;
            existingTlmApp.Qtly_Release_Frequency = tlmApp.Qtly_Release_Frequency;
            existingTlmApp.Security_Enablement = tlmApp.Security_Enablement;
            existingTlmApp.Num_interfaces = tlmApp.Num_interfaces;
            existingTlmApp.Num_Inbound_Interfaces = tlmApp.Num_Inbound_Interfaces;
            existingTlmApp.Num_Outbound_Interfaces = tlmApp.Num_Outbound_Interfaces;
            existingTlmApp.Integration_protocol_list = tlmApp.Integration_protocol_list;
            existingTlmApp.Peak_period = tlmApp.Peak_period;
            existingTlmApp.Multi_Lingual = tlmApp.Multi_Lingual;
            existingTlmApp.Third_Party_Dependency = tlmApp.Third_Party_Dependency;
            existingTlmApp.Documentation_Location = tlmApp.Documentation_Location;
            existingTlmApp.Documentation_Quality = tlmApp.Documentation_Quality;
            existingTlmApp.App_contact = tlmApp.App_contact;
            existingTlmApp.Architecture_contact = tlmApp.Architecture_contact;
            existingTlmApp.Comments = tlmApp.Comments;
            existingTlmApp.Software_Type = tlmApp.Software_Type;
            existingTlmApp.Usage_Type = tlmApp.Usage_Type;
            existingTlmApp.Leanix_TJX_APP_ID = tlmApp.Leanix_TJX_APP_ID;
            existingTlmApp.last_updated_by = tlmApp.last_updated_by;
            existingTlmApp.last_updated_date = tlmApp.last_updated_date;
            existingTlmApp.LeanIX_ID = tlmApp.LeanIX_ID;
            existingTlmApp.SNOW_ID = tlmApp.SNOW_ID;
            existingTlmApp.compliance_flag = tlmApp.compliance_flag;
            existingTlmApp.Business_Capabilities = tlmApp.Business_Capabilities;
            existingTlmApp.Legacy_TJX_APP_ID = tlmApp.Legacy_TJX_APP_ID;

            _context.TlmApps.Update(existingTlmApp);
            await _context.SaveChangesAsync();

            return existingTlmApp;
        }

        public async Task<bool> DeleteTlmApp(string id)
        {
            var tlmApp = await _context.TlmApps.FirstOrDefaultAsync(t => t.TJX_App_ID == id);
            if (tlmApp == null)
            {
                throw new KeyNotFoundException("TlmApp not found");
            }

            _context.TlmApps.Remove(tlmApp);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
