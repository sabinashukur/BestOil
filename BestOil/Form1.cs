using System.Media;

namespace BestOil
{
    public partial class Form1 : Form
    {
        List<string> PetrolList = new() { "AI-92", "AI-95", "AI-98" };
        List<double> PriceList = new() { 1, 1.40, 2 };

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbox_Petrol.DataSource = PetrolList;

        }

        private void cbox_Petrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choice = cbox_Petrol.SelectedItem;
            if (choice == PetrolList[0])
                tbox_PetrolPrice.Text = PriceList[0].ToString();
            else if (choice == PetrolList[1])
                tbox_PetrolPrice.Text = PriceList[1].ToString();
            else if (choice == PetrolList[2])
                tbox_PetrolPrice.Text = PriceList[2].ToString();
        }

        private void tbox_Amount_TextChanged(object sender, EventArgs e)
        {
            lbl_TotalPetrolPrice.Text = tbox_Amount.Text;
        }

        private void tbox_Litr_TextChanged(object sender, EventArgs e)
        {
            lbl_TotalPetrolPrice.Text = (Convert.ToDouble(tbox_PetrolPrice.Text) * Convert.ToDouble(tbox_Litr.Text)).ToString();
        }

        private void rdbtn_Price_CheckedChanged(object sender, EventArgs e)
        {
            tbox_Litr.Text =  "";
        }

        private void rdbtn_Litr_CheckedChanged(object sender, EventArgs e)
        {
            tbox_Amount.Text = "";
        }

        private void tbox_Hotdog_TextChanged(object sender, EventArgs e)
        {
            var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Hotdog.Text) * double.Parse(tbox_HotdogPrice.Text));
            if (chckbox_Hotdog.Checked == true)
                lbl_TotalFoodPrice.Text = price.ToString();
        }

        private void tbox_Hamburger_TextChanged(object sender, EventArgs e)
        {
            var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Hamburger.Text) * double.Parse(tbox_HamburgerPrice.Text));
            if (chckbox_Hamburger.Checked == true)
                lbl_TotalFoodPrice.Text = price.ToString();
        }

        private void tbox_FrenchFries_TextChanged(object sender, EventArgs e)
        {
            var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_FrenchFries.Text) * double.Parse(tbox_FrenchFPrice.Text));
            if (chckbox_FrencFries.Checked == true)
                lbl_TotalFoodPrice.Text = price.ToString();
        }

        private void tbox_Cola_TextChanged(object sender, EventArgs e)
        {
            var price = double.Parse(lbl_TotalFoodPrice.Text) + (double.Parse(tbox_Cola.Text) * double.Parse(tbox_ColaPrice.Text));
            if (chckbox_Cola.Checked == true)
                lbl_TotalFoodPrice.Text = price.ToString();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            lbl_TotalPrice.Text=(Convert.ToDouble(lbl_TotalFoodPrice.Text)+Convert.ToDouble(lbl_TotalPetrolPrice.Text)).ToString();
            SoundPlayer simpleSound = new SoundPlayer(Resource1.goodbye);
            simpleSound.Play();
        }
    }
}