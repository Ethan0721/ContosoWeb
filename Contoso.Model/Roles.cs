using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class Roles : AuditableEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<People> Person { get; set; }
    }
}
