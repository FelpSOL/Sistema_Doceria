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
using maridoces.conexao;

namespace maridoces.componentes
{
    public partial class controle : UserControl
    {
        int ID;
        public controle()
        {
            InitializeComponent();
            flp_Bolos.WrapContents = true;
            Utils.Rounded.setRoundedController(btn_Todos, 10);
            Utils.Rounded.setRoundedController(btn_Branca, 10);
            Utils.Rounded.setRoundedController(btn_chocolate, 10);
            Utils.Rounded.setRoundedController(btn_lowcarb, 10);


            foreach (var item in ProdutosDAL.ListarTodosOsProdutos())
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);

            }
            foreach (var item in ProdutosDAL.Todos(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
            foreach (var item in ProdutosDAL.MassaBranca(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
            foreach (var item in ProdutosDAL.Massadechocolate(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        public controle(int id_categoria)
        {
            InitializeComponent();
            ID = id_categoria;

            foreach (var item in ProdutosDAL.ListarTodosOsProdutos()
                .Where(item => item.id_categoria == id_categoria))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        private void btn_lowcarb_Click(object sender, EventArgs e)
        {
            flp_Bolos.Controls.Clear();
            foreach (var item in ProdutosDAL.LowCarb(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            flp_Bolos.Controls.Clear();
            foreach (var item in ProdutosDAL.Todos(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        private void btn_Branca_Click(object sender, EventArgs e)
        {
            flp_Bolos.Controls.Clear();
            foreach (var item in ProdutosDAL.MassaBranca(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        private void btn_chocolate_Click(object sender, EventArgs e)
        {
            flp_Bolos.Controls.Clear();
            foreach (var item in ProdutosDAL.Massadechocolate(ID))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }

        }
    }
}
