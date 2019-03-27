using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOLAPS
{
    public partial class fDSub2 : Form
    {
        private List<String> _labels = new List<String> { "calderacc", "demment", "juwise", "moneiyy", "sembien" };
        private List<String> _characters = new List<String> { "Aristototle", "Chuck", "Deggart", "Frinces", "Gaylart", "Phoebe" };
        private List<String> _action1 = new List<String> { "has entered the builing", "is at the table","is standing outside" };
        private List<String> _action4 = new List<String> { "have entered the builing", "are at the table", "are meeting outside" };
        private List<String> _subject = new List<String> { "computers", "digging", "dresses", "library", "NewYear" };

        public fDSub2()
        {
            InitializeComponent();
        }

        private void FDSub2_Load(object sender, EventArgs e)
        {

        }
    }
}
