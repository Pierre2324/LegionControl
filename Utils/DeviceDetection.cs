namespace LegionControl.Utils
{
    internal static class DeviceDetection
    {

        internal static string model;
        internal static string cpuName;
        static string[] supportedModels = {"Lenovo Legion 5 15IMH05H", "Legion 5 15ACH6H", "Legion 7 16ACHg6"};

        internal static string adrsTempCurrentCPU;
        internal static string adrsTempCurrentGPU;
        internal static string adrsRpmCurrentCPU;
        internal static string adrsRpmCurrentGPU;
        internal static string[] adrsFanCurveCPU;
        internal static string[] adrsFanCurveGPU;


        internal static void Initialize()
        {
            WMI wmi = new WMI();

            model = wmi.GetDataSelect("root\\CIMV2", "SELECT * FROM Win32_ComputerSystemProduct", "Version");
            cpuName = wmi.GetDataSelect("root\\CIMV2", "SELECT * FROM Win32_Processor", "Name");

            if (Verify() == 0)
                Application.Exit();
            else
                SetVars();
            
        }

        private static int Verify()
        {
            foreach (var sm in supportedModels)
            {
                if (sm.Contains("Lenovo"))
                    sm.Remove(0, 7);

                if (model == sm)
                    return 1;
            }   
            return 0;
        }

        private static void SetVars()
        {
            if (cpuName.Contains("AMD"))
            {
                adrsTempCurrentCPU = "0xFE00D5E6";
                adrsTempCurrentGPU = "0xFE00D5E7";
                adrsRpmCurrentCPU = "0xFE00D4FE";
                adrsRpmCurrentGPU = "0xFE00D406";
                adrsFanCurveCPU = new string[] { "0xFE00D540", "0xFE00D541", "0xFE00D542", "0xFE00D543", "0xFE00D544", "0xFE00D545", "0xFE00D546", "0xFE00D547", "0xFE00D548", "0xFE00D549", "0xFE00D54A" };
                adrsFanCurveGPU = new string[] { "0xFE00D550", "0xFE00D551", "0xFE00D552", "0xFE00D553", "0xFE00D554", "0xFE00D555", "0xFE00D556", "0xFE00D557", "0xFE00D558", "0xFE00D559", "0xFE00D55A" };
            }
            else
            {
                adrsTempCurrentCPU = "0xFF00D5E6";
                adrsTempCurrentGPU = "0xFF00D5E7";
                adrsRpmCurrentCPU = "0xFF00D4FE";
                adrsRpmCurrentGPU = "0xFF00D406";
            }
        }

    }
}
