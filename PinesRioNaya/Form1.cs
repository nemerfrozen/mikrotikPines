using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinesRioNaya
{
    public partial class Form1 : Form
    {
        public string ip = "186.147.237.13";
        public int port = 8729; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            mikrotik mikrotik = new mikrotik(ip,port);

            consola.Items.Add("conectandose a:"+ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else {
                consola.Items.Add("coneccion establecida");
            }
            // mikrotik.Send("/system/identity/getall");
            // mikrotik.Send(".tag=sss", true);
          
             mikrotik.Send("/ip/hotspot/user/getall",true);
           // consola.Items.Add("/ip/hotspot/user/getall");

            //mikrotik.Send("=name=999");
            //mikrotik.Send("=password=999");
            //mikrotik.Send("=profile=default");

            List<string> source = mikrotik.Read();
                List<users> listado = new List<users>();

            foreach (var item in source)
            {
                String[] c = item.Split('=');
                try
                {
                    users user = new users(c[6].ToString(),c[8].ToString(),c[10].ToString(),c[12].ToString(),c[24].ToString());
                    listado.Add(user);
                }
                catch (Exception)
                {

                    
                }
                
            }

            

            dataGridView1.DataSource = listado;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string RowType = row.Cells[4].Value.ToString();

                if (RowType == "true")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (RowType == "flase")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            consola.Items.Add("Listado Actualizado");



            // MessageBox.Show("Creado usuario");

            mikrotik.Close();





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_1hora_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip,port);

            consola.Items.Add("conectandose a: "+ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras ="1h1m"+ R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name="+letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=1h");
            mikrotik.Send("=profile=default",true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = "12h1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=12h");
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = "24h1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=24h");
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: "+ letras);
            mikrotik.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = "1w1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=1wh");
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = "2w1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=2w");
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = "30d1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime=30d");
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mikrotik mikrotik = new mikrotik(ip, port);

            consola.Items.Add("conectandose a: " + ip);
            if (!mikrotik.Login("jesus", "j3sus1"))
            {
                MessageBox.Show("no conecto");
                mikrotik.Close();
                return;
            }
            else
            {
                consola.Items.Add("coneccion establecida");
            }

            Ramdom R = new Ramdom();
            string letras = txt_tiempo.Text+"1m" + R.combinar();

            consola.Items.Add("Crear pin: " + letras);

            mikrotik.Send("/ip/hotspot/user/add");
            mikrotik.Send("=server=hotspot1");
            mikrotik.Send("=name=" + letras);
            mikrotik.Send("=password=" + letras);
            mikrotik.Send("=limit-uptime="+txt_tiempo.Text);
            mikrotik.Send("=profile=default", true);

            List<string> source = mikrotik.Read();

            foreach (var item in source)
            {
                consola.Items.Add(Handle.ToString());
            }


            MessageBox.Show("Pin Creado: " + letras);
            mikrotik.Close();
        }
    }
    }
    

