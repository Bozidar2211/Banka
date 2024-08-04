using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private SqlConnection konekcija = new SqlConnection(Konekcija.konString);

        private void puniComboBoxImePrezime()
        {
            cbImePrezime.Items.Clear();
            try
            {
                konekcija.Open();
                SqlCommand komanda = new SqlCommand("Select Distinct ImePrezime From Klijent",konekcija);
                SqlDataReader reader = komanda.ExecuteReader();
                while(reader.Read())
                {
                    cbImePrezime.Items.Add(reader.GetString(0));
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.klijentTableAdapter1.Fill(this.bankaDataSet1.Klijent);
            this.racunTableAdapter1.Fill(this.bankaDataSet1.Racun);
            groupBoxRacun.Enabled = false;
            groupBoxKlijenti.Enabled = false;
            puniComboBoxImePrezime();
        }

        private void groupBoxKlijenti_Enter(object sender, EventArgs e)
        {

        }

        private void obradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxRacun.Enabled = true ;
        }
        private void PrikaziPodatkeOTipuRacuna(string tip)
        {
            try
            {
               konekcija.Open();
                SqlCommand komanda = new SqlCommand();
              
                komanda.Connection = konekcija;
                komanda.Parameters.Add(new SqlParameter("racun", tip));

                //broj otvorenih računa za tip izabranog računa
                komanda.CommandText = "Select  Count(*) " +
                                      "FROM Racun r JOIN Klijent k " +
                                      "ON r.IDRacun = k.Racun " +
                                      "WHERE r.Tip = @racun";
                tbBrojOtvorenih.Text = komanda.ExecuteScalar().ToString();
                //račun koji ima najviše novčanih sredstava za izabrani tip računa
                komanda.CommandText = "Select  MAX(k.Stanje) " +
                                      "FROM Klijent k JOIN Racun r " +
                                      "ON r.IDRacun = k.Racun " +
                                      "Where r.Tip = @racun";
               tbRacunSaNajNovca.Text = komanda.ExecuteScalar().ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void rtbNamenski_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziPodatkeOTipuRacuna(rtbNamenski.Text); 
        }

        private void rtbDinarski_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziPodatkeOTipuRacuna(rtbDinarski.Text);
        }

        private void rtbNenamesnki_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziPodatkeOTipuRacuna(rtbNenamesnki.Text);
        }

        private void rtbDevizni_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziPodatkeOTipuRacuna(rtbDevizni.Text); 
        }

        private void klijentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxKlijenti.Enabled = true;
        }

        private void cbImePrezime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbImePrezime.SelectedIndex == -1)
                return;

            listBoxPrikaz.Items.Clear();
            try
            {
                konekcija.Open();
                using (SqlCommand komanda = new SqlCommand("Select IDKlijent, Stanje From Klijent Where ImePrezime = @ImePrezime", konekcija))
                {
                   
                    komanda.Parameters.AddWithValue("@ImePrezime", cbImePrezime.SelectedItem.ToString());
                    using (SqlDataReader reader = komanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxPrikaz.Items.Add("Klijent sa ID: " + reader[0].ToString() + " -Stanje racuna: " +  reader[1].ToString()); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbVeceOD.Text))
            {
                MessageBox.Show("Polje StanjeNaRacunuViseOD je obavezno!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbImePrezime.SelectedIndex == -1)
            {
                MessageBox.Show("Obavezno je izabrati klijenta(ImePrezime)", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxPrikaz.Items.Clear();

            try
            {
                konekcija.Open();
                SqlCommand komanda = new SqlCommand("Select IDKlijent, Stanje " +
                                                    "From Klijent WHERE ImePrezime = @klijent " +
                                                    "AND Stanje > @stanje",konekcija);
                
                komanda.Parameters.AddWithValue("klijent",cbImePrezime.SelectedItem.ToString());
                komanda.Parameters.AddWithValue("stanje",int.Parse(tbVeceOD.Text));
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    listBoxPrikaz.Items.Add("Klijent sa ID: " + reader["IDKlijent"].ToString() + " -Stanje racuna: " + reader["Stanje"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();  
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Zelite da obrisete klijenta","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    konekcija.Open();
                    SqlCommand komanda = new SqlCommand("Delete From Klijent Where IDKlijent = @ID",konekcija);
                    komanda.Parameters.AddWithValue("ID", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    komanda.ExecuteNonQuery();
                    klijentTableAdapter1.Fill(bankaDataSet1.Klijent);
                    MessageBox.Show("Uspesno obrisan klijent","Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }
    }
}
