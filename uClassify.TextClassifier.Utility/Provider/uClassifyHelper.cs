using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uClassify.TextClassifier.Utility.Models;
using uClassify.TextClassifier.Utility.Models.Request;
using uClassify.TextClassifier.Utility.Utils;
using uClassify.TextClassifier.Utility.Models.Response;

namespace uClassify.TextClassifier.Utility.Provider
{
    public class uClassifyProvider : uClassifyInterface
    {
     
        uClassifyConfiguration config = uClassifyConfiguration.Instance;
       

        public string ClassifyText(string classifierName, List<string> textList)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username= config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public ClassificationResponse ClassifyText(string classifierName, List<string> textList, bool isObject = false)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST",true);
        }

        public string ClassifyText(string classifierName, string text)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = new List<string> { text} });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public ClassificationResponse ClassifyText(string classifierName, string text,bool isObject=false)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = new List<string> { text } });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST",true);
        }

        public string ClassifyTextKeywords(string classifierName, List<string> textList)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextKeywordsUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public string ClassifyTextKeywords(string classifierName, string text)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextKeywordsUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = new List<string> { text } });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public List<KeywordsResponse> ClassifyTextKeywords(string classifierName, List<string> textList, bool isObject = false)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextKeywordsUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            KeywordsResponse[][] keyvalye = APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST", true);
            List<List<KeywordsResponse>> keywordListOfList = keyvalye.Select(x => x.ToList()).ToList();
            var keywordList = keywordListOfList.SelectMany(d => d).ToList();
            return keywordList;
        }

        public List<KeywordsResponse> ClassifyTextKeywords(string classifierName, string text, bool isObject = false)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextKeywordsUrl, new { username = config.UserName, classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { texts = text });
            KeywordsResponse[][] keyvalye = APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST", true);
            List<List<KeywordsResponse>> keywordListOfList = keyvalye.Select(x => x.ToList()).ToList();
            var keywordList = keywordListOfList.SelectMany(d => d).ToList();
            return keywordList;
        }

        public string ClassifyTextWithLanguage(string classifierName, string language, List<string> textList)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName, language= language });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }
        public ClassificationResponse ClassifyTextWithLanguage(string classifierName, string language, List<string> textList,bool isObject)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName, language = language });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST", isObject);
        }

        public string ClassifyTextWithLanguage(string classifierName, string language, string text)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName, language = language });
            string body = JsonConvert.SerializeObject(new { texts = text });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }
        public ClassificationResponse ClassifyTextWithLanguage(string classifierName, string language, string text,bool isObject)
        {
            string ApiPath = CommonUtils.Format(config.ClassifyTextUrl, new { username = config.UserName, classifierName = classifierName, language = language });
            string body = JsonConvert.SerializeObject(new { texts = text });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST", isObject);
        }

        public bool CreateClassifier(string classifierName)
        {
            string ApiPath = CommonUtils.Format(config.CreateClassifierUrl, new { classifierName = classifierName });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, "", "POST");
        }

        public string GetClassifierInformation(string classifierName)
        {
            string ApiPath = CommonUtils.Format(config.GetClassifierInformationUrl, new { username=config.UserName, classifierName = classifierName });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, "", "POST");
        }
        public List<ClassifierInformationResponse> GetClassifierInformation(string classifierName,bool isObject)
        {
            string ApiPath = CommonUtils.Format(config.GetClassifierInformationUrl, new { username = config.UserName, classifierName = classifierName });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, "", "POST",isObject);
        }
        public bool AddClassifierClass(string classifierName, string className)
        {
            string ApiPath = CommonUtils.Format(config.AddClassifierClassUrl, new { classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { className = className });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, body, "POST");
        }
        public bool RemoveClassifier(string classifierName)
        {
            string ApiPath = CommonUtils.Format(config.RemoveClassifierUrl, new { classifierName = classifierName });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, "", "POST");
        }

        public string RemoveClassifierClass(string classifierName, string className)
        {
            string ApiPath = CommonUtils.Format(config.RemoveClassifierClassUrl, new { classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { className = className });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, body, "POST");
        }

        public string TrainClassifier(string classifierName, string className, List<string> textList)
        {
            string ApiPath = CommonUtils.Format(config.TrainClassifierUrl, new { classifierName = classifierName , className = className, });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public string TrainClassifier(string classifierName, string className, string text)
        {
            string ApiPath = CommonUtils.Format(config.TrainClassifierUrl, new { classifierName = classifierName, className = className, });
            string body = JsonConvert.SerializeObject(new { texts = text });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public string UnTrainClassifier(string classifierName, string className, List<string> textList)
        {
            string ApiPath = CommonUtils.Format(config.UnTrainClassifierUrl, new { classifierName = classifierName, className = className, });
            string body = JsonConvert.SerializeObject(new { texts = textList });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        public string UnTrainClassifier(string classifierName, string className, string text)
        {
            string ApiPath = CommonUtils.Format(config.UnTrainClassifierUrl, new { classifierName = classifierName, className = className, });
            string body = JsonConvert.SerializeObject(new { texts = text });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Read_API_KEY, body, "POST");
        }

        
    }
}
