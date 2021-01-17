using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusChan.Model
{
    class ListViewData
    {
        public static ColumnHeader GetColumnHeader(string Text, string Name, int width)
        {
            ColumnHeader columnHeader = new ColumnHeader(); 
            columnHeader.Text = Text;
            columnHeader.Name = Name;
            columnHeader.Width = width; 
            return columnHeader;
        }

        public static ListViewItem GetListViewItem(string fileName, string fileSize, VirusTotalState virusTotalState)
        {
            ListViewItem listViewItem = new ListViewItem(fileName);
            listViewItem.SubItems.Add(fileSize);
            listViewItem.SubItems.Add(virusTotalState.ToString()); 
            listViewItem.Font = new Font("Comic Sans MS", 8);

            return listViewItem;
        }

        public static OLVColumn CreateColumn(string name, string text, string aspect, int width)
        {
            HeaderFormatStyle style = new HeaderFormatStyle();
            //style.SetBackColor(Color.FromArgb(240, 240, 240));
            
            style.SetForeColor(Color.FromArgb(63, 130, 242));
            style.SetFont(new Font("Comic Sans MS", 10, FontStyle.Bold));
            
            OLVColumn column = new OLVColumn()
            {
                Name = name,
                Text = text,
                AspectName = aspect,
                Width = width,
                HeaderFormatStyle = style,                                
            };

            return column;
        }
    }
}
