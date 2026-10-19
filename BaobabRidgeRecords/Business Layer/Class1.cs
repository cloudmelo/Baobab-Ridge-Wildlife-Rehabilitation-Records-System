using BaobabRidgeRecords.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BaobabRidgeRecords.Business_Layer
{
    public class BusinessLayer
    {
        DataHandler dh = new DataHandler();
        public BusinessLayer() { }
        public BindingSource source()
        {
            BindingSource src = new BindingSource();
            src.DataSource = dh.GetAnimals();
            return src;
        }

    }
}
