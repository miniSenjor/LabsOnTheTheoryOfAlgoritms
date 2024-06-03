using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //Простая одинарная
                case 0:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Блочная одинарная
                case 1:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Маршрутная перестановка
                case 2:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = false;
                    txtSlogan.Visible = false;
                    lblSquareLength.Visible = true;
                    nUDSquareLength.Visible = true;
                    break;
                //Вертикальная перестановка
                case 3:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Перекрёсток
                case 4:
                    chkClockwise.Visible = true;
                    lblSlogan.Visible = false;
                    txtSlogan.Visible = false;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //С использованием треугольников
                case 5:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Поворотная решётка
                case 6:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Магический квадрат
                case 7:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                //Двойная перестановка
                case 8:
                    chkClockwise.Visible = false;
                    lblSlogan.Visible = true;
                    txtSlogan.Visible = true;
                    lblSquareLength.Visible = false;
                    nUDSquareLength.Visible = false;
                    break;
                default:
                    selectedCipher = "";
                    break;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            PermutationCiphers pc = new PermutationCiphers();
            if (selectedCipher == "")
            {
                MessageBox.Show("Не выбран шифр");
                return;
            }

            bool isSuccess = false;
            string result = "";
            switch (selectedCipher)
            {
                case "Простая одинарная":
                    isSuccess = pc.SimpleSingle(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Блочная одинарная":
                    isSuccess = pc.BlockSingle(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Маршрутная перестановка":
                    isSuccess = pc.Route(txtInput.Text, (int)nUDSquareLength.Value, out result);
                    break;
                case "Вертикальная перестановка":
                    //isSuccess = pc.Vertical(txtInput.Text, txtSlogan.Text, out result);
                    break;
                case "Перекрёсток":
                    isSuccess = pc.Crossroad(txtInput.Text, chkClockwise.Checked, (int)nUDSquareLength.Value, out result);
                    break;
                case "Поворотная решётка":
                    //isSuccess = pc.RotatingGrille(txtInput.Text, out result);
                    break;
                case "С использованием треугольников":
                    //isSuccess = pc.UsingTriangles(txtInput.Text, , out result);
                    break;
                case "Магический квадрат":
                    //isSuccess = pc.MagicSquare(txtInput.Text, , out result);
                    break;
                case "Двойная перестановка":
                    isSuccess = pc.DoublePermutation(txtInput.Text, , out result);
                    break;
                default:
                    isSuccess = false;
                    result = "Ошибка";
                    return;
            }
            if (isSuccess)
                txtOutput.Text = result;
            else
                MessageBox.Show(result);
            


        }
    }
}
