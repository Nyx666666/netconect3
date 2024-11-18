using sockets;

namespace _1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Bitmap> bitmaps;
        public Form1()
        {
            InitializeComponent();
            bitmaps = new Dictionary<string, Bitmap>();
            sockets.sockets soc = new sockets.sockets(52000);
        }

        private void msg_boxset_Enter(object sender, EventArgs e)
        {

        }
    }
}