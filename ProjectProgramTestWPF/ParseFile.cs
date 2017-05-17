using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjectProgramTestWPF
{
    class ParseFile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // Событие, которое нужно вызывать при изменении
        // Для удобства обернем событие в метод с единственным параметром - имя изменяемого свойства
        public void RaisePropertyChanged(string propertyName)
        {
            // Если кто-то на него подписан, то вызывем его
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        [JsonProperty("TeacherName")]
        public string TeacherName { get; set; }
        [JsonProperty("StudentName")]
        public string StudentName { get; set; }
        [JsonProperty("Group")]
        public string Group { get; set; }
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
        public List<Answers> Answers;

    }

    class Answers
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
