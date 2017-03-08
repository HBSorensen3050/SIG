/// <summary>
/// Author : Henrik B. Sørensen
/// License: MIT
/// Comment: Copy and use, but please don't delete this header.
/// </summary>

using System.ComponentModel;
using System.Management.Automation;

namespace SysInfoGa
{
    [RunInstaller(true)]
    public class SysInfoGaSnapIn : PSSnapIn
    {
        /// <summary>
        /// Description text
        /// </summary>
        public override string Description
        {
            get
            {
                return "Ping utility";
            }
        }

        /// <summary>
        /// Name of the Add-In
        /// </summary>
        public override string Name
        {
            get
            {
                return "SysInfoGaSnapIn";
            }
        }

        /// <summary>
        /// Vendor name
        /// </summary>
        public override string Vendor
        {
            get
            {
                return "Henrik B. Sørensen";
            }
        }
    }
}
