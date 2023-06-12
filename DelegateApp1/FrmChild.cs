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
    public partial class FrmChild : Form
    {
        //3、创建委托变量
       public PassMsgDelegate passMsg;
        
        public FrmChild()
        {
            InitializeComponent();
        }
        public FrmChild(string childName)
        {
            InitializeComponent();
            this.Text = childName;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //5、使用委托变量调用所关联的方法
            //passMsg(this.txtSendMsg.Text,this.Text);
            //两种方法都一样，建议使用下面的方法
            passMsg.Invoke(this.txtSendMsg.Text, this.Text);
        }

        public void Receiver(string msg)
        {
            this.txtReceiveMsg.Text =msg;
        }


    }
}
