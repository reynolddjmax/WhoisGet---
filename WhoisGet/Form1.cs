using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WhoisGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Log.rt = this.richTextBox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            



            breakApp = false;
            this.dataGridView1.Rows.Clear();

            //DLL.ExcelClass EC = new DLL.ExcelClass();

            //EC.XlsCreat(Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss"), true);

            int Row = 1;
            foreach (var item in this.richTextBox1.Lines)
            {
                //string strA1 = WhoIsQuery.WhoIs(item, "tvwhois.verisign-grs.com");
                //string strB1 = WhoIsQuery.WhoIs(item, "whois.internic.net");

                Log.clear();
                if (breakApp)
                {
                    break;
                }

                if (item.IndexOf(".") == -1)
                {
                    this.dataGridView1.Rows.Add(item, "域名错误");
                    continue;
                }
                this.label1.Text = Row.ToString() + "   " + item;
                Application.DoEvents();


                string strA = "";
                string strB = "";
                string strC = "";
                string strD = "";
                string str;



                strA = WhoIsQuery.WhoIs(item);



                if (checkVaule(GetVaule(strA)))
                {



                    strB = WhoIsQuery.WhoIs(item, "whois.internic.net") + "\r\n" + strA;




                    if (checkVaule(GetVaule(strB)))
                    {

                        string whoisserver = GetStr(strB, "Registrar WHOIS Server:", "Whois Server:", "WHOIS Server:");

                        if (whoisserver != "")
                        {

                            strC = WhoIsQuery.WhoIs(item, whoisserver);
                        }


                        strC = strC + "\r\n" + strB;


                        if (checkVaule(GetVaule(strC)))
                        {



                            strD = WhoIsQuery.WhoIs(item, "whois.PublicDomainRegistry.com") + "\r\n" + strC;
 
                        }


                    }

                }



                str = GetMaxLengh(strA, strB, strC, strD);








                string[] vaule = GetVaule(str);
                this.dataGridView1.Rows.Add(item
                    , vaule[0]
                    , vaule[1]
                    , vaule[2]
                    , vaule[3]
                    , vaule[4]
                    , vaule[5]
                    , vaule[6]
                    , vaule[7]);


                //EC.WriteVaule(1, 1, Row, item);

                ////注册商
                //EC.WriteVaule(1, 2, Row, GetStr(str,"Registrar:"));

                ////联系人
                //EC.WriteVaule(1, 3, Row, GetStr(str, "Registrant Name:"));

                ////联系方式
                //EC.WriteVaule(1, 4, Row, GetStr(str, "Registrant Email:"));

                ////更新日期
                //EC.WriteVaule(1, 5, Row, GetStr(str, "Updated Date:"));

                ////注册日期
                //EC.WriteVaule(1, 6, Row, GetStr(str, "Creation Date:"));

                ////过期日期
                //EC.WriteVaule(1, 7, Row, GetStr(str, "Expiration Date:", "Registrar Registration Expiration Date:"));

                ////Whois
                //EC.WriteVaule(1, 8, Row, GetStr(str, "Whois Server:" ,"Registrar WHOIS Server:"));

                ////DNS
                //EC.WriteVaule(1, 9, Row, GetStr(str, "Name Server:"));


                //EC.XlsSave();
                Row++;
                Log.clear();
                
            }

            this.label1.Text = "Done";


        }

        string GetMaxLengh(params string[] Vaule)
        {
            string re = "";


            foreach (var item in Vaule)
            {
                if (item.Length > re.Length)
                {
                    re = item;
                }
            }

            return re;

        }




        string[] GetVaule(string str)
        {
            string[] vaule = new string[8];


            vaule[0] = GetStr(str, "Sponsoring Registrar:" , "Registrar:");
            vaule[1] = GetStr(str, "Registrant Name:", "Registrant:");
            vaule[2] = GetStr(str, "Registrant Email:", "Registrant Contact Email:");
            vaule[3] = GetStr(str, "Updated Date:");
            vaule[4] = GetStr(str, "Registration Time:" , "Creation Date:");
            vaule[5] = GetStr(str, "Expiration Time:", "Registrar Registration Expiration Date:", "Expiration Date:");
            vaule[6] = GetStr(str, "Registrar WHOIS Server:", "Whois Server:", "WHOIS Server:");
            vaule[7] = GetStr(str, "Name Server:");

            return vaule;
        }


        bool checkVaule(params string[] vaule)
        {
            foreach (var item in vaule)
            {
                if (item == "")
                {
                    return true;
                }
            }


            return false;
        }


        string GetStr(string Str , params string[] Vaule)
        {
            string[] ary = Str.Split(Environment.NewLine.ToCharArray());

            foreach (string item in ary)
            {


                foreach (var item2 in Vaule)
                {
                    if (item.IndexOf(item2) != -1)
                    {
                        string vaule = item.Replace(item2, "");



                        vaule = vaule.Replace(" ", "");
                        vaule = vaule.Replace("<br/>", "");


                        if (vaule == "")
                        {
                            continue;
                        }


                        return vaule;
                    }
                }



            }

            return "";
        }

        bool breakApp = false;

        private void button2_Click(object sender, EventArgs e)
        {
            breakApp = true;
        }
    }
}
