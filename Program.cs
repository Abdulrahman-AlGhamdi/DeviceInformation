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

System.Console.WriteLine("\n------------------------------------------------------\n");

ManagementObjectSearcher hardDisk = new ManagementObjectSearcher("select * from Win32_DiskDrive");

System.Console.WriteLine("Hard Disk Information\n");

int hardDiskCount = 1;

foreach (ManagementObject info in hardDisk.Get()) {
    if (hardDiskCount++ > 1) System.Console.Write("\n");

    int hardDiskNumber = Convert.ToInt32(info.Properties["Index"].Value) + 1;
    Console.WriteLine("Hard Disk Number : {0}", hardDiskNumber);

    PropertyData caption = info.Properties["Caption"];
    Console.WriteLine("Hard Disk Name   : {0}", caption.Value);
    
    PropertyData partitions = info.Properties["Partitions"];
    Console.WriteLine("Partitions	 : {0}", partitions.Value);
    
    PropertyData size = info.Properties["Size"];
    Console.WriteLine("Size		 : {0}", size.Value);
}

System.Console.WriteLine("\n------------------------------------------------------\n");

ManagementObjectSearcher ip4 = new ManagementObjectSearcher("select * from Win32_IP4RouteTable");

System.Console.WriteLine("IP Information\n");

foreach (ManagementObject info in ip4.Get()) {
    string mask = (string) info.Properties["Mask"].Value;

    if (mask == "0.0.0.0") {
        PropertyData ip = info.Properties["NextHop"];
        Console.WriteLine("IP Address : {0}", ip.Value);
        Console.WriteLine("Mask	   : {0}", mask);
    }
}

System.Console.WriteLine("\n------------------------------------------------------\n");

ManagementObjectSearcher ram = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");

System.Console.WriteLine("RAM Information\n");

int ramCount = 1;

foreach (ManagementObject info in ram.Get()) {
    if (ramCount++ > 1) System.Console.Write("\n");

    PropertyData caption = info.Properties["Caption"];
    Console.WriteLine("Caption      : {0}", caption.Value);
    
    PropertyData capacity = info.Properties["Capacity"];
    Console.WriteLine("Capacity     : {0}", capacity.Value);
    
    PropertyData clockSpeed = info.Properties["ConfiguredClockSpeed"];
    Console.WriteLine("Clock Speed  : {0}", clockSpeed.Value);
    
    PropertyData manufacturer = info.Properties["Manufacturer"];
    Console.WriteLine("Manufacturer : {0}", manufacturer.Value);
    
    PropertyData partNumber = info.Properties["PartNumber"];
    Console.WriteLine("Part Number  : {0}", partNumber.Value);
}