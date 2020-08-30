using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StudentTests.Database.Models.Enums
{
    public enum RoleTypeEnum
    {
        User = 0,
        [Description("Test Author")]
        TestAuthor = 1,
        [Description("Admin")]
        Admin = 2

    }
}
