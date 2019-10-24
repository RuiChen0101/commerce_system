using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce_system
{
    public partial class ProductWindow : Form
    {
        private ItemInfo _itemInfo;
        public ProductWindow(ItemInfo itemInfo)
        {
            InitializeComponent();
            this._itemInfo = itemInfo;
        }
    }
}
