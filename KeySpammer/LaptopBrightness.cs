using System;
using System.Management;

public static class LaptopBrightness
{
    public static int Get()
    {
        var mclass = new ManagementClass("WmiMonitorBrightness")
        {
            Scope = new ManagementScope(@"\\.\root\wmi")
        };
        var instances = mclass.GetInstances();
        foreach (ManagementObject instance in instances)
        {
            return (byte)instance.GetPropertyValue("CurrentBrightness");
        }
        return 0;
    }

    public static void Set(int brightness)
    {
        var mclass = new ManagementClass("WmiMonitorBrightnessMethods")
        {
            Scope = new ManagementScope(@"\\.\root\wmi")
        };
        var instances = mclass.GetInstances();
        var args = new object[] { 1, brightness };
        foreach (ManagementObject instance in instances)
        {
            instance.InvokeMethod("WmiSetBrightness", args);
        }
    }
}