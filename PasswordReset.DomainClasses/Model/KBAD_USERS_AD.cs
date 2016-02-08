using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordReset.DomainClasses.Model
{
    public partial class KBAD_USERS_AD
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        [DisplayName("İsim")]
        public string FullName { get; set; }

        [StringLength(50)]
        [DisplayName("Kullanıcı adı")]
        public string LogOnName { get; set; }

        [DisplayName("Telefon Numarası")]
        public long? PhoneNumber { get; set; }
    }
}
