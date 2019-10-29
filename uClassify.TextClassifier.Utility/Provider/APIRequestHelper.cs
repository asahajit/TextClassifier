using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using uClassify.TextClassifier.Utility.Models.Response;

namespace uClassify.TextClassifier.Utility.Provider
{
    internal static class APIRequestHelper
    {
            internal static dynamic DoAPIRequest(string Baseurl, string ApiPath,string token,string requestBody,string RequestType,bool isObject=false)
            {
            if (!string.IsNullOrEmpty(Baseurl) && !string.IsNullOrEmpty(ApiPath) && !string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(requestBody) )
            {
                ErrorResponses error = new ErrorResponses();
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);
                    var response = client.PostAsync(Baseurl+ApiPath, new StringContent(requestBody)).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    if (content.Contains("statusCode"))
                    {
                        error = JsonConvert.DeserializeObject<ErrorResponses>(content);
                    }

                    if (!string.IsNullOrEmpty(content) && error.statusCode != 0 && (error.statusCode != 200 || error.statusCode != 201))
                    {
                        throw new System.ArgumentException(error.statusCode + " Response Received With " + error.message);
                    }

                    else if (!string.IsNullOrEmpty(content) && content.Contains("keyword"))
                    {
                        if (isObject)
                        {
                            return JsonConvert.DeserializeObject<KeywordsResponse[][]>(content);
                        }
                        else
                        {
                            return content;
                        }
                    }
                    else if (!string.IsNullOrEmpty(content) && content.Contains("uniqueFeatures"))
                    {
                        if (isObject)
                        {
                            return JsonConvert.DeserializeObject<List<ClassifierInformationResponse>>(content);
                        }
                        else
                        {
                            return content;
                        }
                    }
                    else if (!string.IsNullOrEmpty(content) && content.Contains("textCoverage"))
                    {
                        if (isObject)
                        {
                            return JsonConvert.DeserializeObject<ClassificationResponse[]>(content)[0];
                        }
                        else
                        {
                            return content;
                        }

                    }
                    else
                    {
                        return true;
                    }
                    
                   
                }

            }
            else
            {
                throw new System.ArgumentException("Baseurl,ApiPath,Token,RequestBody cant be null or empty!");
            }
               
           }

        }
    }
