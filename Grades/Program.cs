﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {


            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is  the grade book program");



            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);



            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("AverageGrade " + stats.AverageGrade);
            Console.WriteLine("Highest Grade " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade " + stats.LowestGrade);
           

            
        }
    }
}
