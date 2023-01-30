using System.Windows.Forms;
using System;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //預設拉條
            comboBox2.SelectedIndex = 0; //預設改缸徑
            radioButton1.Checked = true; //預設計算排量

            foreach (Control c in this.Controls) //所有textbox皆使用遞迴foreach套用KeyPress原則
            {
                if (c is TextBox)
                {
                    c.KeyPress += new KeyPressEventHandler(KeyPress);
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e) //快速選擇，目前熱門白牌改裝車種都在這
        {
            domainUpDown1.SelectedIndex = 8;
            if (cygnus.Checked)
            {
                bore.Text = "52.4";   //缸徑
                length.Text = "57.9"; //行程
                cap.Text = "124.86";  //容積
            }
            else if (gryphus.Checked)
            {
                bore.Text = "52";
                length.Text = "58.7";
                cap.Text = "124.66";
            }
            else if (smax.Checked)
            {
                bore.Text = "58";
                length.Text = "58.7";
                cap.Text = "155.09";
            }
            else if (jets.Checked)
            {
                bore.Text = "54";
                length.Text = "54.4";
                cap.Text = "124.59";
            }
            else if (sl.Checked)
            {
                bore.Text = "53";
                length.Text = "56.5";
                cap.Text = "124.65";
            }
            else if (drg.Checked)
            {
                bore.Text = "59";
                length.Text = "57.8";
                cap.Text = "158.02";
            }
            else if (rcs125.Checked)
            {
                bore.Text = "54";
                length.Text = "54.5";
                cap.Text = "124.82";
            }
            else if (rcs150.Checked)
            {
                bore.Text = "59";
                length.Text = "54.5";
                cap.Text = "149.00";
            }
            else if (krv.Checked)
            {
                bore.Text = "62";
                length.Text = "58";
                cap.Text = "175.11";
            }
            TextChanged(sender, e); //觸發TextChanged事件
        }

        private void KeyPress(object sender, KeyPressEventArgs e) //限制textbox僅能輸入數字、小數點僅一位且不能為開頭、負數僅一位且僅限開頭
        {
            TextBox tb = sender as TextBox;

            //Check if the key pressed is a number or a backspace, negative sign or dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && tb.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Check if there's already a negative sign or decimal point in the text
            if ((e.KeyChar == '-' && tb.SelectionStart != 0) || (e.KeyChar == '.' && tb.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // check if the first char is not negative sign
            if (tb.Text.Length == 0 && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
        
        private void TextChanged(object sender, EventArgs e) //資料自動帶入並即時更新，計算排量
        {
            //將輸入的string轉為double
            double.TryParse(bore.Text, out double boref);               //缸徑
            double.TryParse(length.Text, out double lengthf);           //行程
            double.TryParse(cap.Text, out double capf);                 //容積
            double.TryParse(newbore.Text, out double newboref);         //新缸徑
            double.TryParse(addlength.Text, out double addlengthf);     //加長行程
            double.TryParse(newcap.Text, out double newcapf);           //新容積
            int.TryParse(domainUpDown1.Text, out int domainUpDown1i);   //缸數

            double math = 0.0007854; //數學公式
            /*
             * 0.7854 是一個數值，用於計算圓柱體體積的公式中。
             * 具體來說，它是以四位小數顯示的圓周率（π）的值。
             * 圓柱體體積的公式是：V = πr^2h
             * 其中 V 是體積，r 是圓柱體底面半徑，h 是圓柱體高，π 是圓周率常數。
             * 在這個公式中，0.7854 可以用作 π 的近似值，讓您在已知半徑和高度時可以計算圓柱體的體積。
             * 但又因單位缸徑行程皆為毫米，故需除以1000方能計算出cc數
             */

            double newborefset = 0; //新缸徑(選擇單位用)
            double addlengthfset = 0; //行程(選擇單位用)

            multiplier.Text = (newcapf / capf).ToString("0.00");    //計算倍率
            multiplierCC.Text = (newcapf - capf).ToString("0.00");  //計算cc數
            percent.Text = ((newcapf - capf) / capf * 100).ToString("0.00"); //計算百分比

            if (comboBox2.SelectedIndex == 0) //選擇缸徑
            {
                label11.Text = "mm";
                newborefset = newboref;
            }
            else if (comboBox2.SelectedIndex == 1) //選擇搪缸
            {
                label11.Text = "條";
                newborefset = boref + (newboref * 0.01);
            }

            if (comboBox1.SelectedIndex == 0) //選擇拉條
            {
                label12.Text = "條";
                addlengthfset = lengthf + (addlengthf * 0.01);
            }
            else if (comboBox1.SelectedIndex == 1) //選擇總行程
            {
                label12.Text = "mm";
                addlengthfset = addlengthf;
            }

            double boref2 = boref * boref; //缸徑平方
            double newboref2 = newborefset * newborefset; //新缸徑平方

            if (newbore.Text != "")  //僅改缸未拉條
                newcap.Text = (newboref2 * addlengthfset * math * domainUpDown1i).ToString("0.00");
            else if (addlength.Text != "") //僅拉條未改缸
                newcap.Text = (boref2 * addlengthfset * math * domainUpDown1i).ToString("0.00");

            if (radioButton1.Checked) //選擇計算排量
            {
                cap.Text = (boref2 * lengthf * math * domainUpDown1i).ToString("0.00"); //計算容積
            }
            else if (radioButton2.Checked) //選擇計算缸徑
            {
                bore.Text = (Math.Sqrt(capf / (lengthf * math * domainUpDown1i))).ToString("0.00"); //計算缸徑
            }
            else if (radioButton3.Checked)  //選擇計算行程
            {
                length.Text = (capf / (boref2 * math * domainUpDown1i)).ToString("0.00"); //計算行程
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            //清除所有狀態
            bore.Text = "";
            length.Text = "";
            cap.Text = "";
            newbore.Text = "";
            addlength.Text = "";
            newcap.Text = "";
            multiplier.Text = "";
            multiplierCC.Text = "";
            percent.Text = "";
            domainUpDown1.SelectedIndex = 8;

            
            foreach (var radioButton in groupBox1.Controls.OfType<RadioButton>()) //使用foreach遞迴把groupbox1的radioButton取消勾選
            {
                radioButton.Checked = false;
            }

            if (radioButton1.Checked) //選擇計算排量
            {
                bore.ReadOnly = false;
                length.ReadOnly = false;
                cap.ReadOnly = true;
            }
            else if (radioButton2.Checked) //選擇計算缸徑
            {
                bore.ReadOnly = true;
                length.ReadOnly = false;
                cap.ReadOnly = false;
            }
            else if (radioButton3.Checked)  //選擇計算行程
            {
                bore.ReadOnly = false;
                length.ReadOnly = true;
                cap.ReadOnly = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Use no more than one assignment when you test this code.
            //string target = "C:\\Program Files\\Microsoft Visual Studio\\INSTALL.HTM";
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://github.com/timliucode");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}