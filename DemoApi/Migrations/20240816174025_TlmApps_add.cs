using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApi.Migrations
{
    /// <inheritdoc />
    public partial class TlmApps_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TlmApps",
                columns: table => new
                {
                    TJX_App_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    App_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    app_owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Initial_Deploy_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Interface_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Accessability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    External_Vendor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solution_Delivery_Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Functional_Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legal_Requirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Business_Criticality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Defined_Responsiveness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Performance_Satisfaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skill_Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sensitive_Data_Applicable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Authentication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_Support_Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_Screens = table.Column<int>(type: "int", nullable: false),
                    Future_Scalability = table.Column<int>(type: "int", nullable: false),
                    COTS_Customization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Automation_Deployment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_code_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qtly_Release_Frequency = table.Column<int>(type: "int", nullable: false),
                    Security_Enablement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_interfaces = table.Column<int>(type: "int", nullable: false),
                    Num_Inbound_Interfaces = table.Column<int>(type: "int", nullable: false),
                    Num_Outbound_Interfaces = table.Column<int>(type: "int", nullable: false),
                    Integration_protocol_list = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peak_period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Multi_Lingual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Third_Party_Dependency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentation_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentation_Quality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Architecture_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Software_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usage_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leanix_TJX_APP_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_updated_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeanIX_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SNOW_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    compliance_flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Business_Capabilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legacy_TJX_APP_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TlmApps", x => x.TJX_App_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TlmApps");
        }
    }
}
