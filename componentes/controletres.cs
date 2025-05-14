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
    public partial class controletres : UserControl
    {
        int IDtres;
        public controletres()
        {
            InitializeComponent();
            Utils.Rounded.setRoundedController(btn_Todos, 10);
            Utils.Rounded.setRoundedController(btn_escpecial, 10);
            Utils.Rounded.setRoundedController(btn_aniversario, 10);


            flp_promo.Controls.Clear();
            foreach (var item in ProdutosDAL.ListarTodosOsProdutos().Where(item => item.promocao == true))
            {
                carddois a = new carddois(item);
                flp_promo.Controls.Add(a);
            }
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {

            flp_promo.Controls.Clear();
            foreach (var item in ProdutosDAL.ListarTodosOsProdutos().Where(item => item.promocao == true))
            {
                carddois a = new carddois(item);
                flp_promo.Controls.Add(a);
            }
        }

        private void btn_escpecial_Click(object sender, EventArgs e)
        {
            flp_promo.Controls.Clear();
            PromoPascoa a = new PromoPascoa();
            flp_promo.Controls.Add(a);

        }

        private void btn_aniversario_Click(object sender, EventArgs e)
        {
            flp_promo.Controls.Clear();
            PromoAniver a = new PromoAniver();
            flp_promo.Controls.Add(a);
        }
    }
}