namespace projAtendimento
{
    partial class Form1
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

        private System.Windows.Forms.Button gerarButton;
        private System.Windows.Forms.ListBox senhasList;
        private System.Windows.Forms.Label guicheLabel;
        private System.Windows.Forms.Label numGuicheLabel;
        private System.Windows.Forms.Button addGuicheButton;
        private System.Windows.Forms.Label escolherGuicheLabel;
        private System.Windows.Forms.TextBox guicheTextBox;
        private System.Windows.Forms.Button chamarButton;
        private System.Windows.Forms.ListBox atendimentosListBox;
        private System.Windows.Forms.Button atendimentosButton;
        private System.Windows.Forms.Button listarSenhasButton;
    }
}

