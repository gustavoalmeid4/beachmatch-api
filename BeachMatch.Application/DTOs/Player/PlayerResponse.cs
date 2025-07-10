using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachMatch.Application.DTOs.Player
{
    public class PlayerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
    }
}
