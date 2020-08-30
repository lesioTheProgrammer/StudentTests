using StudentTests.Database.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentTests.Database.Models
{
    [Table("RoleType")]
    public class RoleType : EnumBase<RoleTypeEnum>
    {
    }
}
