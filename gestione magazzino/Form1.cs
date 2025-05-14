namespace gestione_magazzino
{
    public partial class Form1 : Form
    {
        struct Prodotto
        {
            public int Id;
            public string Nome;
            public string Fornitore;
            public int Quantita;
            public double Prezzo;
        }

        public Form1()
        {
            InitializeComponent();
        }
        int PRODOTTI_IN_MAGAZZINO = 0;
        Prodotto[] prodotti = new Prodotto[100];


        private void btnInserisci_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool find = false;

            if (tBTipo.Text == "" || tBPrezzo.Text == "" || tBFornitore.Text == "" || tBQuantità.Text == "")
            {
                MessageBox.Show("Compila tutti i campi");
            }
            else
            {
                if (listBox1.Items.Count == 0) //SE LA LISTA E' VUOTA
                {
                    prodotti[PRODOTTI_IN_MAGAZZINO].Id = PRODOTTI_IN_MAGAZZINO + 1;
                    prodotti[PRODOTTI_IN_MAGAZZINO].Nome = tBTipo.Text;
                    prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo = double.Parse(tBPrezzo.Text);
                    prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore = tBFornitore.Text;
                    prodotti[PRODOTTI_IN_MAGAZZINO].Quantita = int.Parse(tBQuantità.Text);
                    listBox1.Items.Add(prodotti[PRODOTTI_IN_MAGAZZINO].Nome + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Quantita);
                    PRODOTTI_IN_MAGAZZINO += 1;
                    listBox2.Visible = true;
                    rbTipo.Visible = true;
                    rbFornitore.Visible = true;

                }
                else
                {
                    for (i = 0; i < PRODOTTI_IN_MAGAZZINO; i++)
                    {
                        if (prodotti[i].Nome == tBTipo.Text && prodotti[i].Fornitore == tBFornitore.Text)
                        {
                            MessageBox.Show("Articolo " + tBTipo.Text + " già presente!\n Aggiorno la quantità sommando la giacenza (" + prodotti[i].Quantita.ToString() + ") a quanto ora hai inserito (" + tBQuantità.Text + ")!");
                            prodotti[i].Quantita += int.Parse(tBQuantità.Text);
                            listBox1.Items[i] = prodotti[i].Nome + " " + prodotti[i].Prezzo + " " + prodotti[i].Fornitore + " " + prodotti[i].Quantita;
                            find = true;
                        }

                    }
                    if (find != true)
                    {
                        prodotti[PRODOTTI_IN_MAGAZZINO].Id = PRODOTTI_IN_MAGAZZINO + 1;
                        prodotti[PRODOTTI_IN_MAGAZZINO].Nome = tBTipo.Text;
                        prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo = double.Parse(tBPrezzo.Text);
                        prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore = tBFornitore.Text;
                        prodotti[PRODOTTI_IN_MAGAZZINO].Quantita = int.Parse(tBQuantità.Text);
                        listBox1.Items.Add(prodotti[PRODOTTI_IN_MAGAZZINO].Nome + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Quantita);
                        PRODOTTI_IN_MAGAZZINO += 1;

                    }
                }
            }
        }

        private void rbTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipo.Checked == true)
            {
                btFilter.Visible = true;
                cBTipo.Visible = true;
                cBTipo.Items.Clear();
                for (int i = 0; i < PRODOTTI_IN_MAGAZZINO; i++)
                    cBTipo.Items.Add(prodotti[i].Nome);  }
            else { cBTipo.Visible = false; }
        }

        private void rbFornitore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFornitore.Checked == true)
            {
                btFilter.Visible = true;                cBFornitore.Visible = true;
                cBFornitore.Items.Clear();
                for (int i = 0; i < PRODOTTI_IN_MAGAZZINO; i++)
                    cBFornitore.Items.Add(prodotti[i].Fornitore);
            }
            else { cBFornitore.Visible = false; }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
