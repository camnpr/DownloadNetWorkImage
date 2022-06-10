using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

/**
 * 批量下载网络图片（包括http/https）
 *  by camnpr.com
 */
namespace DownloadNetWorkImage
{
    public partial class StartApp : Form
    {
        public StartApp()
        {
            InitializeComponent();
        }

        private void StartApp_Load(object sender, EventArgs e)
        {
            
        }

        public int errorNumberTimer = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            // 先清空之前的下载日志
            processTips.Text = "";
            // 失败次数提示
            errorNumberTips.Text = "";
            errorNumberTimer = 0;

            if (locationHref.Text != "" 
                && firstIndex.Text != "" 
                && lastIndex.Text != "" 
                && fileExt.Text != "" 
                && saveAddress.Text != "")
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls; // 启用https的协议，否则会报错

                // 下载目录
                string distPathPrefix = saveAddress.Text.Replace(@"\", @"\\"); // 路径转换

                for (int i = Convert.ToInt32(firstIndex.Text); i <= Convert.ToInt32(lastIndex.Text); i++)
                {
                    string fullPath = locationHref.Text + i + fileExt.Text;

                    //System.Threading.Thread threadA = new System.Threading.Thread(DownloadFile.)

                    // 下载提示
                    processTips.Text = "开始下载第" + i + "个 " + fullPath + " ...\r\n" + processTips.Text;

                    //DownloadFile(fullPath, "D:\\NetTools\\DownloadNetWorkImage\\DownloadNetWorkImage\\download\\" + i.ToString() + fileExt.Text);
                    DownloadFile(fullPath, distPathPrefix + i.ToString() + fileExt.Text, i);
                }
            }
        }

        
        private void DownloadFile(string fullPath, string distPath, int index)
        {
            try { 
                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(fullPath);
                myReq.KeepAlive = false;
                myReq.Timeout = 30 * 1000; // 超时时间
                myReq.Method = "GET";
                myReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                //myReq.Referer = "https://www.camnpr.com/"; //  "http://www.camnpr.com/";
                myReq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36";

                HttpWebResponse myRes = (HttpWebResponse)myReq.GetResponse();

                // 保存图片
                using (FileStream fs = new FileStream(distPath, FileMode.Create))
                {
                    myRes.GetResponseStream().CopyTo(fs);

                    // 下载提示
                    processTips.Text = "第" + index + "个 " + fullPath + " 下载成功！\r\n" + processTips.Text;
                }
            } catch (Exception e)
            {
                processTips.Text = e.Message;
                errorNumberTimer += 1;

                // 如果失败/异常次数达到5次就提出程序
                errorNumberTips.Text = "已经失败/异常 " + errorNumberTimer + " 次，5次后将自动退出！";
                if (errorNumberTimer >= 5)
                {
                    //Application.Exit();
                    System.Environment.Exit(System.Environment.ExitCode);
                }
            }
        }
    }
}
