using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace Djeciji_vrtic
{
    public static class Servisi
    {
        // Polaznik
        public static List<Models.PolaznikModel> GetPolaznike()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.PolaznikModel>("use Vrtic select * FROM Polaznici ").ToList();
            }
        }
        public static List<Models.PolaznikModel> GetPolaznikbyID(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.PolaznikModel>("use Vrtic select * FROM Polaznici where ID_Polaznik=@id", new { id }).ToList();
            }
        }
        public static List<Models.PolaznikModel> GetPolaznikeByIDGrupe(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.PolaznikModel>("Select * FROM Polaznici where ID_Grupa=@id", new { id }).ToList();
            }
        }
        public static void InsertPolaznik(Models.PolaznikModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Insert into Polaznici (Ime, Prezime, Ime_Roditelja,Datum_Rodjenja, JMBG, Kontakt, Pol, ID_Grupa) " +
                    "values (@ime, @prezime, @imeRoditelja, @datumRodjenja, @jmbg, @kontakt, @pol, @idGrupa)",
                new { ime = model.Ime, prezime = model.Prezime, imeRoditelja = model.Ime_Roditelja, datumRodjenja=model.Datum_Rodjenja, jmbg=model.JMBG, kontakt=model.Kontakt, pol=model.Pol, idGrupa=model.ID_Grupa });

            }

        }
        public static void UpdatePolaznik(Models.PolaznikModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Update Polaznici set Ime=@ime, Prezime=@prezime, Ime_Roditelja=@imeRoditelja, Datum_Rodjenja=@datumRodjenja, JMBG=@jmbg, Kontakt=@kontakt, Pol=@pol where ID_Polaznik=@idPolaznik",
                new { ime = model.Ime, prezime = model.Prezime, imeRoditelja = model.Ime_Roditelja, datumRodjenja = model.Datum_Rodjenja, jmbg = model.JMBG, kontakt = model.Kontakt, pol = model.Pol, idPolaznik=model.ID_Polaznik });

            }

        }
        public static void DeletePolaznikById(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Delete from Polaznici where ID_Polaznik=@id ", new { id });

            }

        }
        public static void SmanjiBrPolaznika(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                int brojPolaznika=db.QuerySingle<int>("Select Broj_Polaznika from Grupa where ID_Grupa=@id", new { id });
                brojPolaznika--;
                db.Execute("Update Grupa set Broj_Polaznika=@brPolaznika where ID_Grupa=@idGrupa", new { brPolaznika=brojPolaznika, idGrupa = id });
            }

        }
        
        public static void PovecajBrPolaznika(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                int brojPolaznika = db.QuerySingle<int>("Select Broj_Polaznika from Grupa where ID_Grupa=@id", new { id });
                brojPolaznika++;
                db.Execute("Update Grupa set Broj_Polaznika=@brPolaznika where ID_Grupa=@idGrupa", new { brPolaznika = brojPolaznika, idGrupa = id });
            }

        }
        /////////////////////////// update broja polaznika kod grupe kad se unosi i azurira
        // Uplate
        public static List<Models.UplateModel> GetUplate()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.UplateModel>("use Vrtic select ID_Uplata, Datum_Uplate, ID_Polaznik, Iznos FROM Uplate").ToList();
            }
        }
        public static List<Models.UplateModel> GetUplateById(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.UplateModel>("select ID_Uplata, Datum_Uplate, ID_Polaznik, Iznos FROM Uplate where ID_Polaznik=@id", new { id }).ToList();
            }
        }
        public static void DeleteUplataById(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Delete from Uplate where ID_Uplata=@id ", new { id });

            }
        }
        public static void InsertUplate(Models.UplateModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Insert into Uplate (Datum_Uplate, Iznos, ID_Polaznik) values (@datum, @iznos, @idPolaznik)",
                new { datum = model.Datum_Uplate, iznos = model.Iznos, idPolaznik = model.ID_Polaznik});

            }
            
        }
        public static void UpdateUplate(Models.UplateModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Update Uplate set Datum_Uplate=@datum, Iznos=@iznos, ID_Polaznik=@idPolaznik where ID_Uplata=@idUplate",
                new { datum = model.Datum_Uplate, iznos = model.Iznos, idPolaznik = model.ID_Polaznik, idUplate = model.ID_Uplata});

            }

        }

        // Grupe
        public static List<Models.GrupeModel> GetGrupe()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.GrupeModel>("USE Vrtic SELECT ID_Grupa,Ime_Grupe,Broj_Polaznika, ID_Zaposleni FROM Grupa").ToList();
            }
        }
        public static void InsertGrupe(Models.GrupeModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                
                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Insert into Grupa (Ime_Grupe, Broj_Polaznika, ID_Zaposleni) values (@imeGrupe, @brojPolaznika, @idZaposleni)",
                new { imeGrupe = model.Ime_Grupe, brojPolaznika = model.Broj_Polaznika, idZaposleni = model.ID_Zaposleni});

            }


        }
        public static void UpdateGrupe(Models.GrupeModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Update Grupa set Ime_Grupe=@imeGrupe, Broj_Polaznika=@brojPolaznika, ID_Zaposleni=@idZaposleni where ID_Grupa=@idGrupa",
                new { imeGrupe = model.Ime_Grupe, brojPolaznika = model.Broj_Polaznika, idZaposleni = model.ID_Zaposleni, idGrupa = model.ID_Grupa});

            }
            
        }
        public static void DeleteGrupeById(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Delete from Grupa where ID_Grupa=@id ",new { id});

            }


        }
        public static Models.ZaposleniModel GetVaspitacByID(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.QuerySingle<Models.ZaposleniModel>("USE Vrtic SELECT ID_Zaposleni,Ime,Prezime,Ime_Roditelja,Datum_Rodjenja,JMBG,Radna_Pozicija,Kontakt FROM Zaposleni where ID_Zaposleni=@id", new { id });
            }
        }
        public static List<Models.GrupeModel> GetGrupeByIdVaspitac(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.GrupeModel>("SELECT ID_Grupa,Ime_Grupe,Broj_Polaznika,ID_Zaposleni FROM Grupa where ID_Zaposleni=@id", new{id}).ToList();
            }
        }

        // Zaposleni
        public static List<Models.ZaposleniModel> GetZaposlene()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.ZaposleniModel>("SELECT ID_Zaposleni,Ime,Prezime,Ime_Roditelja,Datum_Rodjenja,JMBG,Radna_Pozicija,Kontakt FROM Zaposleni").ToList();
            }
        }
        public static List<Models.ZaposleniModel> GetRadnePozicije()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.ZaposleniModel>("select distinct Radna_Pozicija from Zaposleni").ToList();
            }
        }
        public static List<Models.ZaposleniModel> GetZaposleneByRadnaPozicija(string radnaPozicija)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.ZaposleniModel>("select* from Zaposleni where Radna_Pozicija=@radnaPozicija", new { radnaPozicija }).ToList();
            }
        }
        public static void UpdateZaposleni(Models.ZaposleniModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Update Zaposleni set Ime=@ime, Prezime=@prezime, Ime_Roditelja=@imeRoditelja, Datum_Rodjenja=@datumRodjenja, JMBG=@jmbg, Radna_Pozicija=@radnaPozicija, Kontakt=@kontakt where ID_Zaposleni=@idZaposleni",
                new { ime = model.Ime, prezime = model.Prezime, imeRoditelja = model.Ime_Roditelja, datumRodjenja = model.Datum_Rodjenja, jmbg = model.JMBG, radnaPozicija=model.Radna_Pozicija,kontakt=model.Kontakt, idZaposleni = model.ID_Zaposleni });

            }

        }
        public static void InsertZaposleni(Models.ZaposleniModel model)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Insert into Zaposleni (Ime, Prezime, Ime_Roditelja,Datum_Rodjenja, JMBG, Radna_Pozicija, Kontakt) " +
                    "values (@ime, @prezime, @imeRoditelja, @datumRodjenja, @jmbg, @radnaPozicija, @kontakt)",
                new { ime = model.Ime, prezime = model.Prezime, imeRoditelja = model.Ime_Roditelja, datumRodjenja = model.Datum_Rodjenja, jmbg = model.JMBG, kontakt = model.Kontakt, radnaPozicija=model.Radna_Pozicija});

            }

        }
        public static List<Models.ZaposleniModel> GetVaspitace()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<Models.ZaposleniModel>("USE Vrtic SELECT ID_Zaposleni,Ime,Prezime,Ime_Roditelja,Datum_Rodjenja,JMBG,Radna_Pozicija,Kontakt FROM Zaposleni where Radna_Pozicija=N'Vaspitač'").ToList();
            }
        }
        public static void DeleteZaposleniById(int id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("Delete from Zaposleni where ID_Zaposleni=@id ", new { id });

            }


        }

    }
}
