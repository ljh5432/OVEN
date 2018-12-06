using DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181123
{
    public class MainView
    {
        private MYsql db;
        private Commons comm;
        private Panel head, contents;
        static public Panel head_panel;
        private Button btn1, btn2, btn3;
        private Form parentForm, tagetForm;
        private Hashtable hashtable;

        public MainView(Form parentForm)
        {
            this.parentForm = parentForm;
            db = new MYsql();
            comm = new Commons();
            getView();
        }

        private void getView()
        {

            string sql = "select * from ViewControl where vNo = 1;";
            MySqlDataReader sdr = db.Reader(sql);
            //MessageBox.Show("테스트 : " + sdr.ToString());
            while (sdr.Read())
            {
                Color color;
                EventHandler eventhandler;

                //MessageBox.Show(" 패널 정보 : " + sdr["vcType"].ToString());

                // color
                if(Convert.ToInt32(sdr["color"]) == 0)
                {
                    color = Color.Silver;
                    //MessageBox.Show("Color.Silver");
                }
                else if (Convert.ToInt32(sdr["color"]) == 1)
                {
                    color = Color.Yellow;
                    //MessageBox.Show("Color.Yellow");
                }
                else if (Convert.ToInt32(sdr["color"]) == 2)
                {
                    color = Color.White;
                    //MessageBox.Show("Color.White");
                }
                else
                {
                    color = Color.Silver;
                }

                // event
                if (sdr["event"].ToString() == "0")
                {
                    eventhandler = (EventHandler)btn1_click;
                }
                else if (sdr["event"].ToString() == "1")
                {
                    eventhandler = (EventHandler)btn2_click;
                }
                else if (sdr["event"].ToString() == "2")
                {
                    eventhandler = (EventHandler)btn3_click;
                }
                else
                {
                    eventhandler = null;
                }

                //MessageBox.Show("type : " + sdr["vcType"] + ", sdr[vcName] : " + sdr["vcName"] + ", sdr[vcText] : " + sdr["vcText"] + ", sdr[sizeX] : " + sdr["sizeX"] + ", sdr[sizeY] : " + sdr["sizeY"] + ", sdr[pointX] : " + sdr["pointX"] + ", sdr[pointY] : " + sdr["pointY"] + ", sdr[color] : " + sdr["color"] + ", sdr[event] : " + sdr ["event"]);

                Hashtable ht = new Hashtable();
                ht.Add("type", sdr["vcType"]);
                ht.Add("name", sdr["vcName"]);
                ht.Add("text", sdr["vcText"]);
                ht.Add("sX", sdr["sizeX"]);
                ht.Add("sY", sdr["sizeY"]);
                ht.Add("pX", sdr["pointX"]);
                ht.Add("pY", sdr["pointY"]);
                ht.Add("color", color);
                ht.Add("event", eventhandler);

                if (sdr["vcType"].ToString() == "panel")
                {
                    comm.getPanel(ht, parentForm);
                    //MessageBox.Show(" 패널 정보 : " + sdr["vcType"].ToString() );
                }
                else if (sdr["vcType"].ToString() == "button")
                {
                    //head_panel.Controls.Add(comm.getButton(ht, parentForm));
                    //MessageBox.Show(" 버튼 정보 : " + sdr["vcType"].ToString());
                }

            }
            db.ReaderClose(sdr);

            //hashtable = new Hashtable();
            //hashtable.Add("size", new Size(1000, 100));
            //hashtable.Add("point", new Point(0, 0));
            //hashtable.Add("color", Color.Silver);
            //hashtable.Add("name", "head");
            //head = comm.getPanel(hashtable, parentForm);

            //hashtable = new Hashtable();
            //hashtable.Add("size", new Size(1000, 700));
            //hashtable.Add("point", new Point(0, 100));
            //hashtable.Add("color", Color.Yellow);
            //hashtable.Add("name", "contents");
            //contents = comm.getPanel(hashtable, parentForm);

            //hashtable = new Hashtable();
            //hashtable.Add("size", new Size(200, 80));
            //hashtable.Add("point", new Point(100, 10));
            //hashtable.Add("color", Color.White);
            //hashtable.Add("name", "btn1");
            //hashtable.Add("text", "Member");
            //hashtable.Add("click", (EventHandler)btn1_click);
            //btn1 = comm.getButton(hashtable, head);

            //hashtable = new Hashtable();
            //hashtable.Add("size", new Size(200, 80));
            //hashtable.Add("point", new Point(400, 10));
            //hashtable.Add("color", Color.White);
            //hashtable.Add("name", "btn2");
            //hashtable.Add("text", "Rule");
            //hashtable.Add("click", (EventHandler)btn2_click);
            //btn2 = comm.getButton(hashtable, head);

            //hashtable = new Hashtable();
            //hashtable.Add("size", new Size(200, 80));
            //hashtable.Add("point", new Point(700, 10));
            //hashtable.Add("color", Color.White);
            //hashtable.Add("name", "btn3");
            //hashtable.Add("text", "Mapping");
            //hashtable.Add("click", (EventHandler)btn3_click);
            //btn3 = comm.getButton(hashtable, head);
        }

        private void btn1_click(object o, EventArgs a)
        {
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = comm.getMdiForm(parentForm, new UserForm(db), contents);
            tagetForm.Show();
        }

        private void btn2_click(object o, EventArgs a)
        {
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = comm.getMdiForm(parentForm, new RuleForm(db), contents);
            tagetForm.Show();
        }

        private void btn3_click(object o, EventArgs a)
        {
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = comm.getMdiForm(parentForm, new MappingForm(db), contents);
            tagetForm.Show();
        }
    }
}
