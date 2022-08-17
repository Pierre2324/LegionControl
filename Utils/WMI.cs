using System.Management;

namespace LegionControl.Utils
{
	internal class WMI
	{
		internal string GetDataGMZN(string root, string instance, string arg)
		{
			ManagementBaseObject mbo = new ManagementObject(root, instance, null).InvokeMethod(arg, null, null);
			return mbo["Data"].ToString();
		}

		internal string GetDataSelect(string root, string arg, string item)
        {
			ManagementObjectSearcher mos = new ManagementObjectSearcher(root, arg);
			string output = null;
			foreach (ManagementObject mo in mos.Get())
				output = mo[item].ToString();

			return output;
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
