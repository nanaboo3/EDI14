using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAtendimento

{
    public partial class Form1 : Form
    {
        private static int id = 1;
        Senhas senhasGeradas = new Senhas();
        Senhas senhasNaoAtendidas = new Senhas();
        Senhas senhasAtendidas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.gerarButton = new System.Windows.Forms.Button();
            this.senhasList = new System.Windows.Forms.ListBox();
            this.guicheLabel = new System.Windows.Forms.Label();
            this.numGuicheLabel = new System.Windows.Forms.Label();
            this.addGuicheButton = new System.Windows.Forms.Button();
            this.escolherGuicheLabel = new System.Windows.Forms.Label();
            this.guicheTextBox = new System.Windows.Forms.TextBox();
            this.chamarButton = new System.Windows.Forms.Button();
            this.atendimentosListBox = new System.Windows.Forms.ListBox();
            this.atendimentosButton = new System.Windows.Forms.Button();
            this.listarSenhasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gerarButton
            // 
            this.gerarButton.Location = new System.Drawing.Point(126, 12);
            this.gerarButton.Name = "gerarButton";
            this.gerarButton.Size = new System.Drawing.Size(75, 23);
            this.gerarButton.TabIndex = 0;
            this.gerarButton.Text = "Gerar";
            this.gerarButton.UseVisualStyleBackColor = true;
            this.gerarButton.Click += new System.EventHandler(this.gerarButton_Click);
            // 
            // senhasList
            // 
            this.senhasList.FormattingEnabled = true;
            this.senhasList.Location = new System.Drawing.Point(12, 52);
            this.senhasList.Name = "senhasList";
            this.senhasList.Size = new System.Drawing.Size(291, 290);
            this.senhasList.TabIndex = 1;
            this.senhasList.SelectedIndexChanged += new System.EventHandler(this.senhasList_SelectedIndexChanged);
            // 
            // guicheLabel
            // 
            this.guicheLabel.AutoSize = true;
            this.guicheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guicheLabel.Location = new System.Drawing.Point(363, 52);
            this.guicheLabel.Name = "guicheLabel";
            this.guicheLabel.Size = new System.Drawing.Size(53, 17);
            this.guicheLabel.TabIndex = 2;
            this.guicheLabel.Text = "Guichê";
            // 
            // numGuicheLabel
            // 
            this.numGuicheLabel.AutoSize = true;
            this.numGuicheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.numGuicheLabel.Location = new System.Drawing.Point(376, 94);
            this.numGuicheLabel.Name = "numGuicheLabel";
            this.numGuicheLabel.Size = new System.Drawing.Size(26, 29);
            this.numGuicheLabel.TabIndex = 3;
            this.numGuicheLabel.Text = "0";
            this.numGuicheLabel.Click += new System.EventHandler(this.numGuicheLabel_Click);
            // 
            // addGuicheButton
            // 
            this.addGuicheButton.Location = new System.Drawing.Point(340, 206);
            this.addGuicheButton.Name = "addGuicheButton";
            this.addGuicheButton.Size = new System.Drawing.Size(88, 28);
            this.addGuicheButton.TabIndex = 4;
            this.addGuicheButton.Text = "Adicionar";
            this.addGuicheButton.UseVisualStyleBackColor = true;
            this.addGuicheButton.Click += new System.EventHandler(this.addGuicheButton_Click);
            // 
            // escolherGuicheLabel
            // 
            this.escolherGuicheLabel.AutoSize = true;
            this.escolherGuicheLabel.Location = new System.Drawing.Point(556, 22);
            this.escolherGuicheLabel.Name = "escolherGuicheLabel";
            this.escolherGuicheLabel.Size = new System.Drawing.Size(47, 13);
            this.escolherGuicheLabel.TabIndex = 5;
            this.escolherGuicheLabel.Text = "Guichê: ";
            // 
            // guicheTextBox
            // 
            this.guicheTextBox.Location = new System.Drawing.Point(609, 19);
            this.guicheTextBox.Name = "guicheTextBox";
            this.guicheTextBox.Size = new System.Drawing.Size(100, 20);
            this.guicheTextBox.TabIndex = 6;
            this.guicheTextBox.Text = "0";
            this.guicheTextBox.TextChanged += new System.EventHandler(this.guicheTextBox_TextChanged);
            // 
            // chamarButton
            // 
            this.chamarButton.Location = new System.Drawing.Point(755, 17);
            this.chamarButton.Name = "chamarButton";
            this.chamarButton.Size = new System.Drawing.Size(75, 23);
            this.chamarButton.TabIndex = 7;
            this.chamarButton.Text = "Chamar";
            this.chamarButton.UseVisualStyleBackColor = true;
            this.chamarButton.Click += new System.EventHandler(this.chamarButton_Click);
            // 
            // atendimentosListBox
            // 
            this.atendimentosListBox.FormattingEnabled = true;
            this.atendimentosListBox.Location = new System.Drawing.Point(487, 52);
            this.atendimentosListBox.Name = "atendimentosListBox";
            this.atendimentosListBox.Size = new System.Drawing.Size(343, 290);
            this.atendimentosListBox.TabIndex = 8;
            this.atendimentosListBox.SelectedIndexChanged += new System.EventHandler(this.atendimentosListBox_SelectedIndexChanged);
            // 
            // atendimentosButton
            // 
            this.atendimentosButton.Location = new System.Drawing.Point(559, 361);
            this.atendimentosButton.Name = "atendimentosButton";
            this.atendimentosButton.Size = new System.Drawing.Size(175, 23);
            this.atendimentosButton.TabIndex = 9;
            this.atendimentosButton.Text = "Listar Atendimentos";
            this.atendimentosButton.UseVisualStyleBackColor = true;
            this.atendimentosButton.Click += new System.EventHandler(this.atendimentosButton_Click);
            // 
            // listarSenhasButton
            // 
            this.listarSenhasButton.Location = new System.Drawing.Point(71, 361);
            this.listarSenhasButton.Name = "listarSenhasButton";
            this.listarSenhasButton.Size = new System.Drawing.Size(140, 23);
            this.listarSenhasButton.TabIndex = 10;
            this.listarSenhasButton.Text = "Listar Senhas";
            this.listarSenhasButton.UseVisualStyleBackColor = true;
            this.listarSenhasButton.Click += new System.EventHandler(this.listarSenhasButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(848, 407);
            this.Controls.Add(this.listarSenhasButton);
            this.Controls.Add(this.atendimentosButton);
            this.Controls.Add(this.atendimentosListBox);
            this.Controls.Add(this.chamarButton);
            this.Controls.Add(this.guicheTextBox);
            this.Controls.Add(this.escolherGuicheLabel);
            this.Controls.Add(this.addGuicheButton);
            this.Controls.Add(this.numGuicheLabel);
            this.Controls.Add(this.guicheLabel);
            this.Controls.Add(this.senhasList);
            this.Controls.Add(this.gerarButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void atendimentosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gerarButton_Click(object sender, EventArgs e)
        {
            Senha senha = new Senha(id++);
            senhasGeradas.gerar(senha);
            senhasNaoAtendidas.gerar(senha);
        }

        private void addGuicheButton_Click(object sender, EventArgs e)
        {
            Guiche guiche = new Guiche();
            guiches.adicionar(guiche);
            numGuicheLabel.Text = guiches.quantia();
        }

        private void numGuicheLabel_Click(object sender, EventArgs e)
        {

        }

        private void chamarButton_Click(object sender, EventArgs e)
        {
            int numGuiche = int.Parse(guicheTextBox.Text);
            atendimentosListBox.Items.Clear();
            try
            { 
                if(numGuiche > 0 && int.Parse(numGuicheLabel.Text) > 0 )
                { 
                    Guiche guiche = guiches.procurar(numGuiche-1);
                    guiche.chamar(senhasNaoAtendidas.Fila);
                    Senha senhaAtendida = senhasNaoAtendidas.Fila.First();
                    senhaAtendida.DataAtend = DateTime.Now;
                    senhasAtendidas.gerar(senhaAtendida);
                    senhasNaoAtendidas.tirar();
                    senhasNaoAtendidas.ProximoAtendimento = senhasNaoAtendidas.Fila.First().Id;
                }
            }
            catch(System.InvalidOperationException)
            {
                senhasList.Items.Add("Todas as senhas geradas foram chamadas.");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                atendimentosListBox.Items.Clear();
                atendimentosListBox.Items.Add("Guichê indisponível.");
            }
        }

        private void guicheTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void atendimentosButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(guicheTextBox.Text) > 0)
                {
                    atendimentosListBox.Items.Clear();
                    int numGuiche = int.Parse(guicheTextBox.Text);
                    Guiche guiche = guiches.procurar(numGuiche - 1);
                    foreach (Senha senha in guiche.Atendimentos)
                    {
                        atendimentosListBox.Items.Add(senha.dadosCompletos());
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                atendimentosListBox.Items.Clear();
                atendimentosListBox.Items.Add("Guichê indisponível.");
            }
        }

        private void listarSenhasButton_Click(object sender, EventArgs e)
        {
            senhasList.Items.Clear();

            foreach(Senha senha in senhasGeradas.Fila)
            {
                if (senha.DataAtend.HasValue)
                {
                    senhasList.Items.Add(senha.dadosCompletos());
                }
                else
                {
                    senhasList.Items.Add(senha.dadosParciais());
                }
            }
        }

        private void senhasList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
