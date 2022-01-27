using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eNno.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50,MinimumLength =3)]
        public string FullName { get; set; }
        [StringLength(maximumLength: 50)]

        public string Position { get; set; }
        [StringLength(maximumLength: 100)]

        public string Desc { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string Image { get; set; }

    }
}
