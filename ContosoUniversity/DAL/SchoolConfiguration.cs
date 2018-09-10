using System.Data.Entity;
using System.Data.Entity.SqlServer;
using ContosoUniversity.DAL;                         //Added to remove DbInterception errors 
using System.Data.Entity.Infrastructure.Interception;// on line 13-14

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}