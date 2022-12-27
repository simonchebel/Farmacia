using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaSoft.Models;

namespace FarmaSoft
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            using (FarmaciaEntities db = new FarmaciaEntities())
            { 
                var lst = from f in db.Recurso select f;
                dgvRecursos.DataSource = lst.ToList();   
            }
        }
    }
}
