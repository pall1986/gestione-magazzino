namespace gestione_magazzino
{
    public partial class Form1 : Form
    {
        struct Prodotto
        {
            public int Id;
            public string Nome;
            public string Categoria;
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
            if(tBTipo.Text == "" || tBPrezzo.Text == "" || tBFornitore.Text == "" || tBQuantità.Text == "")
            {
                MessageBox.Show("Compila tutti i campi");
            }
            else
            {
                prodotti[PRODOTTI_IN_MAGAZZINO].Id = PRODOTTI_IN_MAGAZZINO + 1;
                prodotti[PRODOTTI_IN_MAGAZZINO].Nome = tBTipo.Text;
                prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo = double.Parse(tBPrezzo.Text);
                prodotti[PRODOTTI_IN_MAGAZZINO].Categoria = tBFornitore.Text;
                prodotti[PRODOTTI_IN_MAGAZZINO].Quantita = int.Parse(tBQuantità.Text);
                listBox1.Items.Add(prodotti[PRODOTTI_IN_MAGAZZINO].Nome + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Prezzo + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Categoria + " " + prodotti[PRODOTTI_IN_MAGAZZINO].Quantita);
            }
        }
    }
}
