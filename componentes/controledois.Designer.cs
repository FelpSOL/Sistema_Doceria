namespace maridoces.conexao
{
    partial class controledois
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Todos = new Button();
            btn_lowCarb = new Button();
            pnl_pao = new Panel();
            flp_dois = new FlowLayoutPanel();
            pnl_pao.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.Linen;
            btn_Todos.Cursor = Cursors.Hand;
            btn_Todos.FlatAppearance.BorderSize = 0;
            btn_Todos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Todos.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Todos.FlatStyle = FlatStyle.Flat;
            btn_Todos.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Todos.ForeColor = Color.FromArgb(67, 36, 24);
            btn_Todos.Location = new Point(3, 3);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 1;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = false;
            btn_Todos.Click += btn_Todos_Click;
            // 
            // btn_lowCarb
            // 
            btn_lowCarb.BackColor = Color.Linen;
            btn_lowCarb.Cursor = Cursors.Hand;
            btn_lowCarb.FlatAppearance.BorderSize = 0;
            btn_lowCarb.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_lowCarb.FlatAppearance.MouseOverBackColor = Color.White;
            btn_lowCarb.FlatStyle = FlatStyle.Flat;
            btn_lowCarb.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lowCarb.ForeColor = Color.FromArgb(67, 36, 24);
            btn_lowCarb.Location = new Point(90, 3);
            btn_lowCarb.Name = "btn_lowCarb";
            btn_lowCarb.Size = new Size(81, 33);
            btn_lowCarb.TabIndex = 3;
            btn_lowCarb.Text = "Low carb";
            btn_lowCarb.UseVisualStyleBackColor = false;
            btn_lowCarb.Click += btn_lowCarb_Click;
            // 
            // pnl_pao
            // 
            pnl_pao.AutoScroll = true;
            pnl_pao.BackColor = Color.BlanchedAlmond;
            pnl_pao.Controls.Add(btn_lowCarb);
            pnl_pao.Controls.Add(btn_Todos);
            pnl_pao.Dock = DockStyle.Top;
            pnl_pao.Location = new Point(0, 0);
            pnl_pao.Margin = new Padding(0);
            pnl_pao.Name = "pnl_pao";
            pnl_pao.Size = new Size(802, 43);
            pnl_pao.TabIndex = 4;
            // 
            // flp_dois
            // 
            flp_dois.AutoScroll = true;
            flp_dois.BackColor = Color.BlanchedAlmond;
            flp_dois.Dock = DockStyle.Fill;
            flp_dois.Location = new Point(0, 43);
            flp_dois.Margin = new Padding(0);
            flp_dois.Name = "flp_dois";
            flp_dois.Size = new Size(802, 461);
            flp_dois.TabIndex = 5;
            // 
            // controledois
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flp_dois);
            Controls.Add(pnl_pao);
            Name = "controledois";
            Size = new Size(802, 504);
            pnl_pao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_lowCarb;
        private Panel pnl_pao;
        private FlowLayoutPanel flp_dois;
    }
}
