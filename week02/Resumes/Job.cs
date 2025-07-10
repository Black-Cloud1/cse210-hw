using System;

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public string _startYear;
    public string _endYear;


    // Method \|/
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
        
    }
}