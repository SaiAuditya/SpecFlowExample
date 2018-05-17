using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Text.RegularExpressions;

[TestClass]
public class Class1
{

public static ChromeDriver driver;
[TestInitialize]
public void startTests()
{
    Console.WriteLine("Starting the tests");
}
public Class1()
{
    driver= new ChromeDriver("C:\\Users\\venkata_srinadhuni\\workspace\\GAC_Selenium\\drivers"); 
}

 
public void getAllAtrributes(String outerhtml)
{
    string node = @outerhtml;
    string pattern = @"
(?:<)(?<Tag>[^\s/>]+)(?![/>])
((?:\s+)
(?<Key>[^=]+)
(?:=)
 
(?([\x22\x27])              # If quotes
(?:[\x22\x27])
(?<Value>[^\x22\x27]+)
(?:[\x22\x27])
|                          # Or w/o quotes
(?<Value>[^\s/>]*)       # It is just a value
)
)+";

    foreach (Match mt in Regex.Matches(node, pattern, System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace))
    {
        int i = 0;
        foreach(Capture ct in mt.Groups["Key"].Captures)
        {
               
            Console.WriteLine(ct.Value+"="+mt.Groups["Value"].Captures[i].Value);
            i = i + 1;
        }

    }
}
    
[TestMethod]
public void verifySeleniumWithCsharp()
{
           
    driver.Url = "https://google.com";
    driver.Navigate().GoToUrl("https://google.com");

    driver.Navigate().GoToUrl("http://sparshv2/Pages/Home.aspx");
        
    driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(200);

    driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(40);


    List<String> all_html_tags = new List<String> {
"a",
"abbr",
"acronym",
"address",
"applet",
"area",
"article",
"aside",
"audio",
"b",
"base",
"basefont",
"bdi",
"bdo",
"big",
"blockquote",
"body",
"br",
"button",
"canvas",
"caption",
"center",
"cite",
"code",
"col",
"colgroup",
"data",
"datalist",
"dd",
"del",
"details",
"dfn",
"dialog",
"dir",
"div",
"dl",
"dt",
"em",
"embed",
"fieldset",
"figcaption",
"figure",
"font",
"footer",
"form",
"frame",
"frameset",
"h1",
"h2",
"h3",
"h4",
"h5",
"h6",
"head",
"header",
"hr",
"html",
"i",
"iframe",
"img",
"input",
"ins",
"kbd",
"label",
"legend",
"li",
"link",
"main",
"map",
"mark",
"menu",
"menuitem",
"meta",
"meter",
"nav",
"noframes",
"noscript",
"object",
"ol",
"optgroup",
"option",
"output",
"p",
"param",
"picture",
"pre",
"progress",
"q",
"rp",
"rt",
"ruby",
"s",
"samp",
"script",
"section",
"select",
"small",
"source",
"span",
"strike",
"strong",
"style",
"sub",
"summary",
"sup",
"table",
"tbody",
"td",
"template",
"textarea",
"tfoot",
"th",
"thead",
"time",
"title",
"tr",
"track",
"tt",
"u",
"ul",
"var",
"video",
"wbr",
};

        List<String> all_html_general_tags = new List<String>
        {
            "a"
        };
           // wait.PollingInterval = TimeSpan.FromMilliseconds(30);

    foreach (String s in all_html_general_tags)
    {
        var all_page_Elements = driver.FindElements(OpenQA.Selenium.By.TagName(s));


        int i = 1;
        Console.WriteLine("Count of tag :"+s+" " + all_page_Elements.Count);
        foreach (OpenQA.Selenium.Remote.RemoteWebElement e in all_page_Elements)
        {
            if (e.Displayed)
            {
                try
                {
                    Console.WriteLine("text=" + e.Text);
                    getAllAtrributes(e.GetAttribute("outerHTML"));
                    Console.WriteLine(Environment.NewLine);
                }
                catch (Exception)
                {

                }

                i = i + 1;

            }
        }
    }
}

[TestCleanup]
public void tearDown()
{
    //driver.Quit();
}

}
