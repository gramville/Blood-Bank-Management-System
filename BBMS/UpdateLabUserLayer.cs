using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BBMS
{
    class UpdateLabUserLayer
    {
        public string check;
        public int bloodid;
        public UpdateLabUserLayer(int bloodid, string check)
        {
            this.bloodid = bloodid;
            this.check = check;
        }
        public UpdateLabUserLayer()
        {

        }
        public void update_unprocessed_donation()
        {
            UpdateLabDbLayer u = new UpdateLabDbLayer();
            u.update_unprocessed_donation(this);
        }
        public DataTable view_unprocessed_donations()
        {
            UpdateLabDbLayer u = new UpdateLabDbLayer();
            DataTable dt = u.view_unprocessed_donations();
            return dt;
        }
    }
}