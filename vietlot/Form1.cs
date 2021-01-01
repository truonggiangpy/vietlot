using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vietlot
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[] xoso = new int[7];
        int randomone(int rand)
        {
            var t = true;
            while (t)
            {
                rand = random.Next(0, 65);
                int i = 0;
                for (i = 0; i < xoso.Length; i++)
                {
                    if (rand == xoso[i])
                    {
                        break;
                    }
                }
                if (i < xoso.Length - 1) t = true;
                else t = false;
            }

            return rand;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                int rand = 0;
                var tam = randomone(rand);
                xoso[i] = tam;
            }

            for (var i = 0; i < xoso.Length - 2; i++)
            { // buble sort
                for (var j = xoso.Length - 2; j > 0; j--)
                {
                    if (xoso[j] < xoso[j - 1])
                    {
                        int tam = xoso[j];
                        xoso[j] = xoso[j - 1];
                        xoso[j - 1] = tam;
                    }
                }
            }

            StringBuilder chuoi = new StringBuilder();
            String chuoixoso;
            for (int i = 0; i <= 5; i++)
            {
                var tamxo = xoso[i];
                if (tamxo < 10)
                {

                    chuoixoso = '0' + tamxo.ToString();
                }
                else
                {
                    chuoixoso = tamxo.ToString();
                }
                chuoi.Append(chuoixoso.ToString() + ' ');
            }
            textquayso.Text = chuoi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var araay = arraymuaso.Text;
            String[] arrListkeySearch = araay.Split(',');

            int v = 0;
            int check = 0;
            while (v < 6) // mỗi 1 phần từ trong mảng nhập từ người dùng sẽ so sánh với tất cả phần từ trong mảng random của sổ số
            {
                int f = 0;
                while (f < 6)
                {
                    try
                    {
                        if (Convert.ToInt32(arrListkeySearch[v]) == xoso[f])
                        {
                            check = check + 1;
                            break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(" bạn phải nhập đủ 6 cặp số bạn mua.");
                        f = 10;
                        v = 10;
                    }
                    f++;
                }
                v++;
            }
            if (check == 6) {
                ketqua.Text = "Chúc Mừng bạn đã Trúng Giải Jackpork1";
            }
            else if (check == 5)
            {
                jackbot2.Visible = true;
                button3.Visible = true;
                ketqua.Text = "Chúc Mừng bạn đã Trúng Giải 1";
            }
            else if (check == 4)
            {
                ketqua.Text = "Chúc Mừng bạn đã Trúng Giải 2";
            }
            else if(check == 3)
            {
                ketqua.Text = "Chúc Mừng bạn đã Trúng Giải 3";
            }
            else {
                ketqua.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xoso[6] = randomone(0);
            StringBuilder chuoi = new StringBuilder();
            String chuoixoso;
            for (int i = 0; i <= 6; i++)
            {
                var tamxo = xoso[i];
                if (tamxo < 10)
                {

                    chuoixoso = '0' + tamxo.ToString();
                }
                else
                {
                    chuoixoso = tamxo.ToString();
                }
                if(i == 6)
                {
                    chuoi.Append("| " + chuoixoso.ToString() + ' ');
                }
                else {
                    chuoi.Append(chuoixoso.ToString() + ' ');
                }
                
            }
            textquayso.Text = chuoi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var araay = arraymuaso.Text;
            String[] arrListkeySearch = araay.Split(',');

            if (Convert.ToInt32(arrListkeySearch[5]) == xoso[6])
            {
                ketqua.Text = "Chúc Mừng bạn đã Trúng Giải jackbot2";
            } else
            {
                ketqua.Text = "sorry bạn chỉ trúng giải nhất";
            }
        }
    }
}
