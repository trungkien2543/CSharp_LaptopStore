using CSharp_laptop.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_laptop.DAO
{
    internal class ChatgptLineDAO
    {
        private MySqlConnectionHelper connectionHelper = new MySqlConnectionHelper();

        public List<ChatgptLineDTO> GetAllLine()
        {
            List<ChatgptLineDTO> lines = new List<ChatgptLineDTO>();

            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID`, `Line` FROM `chatgpt_line` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChatgptLineDTO line = new ChatgptLineDTO
                        {
                            ID = int.Parse(reader["ID"].ToString()),
                            Line = reader["Line"].ToString()
                        };
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }
        public string ConcatAllLines()
        {
            string lines = string.Empty;
            using (MySqlConnection conn = connectionHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT `ID`, `Line` FROM `chatgpt_line` WHERE 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lines += reader["Line"].ToString() + " ";
                        
                    }
                }
            }
            return lines;
        }
    }
}
