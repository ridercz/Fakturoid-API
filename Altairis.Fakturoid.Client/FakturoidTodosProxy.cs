using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public class FakturoidTodosProxy : FakturoidEntityProxy {

        internal FakturoidTodosProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all current todos.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>List of <see cref="JsonTodo"/> instances.</returns>
        public IEnumerable<JsonTodo> Select(DateTime? since = null) {
            return base.GetEntities<JsonTodo>("todos.json", new { since = since });
        }

        /// <summary>
        /// Gets list of current todos, paged by 15.
        /// </summary>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>List of <see cref="JsonTodo"/> instances.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public IEnumerable<JsonTodo> Select(int page, DateTime? since = null) {
            if (page < 1) throw new ArgumentOutOfRangeException("page", "Page must be greater than zero.");

            return base.GetEntities<JsonTodo>("todos.json", page, new { since = since });
        }

    }

}
