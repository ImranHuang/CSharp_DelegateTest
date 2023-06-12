using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateApp1
{
    public partial class FrmMain : Form
    {

        public SendMsgDelegate sendMsg;
        public FrmMain()
        {
            InitializeComponent();
        }

        //窗体集合，后面用于关闭窗体
        private List<Form> formList = new List<Form>();

        //2、根据委托编写具体方法
        private void ReceiveMsg(string msg,string childName)
        {
            this.txtContent.Text += $"来自{childName}的消息：{msg}\r\n";

        }

        private void btnCreateChildForm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                FrmChild child = new FrmChild($"这是第{i+1}个子窗体");
                //4、将委托变量和具体方法关联起来
                child.passMsg += ReceiveMsg;//此处使用=跟+=是一样的效果
                child.Show();

                sendMsg += child.Receiver;//此处必须使用+=。若使用=只能关联最后一个窗体
                formList.Add(child);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtContent.Clear();
            
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            foreach (var item in formList)
            {
                item.Close();
            }
        }

        private void btnBroadCast_Click(object sender, EventArgs e)
        {
            sendMsg(this.txtSend.Text);
        }
    }


    //1、声明委托

    //子窗体往主窗体发数据
    public delegate void PassMsgDelegate(string msg, string childName);

    //主窗体往子窗体发数据
    public delegate void SendMsgDelegate(string msg);

}
