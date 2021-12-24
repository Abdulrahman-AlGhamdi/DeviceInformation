if (!OperatingSystem.IsWindows()) return;

ManagementObjectSearcher os = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

foreach (ManagementObject info in os.Get()) {
    PropertyData osName = info.Properties["Caption"];
    Console.WriteLine("OS Name  	  : {0}", osName.Value);

    PropertyData totalRam = info.Properties["TotalVisibleMemorySize"];
    Console.WriteLine("Total RAM	  : {0}", totalRam.Value);

    PropertyData freeRam = info.Properties["FreePhysicalMemory"];
    Console.WriteLine("Free RAM	  : {0}", freeRam.Value);
    
    PropertyData manufacturer = info.Properties["Manufacturer"];
    Console.WriteLine("Manufacturer Name : {0}", manufacturer.Value);
    
    PropertyData user = info.Properties["RegisteredUser"];
    Console.WriteLine("Username	  : {0}", user.Value);
    
    PropertyData serialNumber = info.Properties["SerialNumber"];
    Console.WriteLine("Serial Number	  : {0}", serialNumber.Value);
    
    PropertyData systemDrive = info.Properties["SystemDrive"];
    Console.WriteLine("System Drive	  : {0}", systemDrive.Value);
    
    PropertyData osVersion = info.Properties["Version"];
    Console.WriteLine("OS Version	  : {0}", osVersion.Value);
}