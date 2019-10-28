using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using uClassify.TextClassifier.Utility.Provider;
using System.Collections.Generic;

namespace uClassify.TextClassifier.Utility.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            uClassifyInterface IuClassify = new uClassifyProvider();
            var A = IuClassify.AddClassifierClass("FindTags", "Love");

        }
        [TestMethod]
        public void TestMethod2()
        {
            uClassifyInterface IuClassify = new uClassifyProvider();
            
            List<string> textlist = new List<string>();
            textlist.Add("I Love You!");
            textlist.Add("I Only Have Love For You!");
            textlist.Add("I Love You All of You");
            textlist.Add("I Love You Who You Are");
            textlist.Add("I Love Your Soul");

            var A = IuClassify.ClassifyText("FindTags", "I Love You!");
            var B = IuClassify.ClassifyText("FindTags", "I Love You!", true);
            var C = IuClassify.ClassifyText("FindTags", textlist);
            var D = IuClassify.ClassifyText("FindTags", textlist, true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            uClassifyInterface IuClassify = new uClassifyProvider();

            List<string> textlist = new List<string>();
            textlist.Add("I Love You!");
            textlist.Add("I Only Have Love For You!");
            textlist.Add("I Love You All of You");
            textlist.Add("I Love You Who You Are");
            textlist.Add("I Love Your Soul");

            var A = IuClassify.ClassifyTextKeywords("FindTags", "I Love You!");
            var B = IuClassify.ClassifyTextKeywords("FindTags", "I Love You!", true);
            var C = IuClassify.ClassifyTextKeywords("FindTags", textlist);
            var D = IuClassify.ClassifyTextKeywords("FindTags", textlist, true);
        }
        public void TestMethod4()
        {
            
        }
    }
}
