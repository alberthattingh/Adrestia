using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adrestia
{
    public partial class UpcomingEvents : Component
    {
        public UpcomingEvents()
        {
            InitializeComponent();
        }

        public UpcomingEvents(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
