namespace LegionControl.Utils
{
    internal static class DeviceDetection
    {
        internal static string model;
        internal static string cpuName;

        static string[] supportedModels = {"Legion 5 15IMH05H", "Legion 5 15ACH6H", "Legion 7 16ACHg6"};

        internal static string   adrsTempCurrentCPU = "0xFE00D5E6";
        internal static string   adrsTempCurrentGPU = "0xFE00D5E7";
        internal static string   adrsRpmCurrentCPU  = "0xFE00D4FE";
        internal static string   adrsRpmCurrentGPU  = "0xFE00D406";
        internal static string[] adrsFanCurveCPU    = new string[] { "0xFE00D540", "0xFE00D541", "0xFE00D542", "0xFE00D543", "0xFE00D544", "0xFE00D545", "0xFE00D546", "0xFE00D547", "0xFE00D548", "0xFE00D549", "0xFE00D54A" };
        internal static string[] adrsFanCurveGPU    = new string[] { "0xFE00D550", "0xFE00D551", "0xFE00D552", "0xFE00D553", "0xFE00D554", "0xFE00D555", "0xFE00D556", "0xFE00D557", "0xFE00D558", "0xFE00D559", "0xFE00D55A" };

        internal static void Initialize()
        {
            WMI wmi = new WMI();

            model = wmi.GetDataSelect("root\\CIMV2", "SELECT * FROM Win32_ComputerSystemProduct", "Version");
            cpuName = wmi.GetDataSelect("root\\CIMV2", "SELECT * FROM Win32_Processor", "Name");

            if (!Verify())
            {
                string invalidDeviceMsg = "Current device is incompatible with the Legion Control software.\n" +
                                          "Make sure you have one of the following models :\n";
                
                foreach (string model in supportedModels)
                    invalidDeviceMsg += model + "\n";

                MessageBox.Show(invalidDeviceMsg);
                Application.Exit();
            }
        }

        private static bool Verify()
        {
            foreach (var sm in supportedModels)
                if (model == sm)
                    return true;

            return false;
        }
    }
}
