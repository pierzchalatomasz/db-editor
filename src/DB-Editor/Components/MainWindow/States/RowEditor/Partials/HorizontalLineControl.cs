using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    public partial class HorizontalLineControl : UserControl, IControlInterface
    {
        public HorizontalLineControl()
        {
            InitializeComponent();
        }

        #region UnnecessaryStuffForCasting
        public string FieldName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ValueName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool NullValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IfNecesseryFullfiled()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
