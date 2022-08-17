﻿using System.Diagnostics;

namespace LegionControl.Utils
{
    internal class Memory
    {
        private string pocPath;
        private string rwPath;

        internal int Initialize()
        {
            if (File.Exists(System.AppContext.BaseDirectory + "PoC.exe"))
            {
                pocPath = System.AppContext.BaseDirectory + "PoC.exe";
            }
            else return 0;

            if (File.Exists(System.AppContext.BaseDirectory + "RwDrv.sys"))
            {
                rwPath = System.AppContext.BaseDirectory + "RwDrv.sys";
            }
            else return 0;

            Process rwCreate = new Process();
            rwCreate.StartInfo.FileName = "cmd.exe";
            rwCreate.StartInfo.Arguments = "/c sc create LegionControl binpath=" + rwPath + " type=kernel";
            rwCreate.StartInfo.CreateNoWindow = true;
            rwCreate.StartInfo.UseShellExecute = false;
            rwCreate.StartInfo.RedirectStandardOutput = true;
            rwCreate.Start();
            rwCreate.WaitForExit();

            Process rwStart = new Process();
            rwStart.StartInfo.FileName = "cmd.exe";
            rwStart.StartInfo.Arguments = "/c sc start LegionControl";
            rwStart.StartInfo.CreateNoWindow = true;
            rwStart.StartInfo.UseShellExecute = false;
            rwStart.StartInfo.RedirectStandardOutput = true;
            rwStart.Start();
            rwStart.WaitForExit();

            return 1;
        }

        internal string GetData(string method, string address)
        {
            Process poc = new Process();
            poc.StartInfo.FileName = "poc.exe";
            poc.StartInfo.Arguments = method + " " + address;
            poc.StartInfo.CreateNoWindow = true;
            poc.StartInfo.UseShellExecute = false;
            poc.StartInfo.RedirectStandardOutput = true;
            poc.Start();
            poc.WaitForExit();
            return Convert.ToInt32(poc.StandardOutput.ReadToEnd().Trim(), 16).ToString();
        }

        internal string[] GetDatas(string method, string[] address)
        {
            string formatAdress = string.Join(" ", address);
            Process poc = new Process();
            poc.StartInfo.FileName = "poc.exe";
            poc.StartInfo.Arguments = method + " " + formatAdress;
            poc.StartInfo.CreateNoWindow = true;
            poc.StartInfo.UseShellExecute = false;
            poc.StartInfo.RedirectStandardOutput = true;
            poc.Start();
            poc.WaitForExit();
            string[] output = poc.StandardOutput.ReadToEnd().Trim().Split(' ');
            for (int i=0; i<output.Length; i++)
                output[i] = (Convert.ToByte(Convert.ToInt32(output[i], 16))).ToString();
            return output;
                               //select Convert.ToByte(Convert.ToInt32(n, 16))).ToString().ToArray();

        }

        internal void SetData(string method, string addressarg)
        {
            Process poc = new Process();
            poc.StartInfo.FileName = "poc.exe";
            poc.StartInfo.Arguments = method + " " + addressarg;
            poc.StartInfo.CreateNoWindow = true;
            poc.StartInfo.UseShellExecute = false;
            poc.StartInfo.RedirectStandardOutput = true;
            poc.Start();
            poc.WaitForExit();
        }

        internal void Exit()
        {
            Process exitStop = new Process();
            exitStop.StartInfo.FileName = "cmd.exe";
            exitStop.StartInfo.Arguments = "/c sc stop LegionControl";
            exitStop.StartInfo.CreateNoWindow = true;
            exitStop.StartInfo.UseShellExecute = false;
            exitStop.StartInfo.RedirectStandardOutput = true;
            exitStop.Start();
            exitStop.WaitForExit();

            Process exitDelete = new Process();
            exitDelete.StartInfo.FileName = "cmd.exe";
            exitDelete.StartInfo.Arguments = "/c sc delete LegionControl";
            exitDelete.StartInfo.CreateNoWindow = true;
            exitDelete.StartInfo.UseShellExecute = false;
            exitDelete.StartInfo.RedirectStandardOutput = true;
            exitDelete.Start();
            exitDelete.WaitForExit();
        }
    }
}
