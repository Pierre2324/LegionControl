using System.Diagnostics;

namespace LegionControl.Utils
{
    internal class Memory
    {
        private string pocPath;
        private string rwPath;

        internal bool Initialize()
        {
            if (File.Exists(System.AppContext.BaseDirectory + "PoC.exe"))
                pocPath = System.AppContext.BaseDirectory + "PoC.exe";
            else 
                return false;

            if (File.Exists(System.AppContext.BaseDirectory + "RwDrv.sys"))
                rwPath = System.AppContext.BaseDirectory + "RwDrv.sys";
            else 
                return false;

            Process rwCreate = RunProcess("cmd.exe", "/c sc create LegionControl binpath=" + rwPath + " type=kernel");

            Process rwStart = RunProcess("cmd.exe", "/c sc start LegionControl");

            return true;
        }

        internal string GetData(string method, string address)
        {
            return Convert.ToInt32(RunProcess("poc.exe", method + " " + address).StandardOutput.ReadToEnd().Trim(), 16).ToString();
        }

        internal string[] GetDatas(string method, string[] address)
        {
            string formatAdress = string.Join(" ", address);

            string[] output = RunProcess("poc.exe", method + " " + formatAdress).StandardOutput.ReadToEnd().Trim().Split(' ');
            for (int i=0; i<output.Length; i++)
                output[i] = (Convert.ToByte(Convert.ToInt32(output[i], 16))).ToString();
            return output;
            //select Convert.ToByte(Convert.ToInt32(n, 16))).ToString().ToArray();
        }

        internal void SetData(string method, string addressarg)
        {
            RunProcess("poc.exe", method + " " + addressarg);
        }

        internal void Exit()
        {
            RunProcess("cmd.exe", "/c sc stop LegionControl");
            RunProcess("cmd.exe", "/c sc delete LegionControl");
        }

        Process RunProcess(string filename, string args)
        {
            Process rwCreate = new Process();
            rwCreate.StartInfo.FileName = filename;
            rwCreate.StartInfo.Arguments = args;
            rwCreate.StartInfo.CreateNoWindow = true;
            rwCreate.StartInfo.UseShellExecute = false;
            rwCreate.StartInfo.RedirectStandardOutput = true;
            rwCreate.Start();
            rwCreate.WaitForExit();

            return rwCreate;
        }
    }
}
