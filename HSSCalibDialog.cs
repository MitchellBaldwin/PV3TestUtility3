using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV3TestUtility3
{
    public partial class HSSCalibDialog : Form
    {
        PV3TestUtility3Main pv3tu3Main;
        
        public HSSCalibDialog()
        {
            InitializeComponent();

            pv3tu3Main = (PV3TestUtility3Main)Owner;
        }
    }
}
