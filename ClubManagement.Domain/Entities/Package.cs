using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class Package
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int SessionGroupId { get; set; }
        public SessionGroup SessionGroup { get; set; }
    }
}
