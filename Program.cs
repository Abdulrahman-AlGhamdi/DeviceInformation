if (!OperatingSystem.IsWindows()) return;

ManagementObjectSearcher os = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

System.Console.WriteLine("OS Information\n");

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

System.Console.WriteLine("\n------------------------------------------------------\n");

ManagementObjectSearcher cpu = new ManagementObjectSearcher("select * from Win32_Processor");

System.Console.WriteLine("CPU Information\n");

foreach (ManagementObject info in cpu.Get()) {
    PropertyData cpuName = info.Properties["Name"];
    Console.WriteLine("CPU Name		: {0}", cpuName.Value);

    PropertyData processorId = info.Properties["ProcessorId"];
    Console.WriteLine("Processor Id		: {0}", processorId.Value);

    PropertyData currentClockSpeed = info.Properties["CurrentClockSpeed"];
    Console.WriteLine("Current Clock Speed	: {0}", currentClockSpeed.Value);

    PropertyData numberOfCores = info.Properties["NumberOfCores"];
    Console.WriteLine("Number Of Cores		: {0}", numberOfCores.Value);

    PropertyData numberOfEnabledCore = info.Properties["NumberOfEnabledCore"];
    Console.WriteLine("Number Of Enabled Cores : {0}", numberOfEnabledCore.Value);

    PropertyData threadCount = info.Properties["ThreadCount"];
    Console.WriteLine("Thread Count	        : {0}", threadCount.Value);
    
    PropertyData loadPercentage = info.Properties["LoadPercentage"];
    Console.WriteLine("Load Percentage         : {0}", loadPercentage.Value);

    PropertyData manufacturer = info.Properties["Manufacturer"];
    Console.WriteLine("Manufacturer Name       : {0}", manufacturer.Value);

    PropertyData socketDesignation = info.Properties["SocketDesignation"];
    Console.WriteLine("Socket Designation      : {0}", socketDesignation.Value);
}