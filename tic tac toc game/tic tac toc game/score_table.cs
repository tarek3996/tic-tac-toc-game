using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toc_game
{
    public partial class score_table : Form
    {
        public score_table()
        {
            InitializeComponent();
            get_data();
            delete_btn.Visible=false;
        }

        public void get_data()
        {
            score_dgv.DataSource = db_context.Select("select * from [dbo].[tic tac toe score table]", "Server=.;Database=tic tac toe;Trusted_Connection=True;TrustServerCertificate=True");
        }

        int id;

        private void delete_btn_Click(object sender, EventArgs e)
        {
            
            db_context.ExecuteNonQuery($"delete from [dbo].[tic tac toe score table] where id ={id}", "Server=.;Database=tic tac toe;Trusted_Connection=True;TrustServerCertificate=True");
            get_data();
        }

        private void score_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id =(int) score_dgv.SelectedRows[0].Cells[0].Value;
            delete_btn.Visible = true;
        }
    }
}
