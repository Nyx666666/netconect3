using sockets;
using System.Diagnostics;

namespace _1
{
    public partial class Form1 : Form
    {
        public bool isconnected;
        
        public Dictionary<string, Bitmap> bitmaps;
        public Form1()
        {
            isconnected = false;
            Debug.WriteLine("AAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH"+ Form.DefaultBackColor.ToArgb());
            InitializeComponent();
            bitmaps = new Dictionary<string, Bitmap>();
            
            //sockets.sockets soc = new sockets.sockets(52000);
        }

        private void msg_boxset_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isconnected)
            {
                string msg = msg_out_box.Text.ToString();
                Debug.WriteLine("'" + msg + "' was sent at : " + DateTime.Now);
            }
            else
            {
                MessageBox.Show("error: not connected");
            }
        }

        private void msg_out_box_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}