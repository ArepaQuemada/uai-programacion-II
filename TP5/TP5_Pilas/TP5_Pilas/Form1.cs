namespace TP5_Pilas
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo();
            nodo.nombre = txtNumber.Text;
            pila.apilar(nodo);
            addToLista();
        }
        private void addToLista()
        {
            listNumbers.Items.Clear();
            agregar(pila.tope);

        }

        private void agregar(Nodo nodo)
        {
            if (nodo != null)
            {
                listNumbers.Items.Add(nodo.nombre);
                agregar(nodo.siguiente);
            }
        }
    }
}