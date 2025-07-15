using BeachMatch.Application.DTOs.Player;
using BeachMatch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachMatch.Application.Mappers
{
    public class PlayerMapper
    {
        public static Player ToEntity(CreatePlayerRequest dto)
        {
            return new Player(dto.Name , dto.SkillLevel);
        }

        public static PlayerResponse ToResponse(Player player)
        {
            return new PlayerResponse
            {
                Id = player.Id,
                Name = player.Name,
                SkillLevel = player.SkillLevel
            };
        }

        public static List<PlayerResponse> ToResponseList(IEnumerable<Player> players)
        {
            return players.Select(ToResponse).ToList();
        }
    }
}
