namespace gestion_pharmacie
{
    partial class AccueilForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserWelcome;
        private Guna.UI2.WinForms.Guna2Button btnDeconnexion;

        // Menu Sidebar
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private System.Windows.Forms.Label lblMenuTitle;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnRechercher;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private Guna.UI2.WinForms.Guna2Button btnModifier;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
        private Guna.UI2.WinForms.Guna2Button btnAlerte;
        private Guna.UI2.WinForms.Guna2Separator separator1;
        private Guna.UI2.WinForms.Guna2Separator separator2;

        // Main Content Area - PLUS DE VSCROLLBAR
        private Guna.UI2.WinForms.Guna2Panel panelMain;

        // Dashboard Cards
        private Guna.UI2.WinForms.Guna2Panel cardTotalMedicaments;
        private Guna.UI2.WinForms.Guna2Panel cardAlerte;
        private Guna.UI2.WinForms.Guna2Panel cardPeremption;
        private Guna.UI2.WinForms.Guna2Panel cardValeurStock;

        private System.Windows.Forms.Label lblTotalMedicaments;
        private System.Windows.Forms.Label lblTotalMedicamentsValue;
        private System.Windows.Forms.Label lblTotalMedicamentsIcon;

        private System.Windows.Forms.Label lblAlerte;
        private System.Windows.Forms.Label lblAlerteValue;
        private System.Windows.Forms.Label lblAlerteIcon;

        private System.Windows.Forms.Label lblPeremption;
        private System.Windows.Forms.Label lblPeremptionValue;
        private System.Windows.Forms.Label lblPeremptionIcon;

        private System.Windows.Forms.Label lblValeurStock;
        private System.Windows.Forms.Label lblValeurStockValue;
        private System.Windows.Forms.Label lblValeurStockIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ... (gardez votre code d'initialisation existant)
            // MAIS NE CRÉEZ PAS DE VSCROLLBAR

            // panelMain doit juste contenir les composants de base
            // Le panelScrollable sera créé dynamiquement dans le code

            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            cardTotalMedicaments.SuspendLayout();
            cardAlerte.SuspendLayout();
            cardPeremption.SuspendLayout();
            cardValeurStock.SuspendLayout();
            SuspendLayout();

            // ... gardez tout votre code d'initialisation existant ...
            // SAUF les lignes concernant vScrollBar1

            // À LA FIN, n'ajoutez PAS le vScrollBar1 aux Controls

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            cardTotalMedicaments.ResumeLayout(false);
            cardTotalMedicaments.PerformLayout();
            cardAlerte.ResumeLayout(false);
            cardAlerte.ResumeLayout();
            cardPeremption.ResumeLayout(false);
            cardPeremption.PerformLayout();
            cardValeurStock.ResumeLayout(false);
            cardValeurStock.PerformLayout();
            ResumeLayout(false);
        }
    }
}