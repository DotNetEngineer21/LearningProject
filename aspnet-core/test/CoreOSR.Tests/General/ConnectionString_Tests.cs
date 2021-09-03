﻿using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace CoreOSR.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=CoreOSR; Trusted_Connection=True;");
            csb["Database"].ShouldBe("CoreOSR");
        }
    }
}
