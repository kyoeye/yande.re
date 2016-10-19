using System.Xml;
using Windows.UI.Xaml.Controls;
using System.Collections.Generic;
using Windows.Data.Xml.Dom;
using System.Xml.Linq;
using Windows.UI.Xaml.Media.Imaging;
using System;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        int a = 0;
        string[] id = new string[2];
        string[] uri = new string[2];
        //private string getacg()
        //{
        //    //string url = "https://yande.re/post.xml?limit=1";
        //    //WebRequest HttpWReq = (HttpWebRequest)WebRequest.Create(url);
        //    //HttpWReq.Method = "GET";//GET请求
        //    //                        //string x = await HttpClient.g 
        //    //XmlDocument xmldoc = new XmlDocument();
        //    //xmldoc.LoadXml(url);
        //    //HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
        //    //StreamReader sw = new StreamReader(HttpWResp.GetResponseStream());
        //    ////将返回的结果读入流


        //    //WebRequest myWebRequest = WebRequest.Create(url);

        //    ////Send the 'WebRequest' and wait for response.
        //    //WebResponse myWebResponse = myWebRequest.GetResponse();
        //    //Stream strm = myWebResponse.GetResponseStream();
        //    //StreamReader reader = new StreamReader(strm);
        //    //string str = reader.ReadToEnd();

        //    //      request.BeginGetResponse(new AsyncCallback(GetResponse), request);
        //    //}



        //    //void GetResponse(IAsyncResult res)
        //    //{
        //    //    HttpWebRequest request = (HttpWebRequest)res.AsyncState;
        //    //    HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(res);
        //    //    string content = "";
        //    //    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
        //    //    {
        //    //        content = reader.ReadToEnd();
        //    //    }
        //    //    Deployment.Current.Dispatcher.BeginInvoke(delegate
        //    //    {
        //    //        MessageBox.Show(content);
        //    //    });

        //    //

        //    //

        //}

        public void getimg()
        {
            try
            {
                string xd = uri[a];
                BitmapImage getimg = new BitmapImage(new Uri(xd));
               
                Imagehaha.Source = getimg;
            }
            catch
            {

            }
        }


        private void mybutton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            getacg();
        }

        public async void getacg()
        {
            string url = "https://yande.re/post.xml?limit=30";
            var mystring = await Class2.GetWebString(url, null);


            XElement root = XElement.Parse(mystring);
            IEnumerable<XElement> elements = root.Elements();
            foreach (var element in elements)
            {
                if (element.Name == "post")
                {
                    IEnumerable<XAttribute> Items = element.Attributes();
                    foreach (var item in Items)
                    {
                        if (item.Name == "id")
                        {
                            
                            id[0] = (string)item;
                            textb.Text = id[0];

                        }
                        else if (item.Name == "file_url")
                        {
                            uri[0] = (string)item;
                            mybutton.Content = uri[0];
                          

                        }
                        else if (item.Name == "rating")
                        {
                            bool fc = ( item.Value != "e" );
                            if (fc == false )
                            {
                                break;
                            }
                            break;
                        }
                       
                    }
                }
                break;
            }

            //Windows.Data.Xml.Dom.XmlDocument doc = new Windows.Data.Xml.Dom.XmlDocument();
            //doc.LoadXml (mystring);

            //Windows.Data.Xml.Dom.XmlNodeList schoolNodeList = doc.SelectNodes("/posts");

            //if (schoolNodeList != null)
            //{
            //    foreach (XmlNode schoolNode in schoolNodeList)
            //    {

            //    }
            //}




            //Windows.Data.Xml.Dom.XmlDocument doc = new Windows.Data.Xml.Dom.XmlDocument();
            //doc.LoadXml(mystring);
            //Windows.Data.Xml.Dom.XmlNodeList postsNodeList = doc.SelectNodes("/posts");//一级节点
            //if (postsNodeList != null)
            //{
            //    foreach (Windows.Data.Xml.Dom.XmlAttribute yandeNode in postsNodeList) //循环
            //    {

            //        Windows.Data.Xml.Dom.XmlAttribute gradesNode = yandeNode.NodeName ;
            //        {
            //            System.Xml.XmlNodeList gradeNodeList = gradesNode.ChildNodes;

            //            if (gradeNodeList != null)
            //            {
            //                foreach (XmlNode gradeNode in gradeNodeList)
            //                {
            //                    textb.Text = yandeNode.Attributes["jpeg_url"].Value;

            //                }
            //            }

            //        }


            //    }
            //}
            //else
            //{
            //    textb.Text = "一个坏消息，无法找到posts";
            //}
        }

        private void mybutton2_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            getimg();
        }
    }
}
