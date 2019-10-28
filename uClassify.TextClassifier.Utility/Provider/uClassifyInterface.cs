using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uClassify.TextClassifier.Utility.Models.Response;

namespace uClassify.TextClassifier.Utility.Provider
{
    public interface uClassifyInterface
    {

        string ClassifyText(string classifierName,string text);
        string ClassifyText(string classifierName, List<string> textList);
        ClassificationResponse ClassifyText(string classifierName, List<string> textList, bool isObject = false);
        ClassificationResponse ClassifyText(string classifierName, string text, bool isObject = false);
        string ClassifyTextWithLanguage(string classifierName,string language, string text);
        string ClassifyTextWithLanguage(string classifierName, string language, List<string> textList);
        string ClassifyTextKeywords(string classifierName, string text);
        string ClassifyTextKeywords(string classifierName, List<string> textList);
        List<KeywordsResponse> ClassifyTextKeywords(string classifierName, string text, bool isObject = false);
        List<KeywordsResponse> ClassifyTextKeywords(string classifierName, List<string> textList, bool isObject = false);
        string GetClassifierInformation(string classifierName);
        string CreateClassifier(string classifierName);
        string RemoveClassifier(string classifierName);
        bool AddClassifierClass(string classifierName, string className);
        string RemoveClassifierClass(string classifierName, string className);
        string TrainClassifier(string classifierName, string className,string text);
        string TrainClassifier(string classifierName, string className, List<string> textList);
        string UnTrainClassifier(string classifierName, string className, string text);
        string UnTrainClassifier(string classifierName, string className, List<string> textList);
    }
}
