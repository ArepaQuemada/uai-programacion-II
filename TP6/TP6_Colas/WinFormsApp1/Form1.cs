namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Cola colaHomres = new Cola();
        Cola colaMujeres = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncolar_Click(object sender, EventArgs e)
        {
            string nadador = textNadadores.Text;
            char caracter = nadador[0];
            if (esNadadorValido(caracter))
            {
                Nodo nodo = new Nodo();
                nodo.Nombre = nadador;
                if (caracter == 'm')
                {
                    colaHomres.Encolar(nodo);
                }
                else
                {
                    colaMujeres.Encolar(nodo);
                }
            }
            actualizarListas();
        }

        private void actualizarListas()
        {
            listHombres.Items.Clear();
            listMujeres.Items.Clear();
            agregarItemGenerico(colaHomres.inicio, listHombres);
            agregarItemGenerico(colaMujeres.inicio, listMujeres);

        }

        private void agregarItemGenerico(Nodo nodo, ListBox lista)
        {
            if (nodo != null)
            {
                lista.Items.Add(nodo.Nombre);
                agregarItemGenerico(nodo.siguiente, lista);
            }
        }

        private bool esNadadorValido(char caracter)
        {
            return caracter == 'm' || caracter == 'f';
        }

        private void btnDesencolarFemenino_Click(object sender, EventArgs e)
        {
            colaMujeres.Desencolar();
            actualizarListas();
        }

        private void btnDesencolarMasculino_Click(object sender, EventArgs e)
        {
            colaHomres.Desencolar();
            actualizarListas();
        }
    }
}