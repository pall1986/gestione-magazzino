namespace gestione_magazzino
{
    public partial class Form1 : Form
    {
        string percorso_database = "magazzino.txt";
        string riga = "";
        StreamReader sr;
        StreamWriter sw;
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
            if (!File.Exists(percorso_database))//Se il file non esiste disabilito il pulsante Inserisci
            {
                btnInserisci.Enabled = true;
            }
            else //Altrimenti abilito il pulsante Inserisci
                btnInserisci.Enabled = false;
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
                    cBTipo.Items.Add(prodotti[i].Nome);
            }
            else { cBTipo.Visible = false; }
        }

        private void rbFornitore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFornitore.Checked == true)
            {
                btFilter.Visible = true; cBFornitore.Visible = true;
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

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists(percorso_database))
            {
                MessageBox.Show("Nessun file presente! Inserisci i dati e poi premi Salva FIle");
            }
            else
            {
                //apri il file in sola lettura
                sr = new StreamReader(percorso_database);
                //Leggi il file riga per riga
                //per ogni riga dividi la stringa in base al delimitatore ';'
                //e memorizza i dati nei campi della struct Prodotto
                //e aggiungi il prodotto alla listbox
                //e incrementa il contatore PRODOTTI_IN_MAGAZZINO


                PRODOTTI_IN_MAGAZZINO = 0;
                listBox1.Items.Clear();
                while ((riga = sr.ReadLine()) != null)
                {
                    string[] campi = riga.Split(';');
                    if (campi.Length >= 4)
                    {
                        prodotti[PRODOTTI_IN_MAGAZZINO].Id = PRODOTTI_IN_MAGAZZINO + 1;
                        prodotti[PRODOTTI_IN_MAGAZZINO].Nome = campi[0];
                        prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo = double.Parse(campi[1]);
                        prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore = campi[2];
                        prodotti[PRODOTTI_IN_MAGAZZINO].Quantita = int.Parse(campi[3]);
                        listBox1.Items.Add(prodotti[PRODOTTI_IN_MAGAZZINO].Nome + " "  + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Fornitore + " "+ prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo + " "+ + prodotti[PRODOTTI_IN_MAGAZZINO].Quantita);
                        PRODOTTI_IN_MAGAZZINO++;
                    }
                }
                sr.Close();
                btnInserisci.Enabled = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            riga = "";
            sw=new StreamWriter(percorso_database, false);
            for (int i = 0; i < PRODOTTI_IN_MAGAZZINO; i++)
            {
                riga=riga+prodotti[i].Nome+";"+prodotti[i].Prezzo+";"+prodotti[i].Fornitore+";"+prodotti[i].Quantita;
                sw.WriteLine(riga);
                riga = "";
            }
            sw.Close();
            MessageBox.Show("File salvato correttamente!");
        }
    }
}
