using maridoces.Cards;
using maridoces.componentes;
using maridoces.conexao;

namespace maridoces
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();

            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Promoções";

            controletres controle3 = new controletres();
            pnl_centro.Controls.Add(controle3);
            controle3.Dock = DockStyle.Fill;

            Utils.Rounded.setRoundedController(btn_carrinho, 10);
            Utils.Rounded.setRoundedController(btn_Prosseguir, 10);
            //btn_fimPagamento_Click += btn_Prosseguir_Click;
        }

        private void card_promocao_Click_1(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Promoções";

            controletres controle3 = new controletres();
            pnl_centro.Controls.Add(controle3);
            controle3.Dock = DockStyle.Fill;
        }

        private void card_pote_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bolos de Pote";
            controle controle = new controle(1);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;

        }

        private void card_bolos_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bolos de festa";
            controle controle = new controle(2);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_brigadeiro_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Brigadeiros";
            controledois controledois = new controledois(3);
            pnl_centro.Controls.Add(controledois);
            controledois.Dock = DockStyle.Fill;
        }

        private void card_trufas_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Trufas";
            controledois controledois = new controledois(4);
            pnl_centro.Controls.Add(controledois);
            controledois.Dock = DockStyle.Fill;
        }

        private void card_brownies_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Brownies";
            controledois controledois = new controledois(5);
            pnl_centro.Controls.Add(controledois);
            controledois.Dock = DockStyle.Fill;
        }

        private void card_paodemel_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Pão de mel";
            controledois controledois = new controledois(6);
            pnl_centro.Controls.Add(controledois);
            controledois.Dock = DockStyle.Fill;
        }

        private void card_bebidas_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bebidas";

            controledois controledois = new controledois(7);
            pnl_centro.Controls.Add(controledois);
            controledois.Dock = DockStyle.Fill;
        }

        ////////////////////////// felipe >

        private void btn_adm_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Administradores";
            LoginADM LoginADM = new LoginADM();
            pnl_centro.Controls.Add(LoginADM);
            LoginADM.Dock = DockStyle.Fill;
        }

        private void btn_fimPagamento_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Carrinho";
            ControleCarrinho controleCarrinho = new ControleCarrinho();
            pnl_centro.Controls.Add(controleCarrinho);
            controleCarrinho.Dock = DockStyle.Fill;
        }

        private void btn_carrinho_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Carrinho";
            ControleCarrinho controleCarrinho = new ControleCarrinho();
            pnl_centro.Controls.Add(controleCarrinho);
            controleCarrinho.Dock = DockStyle.Fill;
        }

        private void btn_Prosseguir_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Carrinho";
            cadastroUsuario Pagamento_Cadastro = new cadastroUsuario();
            pnl_centro.Controls.Add(Pagamento_Cadastro);
            Pagamento_Cadastro.Dock = DockStyle.Fill;
        }

        private void btn_Prosseguir_Click_1(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Forma de Pagamento";
            cadastroUsuario cadastroUsuario = new cadastroUsuario();
            pnl_centro.Controls.Add(cadastroUsuario);
            cadastroUsuario.Dock = DockStyle.Fill;
        }
    }
}
