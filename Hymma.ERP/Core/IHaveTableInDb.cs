using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.ERP.Core
{
    /// <summary>
    /// types that have a table in a data base should inherit from this interface
    /// </summary>
    public interface IHaveTableInDb
    {
        /// <summary>
        /// id of component in the table
        /// </summary>
        int id { get; set; }

        /// <summary>
        /// name of the table in a database that represents this componet
        /// </summary>
        string DataBaseTableName { get; set; }
    }
}
