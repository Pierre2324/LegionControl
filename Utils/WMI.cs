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
		internal string GetData(string root, string instance, string arg)
		{
			ManagementBaseObject mbo = new ManagementObject(root, instance, null).InvokeMethod(arg, null, null);
			return mbo["Data"].ToString();
		}
		internal void SetData(string root, string instance, string param, string arg)
        {
			ManagementObject mo = new ManagementObject(root, instance, null);
			ManagementBaseObject mp = mo.GetMethodParameters(param);
			mp["Data"] = arg;
			mo.InvokeMethod(param, mp, null);
		}
	}
}
