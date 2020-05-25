using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FluentNHibernate;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Uprava.Entiteti;

namespace Uprava
{
	public partial class PolicijskaUprava : Form
	{
		public PolicijskaUprava()
		{
			InitializeComponent();
		}

		private void btnLoadPolicijskaStanica_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				PolicijskaStanica p = s.Load<PolicijskaStanica>(1);

				MessageBox.Show(p.Sef.Ime + " " + p.Zamenik.Ime);

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				//ISession s = DataLayer.GetSession();
				//IList<Policajac> listaPolicajca = s.QueryOver<Policajac>().List<Policajac>();

				//foreach (Policajac pol in listaPolicajca)
				//{
				//	if (pol.GetType() == typeof(PozornikPolicajac))
				//	{
				//		PozornikPolicajac pozornik = (PozornikPolicajac)pol;
				//		MessageBox.Show(pozornik.ToString());
				//	}

				//	else if (pol.GetType() == typeof(VanredniPolicajac))
				//	{
				//		VanredniPolicajac vanredni = (VanredniPolicajac)pol;
				//		MessageBox.Show(vanredni.ToString());
				//	}
				//	else if (pol.GetType() == typeof(SkolskiPolicajac))
				//	{
				//		SkolskiPolicajac skolski = (SkolskiPolicajac)pol;
				//		MessageBox.Show(skolski.ToString());
				//	}
				//	else
				//	{
				//		MessageBox.Show(pol.ToString());
				//	}
				//}
				//s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Uprava.Entiteti.PolicijskaStanica p = s.Load<Uprava.Entiteti.PolicijskaStanica>(1);

				foreach (Policajac pol in p.Policajci)
				{
					MessageBox.Show(pol.Ime + " " + pol.Kurs);
				}

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);

				Console.WriteLine(exception);
				throw;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				


				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				AlarmniSistem a = s.Load<AlarmniSistem>("K1271");

				MessageBox.Show(a.GodinaProizvodnje);
				MessageBox.Show(a.Model);
				MessageBox.Show((a.DatumInstalacije).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Sertifikat se = s.Load<Sertifikat>(4);

				MessageBox.Show(se.Naziv);
				MessageBox.Show((se.Policajac.Ime).ToString());
				MessageBox.Show((se.DatumSticanja).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Cin c = s.Load<Cin>(2);

				MessageBox.Show(c.Naziv);
				MessageBox.Show((c.DatumSticanja).ToString());
				MessageBox.Show(c.pripadaPolicajcu.Ime);

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Intervencija i = s.Load<Intervencija>(2);

				MessageBox.Show((i.Patrola.PatrolaId).ToString());
				MessageBox.Show((i.Objekat.Ime).ToString());
				MessageBox.Show((i.Objekat.Povrsina).ToString());
				MessageBox.Show(i.Vreme);
				MessageBox.Show(i.Opis);


				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Kurs k = s.Load<Kurs>(2);

				MessageBox.Show((k.Policajac.Ime).ToString());
				MessageBox.Show((k.DatumZavrsetka).ToString());



				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Objekat o = s.Load<Objekat>(2);

				MessageBox.Show((o.Ime).ToString());
				MessageBox.Show((o.Povrsina).ToString());
				MessageBox.Show((o.PripadaPolicjkojStanica.StanicaId).ToString());
				MessageBox.Show((o.PripadaPolicjkojStanica.Opstina).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Patrola p = s.Load<Patrola>(3);

				MessageBox.Show((p.PatrolaId).ToString());
				MessageBox.Show((p.Vozilo.Model));
				MessageBox.Show((p.Vodja.DatumSticanjaDiplome).ToString());
				MessageBox.Show((p.Partner.Jmbg).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				SluzbenoVozilo sv = s.Load<SluzbenoVozilo>(3);

				MessageBox.Show((sv.RegistarskaOznaka).ToString());
				MessageBox.Show((sv.Tip).ToString());
				MessageBox.Show((sv.pripadaStanici.Naziv).ToString());


				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Zaduzen z = s.Load<Zaduzen>(3);

				MessageBox.Show((z.Tehnicar.Ime).ToString());
				MessageBox.Show((z.DatumOd).ToString());
				MessageBox.Show((z.DatumDo).ToString());
				MessageBox.Show((z.AlarmSerijskiBr.SerijskiBr).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				TehnickoLice t = s.Load<TehnickoLice>(3);

				MessageBox.Show((t.Ime).ToString());
				MessageBox.Show((t.Prezime).ToString());
				MessageBox.Show((t.KontaktBr).ToString());


				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Ulica ul = s.Load<Ulica>(3);

				MessageBox.Show(ul.Naziv);
				MessageBox.Show	((ul.UlicaId).ToString());
				MessageBox.Show(ul.PripadaPolicajcu.Ime);


				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				Vestina ve = s.Load<Vestina>(3);

				MessageBox.Show(ve.Naziv);
				MessageBox.Show((ve.VestinaId).ToString());
				MessageBox.Show(ve.PripadaPolicajcu.Ime);
				MessageBox.Show((ve.PripadaPolicajcu.PolicajacId).ToString());

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				SkolskiPolicajac sp = s.Load<SkolskiPolicajac>(5);

				MessageBox.Show((sp.PolicajacId).ToString());
				MessageBox.Show((sp.NazivSkole));
				MessageBox.Show(sp.OsobaZaKontakt);
				

				s.Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				Console.WriteLine(exception);
				throw;
			}
		}

        private void btnOnetoManyObjekti_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ISession s = DataLayer.GetSession();
                    Uprava.Entiteti.PolicijskaStanica ps = s.Load<Uprava.Entiteti.PolicijskaStanica>(1);
                
                    foreach(Objekat o in ps.DrziObjekte)
                {
                    MessageBox.Show(o.Adresa + " " + o.TipObjekta);
                }
                   
                    s.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Console.WriteLine(exception);
                    throw;
                }
            
        }

        private void btnOnetoManyAlarmi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.Objekat o = s.Load<Uprava.Entiteti.Objekat>(2);

                foreach (AlarmniSistem a in o.ImaAlarme)
                {
                    MessageBox.Show(a.Tip + " " + a.Proizvodjac+ " " + a.DatumInstalacije);
                }

                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }
        //ovo ne prikazuje nista, kod je dobar, ali mislim da je to zato sto je cin visevrednosni 
        private void btnOnetoManyCinovi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.Policajac p = s.Load<Uprava.Entiteti.Policajac>(1);

                foreach (Cin c in p.Cinovi)
                {
                    MessageBox.Show((c.Naziv).ToString());
                   
                }

                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }
        
        private void btnOnetoManyVozila_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.PolicijskaStanica p = s.Load<Uprava.Entiteti.PolicijskaStanica>(1);

                foreach (SluzbenoVozilo sv in p.SluzbenaVozila)
                {
                    MessageBox.Show(sv.RegistarskaOznaka + " " + sv.Tip + " " + sv.Model);
                }

                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnManytoOneStanice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.Objekat o = s.Load<Uprava.Entiteti.Objekat>(10);

                
                MessageBox.Show(o.TipObjekta);
                MessageBox.Show(o.PripadaPolicjkojStanica.Naziv);


                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnManytoOnePolStanice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.Policajac p = s.Load<Uprava.Entiteti.Policajac>(9);


                MessageBox.Show(p.Ime + " " + p.Jmbg);
                MessageBox.Show(p.PripadaPolicijskaStanica.Naziv);


                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnManytoOnealObjekti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.AlarmniSistem a = s.Load<Uprava.Entiteti.AlarmniSistem>(1);


                MessageBox.Show(a.Tip);
                MessageBox.Show(a.PripadaObjektu.TipObjekta);


                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnManytoOnevozStan_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Uprava.Entiteti.SluzbenoVozilo sv = s.Load<Uprava.Entiteti.SluzbenoVozilo>(9);


                MessageBox.Show(sv.Tip + " " + sv.RegistarskaOznaka);
                MessageBox.Show(sv.pripadaStanici.Naziv);


                s.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception);
                throw;
            }
        }

		private void button17_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();




				Policajac pol = s.Load<Policajac>(11);

				Cin c = new Cin();


				c.DatumSticanja = DateTime.Now;
				c.Naziv = "TEST ZA IGORAAAAAAA";
				c.pripadaPolicajcu= pol;

				pol.Cinovi.Add(c);



				
				s.Save(c);
				s.Flush();

				s.Close();
			
			}


			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Patrola p = s.Load<Patrola>(1);
				Objekat o = s.Load<Objekat>(1);
				Intervencija i = new Intervencija();

				i.Datum = DateTime.Now;
				i.Objekat = o;
				i.Patrola = p;
				i.Vreme = "20:35H";
				i.Opis = "Lagana prica";
				o.ImaoIntervencije.Add(i);
				p.imalaIntervencije.Add(i);

				s.Save(i);
				s.Flush();

				s.Close();

			}


			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Policajac p = new Policajac();
				PolicijskaStanica ps = s.Load<PolicijskaStanica>(1);

				p.Adresa = "Neznanog junaka";
				p.DatumPrijema = DateTime.Now;
				p.DatumRodjenja = new DateTime(1976, 10, 20);
				p.DatumSticanjaDiplome = new DateTime(2006, 2, 11);
				p.Ime = "Slobodan";
				p.ImeRoditelja = "Branislav";
				p.Jmbg = "1452145214521";
				p.Kurs = "No info";
				p.NazivObrazovanja = "Obuceni policajac";
				p.Pol = "M";
				p.Pozicija = "Snajperista";
				p.Skola = "Policijska akademija";
				p.TipPosla = "Skolski Policajac";
				p.Prezime = "Stamenkovic";

				p.PripadaPolicijskaStanica = ps;
				ps.Policajci.Add(p);

				s.Save(p);
				s.Flush();

				s.Close();

			}


			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button20_Click(object sender, EventArgs e)
		{
			try
			{
				/*ISession s = DataLayer.GetSession();

				Vestina v = new Vestina();
				Policajac pol = s.Load<Policajac>(24);

				v.Naziv = "Borilacke vestine";
				v.PripadaPolicajcu = pol;

				pol.Vestine.Add(v);
				

				s.Save(v);
				s.Flush();

				s.Close();*/

			}
			
				catch (Exception ec)
				{
					MessageBox.Show(ec.Message);
				}
			}

		private void button22_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				IList<AlarmniSistem> listaAlarmnihSistema = s.QueryOver<AlarmniSistem>().List<AlarmniSistem>();

				foreach (AlarmniSistem alarm in listaAlarmnihSistema)
				{
					if (alarm.GetType() == typeof(ToplotniAlarmniSistem))
					{
						ToplotniAlarmniSistem toplotni = (ToplotniAlarmniSistem) alarm;
						MessageBox.Show(toplotni.ToString());
					}

					else if (alarm.GetType() == typeof(UltrazvucniAlarmniSistem))
					{
						UltrazvucniAlarmniSistem ultrazvucni = (UltrazvucniAlarmniSistem) alarm;
						MessageBox.Show(ultrazvucni.ToString());
					}
					else if (alarm.GetType() == typeof(DetekcijaPokretaAlarmniSistem))
					{
						DetekcijaPokretaAlarmniSistem detekcijaPokretaAlarmniSistem =
							(DetekcijaPokretaAlarmniSistem) alarm;
						MessageBox.Show(detekcijaPokretaAlarmniSistem.ToString());
					}
				}

				s.Close();

			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button21_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				IList<Policajac> policajci = s.QueryOver<Policajac>().Where(p => p.PolicajacId == 5).List<Policajac>();

				SkolskiPolicajac skolski = (SkolskiPolicajac) policajci[0];
				MessageBox.Show(skolski.ToString());
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button23_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();
				IList<SkolskiPolicajac> policajci = s.QueryOver<SkolskiPolicajac>().List<SkolskiPolicajac>();

				foreach (var pol in policajci)
				{
					MessageBox.Show(pol.ToString());
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void button23_Click_1(object sender, EventArgs e)
		{
			
				try
				{
					ISession s = DataLayer.GetSession();

					Policajac pol = s.Get<Policajac>(11);

					//obrada podataka o odeljenju

					s.Refresh(pol);

					s.Close();

				}
				catch (Exception ec)
				{
					MessageBox.Show(ec.Message);
				}
			}

		private void button24_Click(object sender, EventArgs e)
		{

			try
			{
				ISession s = DataLayer.GetSession();

				Vestina v = s.Get<Vestina>(2);

				//obrada podataka o odeljenju

				s.Refresh(v);

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button25_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				AlarmniSistem a = s.Get<AlarmniSistem>("K1271");

				//obrada podataka o odeljenju

				s.Refresh(a);

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button27_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				IQuery q = s.CreateQuery("from Cin");

				IList<Cin> cinovi = q.List<Cin>();

				foreach (Cin o in cinovi)
				{
					MessageBox.Show(o.Naziv);
					//MessageBox.Show(o.pripadaPolicajcu.Ime);
				}

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button28_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				IQuery q = s.CreateQuery("from AlarmniSistem");

				IList<AlarmniSistem> sistemi = q.List<AlarmniSistem>();

				foreach (AlarmniSistem z in sistemi)
				{
				
					MessageBox.Show(z.GodinaProizvodnje);
					MessageBox.Show(z.SerijskiBr);
					MessageBox.Show(z.Tip);
				}

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button29_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				IQuery q = s.CreateQuery("from Intervencija");

				IList<Intervencija> intervencije = q.List<Intervencija>();

				foreach (Intervencija z in intervencije)
				{

					MessageBox.Show(z.Vreme);
					MessageBox.Show(z.Opis);
					MessageBox.Show((z.IntervencijaId).ToString());
					MessageBox.Show((z.Objekat.ObjekatId).ToString());
				}

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void button30_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				//Odeljenja koja nemaju info pult
				IQuery q = s.CreateQuery("from ToplotniAlarmniSistem as o where o.Proizvodjac='PARADOX'");

				IList<ToplotniAlarmniSistem> sistemi = q.List<ToplotniAlarmniSistem>();

				foreach (ToplotniAlarmniSistem o in sistemi)
				{
					MessageBox.Show(o.SerijskiBr + " " + (o.DatumInstalacije.ToString()));
				}

				s.Close();

			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}
	}
	}
	
	


