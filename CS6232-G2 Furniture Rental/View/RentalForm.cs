using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }
    }
}
