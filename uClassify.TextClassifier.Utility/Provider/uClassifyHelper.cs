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
            throw new NotImplementedException();
        }

        public string ClassifyTextKeywords(string classifierName, string text)
        {
            throw new NotImplementedException();
        }

        public string ClassifyTextWithLanguage(string classifierName, string language, List<string> textList)
        {
            throw new NotImplementedException();
        }

        public string ClassifyTextWithLanguage(string classifierName, string language, string text)
        {
            throw new NotImplementedException();
        }

        public string CreateClassifier(string classifierName)
        {
            throw new NotImplementedException();
        }

        public string GetClassifierInformation(string classifierName)
        {
            throw new NotImplementedException();
        }
        public bool AddClassifierClass(string classifierName, string className)
        {
            string ApiPath = CommonUtils.Format(config.AddClassifierClassUrl, new { classifierName = classifierName });
            string body = JsonConvert.SerializeObject(new { className = className });
            return APIRequestHelper.DoAPIRequest(config.BaseUrl, ApiPath, config.Write_API_KEY, body, "POST");
        }
        public string RemoveClassifier(string classifierName)
        {
            throw new NotImplementedException();
        }

        public string RemoveClassifierClass(string classifierName, string className)
        {
            throw new NotImplementedException();
        }

        public string TrainClassifier(string classifierName, string className, List<string> textList)
        {
            throw new NotImplementedException();
        }

        public string TrainClassifier(string classifierName, string className, string text)
        {
            throw new NotImplementedException();
        }

        public string UnTrainClassifier(string classifierName, string className, List<string> textList)
        {
            throw new NotImplementedException();
        }

        public string UnTrainClassifier(string classifierName, string className, string text)
        {
            throw new NotImplementedException();
        }

        
    }
}
