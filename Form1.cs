using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;


namespace HW_03._06._23_DrawButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int buttonCountMax = 100;
        private int indexButton = 0;
        private Button[] buttons = new Button[buttonCountMax];
        private int x, y, x1, y1, xDown, yDown, click=0, buttonCreate=0, width, height;
            
        private void Form1_MouseDown(object sender, MouseEventArgs e) 
        {
            click = 1;
            xDown=e.X; 
            yDown=e.Y;
            x= e.X;
            y= e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            if (click != 1) return;
            width = x1 - xDown;
            height=y1 - yDown;
            if (width <= 0 || height <= 0)
            {
                if (width > 0 && height > 0)
                {
                    y = y1;
                    height = Math.Abs(height);
                }
                else if (width < 0 && height > 0)
                {
                    x = x1;
                    width = Math.Abs(width);
                }
                else if (width < 0 && height < 0)
                {
                    x = x1;
                    y = y1;
                    width = Math.Abs(width);
                    height = Math.Abs(height);
                }
            }
            if (buttonCreate ==0)
            {
                buttons[indexButton] = new Button();
                SuspendLayout();
                buttons[indexButton].Name = "кнопка" + indexButton;
                buttons[indexButton].Text= "кнопка" + indexButton;
                buttons[indexButton].TabIndex = 0;
                buttons[indexButton].UseVisualStyleBackColor = true;
                buttons[indexButton].Location = new Point(x, y);
                buttons[indexButton].Size = new Size(width, height);
                buttons[indexButton].Visible = true;
                buttonCreate = 1;
                Controls.Add(buttons[indexButton]);
            }
            else
            {
                buttons[indexButton].Location=  new Point(x, y);
                buttons[indexButton].Size = new Size(width, height);
            }
        }
        
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            click = 0;
            buttonCreate = 0;
            if (width<20||height<20) 
            {
                MessageBox.Show("\n\t нопка сликом маленького размера", "ќшибка");
                buttons[indexButton].Dispose();
            }
            else
            {
                x1=e.X; y1=e.Y;
                width = x1 - xDown;
                height = y1 - yDown;
                if (width<=0 || height<=0)
                {
                    if (width>0 && height<0) 
                    {
                        y = y1;
                        height=Math.Abs(height);
                    }
                    else if (width<0 && height>0) 
                    {
                        x = x1;
                        width=Math.Abs(width);
                    }
                    else if(width<0&& height<0)
                    {
                        x= x1;
                        y= y1;
                        width= Math.Abs(width);
                        height= Math.Abs(height);
                    }
                }
                buttons[indexButton].Location = new Point(x, y);
                buttons[indexButton].Size = new Size(width, height);
                ++indexButton;

            }
        }
    }
}