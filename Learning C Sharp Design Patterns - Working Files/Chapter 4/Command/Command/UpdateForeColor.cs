using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class UpdateForeColor : ICommand
    {
        public System.Windows.Forms.Control UI { get; set; }
        public System.Drawing.Color Color { get; set; }

        public void UpdateColor()
        {
            UI.ForeColor = Color;
        }

    }
}
