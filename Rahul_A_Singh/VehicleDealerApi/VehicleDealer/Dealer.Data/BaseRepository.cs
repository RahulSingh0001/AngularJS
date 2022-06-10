using Dealer.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer.Data
{
    public abstract class BaseRepository
    {
        public readonly IOptions<DataConfig> _connectionString;
       

        public BaseRepository(IOptions<DataConfig> connectionString)
        {
            _connectionString = connectionString;           
        }

    }
}
