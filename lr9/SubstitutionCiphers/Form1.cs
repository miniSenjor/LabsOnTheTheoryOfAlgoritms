using System;
using System.Windows.Forms;

namespace PermutationCiphers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string selectedCipher = "";
        private void cbCiphers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCipher = cbCiphers.Text;
            switch (cbCiphers.SelectedIndex)
            {
                //Цезарь
                case 0:
                    lblSlogan.Visible = false;
                    txtSlogan.Visible = false;
                    lblShift.Visible = true;
                    nUDShift.Visible = true;
                    break;
                //Атбаш
                case 1:
                    lblSlogan.Visible = false;
                    txtSlogan.Visible = false;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Лозунговый
                case 2:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Полибиански квадрат
                case 3:
                    lblSlogan.Visible = false;
                    txtSlogan.Visible = false;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Трисемуса
                case 4:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Playfair
                case 5:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Виженера
                case 6:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Хилла
                case 7:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Вариантный
                case 8:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                //Совмещённый
                case 9:
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblShift.Visible = false;
                    nUDShift.Visible = false;
                    break;
                default:
                    selectedCipher = "";
                break;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            SubstitutionCiphers sc = new SubstitutionCiphers();
            if (selectedCipher == "")
            {
                MessageBox.Show("Не выбран шифр");
                return;
            }
            string result = "";
            switch(selectedCipher)
            {
                case "Цезаря":
                    sc.Caesar(txtInput.Text, Convert.ToInt32(nUDShift.Value), checkBoxEncrypt.Checked, out result);
                    break;
                case "Атбаш":
                    sc.Atbash(txtInput.Text, out result);
                    break;
                case "Лозунговый":
                    sc.Slogan(txtInput.Text, txtSlogan.Text, checkBoxEncrypt.Checked, out result);
                    break;
                case "Полибианский квадрат":
                    sc.PolybianSquare(txtInput.Text, checkBoxEncrypt.Checked, out result);
                    break;
                case "Трисемуса":
                    sc.Trisemus(txtInput.Text, txtSlogan.Text, checkBoxEncrypt.Checked, out result);
                    break;
                case "Playfair":
                    sc.Playfair(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Виженера":
                    sc.Vigener(txtInput.Text, txtSlogan.Text, checkBoxEncrypt.Checked, out result);
                    break;
                case "Хилла":
                    sc.Hill(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Вариантный":
                    sc.Variant(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Совмещённый":
                    sc.Сombined(txtInput.Text, txtSlogan.Text, out result);
                    break;
                default:
                    MessageBox.Show("Ошибка");
                return;
            }
            txtOutput.Text = result;

        }
    }
}
