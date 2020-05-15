using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Car_shop_Library;


namespace Car_shop_Stefirca
{
    public partial class FormDialogVehicle : Form
    {
        List<Control> controls;
        string vehicle;
        string imgFilePath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\img\\";
        string fileName = "default.png";
        int selectedIndex;
        FormMain formMain;
        private ErrorProviderUtilities erProv = new ErrorProviderUtilities();


        public FormDialogVehicle(FormMain formMain)
        {
            InitializeComponent();
            Control[] aus = { txtBrand, txtModel, txtColor, nmuDisplacement, nmuPower, nmuKmDone, nmuPrice, nmuAirbag };
            controls = new List<Control>(aus);
            this.formMain = formMain;
            vehicle = "AUTO";

            Text = "AGGIUNGI VEICOLO";
            btnAddModify.Text = "AGGIUNGI";
            btnCancel.DialogResult = DialogResult.Cancel;
            cmbVehicleType.Enabled = true;
            cmbVehicleType.SelectedIndex = 0;
            lblSaddleBrand.Location = lblNAirbag.Location;
            txtSaddleBrand.Location = nmuAirbag.Location;
            dtpMatriculation.MaxDate = DateTime.Today;
            dtpMatriculation.Value = DateTime.Today;
            txtSaddleBrand.Visible = lblSaddleBrand.Visible = false;
        }

        public FormDialogVehicle(FormMain formMain, int selectedIndex) : this(formMain)
        {
            Text = "MODIFICA VEICOLO";
            cmbVehicleType.Enabled = false;
            txtBrand.Text = formMain.ListaVeicoli[selectedIndex].Marca;
            txtModel.Text = formMain.ListaVeicoli[selectedIndex].Modello;
            txtColor.Text = formMain.ListaVeicoli[selectedIndex].Colore;
            nmuDisplacement.Value = formMain.ListaVeicoli[selectedIndex].Cilindrata;
            nmuPower.Value = Convert.ToDecimal(formMain.ListaVeicoli[selectedIndex].Potenza);
            dtpMatriculation.Value = formMain.ListaVeicoli[selectedIndex].Matricolazione;
            chkIsUsed.Checked = formMain.ListaVeicoli[selectedIndex].Usato;
            chkIsKmZero.Checked = formMain.ListaVeicoli[selectedIndex].Km0;
            nmuKmDone.Value = formMain.ListaVeicoli[selectedIndex].KmFatti;
            nmuPrice.Value = Convert.ToDecimal(formMain.ListaVeicoli[selectedIndex].Prezzo);
            fileName = formMain.ListaVeicoli[selectedIndex].Img;
            if (formMain.ListaVeicoli[selectedIndex] is Moto)
            {
                cmbVehicleType.SelectedIndex = 1;
                txtSaddleBrand.Text = (formMain.ListaVeicoli[selectedIndex] as Moto).Sella;
            }
            else
                nmuAirbag.Value = (formMain.ListaVeicoli[selectedIndex] as Auto).NumAirbag;
            btnAddModify.Text = "MODIFICA";
            this.selectedIndex = selectedIndex;
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            bool correct = inputControl();
            if (btnAddModify.Text == "AGGIUNGI")
            {
                if (correct)
                {

                    if (vehicle == "AUTO")
                    {
                        formMain.ListaVeicoli.Add(new Auto(txtBrand.Text, txtModel.Text, txtColor.Text,
                                                           Convert.ToInt32(nmuDisplacement.Value),
                                                           Convert.ToDouble(nmuPower.Value),
                                                           dtpMatriculation.Value, chkIsUsed.Checked,
                                                           chkIsKmZero.Checked, Convert.ToInt32(nmuKmDone.Value),
                                                           Convert.ToInt32(nmuPrice.Value), fileName,
                                                           Convert.ToInt32(nmuAirbag.Value)));
                    }
                    else
                    {
                        formMain.ListaVeicoli.Add(new Moto(txtBrand.Text, txtModel.Text, txtColor.Text,
                                                           Convert.ToInt32(nmuDisplacement.Value),
                                                           Convert.ToDouble(nmuPower.Value),
                                                           dtpMatriculation.Value, chkIsUsed.Checked,
                                                           chkIsKmZero.Checked, Convert.ToInt32(nmuKmDone.Value),
                                                           Convert.ToInt32(nmuPrice.Value), fileName,
                                                           txtSaddleBrand.Text));
                    }
                    Close();
                }

            }
            else
            {
                if (correct && MessageBox.Show("Operazione non reversibile, vuoi procedere?", "Vuoi modificare l'elemento selezionato?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    formMain.ListaVeicoli[selectedIndex].Marca = txtBrand.Text;
                    formMain.ListaVeicoli[selectedIndex].Modello = txtModel.Text;
                    formMain.ListaVeicoli[selectedIndex].Colore = txtColor.Text;
                    formMain.ListaVeicoli[selectedIndex].Cilindrata= Convert.ToInt32(nmuDisplacement.Value);
                    formMain.ListaVeicoli[selectedIndex].Potenza = Convert.ToDouble(nmuPower.Value);
                    formMain.ListaVeicoli[selectedIndex].Matricolazione= dtpMatriculation.Value;
                    formMain.ListaVeicoli[selectedIndex].Usato = chkIsUsed.Checked;
                    formMain.ListaVeicoli[selectedIndex].Km0 = chkIsKmZero.Checked;
                    formMain.ListaVeicoli[selectedIndex].KmFatti = Convert.ToInt32(nmuKmDone.Value);
                    formMain.ListaVeicoli[selectedIndex].Prezzo = Convert.ToInt32(nmuPrice.Value);
                    formMain.ListaVeicoli[selectedIndex].Img = fileName;
                    if (formMain.ListaVeicoli[selectedIndex] is Moto)
                        (formMain.ListaVeicoli[selectedIndex] as Moto).Sella = txtSaddleBrand.Text;
                    else
                        (formMain.ListaVeicoli[selectedIndex] as Auto).NumAirbag = Convert.ToInt32(nmuAirbag.Value);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void tlbUpload_Click(object sender, EventArgs e)
        {
            if (inputControl() && openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                string extension = filepath.Split('.').Last();
                fileName = $"{txtBrand.Text}-{txtColor.Text}-{txtModel.Text}.{extension}";
                string newImgFilepath = $"{imgFilePath}{fileName}";
                if (File.Exists(newImgFilepath)) File.Delete(newImgFilepath);
                File.Copy(filepath, newImgFilepath);
            }
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle = cmbVehicleType.Text;
            if (vehicle == "AUTO") setSpecialInput(true, false, nmuAirbag);
            else setSpecialInput(false, true, txtSaddleBrand);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            erProv.resetError(error, sender as Control);
        }


        private void setSpecialInput(bool auto, bool moto, Control control)
        {
            nmuAirbag.Visible = lblNAirbag.Visible = auto;
            txtSaddleBrand.Visible = lblSaddleBrand.Visible = moto;
            controls.RemoveAt(controls.Count - 1);
            controls.Add(control);
        }

        private bool inputControl()
        {
            bool correct = true;
            for (int i = 0; i < controls.Count && correct; i++)
            {
                correct = controls[i].Text != string.Empty;
                if (!correct)
                    erProv.setError(error, controls[i], "Devi completare tutti i campi richiesti!");
            }
            return correct;
        }

    }
}