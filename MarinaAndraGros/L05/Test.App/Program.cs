using LanguageExt;
using Profile.Domain.Question;
using System;
using System.Collections.Generic;
using System.Net;
using static Profile.Domain.Question.CreateQuestionResult;

namespace Test.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var body = BodySpec.Create("Intrebare intrebare intrebare?","tag1 tag2");
            body.Match(
            Succ: body =>
            {
                Console.WriteLine("Body is valid");
                return Unit.Default;
            },
            Fail: ex =>
            {
                Console.WriteLine($"Invalid body. Reason: {ex.Message}");
                return Unit.Default;
            }
           );

            Console.ReadLine();
        }
            
    }
}
