using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Profile.Domain.Question
{
    public class BodySpec
    {
        public string Body { get;private set; }
        public string Tag { get; private set; }
        

        private BodySpec(string body, string tag)
        {
            Body = body;
            Tag = tag;
        }
        

        public static Result<BodySpec> Create(string body, string tag)
        {
            if(IsBodySpecValid(body,tag))
            {
                return new BodySpec(body,tag);
            }
            else
            {
                return new Result<BodySpec>(new InvalidBodyException(body));
            }
        }

        private static bool IsBodySpecValid(string body,string tag)
        {
            //maxim 1000 de caractere
            if(body.Length <= 1000 && tag.Length>=1 && tag.Length<=3)
            {
                return true;
            }
            return false;
        }

        [Serializable]
        private class InvalidBodyException : Exception
        {
            public InvalidBodyException()
            {
            }

            public InvalidBodyException(string body) : base($"The value\"{ body}\"is an invalid body format")
            {
            }

            
        }
    }
}
