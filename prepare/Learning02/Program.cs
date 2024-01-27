using System;

class Program
{
      static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Computer Operator";
        job1._company = "IT Dept Nigeria Police Force";
        job1._startYear = 2013;
        job1._endYear = 2020;


        Job job2 = new Job();
        job2._jobTitle = "Desktop Support Specialist";
        job2._company = "Brigham Young Univeristy";
        job2._startYear = 2020;
        job2._endYear = 2023;
        

        Job job3 = new Job();
        job3._jobTitle = "System Maintenance Manager";
        job3._company = "Anyi-God Computers Aba";
        job3._startYear = 2023;
        job3._endYear = 2024;
        Resume myResume = new Resume();
        myResume._name = "Paul C. Arungwa";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}