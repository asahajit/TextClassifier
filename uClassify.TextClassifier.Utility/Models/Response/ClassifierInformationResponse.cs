using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uClassify.TextClassifier.Utility.Models.Response
{
   public class ClassifierInformationResponse
    {
        public string className { get; set; }
        public int uniqueFeatures { get; set; }
        public int totalCount { get; set; }
    }
}
