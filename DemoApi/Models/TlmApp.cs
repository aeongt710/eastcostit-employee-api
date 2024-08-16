using System.ComponentModel.DataAnnotations;

namespace DemoApi.Models
{
    public class TlmApp
    {
        [Key]
        public string TJX_App_ID { get; set; }
        public string? App_Name { get; set; }
        public string? App_Description { get; set; }
        public string? App_status { get; set; }
        public string? app_owner { get; set; }
        public DateTime App_Initial_Deploy_Date { get; set; }
        public string? User_Interface_Type { get; set; }
        public string? App_Type { get; set; }
        public string? App_Accessability { get; set; }
        public string? External_Vendor_Name { get; set; }
        public string? Solution_Delivery_Area { get; set; }
        public string? Functional_Area { get; set; }
        public string? Legal_Requirement { get; set; }
        public string? Business_Criticality { get; set; }
        public string? App_Defined_Responsiveness { get; set; }
        public string? App_Performance_Satisfaction { get; set; }
        public string? Skill_Availability { get; set; }
        public string? Sensitive_Data_Applicable { get; set; }
        public string? App_Authentication { get; set; }
        public string? App_Support_Team { get; set; }
        public int Num_Screens { get; set; }
        public int Future_Scalability { get; set; }
        public string? COTS_Customization { get; set; }
        public string? Automation_Deployment { get; set; }
        public string? Source_code_Location { get; set; }
        public int Qtly_Release_Frequency { get; set; }
        public string? Security_Enablement { get; set; }
        public int Num_interfaces { get; set; }
        public int Num_Inbound_Interfaces { get; set; }
        public int Num_Outbound_Interfaces { get; set; }
        public string? Integration_protocol_list { get; set; }
        public string? Peak_period { get; set; }
        public string? Multi_Lingual { get; set; }
        public string? Third_Party_Dependency { get; set; }
        public string? Documentation_Location { get; set; }
        public string? Documentation_Quality { get; set; }
        public string? App_contact { get; set; }
        public string? Architecture_contact { get; set; }
        public string? Comments { get; set; }
        public string? Software_Type { get; set; }
        public string? Usage_Type { get; set; }
        public string? Leanix_TJX_APP_ID { get; set; }
        public string? last_updated_by { get; set; }
        public string? last_updated_date { get; set; }
        public string? LeanIX_ID { get; set; }
        public string? SNOW_ID { get; set; }
        public string? compliance_flag { get; set; }
        public string? Business_Capabilities { get; set; }
        public string? Legacy_TJX_APP_ID { get; set; }

    }
}
