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
            listBox2 = new ListBox();
            cBFornitore = new ComboBox();
            btFilter = new Button();
            btLoad = new Button();
            btSave = new Button();
            rbTipo = new RadioButton();
            rbFornitore = new RadioButton();
            cBTipo = new ComboBox();
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
            listBox1.Size = new Size(368, 139);
            listBox1.TabIndex = 12;
            // 
            // btnInserisci
            // 
            btnInserisci.Location = new Point(353, 76);
            btnInserisci.Name = "btnInserisci";
            btnInserisci.Size = new Size(75, 23);
            btnInserisci.TabIndex = 13;
            btnInserisci.Text = "Inserisci";
            btnInserisci.UseVisualStyleBackColor = true;
            btnInserisci.Click += btnInserisci_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(467, 279);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(321, 139);
            listBox2.TabIndex = 15;
            listBox2.Visible = false;
            // 
            // cBFornitore
            // 
            cBFornitore.Enabled = true;
            cBFornitore.FormattingEnabled = true;
            cBFornitore.Location = new Point(618, 147);
            cBFornitore.Name = "cBFornitore";
            cBFornitore.Size = new Size(121, 23);
            cBFornitore.TabIndex = 16;
            cBFornitore.Visible = false;
            // 
            // btFilter
            // 
            btFilter.Location = new Point(559, 219);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(75, 23);
            btFilter.TabIndex = 19;
            btFilter.Text = "Filtra Ricerca";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Visible = false;
            btFilter.Click += btFilter_Click;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(353, 120);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(75, 23);
            btLoad.TabIndex = 20;
            btLoad.Text = "Carica File";
            btLoad.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(353, 186);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 21;
            btSave.Text = "Salva File";
            btSave.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            rbTipo.AutoSize = true;
            rbTipo.Location = new Point(467, 77);
            rbTipo.Name = "rbTipo";
            rbTipo.Size = new Size(98, 19);
            rbTipo.TabIndex = 22;
            rbTipo.TabStop = true;
            rbTipo.Text = "Filtra per Tipo";
            rbTipo.UseVisualStyleBackColor = true;
            rbTipo.Visible = false;
            rbTipo.CheckedChanged += rbTipo_CheckedChanged;
            // 
            // rbFornitore
            // 
            rbFornitore.AutoSize = true;
            rbFornitore.Location = new Point(467, 147);
            rbFornitore.Name = "rbFornitore";
            rbFornitore.Size = new Size(122, 19);
            rbFornitore.TabIndex = 23;
            rbFornitore.TabStop = true;
            rbFornitore.Text = "Filtra Per Fornitore";
            rbFornitore.UseVisualStyleBackColor = true;
            rbFornitore.Visible = false;
            rbFornitore.CheckedChanged += rbFornitore_CheckedChanged;
            // 
            // cBTipo
            // 
            cBTipo.FormattingEnabled = true;
            cBTipo.Location = new Point(618, 77);
            cBTipo.Name = "cBTipo";
            cBTipo.Size = new Size(121, 23);
            cBTipo.TabIndex = 24;
            cBTipo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBTipo);
            Controls.Add(rbFornitore);
            Controls.Add(rbTipo);
            Controls.Add(btSave);
            Controls.Add(btLoad);
            Controls.Add(btFilter);
            Controls.Add(cBFornitore);
            Controls.Add(listBox2);
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
        private ComboBox comboBox1;
        private ListBox listBox2;
        private ComboBox cBFornitore;
        private Label label2;
        private Button btFilter;
        private Button btLoad;
        private Button btSave;
        private RadioButton rbTipo;
        private RadioButton rbFornitore;
        private ComboBox cBTipo;
    }
}
