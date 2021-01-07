using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using PriceredactedWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PriceredactedWeb.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly PriceredactedDBContext _context;
        public AuthRepository(PriceredactedDBContext context)
        {
            _context = context;
        }
        public UserDatum Register(string username, string password, string email)
        {
            Random rnd = new Random();


            UserDatum user = new UserDatum()
            {
                Username = username,
                Email = email,
                Password = password,
                Id = rnd.Next(1000)
            };
            _context.Add(user);
            _context.SaveChanges();

            return user;
        }

        public UserDatum GetUser(string userEmail)
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=(localdb)\\Priceredacted;Database=PriceredactedDB";
                try
                {
                    cn.Open();
                    using (var select = new SqlCommand())
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        SqlCommand command = new SqlCommand("SELECT Email, Password, Id, Username FROM UserData" +
                            " WHERE Email = @EM", cn);
                        command.Parameters.AddWithValue("@EM", userEmail);

                        da.SelectCommand = command;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserData");

                        cn.Close();
                        da.Dispose();
                        UserDatum user = new UserDatum()
                        {
                            Email = ds.Tables[0].Rows[0]["Email"].ToString(),
                            Id = Int32.Parse(ds.Tables[0].Rows[0]["Id"].ToString()),
                            Username = ds.Tables[0].Rows[0]["Username"].ToString(),
                            Password = ds.Tables[0].Rows[0]["Password"].ToString()
                        };
                        return user;
                    }
                }
                catch (SqlException ex)
                {
                    return null;
                    // maybe some retry logic could be applied if connection failed
                }
                catch (Exception e)
                {
                    return null;
                    // log it here
                }
                finally
                {
                    cn.Close();
                }
            }
        //}

            //return _context.UserData.First(t => t.Email == userEmail);
        }

        public UserDatum GetUser(int userId)
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=(localdb)\\Priceredacted;Database=PriceredactedDB";
                try
                {
                    cn.Open();
                    using (var select = new SqlCommand())
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        SqlCommand command = new SqlCommand("SELECT Email, Password, Id, Username FROM UserData" +
                            " WHERE Id = @ID", cn);
                        command.Parameters.AddWithValue("@ID", userId);

                        da.SelectCommand = command;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserData");

                        cn.Close();
                        da.Dispose();
                        UserDatum user = new UserDatum()
                        {
                            Email = ds.Tables[0].Rows[0]["Email"].ToString(),
                            Id = Int32.Parse(ds.Tables[0].Rows[0]["Id"].ToString()),
                            Username = ds.Tables[0].Rows[0]["Username"].ToString(),
                            Password = ds.Tables[0].Rows[0]["Password"].ToString()
                        };
                        return user;
                    }
                }
                catch (SqlException ex)
                {
                    return null;
                    // maybe some retry logic could be applied if connection failed
                }
                catch (Exception e)
                {
                    return null;
                    // log it here
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}

