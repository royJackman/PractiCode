using System;
using System.Collections.Generic;
using System.Text;

namespace PractiCode.Services
{
    interface IInterpreter
    {
        void OnRunButtonClicked(object sender, EventArgs e);

        void OnClearButtonClicked(object sender, EventArgs e);
    }
}
