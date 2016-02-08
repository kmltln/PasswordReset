using System.ComponentModel;

namespace PasswordReset.DomainClasses.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KBAD_USERS_DB
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        [DisplayName("�sim")]
        public string FullName { get; set; }

        [StringLength(50)]
        [DisplayName("Kullan�c� ad�")]
        public string LogOnName { get; set; }

        [DisplayName("Telefon Numaras�")]
        public long? PhoneNumber { get; set; }
    }
}
