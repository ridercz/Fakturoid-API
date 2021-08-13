using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {

    /// <summary>
    /// Proxy class for working with todo tasks.
    /// </summary>
    public class FakturoidTodosProxy : FakturoidEntityProxy {

        internal FakturoidTodosProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all current todos.
        /// </summary>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>List of <see cref="JsonTodo"/> instances.</returns>
        /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
        public IEnumerable<JsonTodo> Select(DateTime? since = null) => base.GetAllPagedEntities<JsonTodo>("todos.json", new { since });


        /// <summary>
        /// Gets asynchronously list of all current todos.
        /// </summary>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>List of <see cref="JsonTodo"/> instances.</returns>
        /// <remarks>The result may contain duplicate entities, if they are modified between requests for pages. In current version of API, there is no way to solve rhis.</remarks>
        public async Task<IEnumerable<JsonTodo>> SelectAsync(DateTime? since = null) => await base.GetAllPagedEntitiesAsync<JsonTodo>("todos.json", new { since });

        /// <summary>
        /// Gets paged list of current todos
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>
        /// List of <see cref="JsonTodo" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public IEnumerable<JsonTodo> Select(int page, DateTime? since = null) {
            return page < 1
                ? throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.")
                : base.GetPagedEntities<JsonTodo>("todos.json", page, new { since });
        }

        /// <summary>
        /// Gets asynchronously paged list of current todos
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <param name="since">The date since when todos are to be selected.</param>
        /// <returns>
        /// List of <see cref="JsonTodo" /> instances.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">page;Page must be greater than zero.</exception>
        public async Task<IEnumerable<JsonTodo>> SelectAsync(int page, DateTime? since = null) {
            return page < 1
                ? throw new ArgumentOutOfRangeException(nameof(page), "Page must be greater than zero.")
                : await base.GetPagedEntitiesAsync<JsonTodo>("todos.json", page, new { since });
        }


    }

}
