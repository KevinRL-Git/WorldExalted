using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worldexalted
{
    class uInterfaceItem
    {
        public GroupBox getAttributBox( String typeAttribut , int valueAtr ) {

            GroupBox gbAttribut = new GroupBox();
            Label tmpLbl = new Label();
            tmpLbl.Text = typeAttribut;
            gbAttribut.Text = typeAttribut;
            //gbAttribut.Container.Add(tmpLbl);
            int max = valueAtr;
            if (valueAtr < 5) {
                max = 5;
            }
            int atrLeft = valueAtr;
            Control[] tmpControl = new Control[max];
            CheckBox tmpBox;
            CheckBox tmpBox2 = new CheckBox();
            for (int i = 0;i<max;i++) {
                tmpBox = new CheckBox();
                if (atrLeft > 0) {
                    tmpBox.Checked = true;
                    atrLeft--;
                }
                tmpBox.Tag = i.ToString();
                tmpBox.Text = (i+1).ToString();
                tmpBox.Location = new Point((i+1)*10, 25);
                tmpBox.Enabled = false;
                tmpControl[i] = tmpBox;
                
            }
            //tmpControl[4] = tmpBox2;
            gbAttribut.Controls.AddRange(tmpControl);
               
            return gbAttribut;
        }
    }
}
