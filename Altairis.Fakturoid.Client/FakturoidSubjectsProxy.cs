using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client {
    public class FakturoidSubjectsProxy : FakturoidEntityProxy {

        internal FakturoidSubjectsProxy(FakturoidContext context) : base(context) { }

        /// <summary>
        /// Gets list of all subjects.
        /// </summary>
        /// <returns>List of <see cref="JsonSubject"/> instances.</returns>
        public IEnumerable<JsonSubject> Select() {
            return base.GetUnpagedEntities<JsonSubject>("Subjects.json");
        }

        /// <summary>
        /// Selects single subject with specified ID.
        /// </summary>
        /// <param name="id">The subject id.</param>
        /// <returns>Instance of <see cref="JsonSubject"/> class.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public JsonSubject Select(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            return base.GetSingleEntity<JsonSubject>(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Deletes subject with specified id.
        /// </summary>
        /// <param name="id">The contact id.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">id;Value must be greater than zero.</exception>
        public void Delete(int id) {
            if (id < 1) throw new ArgumentOutOfRangeException("id", "Value must be greater than zero.");

            var c = this.Context.GetHttpClient();
            base.DeleteSingleEntity(string.Format("subjects/{0}.json", id));
        }

        /// <summary>
        /// Creates the specified new subject.
        /// </summary>
        /// <param name="newSubject">The new subject.</param>
        /// <returns>ID of newly created subject.</returns>
        /// <exception cref="System.ArgumentNullException">newSubject</exception>
        public int Create(JsonSubject newSubject) {
            if (newSubject == null) throw new ArgumentNullException("newSubject");

            return base.CreateEntity("subjects.json", newSubject);
        }

    }
}
