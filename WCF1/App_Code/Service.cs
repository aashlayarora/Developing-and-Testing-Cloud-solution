using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AT1;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    Configuration AT1Configuration = new Configuration();
    List<String> configurationErrors = new List<string>();

    public string GetData(String path)
	{
        using (WebClient configurationWebClient = new WebClient())
        using (Stream configurationStream = configurationWebClient.OpenRead(path))
        using (StreamReader configurationFile = new StreamReader(configurationStream))
        {
            Configuration.TryParse(configurationFile, path, out AT1Configuration, out configurationErrors);
        }
        return FindOptimalAllocation();
	}

    bool[,] alc, optAloc;
    double[] runtime;
    double totalEnergy, nEnergy;
    int counter;
    int[] taskAlc;
    int st;

    public string getAllocationString(bool[,] allocation, List<Processor> Processors, List<Task> Tasks)
    {
        string ret = "CONFIG-FILE=\"" + AT1Configuration.FilePath + "\"\n";
        ret += "ALLOCATIONS-DATA=1," + AT1Configuration.NumberOfTasks + "," + AT1Configuration.NumberOfProcessors + "\n";
        ret += "ALLOCATION-ID=1\n";
        for (int i = 0; i < Processors.Count; i++)
        {
            for (int j = 0; j < Tasks.Count; j++)
            {
                if (j > 0) ret += ",";
                ret += allocation[i, j] == true ? "1" : "0";
            }
            ret += "\n";
        }
        return ret;
    }
    public string FindOptimalAllocation()
    {
        List<Processor> Processors = AT1Configuration.Processors;
        List<Task> Tasks = AT1Configuration.Tasks;
        alc = new bool[Processors.Count, Tasks.Count];
        optAloc = new bool[Processors.Count, Tasks.Count];
        runtime = new double[Processors.Count];
        taskAlc = new int[Tasks.Count];
        nEnergy = 99999999F;
        totalEnergy = 0;
        for (int i = 0; i < Processors.Count; i++)
        {
            for (int j = 0; j < Tasks.Count; j++)
            {
                alc[i, j] = false;
            }
        }
        counter = 0;
        st = Environment.TickCount;
        Solve(0);
        Console.WriteLine("Counter = " + counter);
        return getAllocationString(optAloc, Processors, Tasks);
    }
    public void Solve(int len)
    {

        counter++;


        if (len == AT1Configuration.NumberOfTasks)
        {
            if (totalEnergy >= nEnergy) return;
            nEnergy = totalEnergy;
            for (int i = 0; i < AT1Configuration.NumberOfProcessors; i++)
            {
                for (int j = 0; j < AT1Configuration.NumberOfTasks; j++)
                {
                    optAloc[i, j] = alc[i, j];
                }
            }
            return;
        }
        if (totalEnergy >= nEnergy) return;
        for (int v = 0; v < AT1Configuration.NumberOfProcessors; v++)
        {
            Task task = AT1Configuration.Tasks[len];
            Processor processor = AT1Configuration.Processors[v];
            if (!task.IsRamSufficient(processor))
            {
                continue;
            }
            double t = task.ElapsedTime(processor);
            if (runtime[processor.ID - 1] + t > AT1Configuration.MaximumProgramDuration)
            {
                continue;
            }
            runtime[processor.ID - 1] += t;
            double ng = task.ElapsedTime(processor) * processor.EnergyPerSecond();
            totalEnergy += ng;
            alc[processor.ID - 1, task.ID - 1] = true;
            taskAlc[task.ID - 1] = processor.ID;
            Solve(len + 1);
            alc[processor.ID - 1, task.ID - 1] = false;
            totalEnergy -= ng;
            runtime[processor.ID - 1] -= t;
        }
    }
}
