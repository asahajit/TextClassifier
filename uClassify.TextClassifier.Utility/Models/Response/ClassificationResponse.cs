using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uClassify.TextClassifier.Utility.Models.Response
{
    public class ClassificationResponse
    {
        public double textCoverage { get; set; }
        public IList<Classification> classification { get; set; }
    }
}
