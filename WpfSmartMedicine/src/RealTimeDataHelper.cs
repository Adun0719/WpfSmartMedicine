using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using WpfSmartMedicine.Views;

namespace WpfSmartMedicine.src
{
    public class RealTimeDataHelper:UniformGrid
    {
        private const int ColumnNumber = 4;
        private const int RowNumber = 4;

        public RealTimeDataHelper()
        {
            Columns = ColumnNumber;
            Rows = RowNumber;
            Init();
        }

        private void Init()
        {
            int frameId;
            for(frameId = 0; frameId < ColumnNumber * RowNumber; frameId++)
            {
                this.Children.Add(new Frame() { Content = new PageRealTimeDataItem() });//待完善
            }
        }
    }
}
