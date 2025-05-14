namespace gestione_magazzino
{
    partial class Form1
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
            lbType = new Label();
            lbPrezzo = new Label();
            lbFornitore = new Label();
            lbQuantità = new Label();
            tBTipo = new TextBox();
            tBPrezzo = new TextBox();
            tBFornitore = new TextBox();
            tBQuantità = new TextBox();
            listBox1 = new ListBox();
            btnInserisci = new Button();
            SuspendLayout();
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(49, 76);
            lbType.Name = "lbType";
            lbType.Size = new Size(31, 15);
            lbType.TabIndex = 1;
            lbType.Text = "Tipo";
            // 
            // lbPrezzo
            // 
            lbPrezzo.AutoSize = true;
            lbPrezzo.Location = new Point(48, 155);
            lbPrezzo.Name = "lbPrezzo";
            lbPrezzo.Size = new Size(41, 15);
            lbPrezzo.TabIndex = 3;
            lbPrezzo.Text = "Prezzo";
            // 
            // lbFornitore
            // 
            lbFornitore.AutoSize = true;
            lbFornitore.Location = new Point(48, 120);
            lbFornitore.Name = "lbFornitore";
            lbFornitore.Size = new Size(55, 15);
            lbFornitore.TabIndex = 2;
            lbFornitore.Text = "Fornitore";
            // 
            // lbQuantità
            // 
            lbQuantità.AutoSize = true;
            lbQuantità.Location = new Point(48, 194);
            lbQuantità.Name = "lbQuantità";
            lbQuantità.RightToLeft = RightToLeft.No;
            lbQuantità.Size = new Size(53, 15);
            lbQuantità.TabIndex = 4;
            lbQuantità.Text = "Qauntità";
            // 
            // tBTipo
            // 
            tBTipo.Location = new Point(130, 76);
            tBTipo.Name = "tBTipo";
            tBTipo.Size = new Size(100, 23);
            tBTipo.TabIndex = 7;
            // 
            // tBPrezzo
            // 
            tBPrezzo.Location = new Point(130, 158);
            tBPrezzo.Name = "tBPrezzo";
            tBPrezzo.Size = new Size(100, 23);
            tBPrezzo.TabIndex = 9;
            // 
            // tBFornitore
            // 
            tBFornitore.Location = new Point(130, 120);
            tBFornitore.Name = "tBFornitore";
            tBFornitore.Size = new Size(100, 23);
            tBFornitore.TabIndex = 8;
            // 
            // tBQuantità
            // 
            tBQuantità.Location = new Point(130, 194);
            tBQuantità.Name = "tBQuantità";
            tBQuantità.Size = new Size(100, 23);
            tBQuantità.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(48, 279);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(649, 139);
            listBox1.TabIndex = 12;
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(451, 51);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(75, 23);
            btnInserisci.TabIndex = 13;
            btnInserisci.Text = "Inserisci";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInserisci);
            Controls.Add(listBox1);
            Controls.Add(tBQuantità);
            Controls.Add(tBPrezzo);
            Controls.Add(tBFornitore);
            Controls.Add(tBTipo);
            Controls.Add(lbQuantità);
            Controls.Add(lbPrezzo);
            Controls.Add(lbFornitore);
            Controls.Add(lbType);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbType;
        private Label lbPrezzo;
        private Label lbFornitore;
        private Label lbQuantità;
        private TextBox textBox1;
        private TextBox tBTipo;
        private TextBox tBPrezzo;
        private TextBox tBFornitore;
        private TextBox tBQuantità;
        private ListBox listBox1;
        private Button btnInserisci;
    }
}
