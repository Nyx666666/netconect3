////using dungon_master;
//using System;
//using _1;


//class display2d
//{
//    public int uiscale = 10;
    
//    //public void picbox(string name, int[] pos, int[] size, Color colour, int z, Form form)
//    //{
//    //    PictureBox pic = new PictureBox()
//    //    {
//    //        Name = name,
//    //        Size = new Size((int)((float)size[0] * (form.Width * uiscale) / (1000)), (int)((float)size[1] * (form.Height * uiscale) / (1000))),
//    //        BackColor = colour,
//    //        Location = new Point((int)((float)pos[0] * (form.Width * uiscale) / (1000)), (int)((float)pos[1] * (form.Height * uiscale) / (1000))),
//    //        Visible = true,
//    //    };
//    //    form.Controls.Add(pic);
//    //    //form.renorder.Add(z, pic);
//    //    reoder(form, z);

//    //}
//    //public void picbox(string name, int[] pos, int[] size, Color colour, string image, bool scale, int z, Form form, Dictionary<string, Bitmap> bitmaps)
//    //{
//    //    //public Dictionary<string, Bitmap> bitmaps;
//    //    PictureBox pic = new PictureBox();
//    //    if (scale)
//    //    {
//    //        pic = new PictureBox()
//    //        {
//    //            Name = name,
//    //            Size = new Size((int)((float)size[0] * (form.Width * uiscale) / (1000)), (int)((float)size[1] * (form.Height * uiscale) / (1000))),
//    //            BackColor = colour,
//    //            Location = new Point((int)((float)pos[0] * (form.Width * uiscale) / (1000)), (int)((float)pos[1] * (form.Height * uiscale) / (1000))),
//    //            Visible = true,
//    //            //Image = (Bitmap)Bitmap.FromFile(@image),
//    //            SizeMode = PictureBoxSizeMode.StretchImage,
//    //        };
//    //    }
//    //    else
//    //    {
//    //        pic = new PictureBox()
//    //        {
//    //            Name = name,
//    //            BackColor = colour,
//    //            Location = new Point((int)((float)pos[0] * (form.Height * uiscale) / (1000)), (int)((float)pos[1] * (form.Height * uiscale) / (1000))),
//    //            Visible = true,
//    //            //Image = (Bitmap)Bitmap.FromFile(@image),
//    //            SizeMode = PictureBoxSizeMode.AutoSize
//    //        };
//    //    }
//    //    try
//    //    {
//    //        pic.Image = bitmaps.GetValueOrDefault(image) ;
//    //    }
//    //    catch
//    //    {
//    //        try
//    //        {
//    //            pic.Image = bitmaps.GetValueOrDefault("placeholder");
//    //        }
//    //        catch { throw new Exception("image and replacement image are null"); }
//    //    }
//    //    form.Controls.Add(pic);
//    //    //form.renorder.Add(z, pic);
//    //    reoder(form, z);


//    //}
//    public void button(string name, int[] pos, int[] size, Color colour, string image, bool scale, int z, Form1 form /*, Dictionary<string, Bitmap> bitmaps*/)
//    {
        

//        Button button = new Button()
//        {
//            Name = name,
//            Size = new Size((int)((float)size[0] * (form.Width * uiscale) / (1000)), (int)((float)size[1] * (form.Height * uiscale) / (1000))),
//            Location = new Point((int)((float)pos[0] * (form.Width * uiscale) / (1000)), (int)((float)pos[1] * (form.Height * uiscale) / (1000))),
//            Visible = true,

//            //BackgroundImage = (Bitmap)Bitmap.FromFile(@image + ".png"),
//            UseVisualStyleBackColor = false,
//            FlatStyle = FlatStyle.Flat,
//            BackgroundImageLayout = ImageLayout.Stretch,

//        };
//        try
//        {
//            button.BackgroundImage = form.bitmaps.GetValueOrDefault(image); ;
//        }
//        catch
//        {
//            try
//            {
//                button.BackgroundImage = form.bitmaps.GetValueOrDefault("placeholder");
//            }
//            catch { throw new Exception("image and replacement image are null"); }
//        }

//        button.FlatAppearance.BorderSize = 0;
//        button.Click += new EventHandler(form.buttonclickevent);
//        form.Controls.Add(button);
//        form.renorder.Add(z, button);
//        reoder(form, z);
//    }
//    public void textbox(string name, int[] pos, int[] size, string text, Color c, int z, Form form)
//    {
//        TextBox box = new TextBox()
//        {

//            Name = name,
//            Size = new Size((int)((float)size[0] * (form.Width * uiscale) / (1000)), (int)((float)size[1] * (form.Height * uiscale) / (1000))),
//            Text = text,
//            ForeColor = c,
//            Location = new Point((int)((float)pos[0] * (form.Height * uiscale) / (1000)), (int)((float)pos[1] * (form.Height * uiscale) / (1000))),
//            Visible = true,
//            BackColor = Color.FromArgb(0, 0, 0, 0),
//            Font = new Font("serif", size[1]),

//        };

//        form.Controls.Add(box);
//        form.renorder.Add(z, box);
//        reoder(form, z);
//    }
//    void reoder(Form form, int z)
//    {
//        for (int i = 0; i < form.renorder.Count; i++)
//        {
//            form.Controls.SetChildIndex(form.renorder.Values.ElementAt(i), form.renorder.Keys.ElementAt(i));
//        }
//    }



//}