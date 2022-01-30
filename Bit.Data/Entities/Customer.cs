using Bit.Data.Enumerations;

namespace Bit.Data.Entities
{
    public class Customer
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public int CustomerNumber   { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastUpdatedAt { get; set; }

        public string LastUpdatedBy { get; set; }

        public RowStatus RowStatus { get; set; }

        #endregion
    }
}
