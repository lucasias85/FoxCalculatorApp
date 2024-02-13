using FoxCalculatorApp.AppCode.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxCalculatorApp.AppCode.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string connectionString)
        {
            _connection = new SQLiteAsyncConnection(connectionString);
            _connection.CreateTableAsync<TaxasModel>().Wait();
        }

        public Task<int> Inserir(TaxasModel model)
        {
            return _connection.InsertAsync(model);
        }

        public Task<int> Alterar(TaxasModel model)
        {
            return _connection.UpdateAsync(model);
        }

        public Task<int> Excluir(int IdTaxa)
        {
            return _connection.DeleteAsync(IdTaxa);
        }

        public Task<List<TaxasModel>> VizualizarTudo()
        {
            return _connection.Table<TaxasModel>().ToListAsync();
        }
    }
}
