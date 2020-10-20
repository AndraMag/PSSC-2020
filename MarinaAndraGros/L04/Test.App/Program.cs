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
            /* var cmd = new CreateProfileCmd("Ion", string.Empty, "Ionescu", "ion.inonescu@company.com");
             var result = CreateProfile(cmd);

             result.Match(
                     ProcessProfileCreated,
                     ProcessProfileNotCreated,
                     ProcessInvalidProfile
                 );

             Console.ReadLine();
         }

         private static ICreateProfileResult ProcessInvalidProfile(ProfileValidationFailed validationErrors)
         {
             Console.WriteLine("Profile validation failed: ");
             foreach (var error in validationErrors.ValidationErrors)
             {
                 Console.WriteLine(error);
             }
             return validationErrors;
         }

         private static ICreateProfileResult ProcessProfileNotCreated(ProfileNotCreated profileNotCreatedResult)
         {
             Console.WriteLine($"Profile not created: {profileNotCreatedResult.Reason}");
             return profileNotCreatedResult;
         }

         private static ICreateProfileResult ProcessProfileCreated(ProfileCreated profile)
         {
             Console.WriteLine($"Profile {profile.ProfileId}");
             return profile;
         }

         public static ICreateProfileResult CreateProfile(CreateProfileCmd createProfileCommand)
         {
             if (string.IsNullOrWhiteSpace(createProfileCommand.EmailAddress))
             {
                 var errors = new List<string>() { "Invlaid email address" };
                 return new ProfileValidationFailed(errors);
             }

             if(new Random().Next(10) > 1)
             {
                 return new ProfileNotCreated("Email could not be verified");
             }

             var profileId = Guid.NewGuid();
             var result = new ProfileCreated(profileId, createProfileCommand.EmailAddress);

             //execute logic
             return result;

            */
 var cmd1 = new CreateQuestionCmd("Can I call a Java api with c++?", "I am trying to build a bot in c++ but the thing is that the API that I want to use - that is a website API. Is in java, is it possible? the bot is mainly made to buy products from a website.", "java c++");
 var result = CreateQuestion(cmd1);

 result.Match(
         ProcessQuestionCreated,
         ProcessQuestionNotCreated,
         ProcessInvalidQuestion
     );

 Console.ReadLine();
}

private static ICreateQuestionResult ProcessInvalidQuestion(QuestionValidationFailed validationErrors)
{
 Console.WriteLine("Question validation failed: ");
 foreach (var error in validationErrors.ValidationErrors)
 {
     Console.WriteLine(error);
 }
 return validationErrors;
}

private static ICreateQuestionResult ProcessQuestionNotCreated(QuestionNotCreated questionNotCreatedResult)
{
 Console.WriteLine($"QUestion not created: {questionNotCreatedResult.Reason}");
 return questionNotCreatedResult;
}

private static ICreateQuestionResult ProcessQuestionCreated(QuestionCreated question)
{
 Console.WriteLine($"Question {question.QuestionId}");
 return question;
}

public static ICreateQuestionResult CreateQuestion(CreateQuestionCmd createQuestionCommand)
{
 if (string.IsNullOrWhiteSpace(createQuestionCommand.Body))
 {
     var errors = new List<string>() { "Invalid body content" };
     return new QuestionValidationFailed(errors);
 }

 if(new Random().Next(10) > 1)
 {
     return new QuestionNotCreated("Body content could not be verified");
 }

 var questionId = Guid.NewGuid();
 var result = new QuestionCreated(questionId, createQuestionCommand.Body);

 return result;

}
}
}
