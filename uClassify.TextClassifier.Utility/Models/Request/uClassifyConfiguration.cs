using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uClassify.TextClassifier.Utility.Models.Request
{
   public sealed class uClassifyConfiguration
    {
        public string BaseUrl
        { get 
                {
                    return ConfigurationManager.AppSettings["BaseUrl"];
                }
        }
        public string Read_API_KEY
        {
            get
            {
                return ConfigurationManager.AppSettings["Read_API_KEY"];
            }
        }
        public string Write_API_KEY
        {
            get
            {
                return ConfigurationManager.AppSettings["Write_API_KEY"];
            }
        }
        public string ClassifyTextUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ClassifyTextUrl"];
            }
        }
        public string UserName
        {
            get
            {
                return ConfigurationManager.AppSettings["UserName"];
            }
        }
        public string ClassifyTextWithLanguageUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ClassifyTextWithLanguageUrl"];
            }
        }
        public string ClassifyTextKeywordsUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ClassifyTextKeywordsUrl"];
            }
        }
        public string GetClassifierInformationUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["GetClassifierInformationUrl"];
            }
        }
        public string CreateClassifierUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["CreateClassifierUrl"];
            }
        }
        public string RemoveClassifierUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["RemoveClassifierUrl"];
            }
        }
        public string AddClassifierClassUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["AddClassifierClassUrl"];
            }
        }
        public string RemoveClassifierClassUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["RemoveClassifierClassUrl"];
            }
        }
        public string TrainClassifierUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["TrainClassifierUrl"];
            }
        }
        public string UnTrainClassifierUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["UnTrainClassifierUrl"];
            }
        }

        private static readonly uClassifyConfiguration instance = new uClassifyConfiguration();

        static uClassifyConfiguration()
        {
        }
        private uClassifyConfiguration()
        {
        }
        public static uClassifyConfiguration Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
