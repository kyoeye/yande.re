using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App1.MainPage;

namespace App1
{
    class Class1
    {
        //void airws_getDomesticAirlinesTimeCompleted(object sender, AirLineWS.getDomesticAirlinesTimeCompletedEventArgs e)
        //{
        //    try
        //    {//关键的解析部分
        //        List<AirLine1> airlinelist = e.Result.Nodes.Descendants("AirlinesTime").Select(
        //            item => new AirLine1()
        //            {
        //                Company1 = item.Element("Company").Value,
        //                AirLineCode1 = item.Element("AirlineCode").Value,
        //                StartDrome1 = item.Element("StartDrome").Value,
        //                EndDrome1 = item.Element("ArriveDrome").Value,
        //                StartTime1 = item.Element("StartTime").Value,
        //                EndTime1 = item.Element("ArriveTime").Value,
        //                AirLineStop1 = item.Element("AirlineStop").Value,
        //                Week1 = item.Element("Week").Value
        //            }).ToList();
        //        foreach (AirLine1 al in airlinelist)
        //        {
        //            //TextBlock t = new TextBlock();
        //            //t.Text = "航空公司:" + al.Company1;
        //            //t.FontSize = 24;
        //            //TextBlock t1 = new TextBlock();
        //            //t1.Text = "航班号:" + al.AirLineCode1;
        //            //t1.FontSize = 24;
        //            //TextBlock t2 = new TextBlock();
        //            //t2.Text = "出发机场:" + al.StartDrome1;
        //            //t2.FontSize = 24;
        //            //TextBlock t3 = new TextBlock();
        //            //t3.Text = "到达机场:" + al.EndDrome1;
        //            //t3.FontSize = 24;
        //            //TextBlock t4 = new TextBlock();
        //            //t4.Text = "出发时间:" + al.StartTime1;
        //            //t4.FontSize = 24;
        //            //TextBlock t5 = new TextBlock();
        //            //t5.Text = "到达时间:" + al.EndTime1;
        //            //t5.FontSize = 24;
        //            //TextBlock t6 = new TextBlock();
        //            //t6.Text = "经停:" + al.AirLineStop1 + "次";
        //            //t6.FontSize = 24;
        //            //TextBlock t7 = new TextBlock();
        //            //t7.Text = "飞行周期:" + al.Week1;
        //            //t7.FontSize = 24;
        //            //StackPanel sp = new StackPanel();
        //            //sp.Margin = new Thickness(0, 10, 0, 0);
        //            //sp.Width = 400;
        //            //sp.Children.Add(t);
        //            //sp.Children.Add(t1);
        //            //sp.Children.Add(t2);
        //            //sp.Children.Add(t3);
        //            //sp.Children.Add(t4);
        //            //sp.Children.Add(t5);
        //            //sp.Children.Add(t6);
        //            //sp.Children.Add(t7);
        //            //stackPanel1.Children.Add(sp);

        //        }
        //    }
        //    catch (Exception ee)
        //    {
        //        MessageBox.Show("很抱歉，找不到您所要查询的信息,请稍后再试");
        //    }
        //}
    }

}
