namespace APP_POO
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            PanelConteudo = new Panel();
            SuspendLayout();
            // 
            // PanelConteudo
            // 
            resources.ApplyResources(PanelConteudo, "PanelConteudo");
            PanelConteudo.Name = "PanelConteudo";
            // 
            // TelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(PanelConteudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TelaPrincipal";
            ResumeLayout(false);
        }

        #endregion

        public Panel PanelConteudo;
    }
}
