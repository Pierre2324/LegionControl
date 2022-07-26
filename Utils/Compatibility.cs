using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegionControl.Utils
{
    internal class Compatibility
    {
        WMI wmi = new WMI();

        internal string model;
        string[] supportedModels = {"Lenovo Legion 5 15IMH05H", "Legion 5 15ACH6H" };

        internal string adrsTempCurrentCPU;
        internal string adrsTempCurrentGPU;
        internal string adrsRpmCurrentCPU;
        internal string adrsRpmCurrentGPU;
        internal string[] adrsFanCurveCPU;
        internal string[] adrsFanCurveGPU;


        internal void Initialize()
        {
            model = wmi.GetDataSelect("root\\CIMV2", "SELECT * FROM Win32_ComputerSystemProduct", "Version");

            if (Verify() == 0)
                Application.Exit();

            SetVars();
            
        }

        private int Verify()
        {
            foreach (var sm in supportedModels)
                if (model == sm)
                    return 1;
            return 0;
        }

        internal void SetVars()
        {
            if (model == "Legion 5 15ACH6H")
            {
                adrsTempCurrentCPU = "0xFE00D5E6";
                adrsTempCurrentGPU = "0xFE00D5E7";
                adrsRpmCurrentCPU = "0xFE00D4FE";
                adrsRpmCurrentGPU = "0xFE00D406";
                adrsFanCurveCPU = new string[] {"0xFE00D540", "0xFE00D541", "0xFE00D542", "0xFE00D543", "0xFE00D544", "0xFE00D545", "0xFE00D546", "0xFE00D547", "0xFE00D548", "0xFE00D549", "0xFE00D54A"};
                adrsFanCurveGPU = new string[] { "0xFE00D550", "0xFE00D551", "0xFE00D552", "0xFE00D553", "0xFE00D554", "0xFE00D555", "0xFE00D556", "0xFE00D557", "0xFE00D558", "0xFE00D559", "0xFE00D55A" };
            }
        }

    }
}
