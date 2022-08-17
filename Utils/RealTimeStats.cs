namespace LegionControl.Utils
{
    internal static class RealTimeStats
    {

        internal static string tempCurrentCPU;
        internal static string tempCurrentGPU;
        internal static string rpmCurrentCPU;
        internal static string rpmCurrentGPU;

        internal static void GetRTS()
        {
            Memory memory = new Memory();

            tempCurrentCPU = memory.GetData("r", DeviceDetection.adrsTempCurrentCPU);
            tempCurrentGPU = memory.GetData("r", DeviceDetection.adrsTempCurrentGPU);
            rpmCurrentCPU = memory.GetData("r", DeviceDetection.adrsRpmCurrentCPU) + "00";
            rpmCurrentGPU = memory.GetData("r", DeviceDetection.adrsRpmCurrentGPU) + "00";
        }
    }
}
