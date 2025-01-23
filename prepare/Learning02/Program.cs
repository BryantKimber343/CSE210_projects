using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Michael Jordan";

        Job job1 = new Job();
        job1._company = "McDonald's";
        job1._jobTitle = "General Manager";
        job1._startYear = 2015;
        job1._endYear = 2017;
        myResume._jobs.Add(job1);
        

        Job job2 = new Job();
        job2._company = "Pizza Hut";
        job2._jobTitle = "Delivery Driver";
        job2._startYear = 2010;
        job2._endYear = 2014;
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}