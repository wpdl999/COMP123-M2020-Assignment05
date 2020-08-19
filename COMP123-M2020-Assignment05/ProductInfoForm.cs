using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Author's name : Wooram Moon
    Author's student Number : 301098673
    Date last Modified : 
    Program description
    1st Revision : Aug 10th
    2nd Revision : Aug 12th
    3rd Revision : Aug 13th
    4th Revision : Aug 15th
    5th Revision : Aug 18th
 */


namespace COMP123_M2020_Assignment05
{
    public partial class ProductInfoForm : Form
    {
        public List<Products> listproducts { get; set; }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            Program.selectForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the save file dialog
            ProductListsaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            // display the savefiledialog and save the results in the saveFileDialogResult object
            var saveFileDialogResult = ProductListsaveFileDialog.ShowDialog();

            if (saveFileDialogResult != DialogResult.Cancel)
            {
                // create new stream
                StreamWriter streamWriter = new StreamWriter(ProductListsaveFileDialog.FileName);

                // write to the file

           

               
                    /*streamWriter.WriteLine(contact.FirstName);
                    streamWriter.WriteLine(contact.LastName);
                    streamWriter.WriteLine(contact.EmailAddress);
                    streamWriter.WriteLine(contact.ContactNumber);*/
                

                // clean up
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            var saveFileDialogResult = saveFileDialog.ShowDialog();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductTextBox.Text = Program.selectProducts.productID.ToString();
            ConditionTextBox.Text = Program.selectProducts.condition;
            CostTextBox.Text = Program.selectProducts.cost.ToString();
            PlatFormTextBox.Text = Program.selectProducts.platform;
            OsTextBox.Text = Program.selectProducts.OS;
            ManuFacTextBox.Text = Program.selectProducts.manufacturer;
            ModelTextBox.Text = Program.selectProducts.model;
            MemoryTextBox.Text = Program.selectProducts.RAM_size;
            LCDTextBox.Text = Program.selectProducts.screensize;
            HDDTextBox.Text = Program.selectProducts.HDD_size;
            CPUBTextBox.Text = Program.selectProducts.CPU_brand;
            CPUNumTextBox.Text = Program.selectProducts.CPU_number;
            GPUTTextBox.Text = Program.selectProducts.GPU_Type;
            CPUTTextBox.Text = Program.selectProducts.CPU_type;
            CPUspeedTextBox.Text = Program.selectProducts.CPU_speed;
            WebCamTextBox.Text = Program.selectProducts.webcam;
        }
        private void ResetForm()
        {
            ProductTextBox.Clear();
            ConditionTextBox.Clear();
            CostTextBox.Clear();
            PlatFormTextBox.Clear();
            OsTextBox.Clear();
            ManuFacTextBox.Clear();
            ModelTextBox.Clear();
            MemoryTextBox.Clear();
            LCDTextBox.Clear();
            HDDTextBox.Clear();
            CPUBTextBox.Clear();
            CPUNumTextBox.Clear();
            GPUTTextBox.Clear();
            CPUTTextBox.Clear();
            CPUspeedTextBox.Clear();
            WebCamTextBox.Clear();

        }


        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductTextBox.Text = Program.selectProducts.productID.ToString();
            ConditionTextBox.Text = Program.selectProducts.condition;
            CostTextBox.Text = Program.selectProducts.cost.ToString();
            PlatFormTextBox.Text = Program.selectProducts.platform;
            OsTextBox.Text = Program.selectProducts.OS;
            ManuFacTextBox.Text = Program.selectProducts.manufacturer;
            ModelTextBox.Text = Program.selectProducts.model;
            MemoryTextBox.Text = Program.selectProducts.RAM_size;
            LCDTextBox.Text = Program.selectProducts.screensize;
            HDDTextBox.Text = Program.selectProducts.HDD_size;
            CPUBTextBox.Text = Program.selectProducts.CPU_brand;
            CPUNumTextBox.Text = Program.selectProducts.CPU_number;
            GPUTTextBox.Text = Program.selectProducts.GPU_Type;
            CPUTTextBox.Text = Program.selectProducts.CPU_type;
            CPUspeedTextBox.Text = Program.selectProducts.CPU_speed;
            WebCamTextBox.Text = Program.selectProducts.webcam;
        }
    }
}
