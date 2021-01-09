using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using PriceredactedWeb.DTOs;
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
        public bool Register(string username, string password, string email)
        {

            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=(localdb)\\Priceredacted;Database=PriceredactedDB";
                try
                {
                    cn.Open();
                    using (var insert = new SqlCommand())
                    {
                        insert.Connection = cn;
                        insert.CommandType = CommandType.Text;
                        insert.CommandText = "INSERT INTO UserData (Email, Password, Username)" +
                            " VALUES (@EM,@PS,@UN)";

                        insert.Parameters.Add(new SqlParameter("@EM", SqlDbType.VarChar, 50, "Email"));
                        insert.Parameters.Add(new SqlParameter("@PS", SqlDbType.VarChar, 50, "Password"));
                        insert.Parameters.Add(new SqlParameter("@UN", SqlDbType.VarChar, 50, "Username"));

                        SqlDataAdapter da = new SqlDataAdapter("SELECT Email, Id, Password, Username FROM UserData", cn);
                        da.InsertCommand = insert;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserData");

                        DataRow newRow = ds.Tables[0].NewRow();
                        newRow["Email"] = email;
                        newRow["Id"] = 11111;
                        newRow["Password"] = password;
                        newRow["Username"] = username;
                        ds.Tables[0].Rows.Add(newRow);

                        da.Update(ds.Tables[0]);
                        cn.Close();
                        da.Dispose();

                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public UserDatum GetUser(string username)
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
                        SqlCommand command = new SqlCommand("SELECT Email, Id, Password, Username FROM UserData" +
                            " WHERE Username = @UN", cn);
                        command.Parameters.AddWithValue("@UN", username);

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
                }
                catch (Exception e)
                {
                    return null;
                }
                finally
                {
                    cn.Close();
                }
            }
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
                        SqlCommand command = new SqlCommand("SELECT Email, Id, Password, Username FROM UserData" +
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
                }
                catch (Exception e)
                {
                    return null;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public bool DeleteUser(int userId)
        {
            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=(localdb)\\Priceredacted;Database=PriceredactedDB";
                try
                {
                    cn.Open();
                    using (var delete = new SqlCommand())
                    {
                        delete.Connection = cn;
                        delete.CommandType = CommandType.Text;
                        delete.CommandText = "DELETE FROM UserData WHERE Id = @ID";

                        delete.Parameters.AddWithValue("@ID", userId);//(new SqlParameter("@ID", SqlDbType.Int, 50, "Id"));

                        SqlDataAdapter da = new SqlDataAdapter("SELECT Email, Id, Password, Username FROM UserData", cn);
                        da.DeleteCommand = delete;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserData");

                        ds.Tables[0].Rows[0].Delete();

                        da.Update(ds.Tables[0]);
                        cn.Close();
                        da.Dispose();

                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public bool UpdatePassword(UpdatePasswordDTO data)
        {

            using (var cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=(localdb)\\Priceredacted;Database=PriceredactedDB";
                try
                {
                    cn.Open();
                    using (var update = new SqlCommand())
                    {
                        update.Connection = cn;
                        update.CommandType = CommandType.Text;
                        update.CommandText = "UPDATE UserData SET Password = @PS WHERE Email = @EM";

                        update.Parameters.AddWithValue("@PS", data.NewPassword);//(new SqlParameter("@ID", SqlDbType.Int, 50, "Id"));
                        update.Parameters.AddWithValue("@EM", data.CurrentEmail);

                        SqlDataAdapter da = new SqlDataAdapter("SELECT Email, Id, Password, Username FROM UserData", cn);
                        da.UpdateCommand = update;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "UserData");

                        da.Update(ds.Tables[0]);
                        cn.Close();
                        da.Dispose();

                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}

