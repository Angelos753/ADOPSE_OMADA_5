using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.IO;


namespace AdopseAddsTeam5.GUI.Main_Form
{
    class DataAccess
    {
        
        //methodos gia to Sign_in
        public void NewUser(string email, string password)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                
                connection.Open();
                //edw kalei tin procedure
                //sign_in(@EmailAddress , @Password");
                using (var cmd = new NpgsqlCommand("SELECT insert_users2(@email , @kwdikos)", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("kwdikos", password);
                    cmd.ExecuteNonQuery();
                } 
            }
        }

        //methodos gia to Log_in
        public User LogIn(string email , string password)
        {
            using (var conn = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try 
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM log_in(@email , @kwdikos)", conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("kwdikos", password);
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        User user = new User();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            //error null pedio pou epistrefei apo tin vasi
                            user.Name = Convert.ToString(reader.GetString(0));
                            user.Image = Convert.ToString(reader.GetString(4));
                            user.EmailAddress = Convert.ToString(reader.GetString(1).ToString());
                            user.Password = Convert.ToString(reader.GetString(2).ToString());

                            return user;
                        }
                        else
                        {
                            return user;
                        }
                    }  
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        //methodos gia tis aggelies tou current user
        public static List<Adds> UserAdds(string email)
        {
            List<Adds> useradds = new List<Adds>();
            using (var conn = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM return_aggelies(@email)", conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        NpgsqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                useradds.Add(new Adds { sid = reader.GetInt32(0), title = reader.GetString(3).ToString(),
                                    perioxi = reader.GetString(1).ToString(), timi = reader.GetInt32(2), emvadon = reader.GetInt32(4), 
                                    ypnodomatia = reader.GetInt32(10), mpanio = reader.GetInt32(9), eidos = reader.GetString(5).ToString() , 
                                    thermansi = reader.GetString(6).ToString() , desc = reader.GetString(8).ToString() , 
                                    phone = reader.GetString(7).ToString() , email = reader.GetString(11).ToString() , 
                                    dieythinsi = reader.GetString(13).ToString() , photonumber = reader.GetInt32(12)});
                            }
                        }
                        return useradds;
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }


        //methodos gia thn emfanisi ton agapimenon aggelion
        public static Adds[] FavoriteAdds(string email)
        {
            Adds[] add;
            using (var conn = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM show_agapimena(@email)", conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        NpgsqlDataReader reader = cmd.ExecuteReader();

                        int c = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                c = c + 1;
                            }
                            reader.Close();
                        }
                        add = new Adds[c];
                        for (int x = 0; x < c; x++)
                        {
                            reader.Read();
                            //gemisma oxi tou List<> alla tou pinaka []
                            add[x].title = reader.GetString(3).ToString();
                            add[x].perioxi = reader.GetString(1).ToString();
                            add[x].timi = reader.GetInt32(2);
                            add[x].emvadon = reader.GetInt32(4);
                            add[x].ypnodomatia = reader.GetInt32(10);
                            add[x].mpanio = reader.GetInt32(9);
                            add[x].eidos = reader.GetString(5).ToString();
                            add[x].thermansi = reader.GetString(6).ToString();
                            add[x].desc = reader.GetString(8).ToString();
                            add[x].phone = reader.GetString(7).ToString();
                            add[x].email = reader.GetString(11).ToString();
                            add[x].dieythinsi = reader.GetString(13).ToString();
                            add[x].photonumber = reader.GetInt32(12);
                        }

                        return add;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        //methodos gia tin eisagogi ton agapimenon
        public void InsertToFavorite(string email , int id)
        {
            using (var conn = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT insert_agapimena(@email , @id)", conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }    
        }

        //emfanisi tis aggelias
        public Adds TheAdd(int id)
        {
            using (var conn = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM TheAdd(@id)", conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        Adds add = new Adds();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                add.title = reader.GetString(3).ToString();
                                add.perioxi = reader.GetString(1).ToString();
                                add.timi = reader.GetInt32(2);
                                add.emvadon = reader.GetInt32(4);
                                add.ypnodomatia = reader.GetInt32(10);
                                add.mpanio = reader.GetInt32(9);
                                add.eidos = reader.GetString(5).ToString();
                                add.thermansi = reader.GetString(6).ToString();
                                add.desc = reader.GetString(8).ToString();
                                add.phone = reader.GetString(7).ToString();
                                add.email = reader.GetString(11).ToString();
                                add.dieythinsi = reader.GetString(13).ToString();
                                add.photonumber = reader.GetInt32(12);
                            }
                        }

                        return add;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //dimiourgia neas aggelias
        //Άλλαξα την μέθοδο σε static - Alex
        public static void NewAdd(int ypnodwmatia , int mpania , string email, string perioxi, string timi, string eidos, string emvadon, string title, string thermansi, string phone, string description, string dieythinsi)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT insert_aggelies1(@perioxi , @timi , @typos_aggelias , @emvadon , @typos_akinitou , @systhma_thermanshs , @thlefwno , @perigrafi , @mpania , @ypnodwmatia , @email , @dieythinsi)", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("perioxi", perioxi);
                    cmd.Parameters.AddWithValue("timi", timi);
                    cmd.Parameters.AddWithValue("typos_aggelias", eidos);
                    cmd.Parameters.AddWithValue("emvadon", emvadon);
                    cmd.Parameters.AddWithValue("typos_akinitou", title);
                    cmd.Parameters.AddWithValue("systhma_thermanshs", thermansi);
                    cmd.Parameters.AddWithValue("thlefwno", phone);
                    cmd.Parameters.AddWithValue("perigrafi", description);
                    cmd.Parameters.AddWithValue("mpania", mpania);
                    cmd.Parameters.AddWithValue("ypnodwmatia", ypnodwmatia);
                    cmd.Parameters.AddWithValue("dieythinsi", dieythinsi);
                    NpgsqlDataReader reader = cmd.ExecuteReader();


                    using (var command = new NpgsqlCommand("SELECT MAX(id) FROM aggelies1"))
                    {
                        if (reader.HasRows)
                        {
                            var newadd = new Adds { };
                            while (reader.Read())
                            {
                                newadd.sid = reader.GetInt32(0);
                                newadd.title = reader.GetString(3).ToString();
                                newadd.perioxi = reader.GetString(1).ToString();
                                newadd.timi = reader.GetInt32(2);
                                newadd.emvadon = reader.GetInt32(4);
                                newadd.ypnodomatia = reader.GetInt32(10);
                                newadd.mpanio = reader.GetInt32(9);
                                newadd.eidos = reader.GetString(5).ToString();
                                newadd.thermansi = reader.GetString(6).ToString();
                                newadd.desc = reader.GetString(8).ToString();
                                newadd.phone = reader.GetString(7).ToString();
                                newadd.email = reader.GetString(11).ToString();
                                newadd.dieythinsi = reader.GetString(13).ToString();
                            }
                            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            //gia na parw to sid kai na ftiaksw folder gia tis foto me auto to sid
                            MainForm.newuseradd = newadd;

                            // add record to Lucene search index
                            LuceneSearch.AddUpdateLuceneIndex(newadd);
                        }
                    } 
                }
            }
        }

        //methodos gia to onoma tou user
        //Άλλαξα την μέθοδο σε static - Alex
        public static void UserName(string email, string name)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {

                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT insert_usersname(@email , @onoma_epwnymo)", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("onoma_epwnymo", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //allagi tou email tou user
        //Άλλαξα την μέθοδο σε static - Alex
        //Πρέπει να είναι λάθος το όνομα της μεθόδου στην DB. - Alex
        public static void UserNewEmail(string email, string newemail)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {

                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT insert_newemail(@email , @newemail)", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("newemail", newemail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //allagi fotografias tou user
        public static void UserImage(string email, string image)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {

                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT change_image(@email , @picture)", connection))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("picture", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //emfanisi pinaka minimaton
        //Άλλαξα το όνομα της μεθόδου άπό UserImage σε UserMessages - Alex
        public static Message[] UserMessages(string email)
        {
            Message[] msg;
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try 
                { 
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM show_message1(@email)", connection))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        NpgsqlDataReader reader = cmd.ExecuteReader();

                        int c = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                c = c + 1;
                            }
                        }
                        msg = new Message[c];
                        for (int x = 0; x < c; x++)
                        {
                            reader.Read();
                            //gemisma oxi tou List<> alla tou pinaka []
                            msg[x].mid = reader.GetInt32(5);
                            msg[x].useremail = reader.GetString(3).ToString();
                            msg[x].firstname = reader.GetString(0).ToString();
                            msg[x].lastname = reader.GetString(1).ToString();
                            msg[x].phone = reader.GetString(2).ToString();
                            msg[x].email = reader.GetString(6).ToString();
                            msg[x].desc = reader.GetString(4).ToString();
                        }

                        return msg;
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }

            }
        }

        //gia to fortoma olon ton aggelion ston index tou lucene
        //auti h methodos prepei na kalite kata to fortoma tou programmatos
        public static void AllAdds()
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM show_aggelies1()", connection))
                    {
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        List<Adds> everyadd = new List<Adds>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                everyadd.Add(new Adds { sid = reader.GetInt32(0), title = reader.GetString(3).ToString(), 
                                    perioxi = reader.GetString(1).ToString(), timi = reader.GetInt32(2), emvadon = reader.GetInt32(4), 
                                    ypnodomatia = reader.GetInt32(10), mpanio = reader.GetInt32(9), eidos = reader.GetString(5).ToString(), 
                                    thermansi = reader.GetString(6).ToString() , desc = reader.GetString(8).ToString() , 
                                    phone = reader.GetString(7).ToString() , email = reader.GetString(11).ToString(),
                                    dieythinsi = reader.GetString(13).ToString(), photonumber = reader.GetInt32(12)});
                            }
                        }
                        //edw gemizei o index tou lucene
                        LuceneSearch.AddUpdateLuceneIndex(everyadd);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        //gia diagrafi aggelias
        public static void deleteAdd(int sid)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT delete_aggelies1(@id)", connection))
                    {
                        cmd.Parameters.AddWithValue("id", sid);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        //methodos gia apostoli message
        public void SendMessage(string useremail , string fname , string lname , string phone , string email , string desc)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT insert_message1(@name , @surname , @phone_number , @email , @text , @email2)", connection))
                    {
                        cmd.Parameters.AddWithValue("email", useremail);
                        cmd.Parameters.AddWithValue("name", fname);
                        cmd.Parameters.AddWithValue("surname", lname);
                        cmd.Parameters.AddWithValue("phone_number)", phone);
                        cmd.Parameters.AddWithValue("email2", email);
                        cmd.Parameters.AddWithValue("text", desc);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //diagrafi minimatos
        public static void deleteMsg(int mid)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT delete_message1(@id)", connection))
                    {
                        cmd.Parameters.AddWithValue("id", mid);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //test methodos gia ta filtra
        public static List<Adds> Filtra(List<Adds> fltr , int timiE , int timiM , int emvE , int emvM , int ypnE , int ypnM , int mpE , int mpM)
        {
            List<Adds> addswithfiltra = new List<Adds>();

            

            foreach (var f in fltr)
            {
                if(f.timi >= timiE && f.timi <= timiM)
                {
                    addswithfiltra.Add(new Adds { sid = f.sid, title = f.title, perioxi = f.perioxi, timi = f.timi, 
                        emvadon = f.emvadon, ypnodomatia = f.ypnodomatia, mpanio = f.mpanio, eidos = f.eidos });
                }
            }

            foreach(var f in addswithfiltra)
            {
                if (f.emvadon >= emvE && f.timi <= emvM)
                {
                    addswithfiltra.Remove(f);
                }
            }

            foreach (var f in addswithfiltra)
            {
                if (f.ypnodomatia >= ypnE && f.timi <= ypnM)
                {
                    addswithfiltra.Remove(f);
                }
            }

            foreach (var f in addswithfiltra)
            {
                if (f.mpanio >= mpE && f.timi <= mpM)
                {
                    addswithfiltra.Remove(f);
                }
            }
            return addswithfiltra;
        }

        public static void setPhotoNum(int y)
        {
            using (var connection = new NpgsqlConnection(Helper.CnnVal("it164760")))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand("SELECT photo_number(@photos)", connection))
                    {
                        cmd.Parameters.AddWithValue("photos", y);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
