﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonAna_Hamburguesa.Models;
using SQLite;

namespace LeonAna_Hamburguesa.Data
{
    public class BurgerDatabaseAL
    {
        string _dbPath;

        private SQLiteConnection conn;
        public BurgerDatabaseAL(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerAL>();
        }
        public int AddNewBurger(BurgerAL burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<BurgerAL> GetAllBurgers()
        {
            Init();
            List<BurgerAL> burgers = conn.Table<BurgerAL>().ToList();
            return burgers;
        }
    }
}
