using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Threading.Tasks;

namespace LegionControl.Utils
{
    internal class WMI
	{
		public string GetData(string root, string instance, string arg)
        {
			ManagementBaseObject mbo = new ManagementObject(root, instance, null).InvokeMethod(arg, null, null);
			return mbo["Data"].ToString();
        }
	}
}
