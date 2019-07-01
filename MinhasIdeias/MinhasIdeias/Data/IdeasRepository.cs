using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasIdeias.Data
{
    public class IdeasRepository
    {
        public int Create()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                return 0;
            }
        }

        public int Update()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                return 0;
            }
        }

        public void GetAll()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {

            }
        }

    }
}
