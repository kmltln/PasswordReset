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
        [DisplayName("Ýsim")]
        public string FullName { get; set; }

        [StringLength(50)]
        [DisplayName("Kullanýcý adý")]
        public string LogOnName { get; set; }

        [DisplayName("Telefon Numarasý")]
        public long? PhoneNumber { get; set; }
    }
}
