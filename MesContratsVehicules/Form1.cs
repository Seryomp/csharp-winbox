using mesContrats;
namespace MesContratsVehicules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValiderCt_Click(object sender, EventArgs e)
        {

        }

        private void txtPrestation_TextChanged(object sender, EventArgs e)
        {

        }
        Categorie[] tabCategorie = new Categorie[3];
        int i = 0;

        private void btnValiderC_Click(object sender, EventArgs e)
        {
            tabCategorie[i] = new
                Categorie(txtCategorie.Text, txtDescription.Text, Convert.ToDouble(txtTarifJour.Text), Convert.ToDouble(txtCaution.Text));
            i++;
            if (i == tabCategorie.Length)
            { 
            MessageBox.Show("Tableau plein");
            btnValiderC.Enabled = false;
            }
            txtCategorie.Clear();
            txtDescription.Clear();
            txtTarifJour.Clear();
            txtCaution.Clear();
        }

        private void txtCaution_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarifJour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnnee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImmat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarque_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnValiderV_Click(object sender, EventArgs e)
        {
            Categorie categorie = new Categorie();
            i = 0;
            foreach (Categorie cat)
        }

        private void txtNumContrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateContrat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatePrise_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateRetour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKmPrise_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKmRetour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehicule_TextChanged(object sender, EventArgs e)
        {

        }
    }
}