using System.Collections.Generic;
using Prism.Mvvm;

namespace PipelineProcessor.Models
{
    public class ProcessorUnit : BindableBase
    {
        public ProcessorUnit(ProcessType type)
        {
            ProcessType = type;
            if (ProcessType == ProcessType.Extract)
            {
                Variables = new Dictionary<string, string>();
            }
        }

        public ProcessType ProcessType { get; set; }

        public string SearchPattern { get; set; }

        public string Replacement { get; set; }

        public Dictionary<string, string> Variables { get; set; }

        public string Start(string input)
        {
            // 仮実装
            if (ProcessType == ProcessType.Extract)
            {
                return input;
            }

            return input + " Replacement";
        }
    }
}