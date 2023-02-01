using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhosNext_Domain.Base
{
    public abstract class BasePlan<T> : AutoIncrementBaseDomain where T : BasePlan<T>
    {
        #region Properties

        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string ExternalCode { get; set; }

        [ForeignKey("Upper")]
        [MaxLength(20)]
        public int? UpperId { get; set; }

        public virtual T Upper { get; set; }

        [InverseProperty("Upper")]
        public virtual List<T> Lowers { get; set; } = new List<T>();

        public int Level
        {
            get
            {
                int level = 1;

                var parent = Upper;
                while (parent != null)
                {
                    level++;
                    parent = parent.Upper;
                }

                return level;
            }
        }

        #endregion
    }
}
