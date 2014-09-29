using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuartz
{
    public class WorkerOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether [run imediately].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [run imediately]; otherwise, <c>false</c>.
        /// </value>
        public bool RunImediately { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
    }
}
