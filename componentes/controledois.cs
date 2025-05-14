using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.Cards;

namespace maridoces.conexao
{
    public partial class controledois : UserControl
    {
        int IDdois;
        public controledois(int id_categoria)
        {
            InitializeComponent();

            IDdois = id_categoria;

            foreach (var item in ProdutosDAL.ListarTodosOsProdutos()
               .Where(item => item.id_categoria == id_categoria))
            {
                carddois a = new carddois(item);
                flp_dois.Controls.Add(a);
            }
            Utils.Rounded.setRoundedController(btn_Todos, 10);
            Utils.Rounded.setRoundedController(btn_lowCarb, 10);


        }

        private void btn_lowCarb_Click(object sender, EventArgs e)
        {
            flp_dois.Controls.Clear();
            foreach (var item in ProdutosDAL.LowCarb(IDdois))
            {
                carddois a = new carddois(item);
                flp_dois.Controls.Add(a);
            }
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {

            flp_dois.Controls.Clear();
            foreach (var item in ProdutosDAL.Todos(IDdois))
            {
                carddois a = new carddois(item);
                flp_dois.Controls.Add(a);
            }
        }
    }
}
