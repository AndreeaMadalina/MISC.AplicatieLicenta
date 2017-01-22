using ClientLicenta_GUI.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLicenta_GUI
{
    public partial class NewsFeedForm : Form
    {
        #region VARIABLES
        private Service1Client _service = new Service1Client();
        private ReadServiceClient _serviceRead = new ReadServiceClient();
        Color _myColor;
        Font _myFont;
        #endregion

        #region CONSTRUCTORS
        public NewsFeedForm()
        {
            InitializeComponent();
            NewsListBox.Items.Clear();
            NewsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.NewsListBox.DrawItem += NewsListBox_DrawItem; //Ma abonez la event pentru editarea item-urilor listBox-ului meu
        }
        #endregion

        #region EVENTS
        #region BackButton_Click
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.NewsListBox.DrawItem -= NewsListBox_DrawItem;
        }
        #endregion

        #region NewsFeedForm_Load
        private void NewsFeedForm_Load(object sender, EventArgs e)
        {
            
            foreach (var item in _serviceRead.FillNewsBox())
            {
                NewsListBox.Items.Add(item.Title);
                NewsListBox.Items.Add(item.Date.ToString("MM/dd/yyyy"));
                NewsListBox.Items.Add(item.Description);
                NewsListBox.Items.Add("\n");
                NewsListBox.Items.Add("\n");
            }  
        }
        #endregion

        #region NewsListBox_DrawItem
        void NewsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            _myColor = Color.Red;
            _myFont = new Font(FontFamily.GenericSerif, 10, FontStyle.Bold);

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
            if (e.Index == 0 || e.Index % 5 == 0)
            {
                myBrush = Brushes.Red;
                // Draw the current item text based on the current Font 
                // and the custom brush settings.
                e.Graphics.DrawString(NewsListBox.Items[e.Index].ToString(),
                    _myFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
            else if (e.Index - 1 == 0 || (e.Index - 1) % 5 == 0)
            {
                Font font = new Font(FontFamily.GenericMonospace, 7, FontStyle.Italic);
                e.Graphics.DrawString(NewsListBox.Items[e.Index].ToString(),
                    font, myBrush, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(NewsListBox.Items[e.Index].ToString(),
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            }


            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        #endregion
        #endregion
    }
}
