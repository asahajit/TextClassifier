using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uClassify.TextClassifier.Utility.Models.Response
{
    public class Classification
    {
        public string className { get; set; }
        public double p { get; set; }
    }
}
