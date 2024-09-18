using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using S7.Net.Types;

namespace PLC_Veri_Yazma
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
            Plc plc1510;
            protected void Page_Load(object sender, EventArgs e)
            {

            }
            protected void Button1_Click(object sender, EventArgs e)
            {

                int i = Convert.ToInt16(TextBox1.Text);
                plc1510 = new Plc(CpuType.S71500, "192.168.0.20", 0, 1);

                try
                {
                    plc1510.Open();

                    if (plc1510.IsConnected)
                    {
                        Label1.Text = "Bağlandı";
                        Label1.ForeColor = Color.Green;

                        // DB101 Data array'inin 1. elemanına 100 değeri yazmak
                        int dbNumber = 101; // DataBlock numarası
                        int startByte = (i - 1) * 2;  // Array'in 1. elemanı (0-index) 2. bayttan başlar (2 byte veri)
                        ushort valueToWrite = Convert.ToUInt16(TextBox2.Text); // Yazmak istediğiniz değer

                        // Data Block'a yazma işlemi
                        plc1510.Write(DataType.DataBlock, dbNumber, startByte, valueToWrite);

                        Label2.Text = $"{i}. Sıraya Veri yazıldı: {valueToWrite}";
                    }
                    else
                    {
                        Label1.Text = "Bağlanılamadı";
                        Label1.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    Label2.Text = "Hata: " + ex.Message;
                }
                finally
                {
                    if (plc1510.IsConnected)
                    {
                        plc1510.Close();
                    }



                    /* using (plc1510 = new Plc(CpuType.S71500, "192.168.0.20", 0, 1))
                    {
                        try
                        {
                            plc1510.Open();

                            if (plc1510.IsConnected)
                            {
                                Label1.Text = "Bağlandı";
                                Label1.ForeColor = Color.Green;

                                // %MW20 adresine 5 değerini yazın
                                int address = 20; // MW20 adresindeki word
                                ushort valueToWrite = 10; // Yazmak istediğiniz değer

                                plc1510.Write("MW" + address, valueToWrite);

                                Label2.Text = "Değer yazıldı: " + valueToWrite;
                            }
                            else
                            {
                                Label1.Text = "Bağlanılamadı";
                                Label1.ForeColor = Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            Label2.Text = "Hata: " + ex.Message;
                        }
                        finally
                        {
                            if (plc1510.IsConnected)
                            {
                                plc1510.Close();
                            } */
                }
            }


        }
    }
