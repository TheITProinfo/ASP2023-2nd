using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CstWebStoredprocedure.Common
{
    public class SqlHelper
    {

        #region Get Connection String
        /// <summary>
        /// static method get connection string
        /// </summary>
        /// <returns> connection string</returns>

        public static string GetSqlConnectionString()
        {

            return ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        }

        #endregion




        #region sql NO query

        /// <summary>
        /// execute SQL script, get affected rows
        /// </summary>
        /// <param name="sqlTxt"></param>
        /// <param name="parameters"></param>
        /// <returns> affected rows</returns>

        public static int ExecuteNoQuery(string sqlTxt, params  SqlParameter[] parameters)
        {

            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand cmd = conn.CreateCommand())

                { 
                    conn.Open();
                    cmd.CommandText = sqlTxt;
                    cmd.Parameters.AddRange(parameters);

                      return cmd.ExecuteNonQuery();




                } // end of cmd


            } //end of conn






        }

        #endregion

        #region SQL scalar
        /// <summary>
        /// get one object-- the value on first column and first row
        /// </summary>
        /// <param name="sqlTxt"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public static object ExecuteScalar(string sqlTxt, params SqlParameter[] parameters)
        {



            using (SqlConnection conn =new SqlConnection(GetSqlConnectionString()))
            {

                using (SqlCommand cmd=conn.CreateCommand())
                {
                    
                    conn.Open();

                    cmd.CommandText = sqlTxt;
                    cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();

                } //end of cmd

            } //end of conn
        }

        #endregion

        #region get data Table
        /// <summary>
        /// execute sqltext, get data table
        /// </summary>
        /// <param name="sqlTxt"></param>
        /// <param name="parameters"></param>
        /// <returns>DataTable</returns>

        public static DataTable ExecuteDataTable(string sqlTxt, params SqlParameter[] parameters)
        {

            using (SqlDataAdapter adapter=new SqlDataAdapter(sqlTxt,GetSqlConnectionString()))
            {
                DataTable dt=new DataTable();
                adapter.SelectCommand.Parameters.AddRange(parameters);
                adapter.Fill(dt);
                return dt;

            }

        }


        #endregion

        #region get data reader
        /// <summary>
        /// execute sqltxt, get data reader
        /// </summary>
        /// <param name="sqlTxt"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        public static SqlDataReader ExecDataReader(string sqlTxt, params SqlParameter[] parameters)
        {
             // datareader require SqlConnection is open
            SqlConnection conn=new SqlConnection(GetSqlConnectionString());
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlTxt;
            cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);

        }

        #endregion


    } //end of class 

}// end of namespace