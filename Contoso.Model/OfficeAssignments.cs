using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
namespace Contoso.Model
{
    public class OfficeAssignments : AuditableEntity
    {
        public string Location  { get; set; }
    }
}
