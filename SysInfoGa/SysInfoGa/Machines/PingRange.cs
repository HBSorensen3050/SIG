/// <summary>
/// Author : Henrik B. Sørensen
/// License: MIT
/// Comment: Copy and use, but please don't delete this header.
/// </summary>using System;

using System.Management.Automation;

namespace SysInfoGa
{
    [Cmdlet("Get", "Pings")]
    public class PingRange : Cmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject("Pinging Machines...");
        }
    }
}
