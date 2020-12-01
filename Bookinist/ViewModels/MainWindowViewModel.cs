using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCore.ViewModels;

namespace Bookinist.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        
        #region A: TYPE - Description

        ///<summary></summary>
        private double _a;

        ///<summary></summary>
        public double A {get => _a; set => Set(ref _a, value);}


        #endregion
    }
}
