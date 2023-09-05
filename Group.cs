using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Liik
{
    public string Name { get; }
    public int Age { get; }
    public DateTime RegistrationDate { get; }

    public Liik(string name, int age, DateTime registrationDate)
    {
        Name = name;
        Age = age;
        RegistrationDate = registrationDate;
    }
}
public class Group
{
    private List<Liik> liikmed = new List<Liik>();
    private readonly int maxAmount;

    public List<Liik> Liikmed
    {
        get { return liikmed; }
    }

    public Group(int maxAmount)
    {
        this.maxAmount = maxAmount;
    }

    public bool AddOpilane(string name, int age, DateTime registrationDate)
    {
        if (liikmed.Any(liik => liik.Name == name)) return false;
        if (liikmed.Count >= maxAmount) return false;
        liikmed.Add(new Liik(name, age, registrationDate));
        return true;
    }

    public int GetOpilasedCount()
    {
        return liikmed.Count;
    }

    public bool HasOpilane(string name)
    {
        return liikmed.Any(liik => liik.Name == name);
        
    }

}