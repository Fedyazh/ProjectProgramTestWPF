﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace ProjectProgramTestWPF
{
    class ParseFile 
    {
       
        
        [JsonProperty("TeacherName")]
        public string TeacherName { get; set; }
      
        [JsonProperty("StudentName")]
        public string StudentName { get; set; }
        public string StudentPastName { get; set; }
        [JsonProperty("Group")]
        public string Group { get;set;  }
        [JsonProperty("PercentAnsw")]
        public string PercentAnsw { get; set; }
        [JsonProperty("TopicQuestion")]
        public string TopicQuestion { get; set; }
        [JsonProperty("Questions")]
        public List<Questions> Questions;

        
    }


    class Questions
    {
        [JsonProperty("Type")]
        public string QType { get; set; }
        [JsonProperty("TypeAnsw")]
        public int QTypeAnsw { get; set; }
        [JsonProperty("Topic")]
        public string QTopic { get; set; }
        [JsonProperty("Subject")]
        public string QSubject { get; set; }
        [JsonProperty("isRight")]
        public bool QAisRight { get; set; }
        [JsonProperty("Answers")]
        public List<Answer> Answers;

    }

    class Answer
    {
        [JsonProperty("Type")]
        public string QAType { get; set; }
        [JsonProperty("Value")]
        public string QAValue { get; set; }
        [JsonProperty("isRight")]
        public bool QAisRight { get; set; }
        [JsonProperty("isAnsw")]
        public bool QAisAnsw { get; set; }
    }
}
